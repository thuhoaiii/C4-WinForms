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
    public partial class Form4 : Form
    {
        double so1, so2;
        string pheptoan;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtManHinh.Text += "0";
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtManHinh.Text);
            pheptoan = "+";
            txtManHinh.Clear();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtManHinh.Text);
            pheptoan = "-";
            txtManHinh.Clear();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtManHinh.Text);
            pheptoan = "*";
            txtManHinh.Clear();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtManHinh.Text);
            pheptoan = "/";
            txtManHinh.Clear();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            so2 = double.Parse(txtManHinh.Text);
            double kq = 0;
            if (pheptoan == "+")
                kq = so1 + so2;
            if (pheptoan == "-")
                kq = so1 - so2;
            if (pheptoan == "*")
                kq = so1 * so2;
            if (pheptoan == "/")
                kq = so1 / so2;
            txtManHinh.Text = kq.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtManHinh.Clear();
        }

        public Form4()
        {
            InitializeComponent();
        }
    }
}
