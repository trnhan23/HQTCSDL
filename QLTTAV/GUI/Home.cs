using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            customizeDesigning();
        }

       private void ChangColor(Button btnEX)
        {
            if (btnEX.BackColor == Color.SlateGray)
                btnEX.BackColor = Color.Silver;
            else
                btnEX.BackColor = Color.SlateGray;
        }
        private void customizeDesigning()
        {
            panelGiangVien.Visible =false;
            panelHocVien.Visible =false;
            panelNhanVien.Visible =false;
            panelThiThu.Visible =false;
        }

        private void hideSubMenu()
        {
            if(panelGiangVien.Visible)
            {
                panelGiangVien.Visible=false;
            }
            if(panelHocVien.Visible)
            {
                panelHocVien.Visible=false;
            }
            if (panelNhanVien.Visible)
                panelNhanVien.Visible = false;
            if (panelThiThu.Visible)
                  panelThiThu.Visible=false;

        }
        
        private void showSubMenu(Panel panelEX)
        {
            if( panelEX.Visible == false)
            {
                hideSubMenu();
                panelEX.Visible = true;
            }
            else
                panelEX.Visible = false;
        }
        private Form currentFormChild;
        private Size originalParentSize;

        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // Lưu trạng thái kích thước gốc của form cha
            originalParentSize = this.Size;

            // Thay đổi kích thước của form cha để vừa với form con
            //this.Size = new Size(childForm.Size.Width, childForm.Size.Height);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopHoc());
            label_nameButton.Text = btnLopHoc.Text;
        }
        private void RestoreParentSize()
        {
            this.Size = originalParentSize;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            //RestoreParentSize();
        }


        private void Home_Load(object sender, EventArgs e)
        {

            this.MinimumSize = new Size(850, 500);
            this.MaximumSize = new Size(850, 500);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChiNhanh());
            label_nameButton.Text = btnChiNhanh.Text;
            if(label_nameButton.Text != btnChiNhanh.Text)
                ChangColor(btnChiNhanh);
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            label_nameButton.Text = "Trang Chủ";
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHocVien);
        }

        private void btnKetQuaTT_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new KetQua());
            label_nameButton.Text = btnKetQuaTT.Text;
            hideSubMenu();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThiThu);
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelNhanVien);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGiangVien);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
