using DAL;
using Microsoft.SqlServer.Server;
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

namespace GUI
{
    public partial class ChiTietDK_TT : Form
    {
        public ChiTietDK_TT()
        {
            InitializeComponent();
        }

        private void ChiTietDK_TT_Load(object sender, EventArgs e)
        {
            HienThiThongTinChiTietDK_TT();
        }

        private void HienThiThongTinChiTietDK_TT()
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * From v_ChiTietDK_TT", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                livChiTietDK_TT.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetString(0));
                    lvi.SubItems.Add(reader.GetString(1));
                    DateTime NgayDK = reader.GetDateTime(2);
                    lvi.SubItems.Add(NgayDK.ToString("dd-MM-yyyy"));
                    
                    livChiTietDK_TT.Items.Add(lvi);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void livChiTietDK_TT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (livChiTietDK_TT.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem lvi = livChiTietDK_TT.SelectedItems[0];
            String MaHV = lvi.SubItems[0].Text;
            String MaTT = lvi.SubItems[1].Text;
            lbMaThiThu.Text = MaTT;

            HienThiTheoMaHV_TT(MaHV,MaTT);
            HienThiDanhSachHocVienDK_TT(MaTT);
        }

        private void HienThiDanhSachHocVienDK_TT(string maTT)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand(maTT, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_HienThiHocVienDK_TT";
                cmd.Connection = conn;

                SqlParameter para = new SqlParameter("@MaTT", SqlDbType.Char);
                para.Value = maTT;
                cmd.Parameters.Add(para);
                SqlDataReader reader = cmd.ExecuteReader();
                livHocVien.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetString(0));
                    lvi.SubItems.Add(reader.GetString(1));
                    lvi.SubItems.Add(reader.GetString(2));
                    DateTime NgaySinh = reader.GetDateTime(3);
                    lvi.SubItems.Add(NgaySinh.ToString("dd-MM-yyyy"));
                    lvi.SubItems.Add(reader.GetString(4));
                    livHocVien.Items.Add(lvi);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HienThiTheoMaHV_TT(string MaHV, string MaTT)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand("pr_HienThiTheoMaHV_TT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_HienThiTheoMaHV_TT";
                cmd.Connection = conn;

                SqlParameter paraMaHV = new SqlParameter("@MaHV", SqlDbType.NChar);
                paraMaHV.Value = MaHV;
                cmd.Parameters.Add(paraMaHV);

                SqlParameter paraMaTT = new SqlParameter("@MaTT", SqlDbType.NChar);
                paraMaTT.Value = MaTT;
                cmd.Parameters.Add(paraMaTT);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtMaHV.Text = reader.GetString(0);
                    txtMaTT.Text = reader.GetString(1);
                    txtNgayDK.Text = reader.GetDateTime(2).ToString("dd-MM-yyyy");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemChiTietDK_TT_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_ThemChiTietDK_TT";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@MaTT", SqlDbType.NChar).Value = txtMaTT.Text;
                
                DateTime ngayDK;
                if (DateTime.TryParseExact(txtNgayDK.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayDK))
                {
                    cmd.Parameters.Add("@NgayDK", SqlDbType.Date).Value = ngayDK;
                }
                else
                {
                    MessageBox.Show("Ngày thi không hợp lệ.");
                    return;
                }
                
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTinChiTietDK_TT();
                    ThongBaoTuTrigger();
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
                MessageBox.Show("Ngày đăng ký thi thử không hợp lệ!!!");
            }
        }

        private void ThongBaoTuTrigger()
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

        private void btnSuaChiTietDK_TT_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_CapNhatChiTietDK_TT";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@MaTT", SqlDbType.NChar).Value = txtMaTT.Text;

                DateTime ngayDK;
                if (DateTime.TryParseExact(txtNgayDK.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayDK))
                {
                    cmd.Parameters.Add("@NgayDK", SqlDbType.Date).Value = ngayDK;
                }
                else
                {
                    MessageBox.Show("Ngày thi không hợp lệ.");
                    return;
                }

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTinChiTietDK_TT();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaChiTietDK_TT_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_XoaChiTietDK_TT";
                cmd.Connection = conn;
                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@MaTT", SqlDbType.NChar).Value = txtMaTT.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTinChiTietDK_TT();
                    
                    txtMaHV.Clear();
                    txtMaTT.Clear();
                    txtNgayDK.Clear();
                    MessageBox.Show("Xoá thành công!");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!");
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
