using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class QuanLySach : UserControl
    {
        BLLQuanLySach db = new BLLQuanLySach();
        DataTable dt = new DataTable();
        public QuanLySach()
        {
            InitializeComponent();
        }

        public void GetValue()
        {
            foreach (var i in db.getAllSach().OrderBy(p => p.MaSach.Length).ToList())
            {
                DataRow row = dt.NewRow();
                row["Mã Sách"] = i.MaSach;
                row["Tác giả"] = db.GetTacGiaById(i.MaTacGia).TenTacGia;
                row["Thể loại"] = db.GetTheLoaiById(i.MaTheLoai).TenTheLoai;
                row["Nhà xuất bản"] = db.GetNXBByID(i.MaNhaXuatBan).TenNhaXuatBan;
                row["Tên Sách"] = i.TenSach;
                row["Giá sách"] = i.GiaSach;
                row["Số Lượng"] = i.SoLuong;
                row["trạng thái sách"] = i.TrangThaiSach;
                row["Ngày Xuất bản"] = i.NgayXuatBan;

                row["Vị trí"] = i.ViTri;
                row["Mô tả"] = i.MoTa;
                dt.Rows.Add(row);

            }
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Mã Sách", typeof(string));
            dt.Columns.Add("Tác giả", typeof(string));
            dt.Columns.Add("Thể loại", typeof(string));
            dt.Columns.Add("Nhà xuất bản", typeof(string));
            dt.Columns.Add("Tên Sách", typeof(string));
            dt.Columns.Add("Giá sách", typeof(string));
            dt.Columns.Add("Số Lượng", typeof(int));
            dt.Columns.Add("trạng thái sách", typeof(string));
            dt.Columns.Add("Ngày Xuất bản", typeof(DateOnly));
            dt.Columns.Add("Vị trí", typeof(string));
            dt.Columns.Add("Mô tả", typeof(string));
            foreach (var i in db.GetTheLoais().ToList())
            {
                ccbtheloai.Items.Add(i.TenTheLoai);
            }
            foreach (var i in db.getAllTacGium().ToList())
            {
                ccbtacgia.Items.Add(i.TenTacGia);
            }
            foreach (var i in db.GetNhaXuatBans().ToList())
            {
                cbbnxb.Items.Add(i.TenNhaXuatBan);
            }

            cbbTrangThaiSach.Items.Add("Mới");
            cbbTrangThaiSach.Items.Add("Đã qua sử dụng");


        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            GetValue();
            dgvquanlynv.DataSource = dt;
            btnhienthi.Enabled = false;
            txtTongDauSach.Text = db.getAllSach().ToList().Count(p => p.MaSach != null).ToString();
            txtTongSoLuong.Text = db.getAllSach().ToList().Sum(p => p.SoLuong).ToString();

        }

        private void dgvquanlynv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvquanlynv.Rows[e.RowIndex];
            txtMaSach.Text = dr.Cells[0].Value.ToString();
            ccbtacgia.SelectedItem = dr.Cells[1].Value.ToString();
            ccbtheloai.SelectedItem = dr.Cells[2].Value.ToString();
            cbbnxb.SelectedItem = dr.Cells[3].Value.ToString();
            txtTenSach.Text = dr.Cells[4].Value.ToString();
            txtGiaSach.Text = dr.Cells[5].Value.ToString();
            txtSoLuong.Text = dr.Cells[6].Value.ToString();
            cbbTrangThaiSach.Text = (string)dr.Cells[7].Value.ToString();
            dtpNgayXuatBan.Text = dr.Cells[8].Value.ToString();
            txtVitri.Text = dr.Cells[9].Value.ToString();
            txtMoTa.Text = dr.Cells[10].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            var search = Convert.ToString(txtTimKiem.Text);
            var list = db.getAllTacGium().ToList()
            .Join(db.getAllSach().ToList(), y => y.MaTacGia, x => x.MaTacGia, (y, x) => new
            {

                y.TenTacGia,
                x.MaSach,
                x.MaTacGia,
                x.MaTheLoai,
                x.TenSach,
                x.MaNhaXuatBan,
                x.GiaSach,
                x.SoLuong,
                x.TrangThaiSach,
                x.NgayXuatBan,
                x.MoTa,
                x.ViTri

            }).Join(db.GetTheLoais().ToList(), b => b.MaTheLoai, a => a.MaTheLoai, (b, a) => new
            {
                b.TenTacGia,
                a.TenTheLoai,
                b.MaSach,
                b.MaTacGia,
                b.MaTheLoai,
                b.TenSach,
                b.MaNhaXuatBan,
                b.GiaSach,
                b.SoLuong,
                b.TrangThaiSach,
                b.NgayXuatBan,
                b.MoTa,
                b.ViTri

            }).Where(p => p.TenTacGia.ToLower().Contains(search.ToString().ToLower())
            || p.TenSach.ToLower().Contains(search.ToString().ToLower())
            || p.TenTheLoai.ToLower().Contains(search.ToLower().ToString())).ToList();
            foreach (var i in list.OrderBy(p => p.MaSach.Length))
            {
                DataRow row = dt.NewRow();
                row["Mã Sách"] = i.MaSach;
                row["Tác giả"] = i.TenTacGia;
                row["Thể loại"] = i.TenTheLoai;
                row["Nhà xuất bản"] = db.GetNXBByID(i.MaNhaXuatBan).TenNhaXuatBan;
                row["Tên Sách"] = i.TenSach;
                row["Giá sách"] = i.GiaSach;
                row["Số Lượng"] = i.SoLuong;
                row["trạng thái sách"] = i.TrangThaiSach;
                row["Ngày Xuất bản"] = i.NgayXuatBan;
                row["Vị trí"] = i.ViTri;
                row["Mô tả"] = i.MoTa;
                dt.Rows.Add(row);

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (ccbtacgia.SelectedItem == "" || ccbtheloai.SelectedItem == "" || txtTenSach.Text == "" || cbbnxb.SelectedItem == ""
                || txtGiaSach.Text == "" || txtSoLuong.Text == "" || txtSoLuong.Text == "" || txtVitri.Text == "")
            {
                DialogResult tb = MessageBox.Show("Nhập thiếu thông tin", "Thông báo", MessageBoxButtons.OKCancel);

            }
            

            else
            {
                dt.Rows.Clear();

                var MaSach = ("S" + (db.getAllSach().ToList().Count(p => p.MaSach != null) + 1)).ToString();
                var MaTacGia = ccbtacgia.Text;
                var MaTheLoai = ccbtheloai.Text;
                var TenSach = txtTenSach.Text;
                var MaNhaXuatBan = cbbnxb.SelectedItem.ToString();
                var GiaSach = txtGiaSach.Text;
                var SoLuong = txtSoLuong.Text;
                var TrangThaiSach = cbbTrangThaiSach.Text;
                var NgayXuatBan = dtpNgayXuatBan.Value.ToShortDateString();
                var MoTa = txtMoTa.Text;
                var ViTri = txtVitri.Text;
                db.AddSach(MaSach, MaTacGia, MaTheLoai, TenSach, MaNhaXuatBan, GiaSach, SoLuong, TrangThaiSach, NgayXuatBan, MoTa, ViTri);
                txtTongDauSach.Text = db.getAllSach().ToList().Count(p => p.MaSach != null).ToString();
                txtTongSoLuong.Text = db.getAllSach().ToList().Sum(p => p.SoLuong).ToString();
                GetValue();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có chắc chắn không?", "Thông báo", MessageBoxButtons.YesNo);
            if (tb == DialogResult.Yes)
            {
                dt.Rows.Clear();
                var MaSach = txtMaSach.Text;
                var MaTacGia = ccbtacgia.Text;
                var MaTheLoai = ccbtheloai.Text;
                var TenSach = txtTenSach.Text;
                var MaNhaXuatBan = Convert.ToString(cbbnxb.SelectedItem);
                var GiaSach = txtGiaSach.Text;
                var SoLuong = txtSoLuong.Text;
                var TrangThaiSach = cbbTrangThaiSach.Text;
                var NgayXuatBan = dtpNgayXuatBan.Value.ToShortDateString();
                var MoTa = txtMoTa.Text;
                var ViTri = txtVitri.Text;
                db.Update(MaSach, MaTacGia, MaTheLoai, TenSach, MaNhaXuatBan, GiaSach, SoLuong, TrangThaiSach, NgayXuatBan, MoTa, ViTri);
                txtTongDauSach.Text = db.getAllSach().ToList().Count(p => p.MaSach != null).ToString();
                txtTongSoLuong.Text = db.getAllSach().ToList().Sum(p => p.SoLuong).ToString();
                GetValue();
            }
        }

        private void txtTongDauSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
            ccbtacgia.SelectedItem = "";
            ccbtheloai.SelectedItem = "";
            cbbnxb.SelectedItem = "";
            txtTenSach.Text = "";
            txtGiaSach.Text = "";
            txtSoLuong.Text = "";
            cbbTrangThaiSach.Text = "";
            dtpNgayXuatBan.Text = null;
            txtVitri.Text = "";
            txtMoTa.Text = "";
        }
    }
}
