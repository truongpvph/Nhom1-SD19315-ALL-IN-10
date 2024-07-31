using BLL;

namespace GUI
{
    public partial class GiaoDien : Form
    {
        DangnhapBLL BLLDangNha = new DangnhapBLL();
        public GiaoDien()
        {
            InitializeComponent();
        }
        private void panel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void GiaoDien_Load(object sender, EventArgs e)
        {
            đăngXuấtToolStripMenuItem.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
            quảnLýSáchToolStripMenuItem.Enabled = false;
            quảnToolStripMenuItem.Enabled = false;
            lậpPhiếuMượnToolStripMenuItem.Enabled = false;
            chiTiếtMượnTrảSáchToolStripMenuItem.Enabled = false;
            quảnLýĐộcGiảToolStripMenuItem.Enabled = false;
            quảnLýTácGiảToolStripMenuItem.Enabled = false;
            quảnLýThểLoạiToolStripMenuItem.Enabled = false;
            quảnLýThểLoạiToolStripMenuItem.Enabled = false;
            quảnLýNhàXuấtBảnToolStripMenuItem.Enabled = false;
        }

        private void heToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chiTiếtMượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietMuon_Tra chiTietMuon_Tra = new ChiTietMuon_Tra();
            panel(chiTietMuon_Tra);
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            var taikhoan = dangNhap.a;
            var matkau = dangNhap.b;
            if (BLLDangNha.Dangnhap(taikhoan, matkau))
            {
                đăngXuấtToolStripMenuItem.Enabled = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = true;
                quảnLýSáchToolStripMenuItem.Enabled = true;
                quảnToolStripMenuItem.Enabled = true;
                lậpPhiếuMượnToolStripMenuItem.Enabled = true;
                chiTiếtMượnTrảSáchToolStripMenuItem.Enabled = true;
                quảnLýĐộcGiảToolStripMenuItem.Enabled = true;
                quảnLýTácGiảToolStripMenuItem.Enabled = true;
                quảnLýThểLoạiToolStripMenuItem.Enabled = true;
                quảnLýThểLoạiToolStripMenuItem.Enabled = true;
                quảnLýNhàXuấtBảnToolStripMenuItem.Enabled = true;
            }
            else if (BLLDangNha.dangnhapnv(taikhoan, matkau))
            {
                đăngXuấtToolStripMenuItem.Enabled = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                quảnLýSáchToolStripMenuItem.Enabled = true;
                quảnToolStripMenuItem.Enabled = true;
                lậpPhiếuMượnToolStripMenuItem.Enabled = true;
                chiTiếtMượnTrảSáchToolStripMenuItem.Enabled = true;
                quảnLýĐộcGiảToolStripMenuItem.Enabled = true;
                quảnLýTácGiảToolStripMenuItem.Enabled = true;
                quảnLýThểLoạiToolStripMenuItem.Enabled = true;
                quảnLýThểLoạiToolStripMenuItem.Enabled = true;
                quảnLýNhàXuấtBảnToolStripMenuItem.Enabled = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            đăngXuấtToolStripMenuItem.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
            quảnLýSáchToolStripMenuItem.Enabled = false;
            quảnToolStripMenuItem.Enabled = false;
            lậpPhiếuMượnToolStripMenuItem.Enabled = false;
            chiTiếtMượnTrảSáchToolStripMenuItem.Enabled = false;
            quảnLýĐộcGiảToolStripMenuItem.Enabled = false;
            quảnLýTácGiảToolStripMenuItem.Enabled = false;
            quảnLýThểLoạiToolStripMenuItem.Enabled = false;
            quảnLýThểLoạiToolStripMenuItem.Enabled = false;
            quảnLýNhàXuấtBảnToolStripMenuItem.Enabled = false;
            panel1.Controls.Clear();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
            panel(quanLyTaiKhoan);
        }

        private void quảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySach quanLySach = new QuanLySach();
            panel(quanLySach);
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDocGia quanLyDocGia = new QuanLyDocGia();
            panel(quanLyDocGia);
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTacGia quanLyTacGia = new QuanLyTacGia();
            panel(quanLyTacGia);
        }

        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTheLoai quanLyTheLoai = new QuanLyTheLoai();
            panel(quanLyTheLoai);
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhaXuatBan quanLyNhaXuatBan = new QuanLyNhaXuatBan();
            panel(quanLyNhaXuatBan);
        }

        private void lậpPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapPhieuMuon lapPhieuMuon = new LapPhieuMuon();
            panel(lapPhieuMuon);
        }
    }
}
