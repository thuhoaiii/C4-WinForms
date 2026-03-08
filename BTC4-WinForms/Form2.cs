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
    public partial class Form2 : Form
    {
        int[] a;
        int n;
        Random rd = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập n");
                txtN.Focus();
                return;
            }

            n = int.Parse(txtN.Text);
            a = new int[n];

            lbDayso.Text = "Dãy số: ";

            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(1, 101);
                lbDayso.Text += a[i] + " ";
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            lbTong.Text = "Tổng dãy số: " + tong;
        }

        private void btnSapxep_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
            lbSapxep.Text = "Sắp xếp: ";
            for (int i = 0; i < n; i++)
            {
                lbSapxep.Text += a[i] + " ";
            }
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            lbDayso.Text = "Dãy số:";
            lbTong.Text = "Tổng dãy số:";
            lbSapxep.Text = "Sắp xếp:";
            txtN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
