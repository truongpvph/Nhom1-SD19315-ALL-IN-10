﻿namespace GUI
{
    partial class QuanLyTaiKhoan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTimKiem = new TextBox();
            label8 = new Label();
            dgvtaikhoannv = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            cbbmavaitro = new ComboBox();
            txtsocccd = new TextBox();
            label4 = new Label();
            btnhienthi = new Button();
            dateNgaySinh = new DateTimePicker();
            btnsua = new Button();
            btnthem = new Button();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            txtMaTaiKhoan = new TextBox();
            label7 = new Label();
            label5 = new Label();
            laba = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvtaikhoannv).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.Location = new Point(214, 56);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm theo tên nhân viên ";
            txtTimKiem.Size = new Size(417, 27);
            txtTimKiem.TabIndex = 130;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(78, 55);
            label8.Name = "label8";
            label8.Size = new Size(108, 28);
            label8.TabIndex = 129;
            label8.Text = "Tìm Kiếm ";
            // 
            // dgvtaikhoannv
            // 
            dgvtaikhoannv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvtaikhoannv.BackgroundColor = Color.Silver;
            dgvtaikhoannv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtaikhoannv.Location = new Point(6, 105);
            dgvtaikhoannv.Name = "dgvtaikhoannv";
            dgvtaikhoannv.RowHeadersWidth = 51;
            dgvtaikhoannv.Size = new Size(712, 516);
            dgvtaikhoannv.TabIndex = 112;
            dgvtaikhoannv.CellClick += dgvtaikhoannv_CellClick;
            dgvtaikhoannv.CellContentClick += dgvtaikhoannv_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvtaikhoannv);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(794, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 629);
            groupBox1.TabIndex = 135;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Tài Khoản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(64, 207);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 140;
            label6.Text = "Ngày Sinh";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(cbbmavaitro);
            groupBox2.Controls.Add(txtsocccd);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnhienthi);
            groupBox2.Controls.Add(dateNgaySinh);
            groupBox2.Controls.Add(btnsua);
            groupBox2.Controls.Add(btnthem);
            groupBox2.Controls.Add(txtMatKhau);
            groupBox2.Controls.Add(txtTaiKhoan);
            groupBox2.Controls.Add(txtSoDienThoai);
            groupBox2.Controls.Add(txtHoTen);
            groupBox2.Controls.Add(txtMaTaiKhoan);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(laba);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(14, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(699, 629);
            groupBox2.TabIndex = 136;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Tài Khoản";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(500, 557);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 155;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbbmavaitro
            // 
            cbbmavaitro.FormattingEnabled = true;
            cbbmavaitro.Location = new Point(194, 91);
            cbbmavaitro.Name = "cbbmavaitro";
            cbbmavaitro.Size = new Size(457, 28);
            cbbmavaitro.TabIndex = 154;
            // 
            // txtsocccd
            // 
            txtsocccd.Location = new Point(194, 457);
            txtsocccd.Name = "txtsocccd";
            txtsocccd.Size = new Size(457, 27);
            txtsocccd.TabIndex = 153;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(54, 460);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 152;
            label4.Text = "Số  CCCD";
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(76, 557);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 151;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            btnhienthi.Click += btnhienthi_Click;
            // 
            // dateNgaySinh
            // 
            dateNgaySinh.Location = new Point(194, 207);
            dateNgaySinh.Name = "dateNgaySinh";
            dateNgaySinh.Size = new Size(457, 27);
            dateNgaySinh.TabIndex = 149;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(358, 557);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 148;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(215, 557);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 147;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(194, 396);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(457, 27);
            txtMatKhau.TabIndex = 146;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(194, 333);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(463, 27);
            txtTaiKhoan.TabIndex = 145;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(194, 266);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(457, 27);
            txtSoDienThoai.TabIndex = 144;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(194, 147);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(457, 27);
            txtHoTen.TabIndex = 143;
            // 
            // txtMaTaiKhoan
            // 
            txtMaTaiKhoan.Enabled = false;
            txtMaTaiKhoan.Location = new Point(194, 26);
            txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            txtMaTaiKhoan.Size = new Size(457, 27);
            txtMaTaiKhoan.TabIndex = 142;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(54, 403);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 141;
            label7.Text = "Mật Khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(39, 269);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 139;
            label5.Text = "Số Điện Thoại ";
            // 
            // laba
            // 
            laba.AutoSize = true;
            laba.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            laba.Location = new Point(48, 333);
            laba.Name = "laba";
            laba.Size = new Size(78, 20);
            laba.TabIndex = 138;
            laba.Text = "Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(64, 154);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 137;
            label3.Text = "Họ Tên ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(64, 99);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 136;
            label2.Text = "Vai Trò";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(48, 33);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 135;
            label1.Text = "Mã Tài Khoản";
            // 
            // QuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QuanLyTaiKhoan";
            Size = new Size(1521, 648);
            Load += QuanLyTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvtaikhoannv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTimKiem;
        private Label label8;
        private DataGridView dgvtaikhoannv;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cbbmavaitro;
        private TextBox txtsocccd;
        private Label label4;
        private Button btnhienthi;
        private DateTimePicker dateNgaySinh;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private TextBox txtMaTaiKhoan;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label laba;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
