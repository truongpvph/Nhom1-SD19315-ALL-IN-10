using BLL;
using DTO.Models;
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
    public partial class QuanLyTaiKhoan : UserControl
    {
        DataTable dt = new DataTable();
        BLLtaikhoan BLLQLnhanvien = new BLLtaikhoan();

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnthem.Enabled = false;
            button1.Enabled = false;

        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            dt.Columns.Add("Mã Tài Khoản", typeof(string));
            dt.Columns.Add("Mã Vai Trò", typeof(string));
            dt.Columns.Add("Họ Tên", typeof(string));
            dt.Columns.Add("Số Điện Thoại", typeof(string));
            dt.Columns.Add("Ngày Sinh", typeof(DateTime));
            dt.Columns.Add("Tài Khoản", typeof(string));
            dt.Columns.Add("Mật Khẩu", typeof(string));
            dt.Columns.Add("Số CCCD", typeof(string));
            loadcbb();
            LoadDuLieu();
            btnhienthi.Enabled = false;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            button1.Enabled = true;

        }
        public void LoadDuLieu()
        {
            dt.Rows.Clear();
            foreach (var a in BLLQLnhanvien.Load().OrderBy(p => p.MaTaiKhoan.Length))
            {
                DataRow dr = dt.NewRow();
                dr["Mã Tài Khoản"] = a.MaTaiKhoan;
                dr["Mã Vai Trò"] = a.MaVaiTro;
                dr["Họ Tên"] = a.HoTen;
                dr["Số Điện Thoại"] = a.SoDienThoai;
                dr["Ngày Sinh"] = a.NgaySinh;
                dr["Tài Khoản"] = a.TaiKhoan1;
                dr["Mật Khẩu"] = a.MatKhau;
                dr["Số CCCD"] = a.SoCccd;
                dt.Rows.Add(dr);
            }
            dgvtaikhoannv.DataSource = dt;
        }
        public void loadcbb()
        {
            foreach (var a in BLLQLnhanvien.loadten())
            {
                cbbmavaitro.Items.Add(a.Vaitro1);
            }
        }
        public VaiTro ID(string id)
        {
            foreach (var a in BLLQLnhanvien.loadten())
            {
                if (a.MaVaiTro.Equals(id))
                {
                    return a;
                }
            }
            return null;
        }
        public VaiTro ID1(string id)
        {
            foreach (var a in BLLQLnhanvien.loadten())
            {
                if (a.Vaitro1.Equals(id))
                {
                    return a;
                }
            }
            return null;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                MaTaiKhoan = "Tk" + (BLLQLnhanvien.Load().Count(p => p.MaTaiKhoan != null) + 1).ToString(),
                MaVaiTro = ID1(cbbmavaitro.SelectedItem.ToString()).MaVaiTro,
                HoTen = txtHoTen.Text,
                SoDienThoai = txtSoDienThoai.Text,
                NgaySinh = (DateTime)dateNgaySinh.Value,
                TaiKhoan1 = txtTaiKhoan.Text,
                MatKhau = txtMatKhau.Text,
                SoCccd = txtsocccd.Text,
            };
            if (txtMaTaiKhoan.Text == "" || txtHoTen.Text == "" || txtMatKhau.Text == "" || txtsocccd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin ", "Thông Báo");
            }
            
            else if (BLLQLnhanvien.SDTduynhat(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại ", "Thông Báo");
            }
            else if (BLLQLnhanvien.SDT(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại chỉ có 10 số vui lòng nhập đúng số điện thoại", "Thông Báo");
            }
            else if(BLLQLnhanvien.Taikhoan(txtTaiKhoan.Text) || BLLQLnhanvien.MatKhau(txtMatKhau.Text))
            {
                MessageBox.Show("Tài khoản và mật khẩu phải trên 8 kí tự ", "Thông Báo ");
            }
            else if (BLLQLnhanvien.Scccd(txtsocccd.Text))
            {
                MessageBox.Show("Số CCCD chỉ có 12 số vui lòng xem lại ", "Thông Báo");
            }
            
            else if (BLLQLnhanvien.kiemtratk(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tài Khoản đã tồn tại ", "Thông Báo");
            }
            else if (BLLQLnhanvien.KTsocccd(txtsocccd.Text))
            {
                MessageBox.Show("Số Căn cước công dân đã tồn tại ", "Thông Báo");
            }
            else if (BLLQLnhanvien.ADD(taiKhoan))
            {
                LoadDuLieu();
                MessageBox.Show("Thêm Thành Công ", "Thông Báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            {
                tk.MaTaiKhoan = txtMaTaiKhoan.Text;
                tk.MaVaiTro = ID1(cbbmavaitro.SelectedItem.ToString()).MaVaiTro;
                tk.HoTen = txtHoTen.Text;
                tk.SoDienThoai = txtSoDienThoai.Text;
                tk.NgaySinh = (DateTime)dateNgaySinh.Value;
                tk.TaiKhoan1 = txtTaiKhoan.Text;
                tk.MatKhau = txtMatKhau.Text;
                tk.SoCccd = txtsocccd.Text;
            };
            string a;
            TaiKhoan taiKhoan = new TaiKhoan();
            
                 
                 if (BLLQLnhanvien.SDT(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Số điện thoại chỉ có 10 số vui lòng nhập đúng số điện thoại", "Thông Báo");
                }
                else if (BLLQLnhanvien.Scccd(txtsocccd.Text))
                {
                    MessageBox.Show("Số CCCD chỉ có 12 số vui lòng xem lại ", "Thông Báo");
                }
                else if(BLLQLnhanvien.Update(tk))
                {
                    LoadDuLieu();
                    MessageBox.Show("Sửa Thành Công ", "Thông Báo");
                }
        }



        private void dgvtaikhoannv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dgvtaikhoannv.Rows[e.RowIndex];
            txtMaTaiKhoan.Text = dgvr.Cells[0].Value.ToString();
            if(dgvr.Cells[1].Value.ToString() == "" )
            {
                cbbmavaitro.SelectedItem = null;
            }
            else
            {
                cbbmavaitro.SelectedItem = ID(dgvr.Cells[1].Value.ToString()).Vaitro1;
            }
            
            txtHoTen.Text = dgvr.Cells[2].Value.ToString();
            txtSoDienThoai.Text = dgvr.Cells[3].Value.ToString();
            if (dgvr.Cells[4].Value.ToString() == "")
            {
                dateNgaySinh.Text = null;
            }
            else
            {
                dateNgaySinh.Value = (DateTime)dgvr.Cells[4].Value;
            }
            txtTaiKhoan.Text = dgvr.Cells[5].Value.ToString();
            txtMatKhau.Text = dgvr.Cells[6].Value.ToString();
            txtsocccd.Text = dgvr.Cells[7].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();

            foreach (var a in BLLQLnhanvien.TimKiem(txtTimKiem.Text).OrderBy(p => p.MaTaiKhoan.Length))
            {
                DataRow dr = dt.NewRow();
                dr["Mã Tài Khoản"] = a.MaTaiKhoan;
                dr["Mã Vai Trò"] = a.MaVaiTro;
                dr["Họ Tên"] = a.HoTen;
                dr["Số Điện Thoại"] = a.SoDienThoai;
                dr["Ngày Sinh"] = a.NgaySinh;
                dr["Tài Khoản"] = a.TaiKhoan1;
                dr["Mật Khẩu"] = a.MatKhau;
                dr["Số CCCD"] = a.SoCccd;
                dt.Rows.Add(dr);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaTaiKhoan.Text = "";
            txtHoTen.Text = "";
            dateNgaySinh.Text = null;
            txtSoDienThoai.Text = "";
            txtsocccd.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cbbmavaitro.Text = null;
        }

        private void dgvtaikhoannv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
