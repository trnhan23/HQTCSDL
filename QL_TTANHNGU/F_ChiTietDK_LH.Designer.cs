namespace QL_TTANHNGU
{
    partial class F_ChiTietDK_LH
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
            lvChiTietDK_LH = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtMaLH = new TextBox();
            lbMaLH = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtNgayDangKy = new TextBox();
            txtMaHV = new TextBox();
            lbNgayDangKy = new Label();
            lbMaHocVien = new Label();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã Học Viên";
            columnHeader1.Width = 100;
            // 
            // lvChiTietDK_LH
            // 
            lvChiTietDK_LH.Alignment = ListViewAlignment.Default;
            lvChiTietDK_LH.AutoArrange = false;
            lvChiTietDK_LH.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvChiTietDK_LH.FullRowSelect = true;
            lvChiTietDK_LH.GridLines = true;
            lvChiTietDK_LH.ImeMode = ImeMode.NoControl;
            lvChiTietDK_LH.Location = new Point(40, 12);
            lvChiTietDK_LH.Name = "lvChiTietDK_LH";
            lvChiTietDK_LH.RightToLeft = RightToLeft.No;
            lvChiTietDK_LH.Scrollable = false;
            lvChiTietDK_LH.Size = new Size(322, 426);
            lvChiTietDK_LH.TabIndex = 2;
            lvChiTietDK_LH.UseCompatibleStateImageBehavior = false;
            lvChiTietDK_LH.UseWaitCursor = true;
            lvChiTietDK_LH.View = View.Details;
            lvChiTietDK_LH.SelectedIndexChanged += lvChiTietDK_LH_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã Lớp Học";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày Đăng Ký";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // txtMaLH
            // 
            txtMaLH.Location = new Point(510, 136);
            txtMaLH.Name = "txtMaLH";
            txtMaLH.Size = new Size(216, 23);
            txtMaLH.TabIndex = 46;
            // 
            // lbMaLH
            // 
            lbMaLH.AutoSize = true;
            lbMaLH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaLH.Location = new Point(412, 140);
            lbMaLH.Name = "lbMaLH";
            lbMaLH.Size = new Size(76, 15);
            lbMaLH.TabIndex = 45;
            lbMaLH.Text = "Mã Lớp Học:";
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Control;
            btnSua.Cursor = Cursors.No;
            btnSua.FlatStyle = FlatStyle.System;
            btnSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(649, 276);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(77, 33);
            btnSua.TabIndex = 44;
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
            btnXoa.Location = new Point(532, 276);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 33);
            btnXoa.TabIndex = 43;
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
            btnThem.Location = new Point(415, 276);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(77, 33);
            btnThem.TabIndex = 42;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtNgayDangKy
            // 
            txtNgayDangKy.Location = new Point(510, 210);
            txtNgayDangKy.Name = "txtNgayDangKy";
            txtNgayDangKy.Size = new Size(216, 23);
            txtNgayDangKy.TabIndex = 39;
            // 
            // txtMaHV
            // 
            txtMaHV.Location = new Point(510, 65);
            txtMaHV.Name = "txtMaHV";
            txtMaHV.Size = new Size(216, 23);
            txtMaHV.TabIndex = 38;
            // 
            // lbNgayDangKy
            // 
            lbNgayDangKy.AutoSize = true;
            lbNgayDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNgayDangKy.Location = new Point(412, 213);
            lbNgayDangKy.Name = "lbNgayDangKy";
            lbNgayDangKy.Size = new Size(87, 15);
            lbNgayDangKy.TabIndex = 35;
            lbNgayDangKy.Text = "Ngày Đăng Ký:";
            // 
            // lbMaHocVien
            // 
            lbMaHocVien.AutoSize = true;
            lbMaHocVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaHocVien.Location = new Point(412, 69);
            lbMaHocVien.Name = "lbMaHocVien";
            lbMaHocVien.Size = new Size(80, 15);
            lbMaHocVien.TabIndex = 34;
            lbMaHocVien.Text = "Mã Học Viên:";
            // 
            // F_ChiTietDK_LH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMaLH);
            Controls.Add(lbMaLH);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtNgayDangKy);
            Controls.Add(txtMaHV);
            Controls.Add(lbNgayDangKy);
            Controls.Add(lbMaHocVien);
            Controls.Add(lvChiTietDK_LH);
            Name = "F_ChiTietDK_LH";
            Text = "F_ChiTietDK_LH";
            Load += F_ChiTietDK_LH_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvChiTietDK_LH;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtMaLH;
        private Label lbMaLH;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtNgayDangKy;
        private TextBox txtMaHV;
        private Label lbNgayDangKy;
        private Label lbMaHocVien;
    }
}