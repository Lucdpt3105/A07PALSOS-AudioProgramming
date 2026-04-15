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
        public frPAL1Main()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qUẢNLÝÂMTHANHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void điềuChỉnhÂmThanhDùngWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hợpÂmChordMẫuTrongÂmThToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hỆTHỐNGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tắtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tRỢGIÚPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tắtFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frPAL1Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripStatusLabel3.Text = "Hôm nay là: " + DateTime.Now.ToString("dd/MM/yyyy ") + " Bây giờ là: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
