using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTC4_WinForms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = (double)numA.Value;
            double b = (double)numB.Value;
            double c = (double)numC.Value;

            rtbKQ.Clear();
            rtbKQ.AppendText("A = " + a + "\n");
            rtbKQ.AppendText("B = " + b + "\n");
            rtbKQ.AppendText("C = " + c + "\n");

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        rtbKQ.AppendText("Phương trình vô số nghiệm");
                    else
                        rtbKQ.AppendText("Phương trình vô nghiệm");
                }
                else
                {
                    double x = -c / b;
                    txtX1.Text = x.ToString();
                    rtbKQ.AppendText("Phương trình bậc nhất, nghiệm x = " + x);
                }
                return;
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                rtbKQ.AppendText("Phương trình vô nghiệm");
                txtX1.Text = "";
                txtX2.Text = "";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                txtX1.Text = x.ToString();
                txtX2.Text = x.ToString();
                rtbKQ.AppendText("Phương trình có nghiệm kép");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                txtX1.Text = x1.ToString("0.##");
                txtX2.Text = x2.ToString("0.##");

                rtbKQ.AppendText("Phương trình có 2 nghiệm phân biệt");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
