using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SQLConnectionData
    {
        public static SqlConnection Connect()
        {
            
            string strCon = @"Data Source=LAPTOP-NJI5KN3O;Initial Catalog=QL_TTANHNGU;User ID=sa; pwd = ThuLai*1212";
            SqlConnection conn = new SqlConnection(strCon);
            return conn;
        }
    }
    public class DatabaseAccess
    {
       
    }
}
