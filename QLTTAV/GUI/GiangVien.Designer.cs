namespace GUI
{
    partial class GiangVien
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
            this.livGiangVien = new System.Windows.Forms.ListView();
            this.MaGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Luong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.btnCapNhatGV = new System.Windows.Forms.Button();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimMaGV = new System.Windows.Forms.TextBox();
            this.txtTimHoTen = new System.Windows.Forms.TextBox();
            this.lb_MaGV = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // livGiangVien
            // 
            this.livGiangVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaGV,
            this.HoTen,
            this.CCCD,
            this.SoDT,
            this.Luong});
            this.livGiangVien.FullRowSelect = true;
            this.livGiangVien.GridLines = true;
            this.livGiangVien.HideSelection = false;
            this.livGiangVien.Location = new System.Drawing.Point(22, 152);
            this.livGiangVien.Name = "livGiangVien";
            this.livGiangVien.Size = new System.Drawing.Size(460, 313);
            this.livGiangVien.TabIndex = 0;
            this.livGiangVien.UseCompatibleStateImageBehavior = false;
            this.livGiangVien.View = System.Windows.Forms.View.Details;
            this.livGiangVien.SelectedIndexChanged += new System.EventHandler(this.livGiangVien_SelectedIndexChanged);
            // 
            // MaGV
            // 
            this.MaGV.Text = "Mã GV";
            this.MaGV.Width = 80;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ Tên";
            this.HoTen.Width = 150;
            // 
            // CCCD
            // 
            this.CCCD.Text = "CCCD";
            this.CCCD.Width = 100;
            // 
            // SoDT
            // 
            this.SoDT.Text = "Số ĐT";
            this.SoDT.Width = 100;
            // 
            // Luong
            // 
            this.Luong.Text = "Lương";
            this.Luong.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(539, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã GV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(539, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(539, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(539, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "CCCD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(539, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lương";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtMaGV.Location = new System.Drawing.Point(638, 167);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(185, 23);
            this.txtMaGV.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtHoTen.Location = new System.Drawing.Point(638, 208);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(185, 23);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtCCCD.Location = new System.Drawing.Point(638, 250);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(185, 23);
            this.txtCCCD.TabIndex = 3;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtSoDT.Location = new System.Drawing.Point(638, 293);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(185, 23);
            this.txtSoDT.TabIndex = 3;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtLuong.Location = new System.Drawing.Point(638, 339);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(185, 23);
            this.txtLuong.TabIndex = 3;
            // 
            // btnThemGV
            // 
            this.btnThemGV.Location = new System.Drawing.Point(589, 378);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(139, 34);
            this.btnThemGV.TabIndex = 4;
            this.btnThemGV.Text = "Thêm";
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // btnCapNhatGV
            // 
            this.btnCapNhatGV.Location = new System.Drawing.Point(589, 418);
            this.btnCapNhatGV.Name = "btnCapNhatGV";
            this.btnCapNhatGV.Size = new System.Drawing.Size(139, 34);
            this.btnCapNhatGV.TabIndex = 4;
            this.btnCapNhatGV.Text = "Sửa";
            this.btnCapNhatGV.UseVisualStyleBackColor = true;
            this.btnCapNhatGV.Click += new System.EventHandler(this.btnCapNhatGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Location = new System.Drawing.Point(589, 458);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(139, 34);
            this.btnXoaGV.TabIndex = 4;
            this.btnXoaGV.Text = "Xoá";
            this.btnXoaGV.UseVisualStyleBackColor = true;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(290, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Thông tin giảng viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(95, 110);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(76, 27);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimMaGV
            // 
            this.txtTimMaGV.Location = new System.Drawing.Point(95, 54);
            this.txtTimMaGV.Name = "txtTimMaGV";
            this.txtTimMaGV.Size = new System.Drawing.Size(158, 22);
            this.txtTimMaGV.TabIndex = 20;
            // 
            // txtTimHoTen
            // 
            this.txtTimHoTen.Location = new System.Drawing.Point(95, 82);
            this.txtTimHoTen.Name = "txtTimHoTen";
            this.txtTimHoTen.Size = new System.Drawing.Size(158, 22);
            this.txtTimHoTen.TabIndex = 21;
            // 
            // lb_MaGV
            // 
            this.lb_MaGV.AutoSize = true;
            this.lb_MaGV.Location = new System.Drawing.Point(23, 60);
            this.lb_MaGV.Name = "lb_MaGV";
            this.lb_MaGV.Size = new System.Drawing.Size(45, 16);
            this.lb_MaGV.TabIndex = 22;
            this.lb_MaGV.Text = "MaGV";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(23, 88);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(49, 16);
            this.lb_HoTen.TabIndex = 23;
            this.lb_HoTen.Text = "HoTen";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(177, 110);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 27);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 667);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.lb_MaGV);
            this.Controls.Add(this.txtTimHoTen);
            this.Controls.Add(this.txtTimMaGV);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXoaGV);
            this.Controls.Add(this.btnCapNhatGV);
            this.Controls.Add(this.btnThemGV);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.livGiangVien);
            this.Name = "GiangVien";
            this.Text = "GiangVien";
            this.Load += new System.EventHandler(this.GiangVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView livGiangVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.ColumnHeader MaGV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader CCCD;
        private System.Windows.Forms.ColumnHeader SoDT;
        private System.Windows.Forms.ColumnHeader Luong;
        private System.Windows.Forms.Button btnCapNhatGV;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimMaGV;
        private System.Windows.Forms.TextBox txtTimHoTen;
        private System.Windows.Forms.Label lb_MaGV;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Button btnClear;
    }
}