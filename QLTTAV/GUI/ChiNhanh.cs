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
using DTO;
using DAL;

namespace GUI
{
    public partial class ChiNhanh : Form
    {
        public ChiNhanh()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

           
        }

       

        private void ChiNhanh_Load(object sender, EventArgs e)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
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
    }
}
