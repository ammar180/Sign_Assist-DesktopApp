using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SignTranslate
{
    public partial class DeafMuteUserForm : Form
    {
        public string lableContent { get; set; }
        public string mediaUrl { get; set; }
        public event EventHandler TextChangedInSecondForm;

        public DeafMuteUserForm(string _lableContent, string _mediaUrl)
        {
            InitializeComponent();
            lableContent = _lableContent;
            mediaUrl = _mediaUrl;
        }
        private void DeafMuteUserForm_Load(object sender, EventArgs e)
        {
            textBox1.Select();
            label1.Text = lableContent;
            axWindowsMediaPlayer1.URL = mediaUrl;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextChangedInSecondForm?.Invoke(this, EventArgs.Empty);
        }
        public string GetTextBoxText()
        {
            return textBox1.Text;
        }

        public void UpdateSign(string lableContent, string mediaUrl)
        {
            label1.Text = lableContent;
            axWindowsMediaPlayer1.URL = mediaUrl;
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // 13 is the ASCII code for Enter
            {
                textBox1.Text = string.Empty;
                e.Handled = true; // Prevent the Enter key from being inserted into the TextBox
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\VScode_project\Visual Studio 2022\SLTS project\Sign-Language-Translator-newclassifier\index.html");
        }
    }
}
