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
    public partial class MayTinh : Form
    {
        double gtri;
        string pheptinh;
        bool check; 
        public MayTinh()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtkq.Clear();
            gtri = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtkq.Text = "0";
        }

        private void PhepTinh(object sender, EventArgs e)
        {
            Button b = sender as Button;
            gtri = Convert.ToDouble(txtkq.Text);
            pheptinh = b.Text;
            txtkq.Text += b.Text;
            check = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((pheptinh == "+") || (pheptinh == "-") || (pheptinh == "/") || (pheptinh == "*"))
            {
                if (check)
                    check = false;
                txtkq.Text = "0";
            }
            Button b = sender as Button;
            if (txtkq.Text == "0")
                txtkq.Text = b.Text;
            else
                txtkq.Text += b.Text;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            switch (pheptinh)
            {
                case "+":
                    txtkq.Text = (gtri + Double.Parse(txtkq.Text)).ToString();
                    break;
                case "-":
                    txtkq.Text = (gtri - Double.Parse(txtkq.Text)).ToString();
                    break;
                case "*":
                    txtkq.Text = (gtri * Double.Parse(txtkq.Text)).ToString();
                    break;
                case "/":
                    txtkq.Text = (gtri / Double.Parse(txtkq.Text)).ToString();
                    break;
            }
        }
  
    }
}
