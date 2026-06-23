using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;

namespace A07PALSOS
{
    public partial class frPAL3IrrKlang : Form
    {
        //Khai báo biến toàn cục thuộc đối tượng File âm thanh của irrKlang.
        string audiopath = AppPaths.AudioDirectory + "\\";
        ISoundEngine fn = new ISoundEngine();
        ISound currentSound = null;//Biến toàn cục lưu trữ âm thanh hiện tại đang phát
        bool isPlaying = false;//Biến toàn cục lưu trạng thái âm thanh đang phát hay không

        public frPAL3IrrKlang()
        {
            InitializeComponent();
            LoadAudioFiles();
            UpdatePositionLabel();
            fn.SoundVolume = trackVolume.Value / 100.0f;
            fn.SetListenerPosition(0, 0, 0, 0, 0, 1);
        }

        /// <summary>
        //PLAY SOUND 3D DÙNG irrKLang, vừa phát vừa lặp lại âm thanh, khi click vào nút Stop thì dừng phát âm thanh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                PlaySelectedAudio3D();
            }
            else
            {
                StopCurrentSound();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopCurrentSound();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (currentSound == null)
            {
                return;
            }

            currentSound.Paused = !currentSound.Paused;
            btnPause.Text = currentSound.Paused ? "Tiếp tục" : "Tạm dừng";
            lblStatus.Text = currentSound.Paused ? "Đang tạm dừng âm thanh 3D." : "Đang phát âm thanh 3D.";
        }

        private void PositionControl_ValueChanged(object sender, EventArgs e)
        {
            UpdateSoundPosition();
        }

        private void trackVolume_ValueChanged(object sender, EventArgs e)
        {
            fn.SoundVolume = trackVolume.Value / 100.0f;
            lblVolumeValue.Text = trackVolume.Value + "%";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAudioFiles();
        }

        private void PlaySelectedAudio3D()
        {
            if (cboAudioFiles.SelectedItem == null)
            {
                MessageBox.Show("Chưa có file âm thanh trong thư mục " + AppPaths.AudioDirectory, "Thiếu file âm thanh",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = Path.Combine(AppPaths.AudioDirectory, cboAudioFiles.SelectedItem.ToString());
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Không tìm thấy file: " + filePath, "Lỗi phát âm thanh",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            fn.StopAllSounds();
            fn.SoundVolume = trackVolume.Value / 100.0f;
            fn.SetListenerPosition(0, 0, 0, 0, 0, 1);

            currentSound = fn.Play3D(filePath, trackX.Value, trackY.Value, trackZ.Value, chkLoop.Checked);
            if (currentSound == null)
            {
                MessageBox.Show("Không phát được file âm thanh bằng irrKlang: " + filePath, "Lỗi phát âm thanh",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentSound.MinDistance = Convert.ToSingle(numMinDistance.Value);
            currentSound.Position = new Vector3D(trackX.Value, trackY.Value, trackZ.Value);
            isPlaying = true;
            btnStartStop.Text = "Stop";
            btnPause.Text = "Tạm dừng";
            lblStatus.Text = "Đang phát 3D: " + Path.GetFileName(filePath);
        }

        private void StopCurrentSound()
        {
            fn.StopAllSounds();
            currentSound = null;
            isPlaying = false;
            btnStartStop.Text = "Play 3D";
            btnPause.Text = "Tạm dừng";
            lblStatus.Text = "Đã dừng.";
        }

        private void UpdateSoundPosition()
        {
            UpdatePositionLabel();
            if (currentSound != null)
            {
                currentSound.Position = new Vector3D(trackX.Value, trackY.Value, trackZ.Value);
            }
        }

        private void UpdatePositionLabel()
        {
            lblPositionValue.Text = "X=" + trackX.Value + ", Y=" + trackY.Value + ", Z=" + trackZ.Value;
        }

        private void LoadAudioFiles()
        {
            audiopath = AppPaths.AudioDirectory + "\\";
            cboAudioFiles.Items.Clear();

            if (Directory.Exists(AppPaths.AudioDirectory))
            {
                foreach (string filePath in Directory.GetFiles(AppPaths.AudioDirectory).Where(AppPaths.IsSupportedAudioFile).OrderBy(Path.GetFileName))
                {
                    cboAudioFiles.Items.Add(Path.GetFileName(filePath));
                }
            }

            if (cboAudioFiles.Items.Count > 0)
            {
                int ambulanceIndex = cboAudioFiles.Items.IndexOf("AMBULANCE.wav");
                cboAudioFiles.SelectedIndex = ambulanceIndex >= 0 ? ambulanceIndex : 0;
                lblStatus.Text = "Sẵn sàng phát âm thanh 3D từ: " + AppPaths.AudioDirectory;
            }
            else
            {
                lblStatus.Text = "Không tìm thấy file âm thanh trong: " + AppPaths.AudioDirectory;
            }
        }

        /// <summary>
        /// Hàm dừng tất cả âm thanh khi đóng form
        private void frPAL3IrrKlang_FormClosing(object sender, FormClosingEventArgs e)
        {
            fn.StopAllSounds();
            fn.Dispose();
        }
    }
}
