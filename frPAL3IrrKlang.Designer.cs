namespace A07PALSOS
{
    partial class frPAL3IrrKlang
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAudioFile = new System.Windows.Forms.Label();
            this.cboAudioFiles = new System.Windows.Forms.ComboBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupPosition = new System.Windows.Forms.GroupBox();
            this.lblPositionValue = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.trackZ = new System.Windows.Forms.TrackBar();
            this.lblY = new System.Windows.Forms.Label();
            this.trackY = new System.Windows.Forms.TrackBar();
            this.lblX = new System.Windows.Forms.Label();
            this.trackX = new System.Windows.Forms.TrackBar();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.lblVolumeValue = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.numMinDistance = new System.Windows.Forms.NumericUpDown();
            this.lblMinDistance = new System.Windows.Forms.Label();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackX)).BeginInit();
            this.groupOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(22, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(805, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "[07 PAL] PHÁT ÂM THANH 3D DÙNG THƯ VIỆN irrKlang";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAudioFile
            // 
            this.lblAudioFile.AutoSize = true;
            this.lblAudioFile.Location = new System.Drawing.Point(27, 89);
            this.lblAudioFile.Name = "lblAudioFile";
            this.lblAudioFile.Size = new System.Drawing.Size(163, 25);
            this.lblAudioFile.TabIndex = 1;
            this.lblAudioFile.Text = "Chọn file âm thanh";
            // 
            // cboAudioFiles
            // 
            this.cboAudioFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAudioFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioFiles.FormattingEnabled = true;
            this.cboAudioFiles.Location = new System.Drawing.Point(211, 85);
            this.cboAudioFiles.Name = "cboAudioFiles";
            this.cboAudioFiles.Size = new System.Drawing.Size(455, 32);
            this.cboAudioFiles.TabIndex = 2;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartStop.Location = new System.Drawing.Point(686, 80);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(141, 43);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "Play 3D";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(686, 533);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(141, 43);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Dừng";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Location = new System.Drawing.Point(514, 533);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(141, 43);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Tạm dừng";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(32, 533);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(169, 43);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Nạp lại danh sách";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupPosition
            // 
            this.groupPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPosition.Controls.Add(this.lblPositionValue);
            this.groupPosition.Controls.Add(this.lblZ);
            this.groupPosition.Controls.Add(this.trackZ);
            this.groupPosition.Controls.Add(this.lblY);
            this.groupPosition.Controls.Add(this.trackY);
            this.groupPosition.Controls.Add(this.lblX);
            this.groupPosition.Controls.Add(this.trackX);
            this.groupPosition.Location = new System.Drawing.Point(32, 151);
            this.groupPosition.Name = "groupPosition";
            this.groupPosition.Size = new System.Drawing.Size(491, 340);
            this.groupPosition.TabIndex = 4;
            this.groupPosition.TabStop = false;
            this.groupPosition.Text = "Vị trí nguồn âm 3D";
            // 
            // lblPositionValue
            // 
            this.lblPositionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPositionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionValue.Location = new System.Drawing.Point(25, 293);
            this.lblPositionValue.Name = "lblPositionValue";
            this.lblPositionValue.Size = new System.Drawing.Size(442, 30);
            this.lblPositionValue.TabIndex = 6;
            this.lblPositionValue.Text = "X=0, Y=0, Z=0";
            this.lblPositionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(25, 206);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(26, 25);
            this.lblZ.TabIndex = 4;
            this.lblZ.Text = "Z";
            // 
            // trackZ
            // 
            this.trackZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackZ.LargeChange = 2;
            this.trackZ.Location = new System.Drawing.Point(65, 190);
            this.trackZ.Maximum = 10;
            this.trackZ.Minimum = -10;
            this.trackZ.Name = "trackZ";
            this.trackZ.Size = new System.Drawing.Size(402, 80);
            this.trackZ.TabIndex = 5;
            this.trackZ.Value = 3;
            this.trackZ.ValueChanged += new System.EventHandler(this.PositionControl_ValueChanged);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(25, 127);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(26, 25);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y";
            // 
            // trackY
            // 
            this.trackY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackY.LargeChange = 2;
            this.trackY.Location = new System.Drawing.Point(65, 111);
            this.trackY.Maximum = 10;
            this.trackY.Minimum = -10;
            this.trackY.Name = "trackY";
            this.trackY.Size = new System.Drawing.Size(402, 80);
            this.trackY.TabIndex = 3;
            this.trackY.ValueChanged += new System.EventHandler(this.PositionControl_ValueChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(25, 50);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 25);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // trackX
            // 
            this.trackX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackX.LargeChange = 2;
            this.trackX.Location = new System.Drawing.Point(65, 34);
            this.trackX.Maximum = 10;
            this.trackX.Minimum = -10;
            this.trackX.Name = "trackX";
            this.trackX.Size = new System.Drawing.Size(402, 80);
            this.trackX.TabIndex = 1;
            this.trackX.ValueChanged += new System.EventHandler(this.PositionControl_ValueChanged);
            // 
            // groupOptions
            // 
            this.groupOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right) 
            | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupOptions.Controls.Add(this.lblVolumeValue);
            this.groupOptions.Controls.Add(this.lblVolume);
            this.groupOptions.Controls.Add(this.trackVolume);
            this.groupOptions.Controls.Add(this.numMinDistance);
            this.groupOptions.Controls.Add(this.lblMinDistance);
            this.groupOptions.Controls.Add(this.chkLoop);
            this.groupOptions.Location = new System.Drawing.Point(547, 151);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(280, 340);
            this.groupOptions.TabIndex = 5;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Tùy chọn phát";
            // 
            // lblVolumeValue
            // 
            this.lblVolumeValue.AutoSize = true;
            this.lblVolumeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeValue.Location = new System.Drawing.Point(173, 62);
            this.lblVolumeValue.Name = "lblVolumeValue";
            this.lblVolumeValue.Size = new System.Drawing.Size(63, 25);
            this.lblVolumeValue.TabIndex = 2;
            this.lblVolumeValue.Text = "85%";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(22, 62);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(93, 25);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "Âm lượng";
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(20, 99);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(238, 80);
            this.trackVolume.TabIndex = 1;
            this.trackVolume.TickFrequency = 10;
            this.trackVolume.Value = 85;
            this.trackVolume.ValueChanged += new System.EventHandler(this.trackVolume_ValueChanged);
            // 
            // numMinDistance
            // 
            this.numMinDistance.DecimalPlaces = 1;
            this.numMinDistance.Location = new System.Drawing.Point(27, 247);
            this.numMinDistance.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMinDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMinDistance.Name = "numMinDistance";
            this.numMinDistance.Size = new System.Drawing.Size(120, 29);
            this.numMinDistance.TabIndex = 5;
            this.numMinDistance.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblMinDistance
            // 
            this.lblMinDistance.AutoSize = true;
            this.lblMinDistance.Location = new System.Drawing.Point(22, 211);
            this.lblMinDistance.Name = "lblMinDistance";
            this.lblMinDistance.Size = new System.Drawing.Size(167, 25);
            this.lblMinDistance.TabIndex = 4;
            this.lblMinDistance.Text = "Khoảng cách gần";
            // 
            // chkLoop
            // 
            this.chkLoop.AutoSize = true;
            this.chkLoop.Checked = true;
            this.chkLoop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLoop.Location = new System.Drawing.Point(27, 296);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(145, 29);
            this.chkLoop.TabIndex = 6;
            this.chkLoop.Text = "Phát lặp lại";
            this.chkLoop.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(27, 592);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(800, 57);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Sẵn sàng.";
            // 
            // frPAL3IrrKlang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(854, 668);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.groupPosition);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.cboAudioFiles);
            this.Controls.Add(this.lblAudioFile);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(878, 732);
            this.Name = "frPAL3IrrKlang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "07 PAL: PHÁT ÂM THANH 3D DÙNG THƯ VIỆN irrKlang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frPAL3IrrKlang_FormClosing);
            this.groupPosition.ResumeLayout(false);
            this.groupPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackX)).EndInit();
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAudioFile;
        private System.Windows.Forms.ComboBox cboAudioFiles;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupPosition;
        private System.Windows.Forms.Label lblPositionValue;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TrackBar trackZ;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TrackBar trackY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TrackBar trackX;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.Label lblVolumeValue;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.NumericUpDown numMinDistance;
        private System.Windows.Forms.Label lblMinDistance;
        private System.Windows.Forms.CheckBox chkLoop;
        private System.Windows.Forms.Label lblStatus;
    }
}
