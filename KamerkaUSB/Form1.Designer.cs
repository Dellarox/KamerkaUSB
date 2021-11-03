namespace KamerkaUSB
{
    partial class KamerkaUSB
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxSelectDriver = new System.Windows.Forms.ComboBox();
            this.buttonSetResolution = new System.Windows.Forms.Button();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.savePhotoDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonContrast = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonRecordVideo = new System.Windows.Forms.Button();
            this.buttonStopRecord = new System.Windows.Forms.Button();
            this.pictureBoxOfCamera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonStart.Location = new System.Drawing.Point(9, 8);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(135, 54);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelHelp.Location = new System.Drawing.Point(186, 8);
            this.labelHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(66, 22);
            this.labelHelp.TabIndex = 1;
            this.labelHelp.Text = "Status:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelStatus.Location = new System.Drawing.Point(186, 36);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(71, 22);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "START";
            // 
            // comboBoxSelectDriver
            // 
            this.comboBoxSelectDriver.FormattingEnabled = true;
            this.comboBoxSelectDriver.Location = new System.Drawing.Point(9, 386);
            this.comboBoxSelectDriver.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSelectDriver.Name = "comboBoxSelectDriver";
            this.comboBoxSelectDriver.Size = new System.Drawing.Size(290, 21);
            this.comboBoxSelectDriver.TabIndex = 4;
            // 
            // buttonSetResolution
            // 
            this.buttonSetResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSetResolution.Location = new System.Drawing.Point(9, 78);
            this.buttonSetResolution.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetResolution.Name = "buttonSetResolution";
            this.buttonSetResolution.Size = new System.Drawing.Size(135, 46);
            this.buttonSetResolution.TabIndex = 5;
            this.buttonSetResolution.Text = "Set Resolution";
            this.buttonSetResolution.UseVisualStyleBackColor = true;
            this.buttonSetResolution.Click += new System.EventHandler(this.buttonSetResolution_Click);
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPhoto.Location = new System.Drawing.Point(8, 144);
            this.buttonPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(135, 46);
            this.buttonPhoto.TabIndex = 6;
            this.buttonPhoto.Text = "Photo";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // buttonContrast
            // 
            this.buttonContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonContrast.Location = new System.Drawing.Point(162, 78);
            this.buttonContrast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContrast.Name = "buttonContrast";
            this.buttonContrast.Size = new System.Drawing.Size(135, 46);
            this.buttonContrast.TabIndex = 8;
            this.buttonContrast.Text = "Set Contrast";
            this.buttonContrast.UseVisualStyleBackColor = true;
            this.buttonContrast.Click += new System.EventHandler(this.buttonContrast_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(309, 386);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(555, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonRecordVideo
            // 
            this.buttonRecordVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRecordVideo.Location = new System.Drawing.Point(162, 144);
            this.buttonRecordVideo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRecordVideo.Name = "buttonRecordVideo";
            this.buttonRecordVideo.Size = new System.Drawing.Size(135, 46);
            this.buttonRecordVideo.TabIndex = 10;
            this.buttonRecordVideo.Text = "Record Video";
            this.buttonRecordVideo.UseVisualStyleBackColor = true;
            this.buttonRecordVideo.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStopRecord
            // 
            this.buttonStopRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonStopRecord.Location = new System.Drawing.Point(162, 207);
            this.buttonStopRecord.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStopRecord.Name = "buttonStopRecord";
            this.buttonStopRecord.Size = new System.Drawing.Size(135, 46);
            this.buttonStopRecord.TabIndex = 11;
            this.buttonStopRecord.Text = "Stop Recording";
            this.buttonStopRecord.UseVisualStyleBackColor = true;
            this.buttonStopRecord.Click += new System.EventHandler(this.buttonStopRecord_Click);
            // 
            // pictureBoxOfCamera
            // 
            this.pictureBoxOfCamera.Location = new System.Drawing.Point(309, 12);
            this.pictureBoxOfCamera.Name = "pictureBoxOfCamera";
            this.pictureBoxOfCamera.Size = new System.Drawing.Size(555, 359);
            this.pictureBoxOfCamera.TabIndex = 12;
            this.pictureBoxOfCamera.TabStop = false;
            // 
            // KamerkaUSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 502);
            this.Controls.Add(this.pictureBoxOfCamera);
            this.Controls.Add(this.buttonStopRecord);
            this.Controls.Add(this.buttonRecordVideo);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonContrast);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.buttonSetResolution);
            this.Controls.Add(this.comboBoxSelectDriver);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KamerkaUSB";
            this.Text = "Kamerka USB";
            this.Load += new System.EventHandler(this.KamerkaUSB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxSelectDriver;
        private System.Windows.Forms.Button buttonSetResolution;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.SaveFileDialog savePhotoDialog;
        private System.Windows.Forms.Button buttonContrast;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonRecordVideo;
        private System.Windows.Forms.Button buttonStopRecord;
        private System.Windows.Forms.PictureBox pictureBoxOfCamera;
    }
}

