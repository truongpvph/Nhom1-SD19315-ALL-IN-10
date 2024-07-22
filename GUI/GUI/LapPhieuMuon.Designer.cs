namespace GUI
{
    partial class LapPhieuMuon
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
            cbbmataikhoan = new ComboBox();
            cbbmadocgia = new ComboBox();
            label2 = new Label();
            btnhienthi = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txtmaphieumuon = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tcttimkiem = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbmataikhoan);
            groupBox1.Controls.Add(cbbmadocgia);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnhienthi);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(txtmaphieumuon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(684, 582);
            groupBox1.TabIndex = 144;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Phiếu Mượn";
            // 
            // cbbmataikhoan
            // 
            cbbmataikhoan.FormattingEnabled = true;
            cbbmataikhoan.Location = new Point(184, 192);
            cbbmataikhoan.Name = "cbbmataikhoan";
            cbbmataikhoan.Size = new Size(444, 28);
            cbbmataikhoan.TabIndex = 152;
            // 
            // cbbmadocgia
            // 
            cbbmadocgia.FormattingEnabled = true;
            cbbmadocgia.Location = new Point(184, 303);
            cbbmadocgia.Name = "cbbmadocgia";
            cbbmadocgia.Size = new Size(444, 28);
            cbbmadocgia.TabIndex = 151;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 311);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 150;
            label2.Text = "Mã Độc Giả";
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(102, 451);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 149;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(534, 451);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 148;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(314, 451);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 147;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // txtmaphieumuon
            // 
            txtmaphieumuon.Location = new Point(184, 69);
            txtmaphieumuon.Name = "txtmaphieumuon";
            txtmaphieumuon.Size = new Size(444, 27);
            txtmaphieumuon.TabIndex = 146;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(26, 200);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 145;
            label3.Text = "Mã Tài Khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 76);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 144;
            label1.Text = "Mã Phiếu Mượn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(tcttimkiem);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(801, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(706, 588);
            groupBox2.TabIndex = 145;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Phiếu Mượn";
            // 
            // tcttimkiem
            // 
            tcttimkiem.Location = new Point(156, 41);
            tcttimkiem.Name = "tcttimkiem";
            tcttimkiem.PlaceholderText = "Tìm kiếm dựa theo mã phiếu mượn";
            tcttimkiem.Size = new Size(544, 27);
            tcttimkiem.TabIndex = 154;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(44, 44);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 153;
            label4.Text = "Tìm Kiếm";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(680, 486);
            dataGridView1.TabIndex = 155;
            // 
            // LapPhieuMuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LapPhieuMuon";
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
        private ComboBox cbbmataikhoan;
        private ComboBox cbbmadocgia;
        private Label label2;
        private Button btnhienthi;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtmaphieumuon;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox tcttimkiem;
        private Label label4;
        private DataGridView dataGridView1;
    }
}
