namespace SignTranslate
{
    partial class NormalUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NormalUser));
            this.listSent = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InputText = new System.Windows.Forms.TextBox();
            this.assign = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.apperSign = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.groupVideoRecord = new System.Windows.Forms.GroupBox();
            this.lblRecordingDuration = new System.Windows.Forms.Label();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.transText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlGetSign = new System.Windows.Forms.TabControl();
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.tabOpen = new System.Windows.Forms.TabPage();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tabScelton = new System.Windows.Forms.TabPage();
            this.frameCaptureTimer = new System.Windows.Forms.Timer(this.components);
            this.tabContact = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupVideoRecord.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlGetSign.SuspendLayout();
            this.tabRecord.SuspendLayout();
            this.tabOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // listSent
            // 
            resources.ApplyResources(this.listSent, "listSent");
            this.listSent.FormattingEnabled = true;
            this.listSent.Name = "listSent";
            this.listSent.SelectedIndexChanged += new System.EventHandler(this.listSent_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // InputText
            // 
            resources.ApplyResources(this.InputText, "InputText");
            this.InputText.ForeColor = System.Drawing.Color.Black;
            this.InputText.Name = "InputText";
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // assign
            // 
            resources.ApplyResources(this.assign, "assign");
            this.assign.Name = "assign";
            this.assign.UseVisualStyleBackColor = true;
            this.assign.Click += new System.EventHandler(this.assign_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apperSign);
            this.groupBox1.Controls.Add(this.listSent);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.delete);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // apperSign
            // 
            this.apperSign.BackColor = System.Drawing.Color.Transparent;
            this.apperSign.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.apperSign.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.apperSign, "apperSign");
            this.apperSign.Name = "apperSign";
            this.apperSign.UseVisualStyleBackColor = false;
            this.apperSign.Click += new System.EventHandler(this.apperSign_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.add, "add");
            this.add.Name = "add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InputText);
            this.panel1.Controls.Add(this.assign);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delete.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.delete, "delete");
            this.delete.Name = "delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // groupVideoRecord
            // 
            this.groupVideoRecord.Controls.Add(this.lblRecordingDuration);
            this.groupVideoRecord.Controls.Add(this.btnStartRecording);
            this.groupVideoRecord.Controls.Add(this.comboBoxDevices);
            this.groupVideoRecord.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.groupVideoRecord, "groupVideoRecord");
            this.groupVideoRecord.Name = "groupVideoRecord";
            this.groupVideoRecord.TabStop = false;
            // 
            // lblRecordingDuration
            // 
            resources.ApplyResources(this.lblRecordingDuration, "lblRecordingDuration");
            this.lblRecordingDuration.Name = "lblRecordingDuration";
            // 
            // btnStartRecording
            // 
            resources.ApplyResources(this.btnStartRecording, "btnStartRecording");
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // comboBoxDevices
            // 
            resources.ApplyResources(this.comboBoxDevices, "comboBoxDevices");
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxDevices_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.transText);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // transText
            // 
            resources.ApplyResources(this.transText, "transText");
            this.transText.ForeColor = System.Drawing.Color.Gray;
            this.transText.Name = "transText";
            this.transText.ReadOnly = true;
            this.transText.TextChanged += new System.EventHandler(this.transText_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControlGetSign, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tabControlGetSign
            // 
            this.tabControlGetSign.Controls.Add(this.tabRecord);
            this.tabControlGetSign.Controls.Add(this.tabOpen);
            this.tabControlGetSign.Controls.Add(this.tabScelton);
            this.tabControlGetSign.Controls.Add(this.tabContact);
            resources.ApplyResources(this.tabControlGetSign, "tabControlGetSign");
            this.tabControlGetSign.Name = "tabControlGetSign";
            this.tabControlGetSign.SelectedIndex = 0;
            // 
            // tabRecord
            // 
            this.tabRecord.Controls.Add(this.groupVideoRecord);
            resources.ApplyResources(this.tabRecord, "tabRecord");
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.UseVisualStyleBackColor = true;
            // 
            // tabOpen
            // 
            this.tabOpen.Controls.Add(this.btnOpen);
            resources.ApplyResources(this.tabOpen, "tabOpen");
            this.tabOpen.Name = "tabOpen";
            this.tabOpen.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            resources.ApplyResources(this.btnOpen, "btnOpen");
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tabScelton
            // 
            resources.ApplyResources(this.tabScelton, "tabScelton");
            this.tabScelton.Name = "tabScelton";
            this.tabScelton.UseVisualStyleBackColor = true;
            // 
            // frameCaptureTimer
            // 
            this.frameCaptureTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabContact
            // 
            resources.ApplyResources(this.tabContact, "tabContact");
            this.tabContact.Name = "tabContact";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // NormalUser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "NormalUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NormalUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupVideoRecord.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlGetSign.ResumeLayout(false);
            this.tabRecord.ResumeLayout(false);
            this.tabOpen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listSent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupVideoRecord;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox transText;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        public System.Windows.Forms.Button assign;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.Timer frameCaptureTimer;
        private System.Windows.Forms.Label lblRecordingDuration;
        private System.Windows.Forms.Button apperSign;
        private System.Windows.Forms.TabControl tabControlGetSign;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.TabPage tabOpen;
        private System.Windows.Forms.TabPage tabScelton;
        private System.Windows.Forms.Button btnOpen;
        public System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TabPage tabContact;
    }
}

