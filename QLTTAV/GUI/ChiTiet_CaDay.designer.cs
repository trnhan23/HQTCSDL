﻿namespace GUI
{
    partial class ChiTiet_CaDay
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
            this.lvCTCaDay = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtNgayBD = new System.Windows.Forms.TextBox();
            this.txtNgayKT = new System.Windows.Forms.TextBox();
            this.txtCaDay = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCTCaDay
            // 
            this.lvCTCaDay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvCTCaDay.FullRowSelect = true;
            this.lvCTCaDay.GridLines = true;
            this.lvCTCaDay.HideSelection = false;
            this.lvCTCaDay.Location = new System.Drawing.Point(12, 12);
            this.lvCTCaDay.Name = "lvCTCaDay";
            this.lvCTCaDay.Size = new System.Drawing.Size(588, 499);
            this.lvCTCaDay.TabIndex = 0;
            this.lvCTCaDay.UseCompatibleStateImageBehavior = false;
            this.lvCTCaDay.View = System.Windows.Forms.View.Details;
            this.lvCTCaDay.SelectedIndexChanged += new System.EventHandler(this.lvCTCaDay_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Lớp Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Giảng Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Bắt Đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Kết Thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ca Dạy";
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(728, 13);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(241, 22);
            this.txtMaLH.TabIndex = 2;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(728, 65);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(241, 22);
            this.txtMaGV.TabIndex = 2;
            // 
            // txtNgayBD
            // 
            this.txtNgayBD.Location = new System.Drawing.Point(728, 117);
            this.txtNgayBD.Name = "txtNgayBD";
            this.txtNgayBD.Size = new System.Drawing.Size(241, 22);
            this.txtNgayBD.TabIndex = 2;
            // 
            // txtNgayKT
            // 
            this.txtNgayKT.Location = new System.Drawing.Point(728, 169);
            this.txtNgayKT.Name = "txtNgayKT";
            this.txtNgayKT.Size = new System.Drawing.Size(241, 22);
            this.txtNgayKT.TabIndex = 2;
            // 
            // txtCaDay
            // 
            this.txtCaDay.Location = new System.Drawing.Point(728, 221);
            this.txtCaDay.Name = "txtCaDay";
            this.txtCaDay.Size = new System.Drawing.Size(241, 22);
            this.txtCaDay.TabIndex = 2;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Lớp Học";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Giảng Viên";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Bắt Đầu";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày Kết Thúc";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ca Dạy";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(621, 300);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(348, 29);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(621, 356);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(348, 29);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(621, 412);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(348, 29);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // ChiTiet_CaDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 523);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtCaDay);
            this.Controls.Add(this.txtNgayKT);
            this.Controls.Add(this.txtNgayBD);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.txtMaLH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvCTCaDay);
            this.Name = "ChiTiet_CaDay";
            this.Text = "ChiTiet_CaDay";
            this.Load += new System.EventHandler(this.ChiTiet_CaDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCTCaDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtNgayBD;
        private System.Windows.Forms.TextBox txtNgayKT;
        private System.Windows.Forms.TextBox txtCaDay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}