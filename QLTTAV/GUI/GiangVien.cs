﻿using DAL;
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

namespace GUI
{
    public partial class GiangVien : Form
    {
        public GiangVien()
        {
            InitializeComponent();
        }

        private void GiangVien_Load(object sender, EventArgs e)
        {
            HienThiThongTinGiangVien();
        }

        private void HienThiThongTinGiangVien()
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * From v_GiangVien", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                livGiangVien.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetString(0));
                    lvi.SubItems.Add(reader.GetString(1));
                    lvi.SubItems.Add(reader.GetString(2));
                    lvi.SubItems.Add(reader.GetString(3));
                    
                    Double Luong = reader.GetDouble(4);
                    lvi.SubItems.Add(Luong + "");
                    
                    livGiangVien.Items.Add(lvi);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void livGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (livGiangVien.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem liv = livGiangVien.SelectedItems[0];
            String MaGV = liv.SubItems[0].Text;
            HienThiTheoMaGV(MaGV);
        }

        private void HienThiTheoMaGV(string MaGV)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand(MaGV, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_HienThiTheoMaGV";
                cmd.Connection = conn;
                SqlParameter para = new SqlParameter("@MaGV", SqlDbType.Char);
                para.Value = MaGV;
                cmd.Parameters.Add(para);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMaGV.Text = reader.GetString(0);
                    txtHoTen.Text = reader.GetString(1);
                    txtCCCD.Text = reader.GetString(2);
                    txtSoDT.Text = reader.GetString(3);
                    Double Luong = reader.GetDouble(4);
                    txtLuong.Text = Luong+"";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_ThemGiangVien";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaGV", SqlDbType.NChar).Value = txtMaGV.Text;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = txtHoTen.Text;
                cmd.Parameters.Add("@CCCD", SqlDbType.NChar).Value = txtCCCD.Text;
                cmd.Parameters.Add("@SoDT", SqlDbType.NChar).Value = txtSoDT.Text;
                cmd.Parameters.Add("@Luong", SqlDbType.Float).Value = txtLuong.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTinGiangVien();
                    MessageBox.Show("Thêm thành công!");
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

        private void btnCapNhatGV_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_CapNhatGiangVien";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaGV", SqlDbType.NChar).Value = txtMaGV.Text;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = txtHoTen.Text;
                cmd.Parameters.Add("@CCCD", SqlDbType.NChar).Value = txtCCCD.Text;
                cmd.Parameters.Add("@SoDT", SqlDbType.NChar).Value = txtSoDT.Text;
                cmd.Parameters.Add("@Luong", SqlDbType.Float).Value = txtLuong.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTinGiangVien();
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

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pr_XoaGiangVien";
                cmd.Connection = conn;
                cmd.Parameters.Add("@MaGV", SqlDbType.NChar).Value = txtMaGV.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTinGiangVien();
                    txtMaGV.Clear();
                    txtHoTen.Clear();
                    txtCCCD.Clear();
                    txtSoDT.Clear();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();
                if (txtTimMaGV.Text == "" && txtTimHoTen.Text == "")
                {
                    HienThiThongTinGiangVien();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "pr_TimKiemGiangVien";
                    cmd.Connection = conn;

                    if (txtTimMaGV.Text == "" && txtTimHoTen.Text != "")
                        cmd.Parameters.Add("@HoTen", SqlDbType.NChar).Value = txtTimHoTen.Text;
                    else if (txtTimMaGV.Text != "" && txtTimHoTen.Text == "")
                        cmd.Parameters.Add("@MaGV", SqlDbType.NVarChar).Value = txtTimMaGV.Text;
                    else
                    {
                        cmd.Parameters.Add("@MaGV", SqlDbType.NChar).Value = txtTimMaGV.Text;
                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = txtTimHoTen.Text;
                    }

                    txtMaGV.Clear();
                    txtHoTen.Clear();
                    txtCCCD.Clear();
                    txtSoDT.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();
                    livGiangVien.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(reader.GetString(0));
                        lvi.SubItems.Add(reader.GetString(1));
                        lvi.SubItems.Add(reader.GetString(2));
                        lvi.SubItems.Add(reader.GetString(3));

                        Double Luong = reader.GetDouble(4);
                        lvi.SubItems.Add(Luong + "");

                        livGiangVien.Items.Add(lvi);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTimMaGV.Clear();
            txtTimHoTen.Clear();
            HienThiThongTinGiangVien();
        }
    }
}
