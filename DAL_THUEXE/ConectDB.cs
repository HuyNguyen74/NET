using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DAL_THUEXE
{
    public class ConectDB
    {
        public static SqlConnection con = new SqlConnection("Server=HUYNGUYEN;uid=sa;pwd=123;database=ThueXeDB");
    }
}
