using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace A07PALSOS
{
    public partial class frPAL1Main : Form
    {
        private readonly Dictionary<Control, Font> originalControlFonts = new Dictionary<Control, Font>();
        private readonly Dictionary<ToolStripItem, Font> originalMenuFonts = new Dictionary<ToolStripItem, Font>();
        private readonly int[] zoomValues = { 90, 100, 110, 125, 150 };
        private int zoomIndex = 1;
        private bool isLoggedIn = true;

        public frPAL1Main()
        {
            InitializeComponent();
            CaptureOriginalFonts(this);
            ConfigureRuntimeMenus();
            UpdateClock();
            UpdatePresentationMenuState();
            SetLoggedIn(true);
            EnsureAudioStoreReady();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void quảnLýÂmThanhDùngWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frPAL2WMP fr = new frPAL2WMP())
            {
                fr.ShowDialog(this);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Có thật sự là muốn thoát chương trình này hay không (Y/N)", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void quảnLýÂmThanhDùngIrrKlangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frPAL3IrrKlang fr = new frPAL3IrrKlang())
            {
                fr.ShowDialog(this);
            }
        }

        private void tắtMởThanhThựcĐơnMenuBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = tắtMởThanhThựcĐơnMenuBarToolStripMenuItem.Checked;
            UpdatePresentationMenuState();
        }

        private void tắtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = tắtToolStripMenuItem.Checked;
            UpdatePresentationMenuState();
        }

        private void tắtMởDòngTrạngTháiStatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = tắtMởDòngTrạngTháiStatusBarToolStripMenuItem.Checked;
            UpdatePresentationMenuState();
        }

        private void tắtFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideMainFormToTray();
        }

        private void ConfigureRuntimeMenus()
        {
            đăngNhậpToolStripMenuItem.Click += (sender, e) => SetLoggedIn(true);
            đăngXuấtToolStripMenuItem.Click += (sender, e) => SetLoggedIn(false);
            kếtNốiThiếtBịToolStripMenuItem.Click += (sender, e) => ShowInformation("Kết nối thiết bị", "Ứng dụng đang phát âm thanh qua thiết bị mặc định của Windows. Hãy kiểm tra loa/tai nghe trong Sound Settings nếu chưa nghe được.");
            thiếtLậpThôngSốKĩThuậtToolStripMenuItem.Click += (sender, e) => ShowInformation("Thông số kỹ thuật", "Định dạng hỗ trợ: MP3, WAV, WMA, FLAC, OGG.\nBộ phát: Windows Media Player và irrKlang 3D.\nDữ liệu lưu tại: " + AppPaths.DataDirectory);

            nạpFilesToolStripMenuItem.Click += (sender, e) => ImportFiles(false);
            nạpFilesToolStripMenuItem1.Click += (sender, e) => ImportFiles(true);
            thuÂmToolStripMenuItem.Click += (sender, e) => ShowFeatureUnavailable("Thu âm", "Chưa có module ghi âm micro trong project hiện tại. Bạn có thể nạp file thu sẵn bằng mục Nạp files.");
            thuÂmToolStripMenuItem1.Click += (sender, e) => ShowFeatureUnavailable("Thu âm", "Chưa có module ghi âm micro trong project hiện tại. Bạn có thể nạp file thu sẵn bằng mục Nạp files.");

            chuyểnÂmTrầmbassÂmCaotrebleDùngWMPToolStripMenuItem.Click += AudioProcessingMenu_Click;
            chuyểnÂmCaotrebleÂmTrầmbassDùngWMPToolStripMenuItem.Click += AudioProcessingMenu_Click;
            khuếchĐạiÂmThanhDùngWMPToolStripMenuItem.Click += AudioProcessingMenu_Click;
            điềuChỉnhÂmThanhDùngWMPToolStripMenuItem.Click += AudioProcessingMenu_Click;
            thayĐổiÂmSắcDùngWMPToolStripMenuItem.Click += AudioProcessingMenu_Click;
            điềuChỉnhTonetôngCủaÂmThanhDùngWMPToolStripMenuItem.Click += AudioProcessingMenu_Click;
            điềuChỉnhBitDepthÂmThanhDùngWMPToolStripMenuItem.Click += AudioProcessingMenu_Click;
            chuyểnMonoStereo3DDùngWMPToolStripMenuItem.Click += (sender, e) => quảnLýÂmThanhDùngIrrKlangToolStripMenuItem_Click(sender, e);
            chuyểnKiểuExtensionFilesÂmThanhDùngWMPToolStripMenuItem.Click += AudioProcessingMenu_Click;
            nénÂmThanhToolStripMenuItem.Click += AudioProcessingMenu_Click;
            xửLýTạpÂmNoiseProcessingToolStripMenuItem.Click += AudioProcessingMenu_Click;
            lọcNhiễuNoiseFilterToolStripMenuItem.Click += AudioProcessingMenu_Click;
            hợpÂmChordMẫuTrongÂmThToolStripMenuItem.Click += AudioProcessingMenu_Click;
            nHẬNDIỆNÂMTHANHToolStripMenuItem.Click += (sender, e) => ShowFeatureUnavailable("Nhận diện âm thanh", "Project hiện tại chưa tích hợp thư viện nhận diện/AI âm thanh. Phần phát và quản lý file đã sẵn sàng dùng.");

            ConfigureToolMenu();
            ConfigureZoomMenu();
            ConfigureHelpMenu();
            ConfigureNotifyMenu();
        }

        private void ConfigureToolMenu()
        {
            cÔNGCỤToolStripMenuItem.DropDownItems.Clear();
            cÔNGCỤToolStripMenuItem.DropDownItems.Add("Mở thư mục âm thanh", null, (sender, e) => OpenFolder(AppPaths.AudioDirectory));
            cÔNGCỤToolStripMenuItem.DropDownItems.Add("Đồng bộ danh sách âm thanh", null, (sender, e) => SyncAudioFiles());
            cÔNGCỤToolStripMenuItem.DropDownItems.Add("Mở thư mục dữ liệu", null, (sender, e) => OpenFolder(AppPaths.DataDirectory));
        }

        private void ConfigureZoomMenu()
        {
            tỷLệZoomToolStripMenuItem.DropDownItems.Clear();
            for (int i = 0; i < zoomValues.Length; i++)
            {
                int currentIndex = i;
                ToolStripMenuItem item = new ToolStripMenuItem(zoomValues[i] + "%");
                item.Click += (sender, e) => ApplyZoom(currentIndex);
                tỷLệZoomToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        private void ConfigureHelpMenu()
        {
            gToolStripMenuItem.Click += (sender, e) => ShowInformation(
                "Giới thiệu phiên bản",
                "A07PALSOS - Audio Program\nSinh viên: 07 Phùng Anh Lực\nPTIT HCM, năm học 2025-2026\n\nỨng dụng quản lý và phát file cảnh báo bằng WMP, hỗ trợ phát âm thanh 3D bằng irrKlang.");
            hướngDẫnSửDụngToolStripMenuItem.Click += (sender, e) => OpenReadmeOrShowGuide();
        }

        private void ConfigureNotifyMenu()
        {
            contextMenuStrip1.Items.Insert(0, new ToolStripMenuItem("Mở màn hình chính", null, (sender, e) => RestoreMainForm()));
            contextMenuStrip1.Items.Insert(1, new ToolStripSeparator());
            notifyIcon1.DoubleClick += (sender, e) => RestoreMainForm();
        }

        private void EnsureAudioStoreReady()
        {
            try
            {
                using (A07PALSOSDataSet dataSet = new A07PALSOSDataSet())
                {
                    AudioFileStore.Load(dataSet);
                    int addedCount = AudioFileStore.SyncFromAudioDirectory(dataSet);
                    toolStripStatusLabel2.Text = addedCount > 0 ? "Đã đồng bộ thêm " + addedCount + " file âm thanh." : "Sẵn sàng.";
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel2.Text = "Lỗi dữ liệu âm thanh.";
                MessageBox.Show("Không thể khởi tạo danh sách âm thanh: " + ex.Message, "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ImportFiles(bool openIrrKlangAfterImport)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = AudioFileStore.OpenFileFilter;
                dialog.Multiselect = true;
                dialog.Title = "Chọn file âm thanh cần nạp";

                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    int importedCount;
                    using (A07PALSOSDataSet dataSet = new A07PALSOSDataSet())
                    {
                        AudioFileStore.Load(dataSet);
                        importedCount = AudioFileStore.ImportAudioFiles(dataSet, dialog.FileNames);
                    }

                    toolStripStatusLabel2.Text = "Đã nạp " + importedCount + " file âm thanh.";
                    MessageBox.Show("Đã nạp " + importedCount + " file âm thanh vào:\n" + AppPaths.AudioDirectory,
                        "Nạp file hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (openIrrKlangAfterImport)
                    {
                        quảnLýÂmThanhDùngIrrKlangToolStripMenuItem_Click(this, EventArgs.Empty);
                    }
                    else
                    {
                        quảnLýÂmThanhDùngWMPToolStripMenuItem_Click(this, EventArgs.Empty);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể nạp file âm thanh: " + ex.Message, "Lỗi nạp file",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SyncAudioFiles()
        {
            try
            {
                int addedCount;
                using (A07PALSOSDataSet dataSet = new A07PALSOSDataSet())
                {
                    AudioFileStore.Load(dataSet);
                    addedCount = AudioFileStore.SyncFromAudioDirectory(dataSet);
                }

                toolStripStatusLabel2.Text = "Đồng bộ xong: thêm " + addedCount + " file.";
                MessageBox.Show("Đồng bộ xong. Đã thêm " + addedCount + " file mới vào danh sách.",
                    "Đồng bộ âm thanh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đồng bộ danh sách âm thanh: " + ex.Message, "Lỗi đồng bộ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AudioProcessingMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            string featureName = item == null ? "Xử lý âm thanh" : item.Text;
            ShowFeatureUnavailable(featureName, "Windows Media Player trong project này dùng để phát/tạm dừng/dừng/chuyển track, chưa có engine DSP để chuyển tông, lọc nhiễu, nén hoặc đổi định dạng file thật. Bạn vẫn có thể mở form WMP để phát thử và quản lý file.");
            quảnLýÂmThanhDùngWMPToolStripMenuItem_Click(sender, e);
        }

        private void ApplyZoom(int newZoomIndex)
        {
            zoomIndex = newZoomIndex;
            float scale = zoomValues[zoomIndex] / 100f;
            ApplyZoomToControl(this, scale);
            UpdatePresentationMenuState();
            toolStripStatusLabel2.Text = "Zoom " + zoomValues[zoomIndex] + "%";
        }

        private void ApplyZoomToControl(Control control, float scale)
        {
            Font originalFont;
            if (originalControlFonts.TryGetValue(control, out originalFont))
            {
                control.Font = new Font(originalFont.FontFamily, Math.Max(6f, originalFont.Size * scale), originalFont.Style);
            }

            ToolStrip toolStrip = control as ToolStrip;
            if (toolStrip != null)
            {
                foreach (ToolStripItem item in toolStrip.Items)
                {
                    ApplyZoomToToolStripItem(item, scale);
                }
            }

            foreach (Control child in control.Controls)
            {
                ApplyZoomToControl(child, scale);
            }
        }

        private void ApplyZoomToToolStripItem(ToolStripItem item, float scale)
        {
            Font originalFont;
            if (originalMenuFonts.TryGetValue(item, out originalFont))
            {
                item.Font = new Font(originalFont.FontFamily, Math.Max(6f, originalFont.Size * scale), originalFont.Style);
            }

            ToolStripMenuItem menuItem = item as ToolStripMenuItem;
            if (menuItem == null)
            {
                return;
            }

            foreach (ToolStripItem child in menuItem.DropDownItems)
            {
                ApplyZoomToToolStripItem(child, scale);
            }
        }

        private void CaptureOriginalFonts(Control control)
        {
            if (!originalControlFonts.ContainsKey(control))
            {
                originalControlFonts.Add(control, control.Font);
            }

            ToolStrip toolStrip = control as ToolStrip;
            if (toolStrip != null)
            {
                foreach (ToolStripItem item in toolStrip.Items)
                {
                    CaptureOriginalToolStripFonts(item);
                }
            }

            foreach (Control child in control.Controls)
            {
                CaptureOriginalFonts(child);
            }
        }

        private void CaptureOriginalToolStripFonts(ToolStripItem item)
        {
            if (!originalMenuFonts.ContainsKey(item))
            {
                originalMenuFonts.Add(item, item.Font);
            }

            ToolStripMenuItem menuItem = item as ToolStripMenuItem;
            if (menuItem == null)
            {
                return;
            }

            foreach (ToolStripItem child in menuItem.DropDownItems)
            {
                CaptureOriginalToolStripFonts(child);
            }
        }

        private void UpdatePresentationMenuState()
        {
            tắtMởThanhThựcĐơnMenuBarToolStripMenuItem.Checked = menuStrip1.Visible;
            tắtToolStripMenuItem.Checked = toolStrip1.Visible;
            tắtMởDòngTrạngTháiStatusBarToolStripMenuItem.Checked = statusStrip1.Visible;
            tỷLệZoomToolStripMenuItem.Text = "Tỷ lệ Zoom (" + zoomValues[zoomIndex] + "%)";

            for (int i = 0; i < tỷLệZoomToolStripMenuItem.DropDownItems.Count; i++)
            {
                ToolStripMenuItem item = tỷLệZoomToolStripMenuItem.DropDownItems[i] as ToolStripMenuItem;
                if (item != null)
                {
                    item.Checked = i == zoomIndex;
                }
            }
        }

        private void SetLoggedIn(bool loggedIn)
        {
            isLoggedIn = loggedIn;
            đăngNhậpToolStripMenuItem.Enabled = !isLoggedIn;
            đăngXuấtToolStripMenuItem.Enabled = isLoggedIn;
            toolStripStatusLabel2.Text = isLoggedIn ? "Đã đăng nhập chế độ cục bộ." : "Đã đăng xuất.";
        }

        private void HideMainFormToTray()
        {
            notifyIcon1.BalloonTipTitle = "A07PALSOS";
            notifyIcon1.BalloonTipText = "Ứng dụng vẫn chạy dưới khay hệ thống. Nhấp đúp biểu tượng để mở lại.";
            notifyIcon1.ShowBalloonTip(2000);
            Hide();
        }

        private void RestoreMainForm()
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void OpenFolder(string folderPath)
        {
            Directory.CreateDirectory(folderPath);
            Process.Start("explorer.exe", folderPath);
        }

        private void OpenReadmeOrShowGuide()
        {
            string readmePath = Path.Combine(Application.StartupPath, "README.md");
            if (!File.Exists(readmePath))
            {
                DirectoryInfo directory = new DirectoryInfo(Application.StartupPath);
                for (int i = 0; i < 5 && directory != null; i++)
                {
                    string candidate = Path.Combine(directory.FullName, "README.md");
                    if (File.Exists(candidate))
                    {
                        readmePath = candidate;
                        break;
                    }

                    directory = directory.Parent;
                }
            }

            if (File.Exists(readmePath))
            {
                Process.Start("notepad.exe", readmePath);
                return;
            }

            ShowInformation("Hướng dẫn sử dụng",
                "1. Vào Quản lý âm thanh > Nạp files để thêm file cảnh báo.\n2. Mở form WMP để phát, dừng, tạm dừng và quản lý danh sách.\n3. Mở form irrKlang để phát âm thanh 3D và chỉnh vị trí X/Y/Z.\n4. Vào Công cụ > Đồng bộ danh sách âm thanh nếu bạn copy file thủ công vào thư mục FileAmThanh.");
        }

        private void ShowInformation(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowFeatureUnavailable(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            toolStripStatusLabel2.Text = title + " chưa có module xử lý riêng.";
        }

        private void UpdateClock()
        {
            toolStripStatusLabel3.Text = "Hôm nay là: " + DateTime.Now.ToString("dd/MM/yyyy ") + " Bây giờ là: " + DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
