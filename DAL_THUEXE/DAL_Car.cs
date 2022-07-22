using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_THUEXE
{
   public class DAL_Car: ConectDB
    {
        public DataTable getCars()
        {
            string qr = string.Format("Select * From xe");
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            DataTable dacar = new DataTable();
            da.Fill(dacar);
            dacar.Columns.Add("Ord");
            for (int i = 1; i <= dacar.Rows.Count; i++)
                dacar.Rows[i - 1]["Ord"] = i.ToString();
            con.Close();
            return dacar;
        }
        public DataTable getCars(long makh)
        {
            string qr = string.Format("Select * From xe where makh='{0}'", makh);
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            DataTable dacar = new DataTable();
            da.Fill(dacar);
            dacar.Columns.Add("Ord");
            for (int i = 1; i <= dacar.Rows.Count; i++)
                dacar.Rows[i - 1]["Ord"] = i.ToString();
            con.Close();
            return dacar;
        }
        public DataTable getCars(String name,String bs)
        {
            string qr = string.Format("Select k.*,x.tenxe,x.bienso From khachhang as k right join xe as x on k.makh=x.makh where tenxe like '%{0}%' and bienso like '%{1}%'", name,bs);
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            DataTable dacar = new DataTable();
            da.Fill(dacar);
            dacar.Columns.Add("Ord");
            for (int i = 1; i <= dacar.Rows.Count; i++)
                dacar.Rows[i - 1]["Ord"] = i.ToString();
            con.Close();
            return dacar;
        }
        public bool insert(String name, String bienso, long makh)
        {
            string qr = string.Format("if(not exists(select * from xe where bienso='{0}'))" +
                "Insert into xe(tenxe,bienso,makh) values('{1}','{2}','{3}')", bienso, name, bienso, makh);
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
        public bool update(long id, String name, String bienso, long makh)
        {
            string qr = string.Format("if(not exists(select * from xe where bienso='{0}'and maxe !='{1}'))" +
                "update xe set tenxe='{2}',bienso='{3}',makh='{4}' where maxe='{5}'", bienso, id, name, bienso, makh,id);
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
            string qr = string.Format("delete from xe where maxe='{0}'", id);
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
