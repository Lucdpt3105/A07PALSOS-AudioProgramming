namespace A07PALSOS
{
    partial class frPAL2WMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPAL2WMP));
            this.LbTitle = new System.Windows.Forms.Label();
            this.gBAudioInfo07 = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.aUDIOFILESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.a07PALSOSDataSet = new A07PALSOS.A07PALSOSDataSet();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbLengthDonVi = new System.Windows.Forms.Label();
            this.lbLength = new System.Windows.Forms.Label();
            this.lbExt = new System.Windows.Forms.Label();
            this.lbDonViSize = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lbMaSo = new System.Windows.Forms.Label();
            this.listBoxAuFile = new System.Windows.Forms.ListBox();
            this.lbAudioInfo = new System.Windows.Forms.Label();
            this.lbAudioSelect = new System.Windows.Forms.Label();
            this.gBAudioTest07 = new System.Windows.Forms.GroupBox();
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnSlow = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnFast = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnRecord = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.aUDIOFILESTableAdapter = new A07PALSOS.A07PALSOSDataSetTableAdapters.AUDIOFILESTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gBAudioInfo07.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOFILESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a07PALSOSDataSet)).BeginInit();
            this.gBAudioTest07.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitle
            // 
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.Location = new System.Drawing.Point(21, 28);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(1119, 32);
            this.LbTitle.TabIndex = 3;
            this.LbTitle.Text = "[07 PAL] QUẢN LÝ FILEs ÂM THANH DÙNG THƯ VIỆN WMP.dll CỦA MS. WINDOWS";
            // 
            // gBAudioInfo07
            // 
            this.gBAudioInfo07.BackColor = System.Drawing.SystemColors.Control;
            this.gBAudioInfo07.Controls.Add(this.txtDesc);
            this.gBAudioInfo07.Controls.Add(this.txtLength);
            this.gBAudioInfo07.Controls.Add(this.txtExt);
            this.gBAudioInfo07.Controls.Add(this.txtSize);
            this.gBAudioInfo07.Controls.Add(this.txtPath);
            this.gBAudioInfo07.Controls.Add(this.txtFileName);
            this.gBAudioInfo07.Controls.Add(this.txtMaSo);
            this.gBAudioInfo07.Controls.Add(this.lbDesc);
            this.gBAudioInfo07.Controls.Add(this.lbLengthDonVi);
            this.gBAudioInfo07.Controls.Add(this.lbLength);
            this.gBAudioInfo07.Controls.Add(this.lbExt);
            this.gBAudioInfo07.Controls.Add(this.lbDonViSize);
            this.gBAudioInfo07.Controls.Add(this.lbSize);
            this.gBAudioInfo07.Controls.Add(this.lbPath);
            this.gBAudioInfo07.Controls.Add(this.lbFileName);
            this.gBAudioInfo07.Controls.Add(this.lbMaSo);
            this.gBAudioInfo07.Controls.Add(this.listBoxAuFile);
            this.gBAudioInfo07.Controls.Add(this.lbAudioInfo);
            this.gBAudioInfo07.Controls.Add(this.lbAudioSelect);
            this.gBAudioInfo07.Location = new System.Drawing.Point(12, 123);
            this.gBAudioInfo07.Name = "gBAudioInfo07";
            this.gBAudioInfo07.Size = new System.Drawing.Size(791, 536);
            this.gBAudioInfo07.TabIndex = 4;
            this.gBAudioInfo07.TabStop = false;
            this.gBAudioInfo07.Text = "[07 PAL] QUẢN LÝ THÔNG TIN FILES ÂM THANH";
            // 
            // txtDesc
            // 
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "description", true));
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(346, 427);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(427, 76);
            this.txtDesc.TabIndex = 8;
            // 
            // aUDIOFILESBindingSource
            // 
            this.aUDIOFILESBindingSource.DataMember = "AUDIOFILES";
            this.aUDIOFILESBindingSource.DataSource = this.a07PALSOSDataSet;
            // 
            // a07PALSOSDataSet
            // 
            this.a07PALSOSDataSet.DataSetName = "A07PALSOSDataSet";
            this.a07PALSOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtLength
            // 
            this.txtLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "length", true));
            this.txtLength.Enabled = false;
            this.txtLength.Location = new System.Drawing.Point(527, 351);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(169, 29);
            this.txtLength.TabIndex = 7;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtExt
            // 
            this.txtExt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "ext", true));
            this.txtExt.Enabled = false;
            this.txtExt.Location = new System.Drawing.Point(526, 295);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(246, 29);
            this.txtExt.TabIndex = 6;
            // 
            // txtSize
            // 
            this.txtSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "size", true));
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(527, 241);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(193, 29);
            this.txtSize.TabIndex = 5;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPath
            // 
            this.txtPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "filepath", true));
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(526, 189);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(246, 29);
            this.txtPath.TabIndex = 4;
            // 
            // txtFileName
            // 
            this.txtFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "filename", true));
            this.txtFileName.Enabled = false;
            this.txtFileName.Location = new System.Drawing.Point(526, 136);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(246, 29);
            this.txtFileName.TabIndex = 3;
            // 
            // txtMaSo
            // 
            this.txtMaSo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource, "ms", true));
            this.txtMaSo.Enabled = false;
            this.txtMaSo.Location = new System.Drawing.Point(526, 88);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(246, 29);
            this.txtMaSo.TabIndex = 2;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(453, 399);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(67, 25);
            this.lbDesc.TabIndex = 2;
            this.lbDesc.Text = "Mô tả:";
            // 
            // lbLengthDonVi
            // 
            this.lbLengthDonVi.AutoSize = true;
            this.lbLengthDonVi.Location = new System.Drawing.Point(702, 351);
            this.lbLengthDonVi.Name = "lbLengthDonVi";
            this.lbLengthDonVi.Size = new System.Drawing.Size(77, 25);
            this.lbLengthDonVi.TabIndex = 2;
            this.lbLengthDonVi.Text = "s (giây)";
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(419, 354);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(101, 25);
            this.lbLength.TabIndex = 2;
            this.lbLength.Text = "Chiều dài:";
            // 
            // lbExt
            // 
            this.lbExt.AutoSize = true;
            this.lbExt.Location = new System.Drawing.Point(340, 299);
            this.lbExt.Name = "lbExt";
            this.lbExt.Size = new System.Drawing.Size(180, 25);
            this.lbExt.TabIndex = 2;
            this.lbExt.Text = "Phần mở rộng(ext):";
            // 
            // lbDonViSize
            // 
            this.lbDonViSize.AutoSize = true;
            this.lbDonViSize.Location = new System.Drawing.Point(726, 241);
            this.lbDonViSize.Name = "lbDonViSize";
            this.lbDonViSize.Size = new System.Drawing.Size(61, 25);
            this.lbDonViSize.TabIndex = 2;
            this.lbDonViSize.Text = "KB[s]";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(410, 245);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(110, 25);
            this.lbSize.TabIndex = 2;
            this.lbSize.Text = "Kích thước:";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(359, 189);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(171, 25);
            this.lbPath.TabIndex = 2;
            this.lbPath.Text = "Đường dẫn (path):";
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(448, 140);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(82, 25);
            this.lbFileName.TabIndex = 2;
            this.lbFileName.Text = "Tên file:";
            // 
            // lbMaSo
            // 
            this.lbMaSo.AutoSize = true;
            this.lbMaSo.Location = new System.Drawing.Point(448, 91);
            this.lbMaSo.Name = "lbMaSo";
            this.lbMaSo.Size = new System.Drawing.Size(72, 25);
            this.lbMaSo.TabIndex = 2;
            this.lbMaSo.Text = "Mã số:";
            // 
            // listBoxAuFile
            // 
            this.listBoxAuFile.DataSource = this.aUDIOFILESBindingSource;
            this.listBoxAuFile.DisplayMember = "filename";
            this.listBoxAuFile.FormattingEnabled = true;
            this.listBoxAuFile.ItemHeight = 24;
            this.listBoxAuFile.Location = new System.Drawing.Point(27, 91);
            this.listBoxAuFile.Name = "listBoxAuFile";
            this.listBoxAuFile.Size = new System.Drawing.Size(307, 412);
            this.listBoxAuFile.TabIndex = 1;
            this.listBoxAuFile.ValueMember = "ms";
            // 
            // lbAudioInfo
            // 
            this.lbAudioInfo.AutoSize = true;
            this.lbAudioInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAudioInfo.Location = new System.Drawing.Point(442, 41);
            this.lbAudioInfo.Name = "lbAudioInfo";
            this.lbAudioInfo.Size = new System.Drawing.Size(330, 25);
            this.lbAudioInfo.TabIndex = 0;
            this.lbAudioInfo.Text = "Thông tin chi tiết về file âm thanh";
            // 
            // lbAudioSelect
            // 
            this.lbAudioSelect.AutoSize = true;
            this.lbAudioSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAudioSelect.Location = new System.Drawing.Point(22, 41);
            this.lbAudioSelect.Name = "lbAudioSelect";
            this.lbAudioSelect.Size = new System.Drawing.Size(204, 25);
            this.lbAudioSelect.TabIndex = 0;
            this.lbAudioSelect.Text = "Chọn files âm thanh";
            // 
            // gBAudioTest07
            // 
            this.gBAudioTest07.AutoSize = true;
            this.gBAudioTest07.BackColor = System.Drawing.SystemColors.Control;
            this.gBAudioTest07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gBAudioTest07.Controls.Add(this.BtnLast);
            this.gBAudioTest07.Controls.Add(this.BtnSlow);
            this.gBAudioTest07.Controls.Add(this.BtnNext);
            this.gBAudioTest07.Controls.Add(this.axWMP);
            this.gBAudioTest07.Controls.Add(this.BtnFirst);
            this.gBAudioTest07.Controls.Add(this.BtnPrev);
            this.gBAudioTest07.Controls.Add(this.BtnFast);
            this.gBAudioTest07.Controls.Add(this.btnPlay);
            this.gBAudioTest07.Controls.Add(this.BtnStop);
            this.gBAudioTest07.Controls.Add(this.btnPause);
            this.gBAudioTest07.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBAudioTest07.Location = new System.Drawing.Point(827, 123);
            this.gBAudioTest07.Name = "gBAudioTest07";
            this.gBAudioTest07.Size = new System.Drawing.Size(612, 536);
            this.gBAudioTest07.TabIndex = 5;
            this.gBAudioTest07.TabStop = false;
            this.gBAudioTest07.Text = "[07 PAL] KIỂM (NGHE THỬ: TEST) FILES ÂM THANH";
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(478, 458);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(128, 43);
            this.BtnLast.TabIndex = 18;
            this.BtnLast.Text = "Last Track";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnSlow
            // 
            this.BtnSlow.Location = new System.Drawing.Point(504, 409);
            this.BtnSlow.Name = "BtnSlow";
            this.BtnSlow.Size = new System.Drawing.Size(102, 43);
            this.BtnSlow.TabIndex = 14;
            this.BtnSlow.Text = "Reverse";
            this.BtnSlow.UseVisualStyleBackColor = true;
            this.BtnSlow.Click += new System.EventHandler(this.BtnSlow_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(331, 458);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(135, 43);
            this.BtnNext.TabIndex = 17;
            this.BtnNext.Text = "Next Track";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // axWMP
            // 
            this.axWMP.DataBindings.Add(new System.Windows.Forms.Binding("URL", this.aUDIOFILESBindingSource, "filepath", true));
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(6, 28);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(324, 204);
            this.axWMP.TabIndex = 9;
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(6, 460);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(141, 43);
            this.BtnFirst.TabIndex = 15;
            this.BtnFirst.Text = "First Track";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Location = new System.Drawing.Point(160, 460);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(155, 43);
            this.BtnPrev.TabIndex = 16;
            this.BtnPrev.Text = "Previous Track";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnFast
            // 
            this.BtnFast.Location = new System.Drawing.Point(396, 409);
            this.BtnFast.Name = "BtnFast";
            this.BtnFast.Size = new System.Drawing.Size(82, 43);
            this.BtnFast.TabIndex = 13;
            this.BtnFast.Text = "Faster";
            this.BtnFast.UseVisualStyleBackColor = true;
            this.BtnFast.Click += new System.EventHandler(this.BtnFast_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(6, 409);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(82, 43);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(269, 409);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(82, 43);
            this.BtnStop.TabIndex = 12;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(136, 409);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(82, 43);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(27, 685);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(130, 43);
            this.BtnLoad.TabIndex = 20;
            this.BtnLoad.Text = "Nạp file mới";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(239, 685);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(189, 43);
            this.BtnModify.TabIndex = 21;
            this.BtnModify.Text = "Sửa thông tin file";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnRecord
            // 
            this.BtnRecord.Location = new System.Drawing.Point(470, 685);
            this.BtnRecord.Name = "BtnRecord";
            this.BtnRecord.Size = new System.Drawing.Size(154, 43);
            this.BtnRecord.TabIndex = 22;
            this.BtnRecord.Text = "Ghi âm file mới";
            this.BtnRecord.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(673, 685);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(130, 43);
            this.BtnDelete.TabIndex = 23;
            this.BtnDelete.Text = "Xóa file";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(833, 685);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(345, 43);
            this.BtnClose.TabIndex = 24;
            this.BtnClose.Text = "Đóng form, về màn hình chính";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(1303, 685);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(130, 43);
            this.BtnExit.TabIndex = 25;
            this.BtnExit.Text = "Thoát app";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // aUDIOFILESTableAdapter
            // 
            this.aUDIOFILESTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frPAL2WMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1460, 845);
            this.Controls.Add(this.gBAudioTest07);
            this.Controls.Add(this.gBAudioInfo07);
            this.Controls.Add(this.LbTitle);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnRecord);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnLoad);
            this.Name = "frPAL2WMP";
            this.Text = "[07 PAL] QUẢN LÝ FILES ÂM THANH DÙNG THƯ VIỆN WMP.dll CỦA MS. WINDOWS";
            this.Load += new System.EventHandler(this.frPAL2WMP_Load);
            this.gBAudioInfo07.ResumeLayout(false);
            this.gBAudioInfo07.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOFILESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a07PALSOSDataSet)).EndInit();
            this.gBAudioTest07.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.GroupBox gBAudioInfo07;
        private System.Windows.Forms.GroupBox gBAudioTest07;
        private System.Windows.Forms.ListBox listBoxAuFile;
        private System.Windows.Forms.Label lbAudioInfo;
        private System.Windows.Forms.Label lbAudioSelect;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.Label lbExt;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Label lbMaSo;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label lbDonViSize;
        private System.Windows.Forms.Label lbLengthDonVi;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button BtnFast;
        private System.Windows.Forms.Button BtnSlow;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnRecord;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnExit;
        private A07PALSOSDataSet a07PALSOSDataSet;
        private System.Windows.Forms.BindingSource aUDIOFILESBindingSource;
        private A07PALSOSDataSetTableAdapters.AUDIOFILESTableAdapter aUDIOFILESTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}