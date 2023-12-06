using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using AForge;
using AForge.Video;
using Accord.Video.FFMPEG;
using AForge.Video.DirectShow;
using Emgu.Util;

namespace SignTranslate
{
    internal class VideoSign
    {
        NormalUser form1;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private VideoFileWriter videoWriter;
        private bool isRecording = false;
        public VideoSign()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }
        public void startCapturing()
        {
            form1 = new NormalUser();
            int selectedCamera = form1.comboBoxDevices.SelectedIndex;
            videoSource = new VideoCaptureDevice(videoDevices[selectedCamera].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(LiveToPictureBox);
            videoSource.Start();
        }

        private void LiveToPictureBox(object sender, NewFrameEventArgs eventArgs)
        {
            form1.pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        public void stopCapturing()
        {
            videoSource.Stop();
            videoSource.SignalToStop();
            videoSource.WaitForStop();
        }
        public void startRecording(string videoName)
        {
            // Set up video writer with the desired settings (e.g., 640x480 resolution, 30 FPS)
            videoWriter = new VideoFileWriter();
            videoWriter.Open($"Data\\Videos\\{videoName}.mp4", 1280, 720, 30, VideoCodec.MPEG4); // Adjust frame rate as needed

            // Attach the NewFrame event handler to capture frames
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            videoWriter.WriteVideoFrame(eventArgs.Frame);
        }
        public void stopRecording()
        {
            videoSource.Stop();
            videoSource.SignalToStop();
            videoSource.WaitForStop();
            videoWriter.Close();
        }
    }
}
