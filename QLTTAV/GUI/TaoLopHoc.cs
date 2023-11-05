using DAL;
using DTO;
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
    public partial class TaoLopHoc : Form
    {
        public TaoLopHoc()
        {
            InitializeComponent();
        }
        private void TaoLopHoc_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from TaoLopHoc", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            lvTaoLopHoc.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                DateTime ngayTao = reader.GetDateTime(2);
                item.SubItems.Add(ngayTao.ToString("dd-MM-yyyy"));

                lvTaoLopHoc.Items.Add(item);
            }
            reader.Close();
        }

        private void lvTaoLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaoLopHoc.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem liv = lvTaoLopHoc.SelectedItems[0];
            String maql = liv.SubItems[0].Text;
            String malh = liv.SubItems[1].Text;
            HienThiTheoMa(maql, malh);
        }

        private void HienThiTheoMa(string maql, string malh)
        {

            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiTheoMa";
            cmd.Connection = conn;

            cmd.Parameters.Add("@maql", SqlDbType.Char).Value = maql;
            cmd.Parameters.Add("@malh", SqlDbType.Char).Value = malh;

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaQL.Text = reader.GetString(0);
                txtMaLH.Text = reader.GetString(1);
                DateTime ngayTao = reader.GetDateTime(2);
                txtNgayTao.Text = ngayTao.ToString("dd-MM-yyyy");
            }
            reader.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemTaoLopHoc";
                cmd.Connection = conn;

                cmd.Parameters.Add("@maql", SqlDbType.NChar).Value = txtMaQL.Text;
                cmd.Parameters.Add("@malh", SqlDbType.NChar).Value = txtMaLH.Text;
                DateTime ngayTao;
                if (DateTime.TryParseExact(txtNgayTao.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayTao))
                {
                    cmd.Parameters.Add("@ngaytao", SqlDbType.Date).Value = ngayTao;
                }
                else
                {
                    MessageBox.Show("Ngày tạo không hợp lệ. Vui lòng nhập theo định dạng dd-MM-yyyy.");
                    return; // Không thực hiện truy vấn nếu ngày không hợp lệ.
                }
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTin();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
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
                cmd.CommandText = "XoaTaoLopHoc";
                cmd.Connection = conn;
                cmd.Parameters.Add("@maql", SqlDbType.Char).Value = txtMaQL.Text;
                cmd.Parameters.Add("@malh", SqlDbType.Char).Value = txtMaLH.Text;
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTin();
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
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
                cmd.CommandText = "SuaTaoLopHoc";
                cmd.Connection = conn;
                cmd.Parameters.Add("@maql", SqlDbType.NChar).Value = txtMaQL.Text;
                cmd.Parameters.Add("malh", SqlDbType.NChar).Value = txtMaLH.Text;
                DateTime ngayTao;
                if (DateTime.TryParseExact(txtNgayTao.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayTao))
                {
                    cmd.Parameters.Add("@ngaytao", SqlDbType.Date).Value = ngayTao;
                }
                else
                {
                    MessageBox.Show("Ngày tạo không hợp lệ. Vui lòng nhập theo định dạng dd-MM-yyyy.");
                    return; // Không thực hiện truy vấn nếu ngày không hợp lệ.
                }
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTin();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
