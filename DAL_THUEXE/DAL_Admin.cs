using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL_THUEXE
{
    public class DAL_Admin:ConectDB
    {
        public bool ktDn(String us, String pass) 
        {
            // SqlDataAdapter da = new SqlDataAdapter("Select * From Student", con);
            string qr = string.Format("select * from Admin where tendn='{0}' and mk= '{1}' and tt=1", us, pass);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);

                // cmd.ExecuteNonQuery();
                SqlDataReader da = cmd.ExecuteReader();

                if (da.Read() == true)
                {
                    con.Close();
                    return true;
                }

                else { con.Close(); return false; }

            }
            catch (Exception e)
            {
                return false;
            }

        }
        public bool update(String us,String pass)
        {
            try {
                string qr = string.Format("Update admin set mk='{0}' Where tendn='{1}'",pass,us);
                con.Open();
                SqlCommand cmd = new SqlCommand(qr,con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch {
                con.Close();
                return false;
            }
        }
    }
}
