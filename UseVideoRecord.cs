using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace SignTranslate
{
    public partial class UseVideoRecord : UserControl
    {
        //private VideoCaptureDevice videoSource;
        private FilterInfoCollection videoDevices;
        private int cameraIndex = 0;
        private VideoCapture videoCapture;
        private VideoWriter videoWriter;
        private bool isRecording = false;
        private NormalUser user1 = null;
        private TimeSpan recordingDuration = TimeSpan.Zero;

        public UseVideoRecord()
        {
            InitializeComponent();
            user1 = new NormalUser();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

        }

        private void UseVideoRecord_Load(object sender, EventArgs e)
        {
            compoboxConfig();
            if (!user1.isCapturing)
                startCapturing();
            else
                pictureBox1.Image = null;
        }

        private void startCapturing()
        {
            // Initialize the frame capture timer
            frameCaptureTimer = new Timer();
            frameCaptureTimer.Interval = 1000 / 30;

            // Initialize the video capture device (usually, 0 is the default webcam)
            videoCapture = new VideoCapture(cameraIndex);

            // Capture frames at approximately 30 frames per second
            frameCaptureTimer.Tick += (s, args) => CaptureFrame();

            frameCaptureTimer.Tick += new EventHandler(timer1_Tick);

            // Start the timer when the form loads
            frameCaptureTimer.Start();
        }

        private void CaptureFrame()
        {
            using (Mat frame = new Mat())
            {
                videoCapture.Read(frame);
                // Display the captured frame in pictureBox1
                pictureBox1.Image = BitmapConverter.ToBitmap(frame);

                // If recording is active, save the frame to the video file
                if (isRecording)
                {
                    videoWriter.Write(frame);
                }

            }
        }

        private void compoboxConfig()
        {
            foreach (FilterInfo device in videoDevices)
                comboBoxDevices.Items.Add(device.Name);

            if (comboBoxDevices.Items.Count > 0)
                comboBoxDevices.SelectedIndex = 0;
            else
                MessageBox.Show("No video capture devices found.");
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            // Initialize the video capture device (usually, 0 is the default webcam)
            videoCapture = new VideoCapture(cameraIndex);

            if (!isRecording)
            {
                // Start recording
                videoWriter = new VideoWriter($"Data\\Videos\\{user1.InputText.Text}.avi", FourCC.MJPG, 30, new OpenCvSharp.Size(640, 480)); // Adjust frame size and other parameters as needed
                isRecording = true;
                btnStartRecording.Text = "Stop Record";
            }
            else
            {
                // Stop recording
                frameCaptureTimer.Stop(); // Stop capturing frames 
                videoCapture.Release();
                videoWriter.Release();
                isRecording = false;

                btnStartRecording.Text = "Start Record";
                pictureBox1.Image = null;
                user1.assign.Enabled = true;
                lblRecordingDuration.Text = string.Empty;
            }

        }

        private void comboBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            cameraIndex = comboBoxDevices.SelectedIndex;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isRecording)
            {
                recordingDuration = recordingDuration.Add(TimeSpan.FromSeconds(1));
                lblRecordingDuration.Text = recordingDuration.ToString(@"hh\:mm\:ss");
            }
        }
    }
}
