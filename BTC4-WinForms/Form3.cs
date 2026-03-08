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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtTong.ReadOnly = true;
            rad5.Visible = false;
            rad10.Visible = false;
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void chkGiamgia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGiamgia.Checked)
            {
                rad5.Visible = true;
                rad10.Visible = true;
            }
            else
            {
                rad5.Visible = false;
                rad10.Visible = false;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtDongia.Text == "" || txtSoluong.Text == "")
            {
                MessageBox.Show("Nhập đơn giá và số lượng");
                return;
            }
            int dongia = int.Parse(txtDongia.Text);
            int soluong = int.Parse(txtSoluong.Text);
            double tong = dongia * soluong;
            if (chkGiamgia.Checked)
            {
                if (rad5.Checked)
                    tong = tong * 0.95;

                if (rad10.Checked)
                    tong = tong * 0.9;
            }
            txtTong.Text = tong.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
