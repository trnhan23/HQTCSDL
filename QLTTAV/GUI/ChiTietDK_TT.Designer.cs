namespace GUI
{
    partial class ChiTietDK_TT
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
            this.livChiTietDK_TT = new System.Windows.Forms.ListView();
            this.MaHV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayDK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.txtNgayDK = new System.Windows.Forms.TextBox();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.btnThemChiTietDK_TT = new System.Windows.Forms.Button();
            this.btnSuaChiTietDK_TT = new System.Windows.Forms.Button();
            this.btnXoaChiTietDK_TT = new System.Windows.Forms.Button();
            this.livHocVien = new System.Windows.Forms.ListView();
            this.hvMaHV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hvHoTenHV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hvGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hvNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hvSoDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaThiThu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // livChiTietDK_TT
            // 
            this.livChiTietDK_TT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHV,
            this.MaTT,
            this.NgayDK});
            this.livChiTietDK_TT.FullRowSelect = true;
            this.livChiTietDK_TT.GridLines = true;
            this.livChiTietDK_TT.HideSelection = false;
            this.livChiTietDK_TT.Location = new System.Drawing.Point(17, 16);
            this.livChiTietDK_TT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.livChiTietDK_TT.Name = "livChiTietDK_TT";
            this.livChiTietDK_TT.Size = new System.Drawing.Size(593, 248);
            this.livChiTietDK_TT.TabIndex = 0;
            this.livChiTietDK_TT.UseCompatibleStateImageBehavior = false;
            this.livChiTietDK_TT.View = System.Windows.Forms.View.Details;
            this.livChiTietDK_TT.SelectedIndexChanged += new System.EventHandler(this.livChiTietDK_TT_SelectedIndexChanged);
            // 
            // MaHV
            // 
            this.MaHV.Text = "Mã HV";
            this.MaHV.Width = 80;
            // 
            // MaTT
            // 
            this.MaTT.Text = "Mã TT";
            this.MaTT.Width = 80;
            // 
            // NgayDK
            // 
            this.NgayDK.Text = "Ngày Đăng Kí";
            this.NgayDK.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(667, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã TT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã HV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(667, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày ĐK";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHV.Location = new System.Drawing.Point(781, 50);
            this.txtMaHV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(236, 35);
            this.txtMaHV.TabIndex = 2;
            // 
            // txtNgayDK
            // 
            this.txtNgayDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDK.Location = new System.Drawing.Point(781, 202);
            this.txtNgayDK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayDK.Name = "txtNgayDK";
            this.txtNgayDK.Size = new System.Drawing.Size(236, 35);
            this.txtNgayDK.TabIndex = 2;
            // 
            // txtMaTT
            // 
            this.txtMaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTT.Location = new System.Drawing.Point(781, 125);
            this.txtMaTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(236, 35);
            this.txtMaTT.TabIndex = 2;
            // 
            // btnThemChiTietDK_TT
            // 
            this.btnThemChiTietDK_TT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemChiTietDK_TT.Location = new System.Drawing.Point(781, 350);
            this.btnThemChiTietDK_TT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemChiTietDK_TT.Name = "btnThemChiTietDK_TT";
            this.btnThemChiTietDK_TT.Size = new System.Drawing.Size(133, 39);
            this.btnThemChiTietDK_TT.TabIndex = 3;
            this.btnThemChiTietDK_TT.Text = "Thêm";
            this.btnThemChiTietDK_TT.UseVisualStyleBackColor = false;
            this.btnThemChiTietDK_TT.Click += new System.EventHandler(this.btnThemChiTietDK_TT_Click);
            // 
            // btnSuaChiTietDK_TT
            // 
            this.btnSuaChiTietDK_TT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
            this.btnSuaChiTietDK_TT.Location = new System.Drawing.Point(781, 419);
            this.btnSuaChiTietDK_TT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaChiTietDK_TT.Name = "btnSuaChiTietDK_TT";
            this.btnSuaChiTietDK_TT.Size = new System.Drawing.Size(133, 39);
            this.btnSuaChiTietDK_TT.TabIndex = 4;
            this.btnSuaChiTietDK_TT.Text = "Sửa";
            this.btnSuaChiTietDK_TT.UseVisualStyleBackColor = false;
            this.btnSuaChiTietDK_TT.Click += new System.EventHandler(this.btnSuaChiTietDK_TT_Click);
            // 
            // btnXoaChiTietDK_TT
            // 
            this.btnXoaChiTietDK_TT.BackColor = System.Drawing.Color.Red;
            this.btnXoaChiTietDK_TT.Location = new System.Drawing.Point(781, 491);
            this.btnXoaChiTietDK_TT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaChiTietDK_TT.Name = "btnXoaChiTietDK_TT";
            this.btnXoaChiTietDK_TT.Size = new System.Drawing.Size(133, 39);
            this.btnXoaChiTietDK_TT.TabIndex = 5;
            this.btnXoaChiTietDK_TT.Text = "Xoá";
            this.btnXoaChiTietDK_TT.UseVisualStyleBackColor = false;
            this.btnXoaChiTietDK_TT.Click += new System.EventHandler(this.btnXoaChiTietDK_TT_Click);
            // 
            // livHocVien
            // 
            this.livHocVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hvMaHV,
            this.hvHoTenHV,
            this.hvGioiTinh,
            this.hvNgaySinh,
            this.hvSoDT});
            this.livHocVien.GridLines = true;
            this.livHocVien.HideSelection = false;
            this.livHocVien.Location = new System.Drawing.Point(16, 322);
            this.livHocVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.livHocVien.Name = "livHocVien";
            this.livHocVien.Size = new System.Drawing.Size(594, 224);
            this.livHocVien.TabIndex = 6;
            this.livHocVien.UseCompatibleStateImageBehavior = false;
            this.livHocVien.View = System.Windows.Forms.View.Details;
            // 
            // hvMaHV
            // 
            this.hvMaHV.Text = "Mã HV";
            this.hvMaHV.Width = 80;
            // 
            // hvHoTenHV
            // 
            this.hvHoTenHV.Text = "Họ Tên HV";
            this.hvHoTenHV.Width = 150;
            // 
            // hvGioiTinh
            // 
            this.hvGioiTinh.Text = "Giới Tính";
            this.hvGioiTinh.Width = 80;
            // 
            // hvNgaySinh
            // 
            this.hvNgaySinh.Text = "Ngày Sinh";
            this.hvNgaySinh.Width = 100;
            // 
            // hvSoDT
            // 
            this.hvSoDT.Text = "Số ĐT";
            this.hvSoDT.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Danh sách học viên đăng kí lớp thi thử có mã: ";
            // 
            // lbMaThiThu
            // 
            this.lbMaThiThu.AutoSize = true;
            this.lbMaThiThu.Location = new System.Drawing.Point(349, 287);
            this.lbMaThiThu.Name = "lbMaThiThu";
            this.lbMaThiThu.Size = new System.Drawing.Size(53, 20);
            this.lbMaThiThu.TabIndex = 8;
            this.lbMaThiThu.Text = "Mã TT";
            // 
            // ChiTietDK_TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 553);
            this.Controls.Add(this.lbMaThiThu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.livHocVien);
            this.Controls.Add(this.btnXoaChiTietDK_TT);
            this.Controls.Add(this.btnSuaChiTietDK_TT);
            this.Controls.Add(this.btnThemChiTietDK_TT);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.txtNgayDK);
            this.Controls.Add(this.txtMaHV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.livChiTietDK_TT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChiTietDK_TT";
            this.Text = "ChiTietDK_TT";
            this.Load += new System.EventHandler(this.ChiTietDK_TT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView livChiTietDK_TT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.TextBox txtNgayDK;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Button btnThemChiTietDK_TT;
        private System.Windows.Forms.Button btnSuaChiTietDK_TT;
        private System.Windows.Forms.Button btnXoaChiTietDK_TT;
        private System.Windows.Forms.ColumnHeader MaHV;
        private System.Windows.Forms.ColumnHeader MaTT;
        private System.Windows.Forms.ColumnHeader NgayDK;
        private System.Windows.Forms.ListView livHocVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaThiThu;
        private System.Windows.Forms.ColumnHeader hvMaHV;
        private System.Windows.Forms.ColumnHeader hvHoTenHV;
        private System.Windows.Forms.ColumnHeader hvGioiTinh;
        private System.Windows.Forms.ColumnHeader hvNgaySinh;
        private System.Windows.Forms.ColumnHeader hvSoDT;
    }
}