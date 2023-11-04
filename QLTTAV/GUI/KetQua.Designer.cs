namespace GUI
{
    partial class KetQua
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
            this.lvKetQua = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaKQ = new System.Windows.Forms.Button();
            this.btnSuaKQ = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoCauDocDung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoCauNgheDung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnTinhDiem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimKiemKQTT = new System.Windows.Forms.Button();
            this.txtTKMaHV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTKMaTT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvKetQua
            // 
            this.lvKetQua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvKetQua.FullRowSelect = true;
            this.lvKetQua.GridLines = true;
            this.lvKetQua.HideSelection = false;
            this.lvKetQua.Location = new System.Drawing.Point(12, 239);
            this.lvKetQua.Name = "lvKetQua";
            this.lvKetQua.Size = new System.Drawing.Size(515, 322);
            this.lvKetQua.TabIndex = 0;
            this.lvKetQua.UseCompatibleStateImageBehavior = false;
            this.lvKetQua.View = System.Windows.Forms.View.Details;
            this.lvKetQua.SelectedIndexChanged += new System.EventHandler(this.lvKetQua_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã học viên";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã thi thử";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số câu đọc đúng";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số câu nghe đúng";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điểm";
            // 
            // btnXoaKQ
            // 
            this.btnXoaKQ.BackColor = System.Drawing.Color.Red;
            this.btnXoaKQ.Location = new System.Drawing.Point(642, 567);
            this.btnXoaKQ.Name = "btnXoaKQ";
            this.btnXoaKQ.Size = new System.Drawing.Size(194, 42);
            this.btnXoaKQ.TabIndex = 20;
            this.btnXoaKQ.Text = "Xoá";
            this.btnXoaKQ.UseVisualStyleBackColor = false;
            this.btnXoaKQ.Click += new System.EventHandler(this.btnXoaKQ_Click);
            // 
            // btnSuaKQ
            // 
            this.btnSuaKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(206)))));
            this.btnSuaKQ.Location = new System.Drawing.Point(642, 519);
            this.btnSuaKQ.Name = "btnSuaKQ";
            this.btnSuaKQ.Size = new System.Drawing.Size(194, 42);
            this.btnSuaKQ.TabIndex = 21;
            this.btnSuaKQ.Text = "Sửa";
            this.btnSuaKQ.UseVisualStyleBackColor = false;
            this.btnSuaKQ.Click += new System.EventHandler(this.btnSuaKQ_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(642, 471);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(194, 42);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(745, 167);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(208, 26);
            this.txtMaTT.TabIndex = 18;
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(745, 97);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(208, 26);
            this.txtMaHV.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số câu đọc đúng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã thi thử";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã học viên";
            // 
            // txtSoCauDocDung
            // 
            this.txtSoCauDocDung.Location = new System.Drawing.Point(745, 231);
            this.txtSoCauDocDung.Name = "txtSoCauDocDung";
            this.txtSoCauDocDung.Size = new System.Drawing.Size(208, 26);
            this.txtSoCauDocDung.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số câu nghe đúng";
            // 
            // txtSoCauNgheDung
            // 
            this.txtSoCauNgheDung.Location = new System.Drawing.Point(745, 303);
            this.txtSoCauNgheDung.Name = "txtSoCauNgheDung";
            this.txtSoCauNgheDung.Size = new System.Drawing.Size(208, 26);
            this.txtSoCauNgheDung.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(576, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Điểm";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(745, 367);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(208, 26);
            this.txtDiem.TabIndex = 18;
            // 
            // btnTinhDiem
            // 
            this.btnTinhDiem.Location = new System.Drawing.Point(643, 423);
            this.btnTinhDiem.Name = "btnTinhDiem";
            this.btnTinhDiem.Size = new System.Drawing.Size(194, 42);
            this.btnTinhDiem.TabIndex = 23;
            this.btnTinhDiem.Text = "Tính điểm";
            this.btnTinhDiem.UseVisualStyleBackColor = true;
            this.btnTinhDiem.Click += new System.EventHandler(this.btnTinhDiem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(390, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 36);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kết Quả Thi Thử";
            // 
            // btnTimKiemKQTT
            // 
            this.btnTimKiemKQTT.BackColor = System.Drawing.Color.Turquoise;
            this.btnTimKiemKQTT.Location = new System.Drawing.Point(12, 178);
            this.btnTimKiemKQTT.Name = "btnTimKiemKQTT";
            this.btnTimKiemKQTT.Size = new System.Drawing.Size(115, 33);
            this.btnTimKiemKQTT.TabIndex = 27;
            this.btnTimKiemKQTT.Text = "Tìm Kiếm";
            this.btnTimKiemKQTT.UseVisualStyleBackColor = false;
            this.btnTimKiemKQTT.Click += new System.EventHandler(this.btnTimKiemKQTT_Click);
            // 
            // txtTKMaHV
            // 
            this.txtTKMaHV.Location = new System.Drawing.Point(130, 98);
            this.txtTKMaHV.Name = "txtTKMaHV";
            this.txtTKMaHV.Size = new System.Drawing.Size(182, 26);
            this.txtTKMaHV.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mã học viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Mã thi thử";
            // 
            // txtTKMaTT
            // 
            this.txtTKMaTT.Location = new System.Drawing.Point(130, 130);
            this.txtTKMaTT.Name = "txtTKMaTT";
            this.txtTKMaTT.Size = new System.Drawing.Size(182, 26);
            this.txtTKMaTT.TabIndex = 26;
            // 
            // KetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(977, 645);
            this.Controls.Add(this.btnTimKiemKQTT);
            this.Controls.Add(this.txtTKMaTT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTKMaHV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTinhDiem);
            this.Controls.Add(this.btnXoaKQ);
            this.Controls.Add(this.btnSuaKQ);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtSoCauNgheDung);
            this.Controls.Add(this.txtSoCauDocDung);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.txtMaHV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvKetQua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KetQua";
            this.Text = "KetQua";
            this.Load += new System.EventHandler(this.KetQua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvKetQua;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnXoaKQ;
        private System.Windows.Forms.Button btnSuaKQ;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoCauDocDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoCauNgheDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnTinhDiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimKiemKQTT;
        private System.Windows.Forms.TextBox txtTKMaHV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTKMaTT;
    }
}