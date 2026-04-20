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
        // component load
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStripStatusLabel3.Text = "Hôm nay là: " + DateTime.Now.ToString("dd/MM/yyyy ") + " Bây giờ là: " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void quảnLýÂmThanhDùngWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frPAL2WMP fr = new frPAL2WMP();
            fr.ShowDialog();
        }//gọi WMP frPAL2WMP

    }
}
