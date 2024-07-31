using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DangNhap : Form
    {
        DangnhapBLL BLLDangNha = new DangnhapBLL();
        public string a = "";
        public string b = "";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.Parent = pictureBox1;
            groupBox2.BackColor = Color.Transparent;
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            a = txttaikhoan.Text;
            b = txtmatkhau.Text;
            if (BLLDangNha.Dangnhap(a, b))
            {
                this.Close();
            }
            else if (BLLDangNha.dangnhapnv(a, b))
            {
                this.Close();
            }
            else if (txttaikhoan.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Tài Khoản ", "Thông Báo");
            }
            else if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Thông tin hoặc mật khẩu sai!!! Vui Lòng nhập Lại ", "Thông Báo", MessageBoxButtons.OKCancel);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
