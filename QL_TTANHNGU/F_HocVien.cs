using System.Data;
using System.Data.SqlClient;


namespace QL_TTANHNGU
{
    public partial class F_HocVien : Form
    {
        public F_HocVien()
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
                cmd.CommandText = "ThemHocVien";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@HoTenHV", SqlDbType.NVarChar).Value = txtHoTen.Text;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = txtNgaySinh.Text;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = txtGioiTinh.Text;
                cmd.Parameters.Add("@SoDT", SqlDbType.NChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@DiaChiHV", SqlDbType.NVarChar).Value = txtDiaChi.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinHocVien();
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
                cmd.CommandText = "XoaHocVien";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinHocVien();
                    txtMaHV.Clear();
                    txtHoTen.Clear();
                    txtNgaySinh.Clear();
                    txtGioiTinh.Clear();
                    txtSDT.Clear();
                    txtDiaChi.Clear();
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
                cmd.CommandText = "SuaHocVien";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@HoTenHV", SqlDbType.NVarChar).Value = txtHoTen.Text;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = txtNgaySinh.Text;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = txtGioiTinh.Text;
                cmd.Parameters.Add("@SoDT", SqlDbType.NChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@DiaChiHV", SqlDbType.NVarChar).Value = txtDiaChi.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinHocVien();
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

        private void F_HocVien_Load(object sender, EventArgs e)
        {
            ThongTinHocVien();
        }

        private void ThongTinHocVien()
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from v_HocVien", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            lvHocVien.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                DateTime ngaySinh = reader.GetDateTime(2);
                item.SubItems.Add(ngaySinh.ToString("dd-MM-yyyy"));
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetString(4));
                item.SubItems.Add(reader.GetString(5));
                lvHocVien.Items.Add(item);
            }

            reader.Close();

        }

        private void lvHocVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHocVien.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem lv = lvHocVien.SelectedItems[0];
            HienThiTTTheoMaHV(lv.SubItems[0].Text);
        }

        private void HienThiTTTheoMaHV(string MaHV)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand(MaHV, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "HienThiTTTheoMaHV";
                cmd.Connection = conn;


                SqlParameter para = new SqlParameter("@MaHV", SqlDbType.NChar);
                para.Value = MaHV;
                cmd.Parameters.Add(para);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMaHV.Text = reader.GetString(0);
                    txtHoTen.Text = reader.GetString(1);
                    DateTime ngaysinh = reader.GetDateTime(2);
                    txtNgaySinh.Text = ngaysinh.ToString();
                    txtGioiTinh.Text = reader.GetString(3);
                    txtSDT.Text = reader.GetString(4);
                    txtDiaChi.Text = reader.GetString(5);
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