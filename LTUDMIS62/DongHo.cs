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
    public partial class DongHo : Form
    {
        public DongHo()
        {
            InitializeComponent();
        }

        private void bnnStart_Click(object sender, EventArgs e)
        {
            timerClock.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerClock.Stop();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(lblSecond.Text);
            int b = Int32.Parse(lblMinute.Text);
            a++;
            if (a > 59)
            {
              a = 0;
              b++;
            }
            if (a < 10)
                lblSecond.Text = "0" + a;
            else
                lblSecond.Text = a + "";
            if (b < 10)
                lblMinute.Text = "0" + b;
            else
                lblMinute.Text = b + "";
        }
    }
}
