namespace GUI
{
    partial class Home
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
            this.panel_Left = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_nameButton = new System.Windows.Forms.Label();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnKetQuaTT = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLopHoc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnChiNhanh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Left.SuspendLayout();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel_Left.Controls.Add(this.button7);
            this.panel_Left.Controls.Add(this.btnKetQuaTT);
            this.panel_Left.Controls.Add(this.label1);
            this.panel_Left.Controls.Add(this.button5);
            this.panel_Left.Controls.Add(this.button4);
            this.panel_Left.Controls.Add(this.btnLopHoc);
            this.panel_Left.Controls.Add(this.button2);
            this.panel_Left.Controls.Add(this.btnChiNhanh);
            this.panel_Left.Controls.Add(this.pictureBox1);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(261, 665);
            this.panel_Left.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "ADMIN";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Top.Controls.Add(this.button1);
            this.panel_Top.Controls.Add(this.label_nameButton);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(261, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(966, 49);
            this.panel_Top.TabIndex = 1;
            // 
            // label_nameButton
            // 
            this.label_nameButton.AutoSize = true;
            this.label_nameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_nameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_nameButton.Location = new System.Drawing.Point(3, 8);
            this.label_nameButton.Name = "label_nameButton";
            this.label_nameButton.Size = new System.Drawing.Size(121, 29);
            this.label_nameButton.TabIndex = 0;
            this.label_nameButton.Text = "Trang chủ";
            this.label_nameButton.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.BackgroundImage = global::GUI.Properties.Resources._98c17eb653ed65ac1b2e588f8e9f00bd;
            this.panel_Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(261, 49);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(966, 616);
            this.panel_Body.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GUI.Properties.Resources.log_out_regular_24;
            this.button1.Location = new System.Drawing.Point(899, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 31);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::GUI.Properties.Resources.user_regular_24;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(0, 476);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(261, 64);
            this.button7.TabIndex = 8;
            this.button7.Text = "Giảng Viên";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnKetQuaTT
            // 
            this.btnKetQuaTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKetQuaTT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKetQuaTT.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnKetQuaTT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKetQuaTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetQuaTT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnKetQuaTT.ForeColor = System.Drawing.Color.White;
            this.btnKetQuaTT.Image = global::GUI.Properties.Resources.notepad_regular_24;
            this.btnKetQuaTT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKetQuaTT.Location = new System.Drawing.Point(0, 401);
            this.btnKetQuaTT.Name = "btnKetQuaTT";
            this.btnKetQuaTT.Size = new System.Drawing.Size(261, 75);
            this.btnKetQuaTT.TabIndex = 7;
            this.btnKetQuaTT.Text = "Kết Quả Thi Thử";
            this.btnKetQuaTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKetQuaTT.UseVisualStyleBackColor = true;
            this.btnKetQuaTT.Click += new System.EventHandler(this.btnKetQuaTT_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::GUI.Properties.Resources.registered_regular_24;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(0, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 64);
            this.button5.TabIndex = 6;
            this.button5.Text = "Thi Thử";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::GUI.Properties.Resources.male_female_regular_24;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(0, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(261, 64);
            this.button4.TabIndex = 5;
            this.button4.Text = "Học Viên";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLopHoc.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLopHoc.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLopHoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLopHoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopHoc.ForeColor = System.Drawing.Color.White;
            this.btnLopHoc.Image = global::GUI.Properties.Resources.door_open_regular_24;
            this.btnLopHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLopHoc.Location = new System.Drawing.Point(0, 209);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(261, 64);
            this.btnLopHoc.TabIndex = 4;
            this.btnLopHoc.Text = "Lớp Học";
            this.btnLopHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLopHoc.UseVisualStyleBackColor = true;
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::GUI.Properties.Resources.group_regular_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "Nhân Viên";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChiNhanh
            // 
            this.btnChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChiNhanh.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnChiNhanh.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnChiNhanh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChiNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiNhanh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiNhanh.ForeColor = System.Drawing.Color.White;
            this.btnChiNhanh.Image = global::GUI.Properties.Resources.buildings_solid_24;
            this.btnChiNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiNhanh.Location = new System.Drawing.Point(0, 81);
            this.btnChiNhanh.Name = "btnChiNhanh";
            this.btnChiNhanh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChiNhanh.Size = new System.Drawing.Size(261, 64);
            this.btnChiNhanh.TabIndex = 2;
            this.btnChiNhanh.Text = "Chi Nhánh";
            this.btnChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChiNhanh.UseVisualStyleBackColor = true;
            this.btnChiNhanh.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1227, 665);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Left);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel_Left.ResumeLayout(false);
            this.panel_Left.PerformLayout();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLopHoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChiNhanh;
        private System.Windows.Forms.Button btnKetQuaTT;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nameButton;
        private System.Windows.Forms.Button button1;
    }
}