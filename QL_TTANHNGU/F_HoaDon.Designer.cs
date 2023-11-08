namespace QL_TTANHNGU
{
    partial class F_HoaDon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ColumnHeader columnHeader1;
            lvHoaDon = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtSoTien = new TextBox();
            txtMaHD = new TextBox();
            txtNgayGiaoDich = new TextBox();
            txtMaHV = new TextBox();
            lbSoTien = new Label();
            lbMaHoaDon = new Label();
            lbNgayGiaoDich = new Label();
            lbMaHocVien = new Label();
            txtMaLH = new TextBox();
            label1 = new Label();
            txtTimKiemMaHD = new TextBox();
            txtTimKiemMaHV = new TextBox();
            btnTimKiem = new Button();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã Hóa Đơn";
            columnHeader1.Width = 80;
            // 
            // lvHoaDon
            // 
            lvHoaDon.Alignment = ListViewAlignment.Default;
            lvHoaDon.AutoArrange = false;
            lvHoaDon.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvHoaDon.FullRowSelect = true;
            lvHoaDon.GridLines = true;
            lvHoaDon.ImeMode = ImeMode.NoControl;
            lvHoaDon.Location = new Point(12, 12);
            lvHoaDon.Name = "lvHoaDon";
            lvHoaDon.RightToLeft = RightToLeft.No;
            lvHoaDon.Scrollable = false;
            lvHoaDon.Size = new Size(417, 426);
            lvHoaDon.TabIndex = 1;
            lvHoaDon.UseCompatibleStateImageBehavior = false;
            lvHoaDon.UseWaitCursor = true;
            lvHoaDon.View = View.Details;
            lvHoaDon.SelectedIndexChanged += lvHoaDon_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ngày Giao Dịch";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số Tiền";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Mã Học Viên";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mã Lớp Học";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 85;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Control;
            btnSua.Cursor = Cursors.No;
            btnSua.FlatStyle = FlatStyle.System;
            btnSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(695, 382);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(77, 33);
            btnSua.TabIndex = 30;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.Control;
            btnXoa.Cursor = Cursors.No;
            btnXoa.FlatStyle = FlatStyle.System;
            btnXoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(578, 382);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 33);
            btnXoa.TabIndex = 29;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Control;
            btnThem.Cursor = Cursors.No;
            btnThem.FlatStyle = FlatStyle.System;
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(461, 382);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(77, 33);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(556, 215);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(216, 23);
            txtSoTien.TabIndex = 27;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(556, 115);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(216, 23);
            txtMaHD.TabIndex = 26;
            // 
            // txtNgayGiaoDich
            // 
            txtNgayGiaoDich.Location = new Point(556, 164);
            txtNgayGiaoDich.Name = "txtNgayGiaoDich";
            txtNgayGiaoDich.Size = new Size(216, 23);
            txtNgayGiaoDich.TabIndex = 24;
            // 
            // txtMaHV
            // 
            txtMaHV.Location = new Point(556, 265);
            txtMaHV.Name = "txtMaHV";
            txtMaHV.Size = new Size(216, 23);
            txtMaHV.TabIndex = 22;
            // 
            // lbSoTien
            // 
            lbSoTien.AutoSize = true;
            lbSoTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSoTien.Location = new Point(458, 218);
            lbSoTien.Name = "lbSoTien";
            lbSoTien.Size = new Size(51, 15);
            lbSoTien.TabIndex = 21;
            lbSoTien.Text = "Số Tiền:";
            // 
            // lbMaHoaDon
            // 
            lbMaHoaDon.AutoSize = true;
            lbMaHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaHoaDon.Location = new Point(458, 118);
            lbMaHoaDon.Name = "lbMaHoaDon";
            lbMaHoaDon.Size = new Size(79, 15);
            lbMaHoaDon.TabIndex = 20;
            lbMaHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // lbNgayGiaoDich
            // 
            lbNgayGiaoDich.AutoSize = true;
            lbNgayGiaoDich.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNgayGiaoDich.Location = new Point(458, 167);
            lbNgayGiaoDich.Name = "lbNgayGiaoDich";
            lbNgayGiaoDich.Size = new Size(94, 15);
            lbNgayGiaoDich.TabIndex = 18;
            lbNgayGiaoDich.Text = "Ngày Giao Dịch:";
            // 
            // lbMaHocVien
            // 
            lbMaHocVien.AutoSize = true;
            lbMaHocVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaHocVien.Location = new Point(458, 269);
            lbMaHocVien.Name = "lbMaHocVien";
            lbMaHocVien.Size = new Size(80, 15);
            lbMaHocVien.TabIndex = 16;
            lbMaHocVien.Text = "Mã Học Viên:";
            // 
            // txtMaLH
            // 
            txtMaLH.Location = new Point(556, 317);
            txtMaLH.Name = "txtMaLH";
            txtMaLH.Size = new Size(216, 23);
            txtMaLH.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(458, 321);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 32;
            label1.Text = "Mã Lớp Học:";
            // 
            // txtTimKiemMaHD
            // 
            txtTimKiemMaHD.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtTimKiemMaHD.ForeColor = Color.DarkGray;
            txtTimKiemMaHD.Location = new Point(458, 31);
            txtTimKiemMaHD.Name = "txtTimKiemMaHD";
            txtTimKiemMaHD.Size = new Size(216, 23);
            txtTimKiemMaHD.TabIndex = 34;
            txtTimKiemMaHD.Text = "Nhập Mã Hóa Đơn Cần Tìm";
            txtTimKiemMaHD.MouseCaptureChanged += txtTimKiemMaHD_MouseCaptureChanged;
            // 
            // txtTimKiemMaHV
            // 
            txtTimKiemMaHV.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtTimKiemMaHV.ForeColor = Color.DarkGray;
            txtTimKiemMaHV.Location = new Point(458, 70);
            txtTimKiemMaHV.Name = "txtTimKiemMaHV";
            txtTimKiemMaHV.Size = new Size(216, 23);
            txtTimKiemMaHV.TabIndex = 35;
            txtTimKiemMaHV.Text = "Nhập Mã Học Viên Cần Tìm";
            txtTimKiemMaHV.MouseCaptureChanged += txtTimKiemMaHV_MouseCaptureChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.Control;
            btnTimKiem.Cursor = Cursors.No;
            btnTimKiem.FlatStyle = FlatStyle.System;
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(695, 48);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(77, 29);
            btnTimKiem.TabIndex = 36;
            btnTimKiem.Text = "Search";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // F_HoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiemMaHV);
            Controls.Add(txtTimKiemMaHD);
            Controls.Add(txtMaLH);
            Controls.Add(label1);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtSoTien);
            Controls.Add(txtMaHD);
            Controls.Add(txtNgayGiaoDich);
            Controls.Add(txtMaHV);
            Controls.Add(lbSoTien);
            Controls.Add(lbMaHoaDon);
            Controls.Add(lbNgayGiaoDich);
            Controls.Add(lbMaHocVien);
            Controls.Add(lvHoaDon);
            Name = "F_HoaDon";
            Text = "F_HoaDon";
            Load += F_HoaDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvHoaDon;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtSoTien;
        private TextBox txtMaHD;
        private TextBox txtNgayGiaoDich;
        private TextBox txtMaHV;
        private Label lbSoTien;
        private Label lbMaHoaDon;
        private Label lbNgayGiaoDich;
        private Label lbMaHocVien;
        private TextBox txtMaLH;
        private Label label1;
        private ColumnHeader columnHeader5;
        private TextBox txtTimKiemMaHD;
        private TextBox txtTimKiemMaHV;
        private Button btnTimKiem;
    }
}