namespace GUI
{
    partial class TaoLopHoc
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
            this.lvTaoLopHoc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaQL = new System.Windows.Forms.TextBox();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.txtNgayTao = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvTaoLopHoc
            // 
            this.lvTaoLopHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvTaoLopHoc.FullRowSelect = true;
            this.lvTaoLopHoc.GridLines = true;
            this.lvTaoLopHoc.HideSelection = false;
            this.lvTaoLopHoc.Location = new System.Drawing.Point(12, 12);
            this.lvTaoLopHoc.Name = "lvTaoLopHoc";
            this.lvTaoLopHoc.Size = new System.Drawing.Size(482, 425);
            this.lvTaoLopHoc.TabIndex = 0;
            this.lvTaoLopHoc.UseCompatibleStateImageBehavior = false;
            this.lvTaoLopHoc.View = System.Windows.Forms.View.Details;
            this.lvTaoLopHoc.SelectedIndexChanged += new System.EventHandler(this.lvTaoLopHoc_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Quản Lý";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Lớp Học";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Tạo Lớp Học";
            this.columnHeader3.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Quản Lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Lớp Học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày Tạo Lớp Học";
            // 
            // txtMaQL
            // 
            this.txtMaQL.Location = new System.Drawing.Point(635, 44);
            this.txtMaQL.Name = "txtMaQL";
            this.txtMaQL.Size = new System.Drawing.Size(195, 22);
            this.txtMaQL.TabIndex = 3;
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(635, 94);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(195, 22);
            this.txtMaLH.TabIndex = 3;
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Location = new System.Drawing.Point(635, 147);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Size = new System.Drawing.Size(195, 22);
            this.txtNgayTao.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(514, 355);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(316, 30);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(514, 288);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(316, 30);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(514, 221);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(316, 30);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // TaoLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtNgayTao);
            this.Controls.Add(this.txtMaLH);
            this.Controls.Add(this.txtMaQL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvTaoLopHoc);
            this.Name = "TaoLopHoc";
            this.Text = "TaoLopHoc";
            this.Load += new System.EventHandler(this.TaoLopHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTaoLopHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaQL;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.TextBox txtNgayTao;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}