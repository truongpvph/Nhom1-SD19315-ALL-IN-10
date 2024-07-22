namespace GUI
{
    partial class QuanLyTheLoai
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
            txttentheloai = new TextBox();
            txttheloai = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtTimKiem = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
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
            groupBox1.Controls.Add(txttentheloai);
            groupBox1.Controls.Add(txttheloai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(664, 621);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Thể Loại ";
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(25, 467);
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
            btnsua.Location = new Point(506, 467);
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
            btnthem.Location = new Point(256, 467);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 124;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // txttentheloai
            // 
            txttentheloai.Location = new Point(131, 265);
            txttentheloai.Name = "txttentheloai";
            txttentheloai.Size = new Size(501, 27);
            txttentheloai.TabIndex = 121;
            // 
            // txttheloai
            // 
            txttheloai.Location = new Point(131, 129);
            txttheloai.Name = "txttheloai";
            txttheloai.Size = new Size(501, 27);
            txttheloai.TabIndex = 120;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(18, 268);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 119;
            label3.Text = "Tên Thể Loại ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(18, 129);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 118;
            label1.Text = "Mã Thể Loại";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(771, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(727, 608);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Thể Loại ";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(151, 32);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm Kiếm Theo Tên Thể Loại";
            txtTimKiem.Size = new Size(525, 27);
            txtTimKiem.TabIndex = 125;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(45, 39);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 124;
            label8.Text = "Tìm Kiếm ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(715, 486);
            dataGridView1.TabIndex = 128;
            // 
            // QuanLyTheLoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QuanLyTheLoai";
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
        private TextBox txttentheloai;
        private TextBox txttheloai;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtTimKiem;
        private Label label8;
        private DataGridView dataGridView1;
    }
}
