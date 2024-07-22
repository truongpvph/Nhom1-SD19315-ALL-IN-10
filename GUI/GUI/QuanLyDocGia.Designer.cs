namespace GUI
{
    partial class QuanLyDocGia
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
            groupBox1 = new GroupBox();
            btnhienthi = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            txtmadocgia = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtTimKiem = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnhienthi);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtmadocgia);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(681, 624);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(36, 410);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 127;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(538, 410);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 125;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(290, 410);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 124;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(160, 258);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(489, 27);
            txtSoDienThoai.TabIndex = 121;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(160, 165);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(489, 27);
            txtHoTen.TabIndex = 120;
            // 
            // txtmadocgia
            // 
            txtmadocgia.Location = new Point(160, 68);
            txtmadocgia.Name = "txtmadocgia";
            txtmadocgia.Size = new Size(489, 27);
            txtmadocgia.TabIndex = 119;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(7, 265);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 118;
            label5.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(23, 172);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 117;
            label3.Text = "Họ Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 75);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 116;
            label1.Text = "Mã Độc Giả";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(743, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(764, 619);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(755, 486);
            dataGridView1.TabIndex = 126;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(179, 41);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm Kiếm Theo Tên Độc Giả ";
            txtTimKiem.Size = new Size(551, 27);
            txtTimKiem.TabIndex = 125;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(73, 48);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 124;
            label8.Text = "Tìm Kiếm ";
            // 
            // QuanLyDocGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QuanLyDocGia";
            Size = new Size(1521, 648);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnhienthi;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private TextBox txtmadocgia;
        private Label label5;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox txtTimKiem;
        private Label label8;
    }
}
