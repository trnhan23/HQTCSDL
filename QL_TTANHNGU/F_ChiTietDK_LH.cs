using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TTANHNGU
{
    public partial class F_ChiTietDK_LH : Form
    {
        public F_ChiTietDK_LH()
        {
            InitializeComponent();
        }


        private void ThongBaoTrigger()
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select messageLog From triggerLog", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string message = reader.GetString(0);
                MessageBox.Show(message);
            }
            reader.Close();
            cmd = new SqlCommand("delete From triggerLog", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemChiTietDK_LH";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@MaLH", SqlDbType.NChar).Value = txtMaLH.Text;
                cmd.Parameters.Add("@NgayDK", SqlDbType.Date).Value = txtNgayDangKy.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinChiTietDK_LH();
                    ThongBaoTrigger();
                    MessageBox.Show("Thêm thành công!\n");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaChiTietDK_LH";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@MaLH", SqlDbType.NChar).Value = txtMaLH.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinChiTietDK_LH();
                    txtMaHV.Clear();
                    txtMaLH.Clear();
                    txtNgayDangKy.Clear();
                    MessageBox.Show("Xoá thành công!");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaChiTietDK_LH";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@MaLH", SqlDbType.NChar).Value = txtMaLH.Text;
                cmd.Parameters.Add("@NgayDK", SqlDbType.Date).Value = txtNgayDangKy.Text;


                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinChiTietDK_LH();
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void F_ChiTietDK_LH_Load(object sender, EventArgs e)
        {
            ThongTinChiTietDK_LH();
        }


        private void ThongTinChiTietDK_LH()
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from v_ChiTietDK_LH", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            lvChiTietDK_LH.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                DateTime ngayDangKy = reader.GetDateTime(2);
                item.SubItems.Add(ngayDangKy.ToString("dd-MM-yyyy"));


                lvChiTietDK_LH.Items.Add(item);
            }

            reader.Close();

        }


        private void lvChiTietDK_LH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvChiTietDK_LH.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem lv = lvChiTietDK_LH.SelectedItems[0];
            HienThiTTTheoMaHV(lv.SubItems[0].Text, lv.SubItems[1].Text);
        }


        private void HienThiTTTheoMaHV(string MaHV, string MaLH)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand(MaHV, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "HienThiTTTheoMaHVandMaLH";
                cmd.Connection = conn;


                SqlParameter para1 = new SqlParameter("@MaHV", SqlDbType.NChar);
                para1.Value = MaHV;
                cmd.Parameters.Add(para1);

                SqlParameter para2 = new SqlParameter("@MaLH", SqlDbType.NChar);
                para2.Value = MaLH;
                cmd.Parameters.Add(para2);


                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMaHV.Text = reader.GetString(0);
                    txtMaLH.Text = reader.GetString(1);
                    DateTime ngayDangKy = reader.GetDateTime(2);
                    txtNgayDangKy.Text = ngayDangKy.ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
