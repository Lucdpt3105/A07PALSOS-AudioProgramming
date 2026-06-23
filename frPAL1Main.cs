using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A07PALSOS
{
    public partial class frPAL1Main : Form
    {
        /// <summary>
        /// HÀM THIẾT LẬP CỦA FORM MAIN CONSTRUCTOR
        /// </summary>
        public frPAL1Main()
        {
            InitializeComponent();
        }
        // component load
        /// <summary>
        /// THỦ TỤC NHẢY ĐỒNG HỒ = LẤY THỜI GIAN HIỆN TẠI VÀ HIỂN THỊ LÊN STATUS STRIP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripStatusLabel3.Text = "Hôm nay là: " + DateTime.Now.ToString("dd/MM/yyyy ") + " Bây giờ là: " + DateTime.Now.ToString("hh:mm:ss tt");
        }
        /// <summary>
        /// THỦ TỤC HIỂN THỊ FORM 2 KHI NHẤP VÀO MENU QUẢN LÝ ÂM THANH DÙNG WMP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quảnLýÂmThanhDùngWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frPAL2WMP fr = new frPAL2WMP();
            fr.ShowDialog();
        }//gọi WMP frPAL2WMP

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Có thật sự là muốn thoát chương trình này hay không (Y/N)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();//thoát chương trình
            }
        }

        private void quảnLýÂmThanhDùngIrrKlangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frPAL3IrrKlang fr = new frPAL3IrrKlang();
            fr.ShowDialog();
        }

        private void tắtMởThanhThựcĐơnMenuBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = !menuStrip1.Visible;
        }

        private void tắtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void tắtMởDòngTrạngTháiStatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;  // Ẩn/Hiện statusbar
        }

        private void tắtFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Có thật sự là muốn thoát chương trình này hay không (Y/N)", "Xác nhận",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();  // Thoát app
            }
        }
    }// class
}// namespace
