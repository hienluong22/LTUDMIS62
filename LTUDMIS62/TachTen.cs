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
    public partial class TachTen : Form
    {
        string ht, kq;
        int vt1, vt2;
        public TachTen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndem_Click(object sender, EventArgs e)
        {
            ht = txtHT.Text.Trim();
            vt1 = ht.IndexOf(" ");
            vt2 = ht.LastIndexOf(" ");
            kq = ht.Substring(vt1, vt2 - vt1);
            kq = ("Đệm: " + kq);
            lblKQ.Text = kq;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btndemvaten_Click(object sender, EventArgs e)
        {

            string ten, hodem;
            ht = txtHT.Text.Trim();
            vt1 = ht.LastIndexOf(" ");
            hodem = ht.Substring(0, vt1);
            ten = ht.Substring(vt1, txtHT.TextLength - vt1);
            kq = ("Họ đệm: " + hodem + "\n" + "Tên: " + ten);
            lblKQ.Text = kq;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnhodem_Click(object sender, EventArgs e)
        {
            ht = txtHT.Text.Trim();
            vt1 = ht.LastIndexOf(" ");
            kq = ht.Substring(0, vt1);
           //kq= ("Họ đệm: " + kq);
            lblKQ.Text = kq;

        }
    }
}
