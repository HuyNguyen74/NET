using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_THUEXE
{
   public class DAL_Customer: ConectDB
    {
        public DataTable getCustomers()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From khachhang", con);
            DataTable dacus = new DataTable();
            da.Fill(dacus);
            dacus.Columns.Add("Ord");
            for (int i = 1; i <= dacus.Rows.Count; i++)
                dacus.Rows[i - 1]["Ord"] = i.ToString();
            con.Close();
            return dacus;
        }
        public DataTable getCustomers(String name)
        {
            string qr = string.Format("Select k.*,x.tenxe,x.bienso From khachhang as k left join xe as x on k.makh=x.makh where tenkh like'%{0}%'", name);
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            DataTable dacus = new DataTable();
            da.Fill(dacus);
            dacus.Columns.Add("Ord");
            for (int i = 1; i <= dacus.Rows.Count; i++)
                dacus.Rows[i - 1]["Ord"] = i.ToString();
            con.Close();
            return dacus;
        }
        public bool insert(String name,String phone,String email)
        {
            string qr = string.Format("if(not exists(select * from khachhang where email='{0}'))" +
                "Insert into khachhang(tenkh,sdt,email) values('{1}','{2}','{3}')",email ,name, phone,email);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);
                if (cmd.ExecuteNonQuery()>0) return true;
                
                con.Close();
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool update(long id,String name, String phone, String email)
        {
            string qr = string.Format("if(not exists(select * from khachhang where email='{0}'and makh !='{1}'))" +
                "update khachhang set tenkh='{2}',sdt='{3}',email='{4}' where makh='{5}'", email,id, name, phone, email,id);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);
                if (cmd.ExecuteNonQuery() > 0) return true;

                con.Close();
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool delete(long id)
        {
            string qr = string.Format("delete from khachhang where makh='{0}'",id);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(qr, con);
                if (cmd.ExecuteNonQuery() > 0) return true;

                con.Close();
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
