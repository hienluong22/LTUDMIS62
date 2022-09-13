using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDMIS62
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếtThúcChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPT f = new GiaiPT();
            f.Show();
        }

        private void táchTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TachTen f = new TachTen();
            f.Show();
        }

        private void kếtThứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giảiPhươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPT f = new GiaiPT();
            f.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            GiaiPT f = new GiaiPT();
            f.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
