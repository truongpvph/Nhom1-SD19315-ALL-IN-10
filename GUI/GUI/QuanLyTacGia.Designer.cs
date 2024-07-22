namespace GUI
{
    partial class QuanLyTacGia
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
            cbbgioitinh = new ComboBox();
            label1 = new Label();
            btnhienthi = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txtquoctich = new TextBox();
            txtHoTen = new TextBox();
            txtmatacgia = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtTimKiem = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbbgioitinh
            // 
            cbbgioitinh.FormattingEnabled = true;
            cbbgioitinh.Location = new Point(109, 230);
            cbbgioitinh.Name = "cbbgioitinh";
            cbbgioitinh.Size = new Size(531, 28);
            cbbgioitinh.TabIndex = 128;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 127;
            label1.Text = "Mã Tác Giả";
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(93, 436);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 126;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(543, 436);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 123;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(321, 436);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 122;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // txtquoctich
            // 
            txtquoctich.Location = new Point(106, 322);
            txtquoctich.Name = "txtquoctich";
            txtquoctich.Size = new Size(534, 27);
            txtquoctich.TabIndex = 121;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(106, 143);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(531, 27);
            txtHoTen.TabIndex = 120;
            // 
            // txtmatacgia
            // 
            txtmatacgia.Location = new Point(109, 52);
            txtmatacgia.Name = "txtmatacgia";
            txtmatacgia.Size = new Size(531, 27);
            txtmatacgia.TabIndex = 119;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(13, 322);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 118;
            label6.Text = "Quốc Tịch ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(13, 230);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 117;
            label3.Text = "Giới Tính ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 143);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 116;
            label2.Text = "Tên Tác Giả";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtmatacgia);
            groupBox1.Controls.Add(btnhienthi);
            groupBox1.Controls.Add(cbbgioitinh);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtquoctich);
            groupBox1.Location = new Point(14, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 602);
            groupBox1.TabIndex = 129;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Tác Giả";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(797, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(706, 586);
            groupBox2.TabIndex = 130;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Tác Giả ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(682, 486);
            dataGridView1.TabIndex = 127;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(128, 38);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm Kiếm Theo tên Tác giả ";
            txtTimKiem.Size = new Size(422, 27);
            txtTimKiem.TabIndex = 114;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.ImageAlign = ContentAlignment.TopLeft;
            label8.Location = new Point(29, 45);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 113;
            label8.Text = "Tìm Kiếm ";
            // 
            // QuanLyTacGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QuanLyTacGia";
            Size = new Size(1521, 648);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbbgioitinh;
        private Label label1;
        private Button btnhienthi;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtquoctich;
        private TextBox txtHoTen;
        private TextBox txtmatacgia;
        private Label label6;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTimKiem;
        private Label label8;
        private DataGridView dataGridView1;
    }
}
