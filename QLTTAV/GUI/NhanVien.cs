using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace GUI
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            HienThiThongTinNhanVien();  
        }

        private void HienThiThongTinNhanVien()
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from vNhanVien", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            lvNhanVien.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetDouble(4).ToString());
                item.SubItems.Add(reader.GetString(5));
                if(!reader.IsDBNull(6))
                {
                    item.SubItems.Add(reader.GetString(6));
                }
                else
                {
                    item.SubItems.Add("");
                }
                item.SubItems.Add(reader.GetString(7));
                lvNhanVien.Items.Add(item);
            }
            reader.Close();
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem liv = lvNhanVien.SelectedItems[0];
            String manv = liv.SubItems[0].Text;
            HienThiTheoMaNV(manv);
        }

        private void HienThiTheoMaNV(string manv)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand(manv, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiTheoMaNV";
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@manv", SqlDbType.Char);
            para.Value = manv;
            cmd.Parameters.Add(para);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaNV.Text = reader.GetString(0);
                txtHoTen.Text = reader.GetString(1);
                txtCCCD.Text = reader.GetString(2);
                txtSoDT.Text = reader.GetString(3);
                txtLuong.Text = reader.GetDouble(4).ToString();
                txtMaCN.Text = reader.GetString(5);              
                if (!reader.IsDBNull(6))
                {
                    txtMaQL.Text = reader.GetString(6);
                }
                else
                {
                    txtMaQL.Text = "";
                }
                txtMaCV.Text = reader.GetString(7);
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
                cmd.CommandText = "ThemNhanVien";
                cmd.Connection = conn;

                cmd.Parameters.Add("@manv", SqlDbType.NChar).Value = txtMaNV.Text;
                cmd.Parameters.Add("@hotennv", SqlDbType.NVarChar).Value = txtHoTen.Text;
                cmd.Parameters.Add("@cccd", SqlDbType.NChar).Value = txtCCCD.Text;
                cmd.Parameters.Add("@sodt", SqlDbType.NChar).Value = txtSoDT.Text;
                cmd.Parameters.Add("@luong", SqlDbType.Float).Value = float.Parse(txtLuong.Text);
                cmd.Parameters.Add("macn", SqlDbType.NChar).Value = txtMaCN.Text;
                if (txtMaQL.Text == "")
                {
                    cmd.Parameters.Add("maql", SqlDbType.NChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("maql", SqlDbType.NChar).Value = txtMaQL.Text;
                }
                cmd.Parameters.Add("macv", SqlDbType.NChar).Value = txtMaCV.Text;


                int n = cmd.ExecuteNonQuery();

                if (n > 0)
                {
                    HienThiThongTinNhanVien();
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
                cmd.CommandText = "XoaNhanVien";
                cmd.Connection = conn;
                cmd.Parameters.Add("@manv", SqlDbType.NChar).Value = txtMaNV.Text;
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTinNhanVien();
                    MessageBox.Show("Xóa thành công");
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
                cmd.CommandText = "SuaNhanVien";
                cmd.Connection = conn;

                cmd.Parameters.Add("@manv", SqlDbType.NChar).Value = txtMaNV.Text;
                cmd.Parameters.Add("@hotennv", SqlDbType.NVarChar).Value = txtHoTen.Text;
                cmd.Parameters.Add("@cccd", SqlDbType.NChar).Value = txtCCCD.Text;
                cmd.Parameters.Add("@sodt", SqlDbType.NChar).Value = txtSoDT.Text;
                cmd.Parameters.Add("@luong", SqlDbType.Float).Value = float.Parse(txtLuong.Text);
                cmd.Parameters.Add("macn", SqlDbType.NChar).Value = txtMaCN.Text;
                if (txtMaQL.Text == "")
                {
                    cmd.Parameters.Add("maql", SqlDbType.NChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("maql", SqlDbType.NChar).Value = txtMaQL.Text;
                }
                cmd.Parameters.Add("macv", SqlDbType.NChar).Value = txtMaCV.Text;
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTinNhanVien();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            if (txtTimMaNV.Text == "" && txtTimTenNV.Text == "")
            {
                HienThiThongTinNhanVien();
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TimKiemNhanVien";
                cmd.Connection = conn;
                if (txtTimMaNV.Text == "" && txtTimTenNV.Text != "")
                {
                    cmd.Parameters.Add("@tennv", SqlDbType.NVarChar).Value = txtTimTenNV.Text;
                }
                else if(txtTimMaNV.Text != "" && txtTimTenNV.Text == "")
                    cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = txtTimMaNV.Text;
                else
                {
                    cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = txtTimMaNV.Text;
                    cmd.Parameters.Add("@tennv", SqlDbType.NVarChar).Value = txtTimTenNV.Text;
                }
                SqlDataReader reader = cmd.ExecuteReader();
                lvNhanVien.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetString(2));
                    item.SubItems.Add(reader.GetString(3));
                    item.SubItems.Add(reader.GetDouble(4).ToString());
                    item.SubItems.Add(reader.GetString(5));
                    if (!reader.IsDBNull(6))
                    {
                        item.SubItems.Add(reader.GetString(6));
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }
                    item.SubItems.Add(reader.GetString(7));
                    lvNhanVien.Items.Add(item);
                }
                reader.Close();
            } 
        }
    }
}

