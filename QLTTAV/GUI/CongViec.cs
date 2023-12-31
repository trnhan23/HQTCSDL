﻿using DAL;
using DTO;
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
    public partial class CongViec : Form
    {
        public CongViec()
        {
            InitializeComponent();
        }

        private void CongViec_Load(object sender, EventArgs e)
        {
            HienThiThongTinCongViec();
        }

        private void HienThiThongTinCongViec()
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from CongViec", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            lvCongViec.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                lvCongViec.Items.Add(item);
            }
            reader.Close();
        }

        private void lvCongViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCongViec.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem liv = lvCongViec.SelectedItems[0];
            String macv = liv.SubItems[0].Text;
            HienThiTheoMaCV(macv);
        }

        private void HienThiTheoMaCV(string macv)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand(macv, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiTheoMaCV";
            cmd.Connection = conn;
            SqlParameter para = new SqlParameter("@macv", SqlDbType.Char);
            para.Value = macv;
            cmd.Parameters.Add(para);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaCV.Text = reader.GetString(0);
                txtTenCV.Text = reader.GetString(1);
            }
            reader.Close();
          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThemCongViec";
            cmd.Connection = conn;

            cmd.Parameters.Add("@macv", SqlDbType.NChar).Value = txtMaCV.Text;
            cmd.Parameters.Add("@tencv", SqlDbType.NVarChar).Value = txtTenCV.Text;
           
            int n = cmd.ExecuteNonQuery();

            if (n > 0)
            {
                HienThiThongTinCongViec();
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
            cmd.CommandText = "XoaCongViec";
            cmd.Connection = conn;
            cmd.Parameters.Add("@macv", SqlDbType.NChar).Value = txtMaCV.Text;
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                HienThiThongTinCongViec();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SuaCongViec";
            cmd.Connection = conn;

            cmd.Parameters.Add("@macv", SqlDbType.NChar).Value = txtMaCV.Text;
            cmd.Parameters.Add("@tencv", SqlDbType.NVarChar).Value = txtTenCV.Text;
            
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                HienThiThongTinCongViec();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }
    }
}
