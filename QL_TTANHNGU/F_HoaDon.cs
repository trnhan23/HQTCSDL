using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_TTANHNGU
{
    public partial class F_HoaDon : Form
    {
        public F_HoaDon()
        {
            InitializeComponent();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemHoaDon";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = txtMaHD.Text;
                cmd.Parameters.Add("@NgayGioGD", SqlDbType.Date).Value = txtNgayGiaoDich.Text;
                cmd.Parameters.Add("@SoTien", SqlDbType.Float).Value = txtSoTien.Text;
                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@MaLH", SqlDbType.NChar).Value = txtMaLH.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinHoaDon();
                    MessageBox.Show("Thêm thành công!");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                    conn.Close();
                }
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
                cmd.CommandText = "XoaHoaDon";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = txtMaHD.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinHoaDon();
                    txtMaHD.Clear();
                    txtNgayGiaoDich.Clear();
                    txtSoTien.Clear();
                    txtMaHV.Clear();
                    txtMaLH.Clear();
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
                cmd.CommandText = "SuaHoaDon";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = txtMaHD.Text;
                cmd.Parameters.Add("@NgayGD", SqlDbType.Date).Value = txtNgayGiaoDich.Text;
                cmd.Parameters.Add("@SoTien", SqlDbType.Float).Value = txtSoTien.Text;
                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@MaLH", SqlDbType.NChar).Value = txtMaLH.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinHoaDon();
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



        private void F_HoaDon_Load(object sender, EventArgs e)
        {
            ThongTinHoaDon();
        }

        private void ThongTinHoaDon()
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from v_HoaDon", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            lvHoaDon.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                DateTime ngayGiaoDich = reader.GetDateTime(1);
                item.SubItems.Add(ngayGiaoDich.ToString("dd-MM-yyyy"));
                item.SubItems.Add(reader.GetDouble(2) + "");
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetString(4));

                lvHoaDon.Items.Add(item);
            }

            reader.Close();

        }


        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem lv = lvHoaDon.SelectedItems[0];
            HienThiTTTheoMaHD(lv.SubItems[0].Text);
        }


        private void HienThiTTTheoMaHD(string MaHD)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand(MaHD, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "HienThiTTTheoMaHD";
                cmd.Connection = conn;


                SqlParameter para = new SqlParameter("@MaHD", SqlDbType.NChar);
                para.Value = MaHD;
                cmd.Parameters.Add(para);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMaHD.Text = reader.GetString(0);
                    DateTime ngayGiaoDich = reader.GetDateTime(1);
                    txtNgayGiaoDich.Text = ngayGiaoDich.ToString();
                    txtSoTien.Text = reader.GetDouble(2) + "";
                    txtMaHV.Text = reader.GetString(3);
                    txtMaLH.Text = reader.GetString(4);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();
                if (txtTimKiemMaHD.Text == "" && txtTimKiemMaHV.Text == "")
                {
                    ThongTinHoaDon();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "TimKiemHoaDon";
                    cmd.Connection = conn;

                    if (txtTimKiemMaHD.Text == "" && txtTimKiemMaHV.Text != "")
                        cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtTimKiemMaHV.Text;
                    else if (txtTimKiemMaHD.Text != "" && txtTimKiemMaHV.Text == "")
                        cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = txtTimKiemMaHD.Text;
                    else
                    {
                        cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = txtTimKiemMaHD.Text;
                        cmd.Parameters.Add("@MaHV", SqlDbType.NVarChar).Value = txtTimKiemMaHV.Text;
                    }

                    txtMaHD.Clear();
                    txtNgayGiaoDich.Clear();
                    txtSoTien.Clear();
                    txtMaHV.Clear();
                    txtMaLH.Clear();


                    SqlDataReader reader = cmd.ExecuteReader();
                    lvHoaDon.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader.GetString(0));
                        DateTime ngayGiaoDich = reader.GetDateTime(1);
                        item.SubItems.Add(ngayGiaoDich.ToString("dd-MM-yyyy"));
                        item.SubItems.Add(reader.GetDouble(2) + "");
                        item.SubItems.Add(reader.GetString(3));
                        item.SubItems.Add(reader.GetString(4));

                        lvHoaDon.Items.Add(item);
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiemMaHD_MouseCaptureChanged(object sender, EventArgs e)
        {
            txtTimKiemMaHD.Clear();
            txtTimKiemMaHD.ForeColor = Color.Black;
        }

        private void txtTimKiemMaHV_MouseCaptureChanged(object sender, EventArgs e)
        {
            txtTimKiemMaHV.Clear();
            txtTimKiemMaHV.ForeColor = Color.Black;
        }
    }
}
