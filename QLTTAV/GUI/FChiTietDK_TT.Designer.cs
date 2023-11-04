namespace GUI
{
    partial class FChiTietDK_TT
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
            this.lbMaThiThu = new System.Windows.Forms.Label();
            this.hvSoDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hvNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hvGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hvHoTenHV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hvMaHV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.livHocVien = new System.Windows.Forms.ListView();
            this.btnXoaChiTietDK_TT = new System.Windows.Forms.Button();
            this.btnSuaChiTietDK_TT = new System.Windows.Forms.Button();
            this.btnThemChiTietDK_TT = new System.Windows.Forms.Button();
            this.txtNgayDK = new System.Windows.Forms.TextBox();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NgayDK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaHV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.livChiTietDK_TT = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMaThiThu
            // 
            this.lbMaThiThu.AutoSize = true;
            this.lbMaThiThu.Location = new System.Drawing.Point(363, 331);
            this.lbMaThiThu.Name = "lbMaThiThu";
            this.lbMaThiThu.Size = new System.Drawing.Size(53, 20);
            this.lbMaThiThu.TabIndex = 21;
            this.lbMaThiThu.Text = "Mã TT";
            // 
            // hvSoDT
            // 
            this.hvSoDT.Text = "Số ĐT";
            this.hvSoDT.Width = 100;
            // 
            // hvNgaySinh
            // 
            this.hvNgaySinh.Text = "Ngày Sinh";
            this.hvNgaySinh.Width = 100;
            // 
            // hvGioiTinh
            // 
            this.hvGioiTinh.Text = "Giới Tính";
            this.hvGioiTinh.Width = 80;
            // 
            // hvHoTenHV
            // 
            this.hvHoTenHV.Text = "Họ Tên HV";
            this.hvHoTenHV.Width = 150;
            // 
            // hvMaHV
            // 
            this.hvMaHV.Text = "Mã HV";
            this.hvMaHV.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Danh sách học viên đăng kí lớp thi thử có mã: ";
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
            this.livHocVien.Location = new System.Drawing.Point(30, 366);
            this.livHocVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.livHocVien.Name = "livHocVien";
            this.livHocVien.Size = new System.Drawing.Size(485, 224);
            this.livHocVien.TabIndex = 19;
            this.livHocVien.UseCompatibleStateImageBehavior = false;
            this.livHocVien.View = System.Windows.Forms.View.Details;
            // 
            // btnXoaChiTietDK_TT
            // 
            this.btnXoaChiTietDK_TT.BackColor = System.Drawing.Color.Red;
            this.btnXoaChiTietDK_TT.Location = new System.Drawing.Point(663, 515);
            this.btnXoaChiTietDK_TT.Name = "btnXoaChiTietDK_TT";
            this.btnXoaChiTietDK_TT.Size = new System.Drawing.Size(156, 42);
            this.btnXoaChiTietDK_TT.TabIndex = 18;
            this.btnXoaChiTietDK_TT.Text = "Xoá";
            this.btnXoaChiTietDK_TT.UseVisualStyleBackColor = false;
            this.btnXoaChiTietDK_TT.Click += new System.EventHandler(this.btnXoaChiTietDK_TT_Click);
            // 
            // btnSuaChiTietDK_TT
            // 
            this.btnSuaChiTietDK_TT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
            this.btnSuaChiTietDK_TT.Location = new System.Drawing.Point(663, 443);
            this.btnSuaChiTietDK_TT.Name = "btnSuaChiTietDK_TT";
            this.btnSuaChiTietDK_TT.Size = new System.Drawing.Size(156, 42);
            this.btnSuaChiTietDK_TT.TabIndex = 17;
            this.btnSuaChiTietDK_TT.Text = "Sửa";
            this.btnSuaChiTietDK_TT.UseVisualStyleBackColor = false;
            this.btnSuaChiTietDK_TT.Click += new System.EventHandler(this.btnSuaChiTietDK_TT_Click);
            // 
            // btnThemChiTietDK_TT
            // 
            this.btnThemChiTietDK_TT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemChiTietDK_TT.Location = new System.Drawing.Point(663, 374);
            this.btnThemChiTietDK_TT.Name = "btnThemChiTietDK_TT";
            this.btnThemChiTietDK_TT.Size = new System.Drawing.Size(156, 42);
            this.btnThemChiTietDK_TT.TabIndex = 16;
            this.btnThemChiTietDK_TT.Text = "Thêm";
            this.btnThemChiTietDK_TT.UseVisualStyleBackColor = false;
            this.btnThemChiTietDK_TT.Click += new System.EventHandler(this.btnThemChiTietDK_TT_Click);
            // 
            // txtNgayDK
            // 
            this.txtNgayDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDK.Location = new System.Drawing.Point(663, 243);
            this.txtNgayDK.Name = "txtNgayDK";
            this.txtNgayDK.Size = new System.Drawing.Size(208, 26);
            this.txtNgayDK.TabIndex = 13;
            // 
            // txtMaHV
            // 
            this.txtMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHV.Location = new System.Drawing.Point(663, 91);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(208, 26);
            this.txtMaHV.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã HV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày ĐK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã TT";
            // 
            // NgayDK
            // 
            this.NgayDK.Text = "Ngày Đăng Kí";
            this.NgayDK.Width = 130;
            // 
            // MaTT
            // 
            this.MaTT.Text = "Mã TT";
            this.MaTT.Width = 80;
            // 
            // MaHV
            // 
            this.MaHV.Text = "Mã HV";
            this.MaHV.Width = 80;
            // 
            // txtMaTT
            // 
            this.txtMaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTT.Location = new System.Drawing.Point(663, 166);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(208, 26);
            this.txtMaTT.TabIndex = 15;
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
            this.livChiTietDK_TT.Location = new System.Drawing.Point(31, 60);
            this.livChiTietDK_TT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.livChiTietDK_TT.Name = "livChiTietDK_TT";
            this.livChiTietDK_TT.Size = new System.Drawing.Size(484, 248);
            this.livChiTietDK_TT.TabIndex = 9;
            this.livChiTietDK_TT.UseCompatibleStateImageBehavior = false;
            this.livChiTietDK_TT.View = System.Windows.Forms.View.Details;
            this.livChiTietDK_TT.SelectedIndexChanged += new System.EventHandler(this.livChiTietDK_TT_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(388, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 36);
            this.label5.TabIndex = 22;
            this.label5.Text = "Đăng kí thi thử";
            // 
            // FChiTietDK_TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 834);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMaThiThu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.livHocVien);
            this.Controls.Add(this.btnXoaChiTietDK_TT);
            this.Controls.Add(this.btnSuaChiTietDK_TT);
            this.Controls.Add(this.btnThemChiTietDK_TT);
            this.Controls.Add(this.txtNgayDK);
            this.Controls.Add(this.txtMaHV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.livChiTietDK_TT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FChiTietDK_TT";
            this.Text = "FChiTietDK_TT";
            this.Load += new System.EventHandler(this.ChiTietDK_TT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaThiThu;
        private System.Windows.Forms.ColumnHeader hvSoDT;
        private System.Windows.Forms.ColumnHeader hvNgaySinh;
        private System.Windows.Forms.ColumnHeader hvGioiTinh;
        private System.Windows.Forms.ColumnHeader hvHoTenHV;
        private System.Windows.Forms.ColumnHeader hvMaHV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView livHocVien;
        private System.Windows.Forms.Button btnXoaChiTietDK_TT;
        private System.Windows.Forms.Button btnSuaChiTietDK_TT;
        private System.Windows.Forms.Button btnThemChiTietDK_TT;
        private System.Windows.Forms.TextBox txtNgayDK;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader NgayDK;
        private System.Windows.Forms.ColumnHeader MaTT;
        private System.Windows.Forms.ColumnHeader MaHV;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.ListView livChiTietDK_TT;
        private System.Windows.Forms.Label label5;
    }
}