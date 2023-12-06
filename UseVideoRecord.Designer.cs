namespace SignTranslate
{
    partial class UseVideoRecord
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.frameCaptureTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.lblRecordingDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 523);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(675, 529);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(147, 24);
            this.comboBoxDevices.TabIndex = 11;
            this.comboBoxDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxDevices_SelectedIndexChanged);
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStartRecording.Location = new System.Drawing.Point(3, 529);
            this.btnStartRecording.MaximumSize = new System.Drawing.Size(124, 35);
            this.btnStartRecording.MinimumSize = new System.Drawing.Size(124, 35);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(124, 35);
            this.btnStartRecording.TabIndex = 12;
            this.btnStartRecording.Text = "Start Record";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // lblRecordingDuration
            // 
            this.lblRecordingDuration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRecordingDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordingDuration.Location = new System.Drawing.Point(0, 682);
            this.lblRecordingDuration.Name = "lblRecordingDuration";
            this.lblRecordingDuration.Size = new System.Drawing.Size(825, 43);
            this.lblRecordingDuration.TabIndex = 13;
            this.lblRecordingDuration.Text = "lable";
            this.lblRecordingDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UseVideoRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRecordingDuration);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxDevices);
            this.Controls.Add(this.btnStartRecording);
            this.Name = "UseVideoRecord";
            this.Size = new System.Drawing.Size(825, 725);
            this.Load += new System.EventHandler(this.UseVideoRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer frameCaptureTimer;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.Label lblRecordingDuration;
    }
}
