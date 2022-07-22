using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_THUEXE;
using System.Data;
namespace BUS_THUEXE
{
    public class BUS_Customer
    {
        DAL_Customer dacus = new DAL_Customer();
        public DataTable getCustomers()
        {
            return dacus.getCustomers();
        }
        public DataTable getCustomers(String name)
        {
            return dacus.getCustomers(name);
        }
        public bool insert(String name, String phone, String email)
        {
            return dacus.insert(name, phone, email);
        }
        public bool update(long id, String name, String phone, String email)
        {
            return dacus.update(id, name, phone, email);
        }
        public bool delete(long id)
        {
            return dacus.delete(id);
        }
        public bool checkemail(long id ,String email)
        {
            DataTable dacus = getCustomers();
            for (int i = 0; i < dacus.Rows.Count; i++)
                if (dacus.Rows[i]["email"].ToString().ToLower().Equals(email.ToLower()) && (long)dacus.Rows[i]["makh"]!=id)
                    return true;

            return false;
        }
        public bool checkemail( String email)
        {
            DataTable dacus = getCustomers();
            for (int i = 0; i < dacus.Rows.Count; i++)
                if (dacus.Rows[i]["email"].ToString().ToLower().Equals(email.ToLower()) )
                    return true;

            return false;
        }
    }
}
