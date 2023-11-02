using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TTANHNGU
{
    public class SQLConnectionData
    {
        public static SqlConnection Connect()
        {
            string strCon = @"Data Source=NGANHOANG\DESKTOP_HN;Initial Catalog=QL_TTANHNGU;Persist Security Info=True;User ID=sa;Password=jcw05071987";
            SqlConnection conn = new SqlConnection(strCon);
            return conn;
        }
    }
}
