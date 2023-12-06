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
    public partial class NormalUser : Form
    {
        //private VideoCaptureDevice videoSource;
        private FilterInfoCollection videoDevices;
        private int cameraIndex = 0;
        private VideoCapture videoCapture;
        private string selcetedSent = "";
        private VideoWriter videoWriter;
        private bool isRecording = false;
        public bool isCapturing = false;
        private TimeSpan recordingDuration = TimeSpan.Zero;
        private DeafMuteUserForm currentForm2Instance = null; private Screen[] screens = Screen.AllScreens;
        

        public NormalUser()
        {
            InitializeComponent();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }
        private void NormalUser_Load(object sender, EventArgs e)
        {
            prepareFiles();
            compoboxConfig();
            fill_listBox();
            startDeafMuteWindow();
            currentForm2Instance.TextChangedInSecondForm += MainForm_TextChangedInSecondForm;
            // Initialize the frame capture timer
            frameCaptureTimer = new Timer();
            frameCaptureTimer.Interval = 1000/33;

            // Start the timer when the form loads
            frameCaptureTimer.Start();
        }
        private void MainForm_TextChangedInSecondForm(object sender, EventArgs e)
        {
            // Update the textbox in the first form with the text from the second form
            transText.Text = currentForm2Instance.GetTextBoxText();
        }
        private void startDeafMuteWindow()
        {
            if (currentForm2Instance != null && currentForm2Instance.IsAccessible)
            {
                currentForm2Instance.Close();
                currentForm2Instance.Dispose();
            }
            else
            {
                // Create a new instance of Form2 and pass the selected video path
                currentForm2Instance = new DeafMuteUserForm("Welcome", "Data\\Videos\\Welcome.avi");
                screenConfiger();
                currentForm2Instance.Show();
            }
        }

        private void prepareFiles()
        {
            if(!Directory.Exists("Data\\Videos") && !File.Exists("Data\\sentences.txt"))
            {
                Directory.CreateDirectory("Data\\Videos");
                File.CreateText("Data\\sentences.txt");
            }
        }
        private void fill_listBox()
        {
            StreamReader SR = new StreamReader("Data\\sentences.txt");
            string line = SR.ReadLine();
            while (line != null)
            {
                listSent.Items.Add(line);
                line = SR.ReadLine();
            }
            SR.Close();
        }
        private void update_stream()
        {
            StreamWriter SW = new StreamWriter("Data\\sentences.txt", false, Encoding.UTF8);
            foreach (string s in listSent.Items)
            {
                SW.WriteLine(s);
            }
            SW.Close();
        }
        private void compoboxConfig()
        {
            foreach (FilterInfo device in videoDevices)
                comboBoxDevices.Items.Add(device.Name);

            if (comboBoxDevices.Items.Count > 0)
                comboBoxDevices.SelectedIndex = 1;
            else
                MessageBox.Show("No video capture devices found.");
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listSent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void assign_Click(object sender, EventArgs e)
        {
            listSent.Items.Add(InputText.Text);
            update_stream();

            InputText.Text = "";
            assign.Enabled = false;
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            
             // Set height to 720 for 720p
            if (!isRecording)
            {
                // Start recording
                videoWriter = new VideoWriter($"Data\\Videos\\{InputText.Text}.avi", FourCC.XVID, 30, new OpenCvSharp.Size(1280, 720)); // Adjust frame size and other parameters as needed
                isRecording = true;
                btnStartRecording.Text = "Stop Record";
            }
            else
            {

                // Stop recording
                videoCapture.Release();
                videoWriter.Release();
                frameCaptureTimer.Stop(); // Stop capturing frames 

                btnStartRecording.Text = "Start Record";
                pictureBox1.Image = null;
                assign.Enabled = true;
                isRecording = false;
                lblRecordingDuration.Text = string.Empty;
                frameCaptureTimer.Stop();
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            startCapturing();
            isCapturing = true;
            InputText.Enabled = true;
        }
        private void startCapturing()
        {

            // Initialize the video capture device (usually, 0 is the default webcam)
            videoCapture = new VideoCapture(cameraIndex);

            videoCapture.Set(VideoCaptureProperties.FrameWidth, 1280); // Set width to 1280 for 720p
            videoCapture.Set(VideoCaptureProperties.FrameHeight, 720);
            // Capture frames at approximately 30 frames per second
            frameCaptureTimer.Tick += (s, args) => CaptureFrame();

            //frameCaptureTimer.Tick += new EventHandler(timer1_Tick);

        }
        private void delete_Click(object sender, EventArgs e)
        {
            if ( !(listSent.SelectedItem == null))
            {
                selcetedSent = listSent.SelectedItem.ToString();
                listSent.Items.Remove(selcetedSent);
                update_stream();
                File.Delete($@"Data\Videos\{selcetedSent}.avi");
            }
            else
                MessageBox.Show("Please select a Sentence");
        }
        private void comboBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            cameraIndex = comboBoxDevices.SelectedIndex;
        }



        public void startCapturingWithAforg()
        {
            //selectedCamera = comboBoxDevices.SelectedIndex;
            //videoSource = new VideoCaptureDevice(videoDevices[selectedCamera].MonikerString);
            //videoSource.NewFrame += new NewFrameEventHandler(LiveToPictureBox);
            //videoSource.Start();
        }
        private void LiveToPictureBox(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        public void stopCapturing()
        {
            //if(videoSource.IsRunning && isRecording)
            //{
            //    videoSource.Stop();
            //    videoSource.SignalToStop();
            //    videoSource.WaitForStop();
            //    videoWriter.DeepClone();
            //    pictureBox1.Image = null;
            //}
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string sourceVideoFile = opf.FileName;
                opf.Filter = "Video files (*.avi, *.mp4)|*.mp4";
                string destVideoFile = $@"Data\Videos\{InputText.Text}.avi";
                File.Copy(sourceVideoFile, destVideoFile);
                assign.Enabled = true;
            }
        }
        private void InputText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InputText.Text) || InputText.Text.Length < 5)
            {
                assign.Enabled = false;
                btnStartRecording.Enabled = false;
            }
            else btnStartRecording.Enabled = true;
        }
        private void CaptureFrame()
        {
            using (Mat frame = new Mat())
            {
                videoCapture.Read(frame);

                if (!frame.Empty())
                {
                    pictureBox1.Image = frame.ToBitmap();

                    if (isRecording)
                    {
                        videoWriter.Write(frame);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isRecording)
            {
                recordingDuration = recordingDuration.Add(TimeSpan.FromSeconds(1));
                lblRecordingDuration.Text = recordingDuration.ToString(@"hh\:mm\:ss");
            }
        }

        private void apperSign_Click(object sender, EventArgs e)
        {
            if (listSent.SelectedItem != null)
            {
                selcetedSent = listSent.SelectedItem.ToString();

                string VideoUrl = $"Data\\Videos\\{selcetedSent}.avi";
                currentForm2Instance.UpdateSign(selcetedSent, VideoUrl);
            }
            else
                MessageBox.Show("Please select a Sign from the list of sentnces");

        }
        private void screenConfiger()
        {
            if (screens.Length > 1)
            {
                Screen secondMonitor = screens[1];
                currentForm2Instance.Location = secondMonitor.Bounds.Location;
                currentForm2Instance.Size = secondMonitor.Bounds.Size;
                currentForm2Instance.WindowState = FormWindowState.Maximized;
            }
        }

        private void transText_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
