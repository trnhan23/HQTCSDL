﻿namespace GUI
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
            this.livGiangVien.Location = new System.Drawing.Point(19, 81);
            this.livGiangVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.livGiangVien.Name = "livGiangVien";
            this.livGiangVien.Size = new System.Drawing.Size(517, 390);
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
            this.label1.Location = new System.Drawing.Point(601, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã GV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(601, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(601, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(601, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "CCCD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(601, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lương";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtMaGV.Location = new System.Drawing.Point(712, 100);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(208, 26);
            this.txtMaGV.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtHoTen.Location = new System.Drawing.Point(712, 151);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(208, 26);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtCCCD.Location = new System.Drawing.Point(712, 204);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(208, 26);
            this.txtCCCD.TabIndex = 3;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtSoDT.Location = new System.Drawing.Point(712, 258);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(208, 26);
            this.txtSoDT.TabIndex = 3;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtLuong.Location = new System.Drawing.Point(712, 315);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(208, 26);
            this.txtLuong.TabIndex = 3;
            // 
            // btnThemGV
            // 
            this.btnThemGV.Location = new System.Drawing.Point(657, 391);
            this.btnThemGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(156, 42);
            this.btnThemGV.TabIndex = 4;
            this.btnThemGV.Text = "Thêm";
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // btnCapNhatGV
            // 
            this.btnCapNhatGV.Location = new System.Drawing.Point(657, 455);
            this.btnCapNhatGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhatGV.Name = "btnCapNhatGV";
            this.btnCapNhatGV.Size = new System.Drawing.Size(156, 42);
            this.btnCapNhatGV.TabIndex = 4;
            this.btnCapNhatGV.Text = "Sửa";
            this.btnCapNhatGV.UseVisualStyleBackColor = true;
            this.btnCapNhatGV.Click += new System.EventHandler(this.btnCapNhatGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Location = new System.Drawing.Point(657, 519);
            this.btnXoaGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(156, 42);
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
            this.label6.Location = new System.Drawing.Point(326, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 36);
            this.label6.TabIndex = 18;
            this.label6.Text = "Thông tin giảng viên";
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 834);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}