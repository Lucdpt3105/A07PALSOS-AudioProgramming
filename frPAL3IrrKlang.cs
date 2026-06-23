using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;

namespace A07PALSOS
{
    public partial class frPAL3IrrKlang : Form
    {
        //Khai báo biến toàn cục thuộc đối tượng File âm thanh của irrKLang 
        string audiopath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath))) + "\\FileAmThanh\\";
        //LẤY THƯ MỤC HIỆN TẠI (PATH) CỦA APP
        //Application.StartupPath = đường dẫn thư mục App \bin\Debug => để path của App lấy ra ngoài thư mục cha 3 lần
        //để lấy thư mục cha sử dụng System.IO.Path.GetDirectoryName(Application.StartupPath)

        //KHAI BÁO CÁC BIẾN TOÀN CỤC 

        ISoundEngine fn = new ISoundEngine();
        ISound currentSound = null;//Biến toàn cục lưu trữ âm thanh hiện tại đang phát
        bool isPlaying = false;//Biến toàn cục lưu trạng thái âm thanh đang phát hay không

        public frPAL3IrrKlang()
        {
            InitializeComponent();
        }

        /// <summary>
        //PLAY SOUND 2D DÙNG irrKLang, vừa phát vừa lặp lại âm thanh, khi click vào nút Stop thì dừng phát âm thanh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            string filePath = audiopath + "AMBULANCE.wav";

            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("Không tìm thấy file: " + filePath);
                return;
            }

            if (!isPlaying)
            {
                fn.SoundVolume = 1.0f;
                fn.StopAllSounds();

                currentSound = fn.Play2D(filePath, true);

                isPlaying = true;
                btnStartStop.Text = "Stop";

                MessageBox.Show("Đã phát: " + filePath);
            }
            else
            {
                fn.StopAllSounds();
                currentSound = null;
                isPlaying = false;
                btnStartStop.Text = "Play";
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