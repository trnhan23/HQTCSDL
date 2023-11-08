namespace QL_TTANHNGU
{
    partial class F_HocVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ColumnHeader columnHeader1;
            lvHocVien = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            lbMaHocVien = new Label();
            lbHoVaTen = new Label();
            lbNgaySinh = new Label();
            lbGioiTinh = new Label();
            lbSDT = new Label();
            lbDiaChi = new Label();
            txtMaHV = new TextBox();
            txtHoTen = new TextBox();
            txtNgaySinh = new TextBox();
            txtGioiTinh = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            txtTimKiemMaHV = new TextBox();
            btnTimKiem = new Button();
            txtTimKiemTenHV = new TextBox();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã Học Viên";
            columnHeader1.Width = 80;
            // 
            // lvHocVien
            // 
            lvHocVien.Alignment = ListViewAlignment.Default;
            lvHocVien.AutoArrange = false;
            lvHocVien.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvHocVien.FullRowSelect = true;
            lvHocVien.GridLines = true;
            lvHocVien.ImeMode = ImeMode.Off;
            lvHocVien.Location = new Point(12, 12);
            lvHocVien.Name = "lvHocVien";
            lvHocVien.RightToLeft = RightToLeft.No;
            lvHocVien.Size = new Size(411, 426);
            lvHocVien.TabIndex = 0;
            lvHocVien.UseCompatibleStateImageBehavior = false;
            lvHocVien.UseWaitCursor = true;
            lvHocVien.View = View.Details;
            lvHocVien.SelectedIndexChanged += lvHocVien_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Họ và Tên";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày Sinh";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giới Tính";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "SĐT";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Địa Chỉ";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 150;
            // 
            // lbMaHocVien
            // 
            lbMaHocVien.AutoSize = true;
            lbMaHocVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaHocVien.Location = new Point(465, 125);
            lbMaHocVien.Name = "lbMaHocVien";
            lbMaHocVien.Size = new Size(80, 15);
            lbMaHocVien.TabIndex = 1;
            lbMaHocVien.Text = "Mã Học Viên:";
            // 
            // lbHoVaTen
            // 
            lbHoVaTen.AutoSize = true;
            lbHoVaTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbHoVaTen.Location = new Point(465, 164);
            lbHoVaTen.Name = "lbHoVaTen";
            lbHoVaTen.Size = new Size(65, 15);
            lbHoVaTen.TabIndex = 2;
            lbHoVaTen.Text = "Họ và Tên:";
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.AutoSize = true;
            lbNgaySinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNgaySinh.Location = new Point(465, 204);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(65, 15);
            lbNgaySinh.TabIndex = 3;
            lbNgaySinh.Text = "Ngày Sinh:";
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.AutoSize = true;
            lbGioiTinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbGioiTinh.Location = new Point(465, 245);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(60, 15);
            lbGioiTinh.TabIndex = 4;
            lbGioiTinh.Text = "Giới Tính:";
            // 
            // lbSDT
            // 
            lbSDT.AutoSize = true;
            lbSDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSDT.Location = new Point(465, 284);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(33, 15);
            lbSDT.TabIndex = 5;
            lbSDT.Text = "SĐT:";
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDiaChi.Location = new Point(465, 324);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(48, 15);
            lbDiaChi.TabIndex = 6;
            lbDiaChi.Text = "Địa Chỉ:";
            // 
            // txtMaHV
            // 
            txtMaHV.Location = new Point(563, 121);
            txtMaHV.Name = "txtMaHV";
            txtMaHV.Size = new Size(216, 23);
            txtMaHV.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(563, 161);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(216, 23);
            txtHoTen.TabIndex = 8;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(563, 201);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(216, 23);
            txtNgaySinh.TabIndex = 9;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(563, 242);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(216, 23);
            txtGioiTinh.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(563, 281);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(216, 23);
            txtSDT.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(563, 321);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(216, 23);
            txtDiaChi.TabIndex = 12;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Control;
            btnThem.Cursor = Cursors.No;
            btnThem.FlatStyle = FlatStyle.System;
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(468, 375);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(77, 33);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.Control;
            btnXoa.Cursor = Cursors.No;
            btnXoa.FlatStyle = FlatStyle.System;
            btnXoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(585, 375);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 33);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Control;
            btnSua.Cursor = Cursors.No;
            btnSua.FlatStyle = FlatStyle.System;
            btnSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(702, 375);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(77, 33);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // txtTimKiemMaHV
            // 
            txtTimKiemMaHV.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtTimKiemMaHV.ForeColor = Color.DarkGray;
            txtTimKiemMaHV.Location = new Point(465, 44);
            txtTimKiemMaHV.Name = "txtTimKiemMaHV";
            txtTimKiemMaHV.Size = new Size(246, 23);
            txtTimKiemMaHV.TabIndex = 16;
            txtTimKiemMaHV.Text = "Nhập Mã Học Viên Cần Tìm ";
            txtTimKiemMaHV.MouseCaptureChanged += txtTimKiemMaHV_MouseCaptureChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.Control;
            btnTimKiem.Cursor = Cursors.No;
            btnTimKiem.FlatStyle = FlatStyle.System;
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(717, 56);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(62, 23);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Search";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiemTenHV
            // 
            txtTimKiemTenHV.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtTimKiemTenHV.ForeColor = Color.DarkGray;
            txtTimKiemTenHV.Location = new Point(465, 73);
            txtTimKiemTenHV.Name = "txtTimKiemTenHV";
            txtTimKiemTenHV.Size = new Size(246, 23);
            txtTimKiemTenHV.TabIndex = 18;
            txtTimKiemTenHV.Text = "Nhập Tên Học Viên Cần Tìm ";
            txtTimKiemTenHV.MouseCaptureChanged += txtTimKiemTenHV_MouseCaptureChanged;
            // 
            // F_HocVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTimKiemTenHV);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiemMaHV);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtGioiTinh);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHV);
            Controls.Add(lbDiaChi);
            Controls.Add(lbSDT);
            Controls.Add(lbGioiTinh);
            Controls.Add(lbNgaySinh);
            Controls.Add(lbHoVaTen);
            Controls.Add(lbMaHocVien);
            Controls.Add(lvHocVien);
            Name = "F_HocVien";
            Text = "F_HocVien";
            Load += F_HocVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvHocVien;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label lbMaHocVien;
        private Label lbHoVaTen;
        private Label lbNgaySinh;
        private Label lbGioiTinh;
        private Label lbSDT;
        private Label lbDiaChi;
        private TextBox txtMaHV;
        private TextBox txtHoTen;
        private TextBox txtNgaySinh;
        private TextBox txtGioiTinh;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtTimKiemMaHV;
        private Button btnTimKiem;
        private TextBox txtTimKiemTenHV;
    }
}