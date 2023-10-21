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

namespace TTQLAV
{
    public partial class ChiNhanh : Form
    {
        
        public ChiNhanh()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strCon = @"Data Source=ADMIN-PC;Initial Catalog=QL_TTANHNGU;User ID=sa; pwd=Nguyentam_@1984";

        private void ChiNhanh_Load(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(strCon);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from ChiNhanh", conn);
            
            SqlDataReader reader = cmd.ExecuteReader();
            lvChiNhanh.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                lvChiNhanh.Items.Add(item);
            }

            reader.Close();
        }

        private void lvChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtMaCN_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnXoa(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
