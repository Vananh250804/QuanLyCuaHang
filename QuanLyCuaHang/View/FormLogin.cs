using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void guna2Chip1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Chip2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(240, 242, 245); // màu nền đăng nhập kiểu Facebook

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_Missing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormQuenMK f = new FormQuenMK();
            f.ShowDialog();
            this.Show(); // Hiện lại sau khi đóng form Quên MK
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu(); 
            formMenu.ShowDialog();
            this.Show();
        }
    }
}
