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
    public partial class ChiTiet_CaDay : Form
    {
        public ChiTiet_CaDay()
        {
            InitializeComponent();
        }

        private void ChiTiet_CaDay_Load(object sender, EventArgs e)
        {
            HienThiThongTinCTCaDay();
        }

        private void HienThiThongTinCTCaDay()
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ChiTiet_CaDay", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            lvCTCaDay.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                DateTime ngayBatDau = reader.GetDateTime(2);
                item.SubItems.Add(ngayBatDau.ToString("dd-MM-yyyy"));
                DateTime ngayKetThuc = reader.GetDateTime(3);
                item.SubItems.Add(ngayKetThuc.ToString("dd-MM-yyyy"));
                item.SubItems.Add(reader.GetString(4));

                lvCTCaDay.Items.Add(item);
            }
            reader.Close();
        }

        private void lvCTCaDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCTCaDay.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem liv = lvCTCaDay.SelectedItems[0];
            String malh = liv.SubItems[0].Text;
            String magv = liv.SubItems[1].Text;
            HienThiTheoMa(malh, magv);
        }

        private void HienThiTheoMa(string malh, string magv)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiTheoMaCTCaDay";
            cmd.Connection = conn;

            cmd.Parameters.Add("@malh", SqlDbType.Char).Value = malh;
            cmd.Parameters.Add("@magv", SqlDbType.Char).Value = magv;

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaLH.Text = reader.GetString(0);
                txtMaGV.Text = reader.GetString(1);
                DateTime ngayBatDau = reader.GetDateTime(2);
                txtNgayBD.Text = ngayBatDau.ToString("dd-MM-yyyy");
                DateTime ngayKetThuc = reader.GetDateTime(3);
                txtNgayKT.Text = ngayKetThuc.ToString("dd-MM-yyyy");
                txtCaDay.Text = reader.GetString(4);
            }
            reader.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThemCTCaDay";
            cmd.Connection = conn;

            cmd.Parameters.Add("@malh", SqlDbType.NChar).Value = txtMaLH.Text;
            cmd.Parameters.Add("@magv", SqlDbType.NChar).Value = txtMaGV.Text;
            DateTime ngayBatDau;
            if (DateTime.TryParseExact(txtNgayBD.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayBatDau))
            {
                cmd.Parameters.Add("@ngaybatdau", SqlDbType.Date).Value = ngayBatDau;
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu không hợp lệ. Vui lòng nhập theo định dạng dd-MM-yyyy.");
                return; // Không thực hiện truy vấn nếu ngày không hợp lệ.
            }
            DateTime ngayKetThuc;
            if (DateTime.TryParseExact(txtNgayKT.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayKetThuc))
            {
                cmd.Parameters.Add("@ngayketthuc", SqlDbType.Date).Value = ngayKetThuc;
            }
            else
            {
                MessageBox.Show("Ngày kết thúc không hợp lệ. Vui lòng nhập theo định dạng dd-MM-yyyy.");
                return; // Không thực hiện truy vấn nếu ngày không hợp lệ.
            }
            cmd.Parameters.Add("caday", SqlDbType.NChar).Value =txtCaDay.Text;

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                HienThiThongTinCTCaDay();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "XoaCTCaDay";
            cmd.Connection = conn;
            cmd.Parameters.Add("@malh", SqlDbType.Char).Value = txtMaLH.Text;
            cmd.Parameters.Add("@magv", SqlDbType.Char).Value = txtMaGV.Text;
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                HienThiThongTinCTCaDay();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SuaCTCaDay";
            cmd.Connection = conn;

            cmd.Parameters.Add("@malh", SqlDbType.NChar).Value = txtMaLH.Text;
            cmd.Parameters.Add("@magv", SqlDbType.NChar).Value = txtMaGV.Text;
            DateTime ngayBatDau;
            if (DateTime.TryParseExact(txtNgayBD.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayBatDau))
            {
                cmd.Parameters.Add("@ngaybatdau", SqlDbType.Date).Value = ngayBatDau;
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu không hợp lệ. Vui lòng nhập theo định dạng dd-MM-yyyy.");
                return; // Không thực hiện truy vấn nếu ngày không hợp lệ.
            }
            DateTime ngayKetThuc;
            if (DateTime.TryParseExact(txtNgayKT.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayKetThuc))
            {
                cmd.Parameters.Add("@ngayketthuc", SqlDbType.Date).Value = ngayKetThuc;
            }
            else
            {
                MessageBox.Show("Ngày kết thúc không hợp lệ. Vui lòng nhập theo định dạng dd-MM-yyyy.");
                return; // Không thực hiện truy vấn nếu ngày không hợp lệ.
            }
            cmd.Parameters.Add("caday", SqlDbType.NChar).Value = txtCaDay.Text;

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                HienThiThongTinCTCaDay();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }
    }
}
