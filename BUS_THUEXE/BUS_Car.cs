using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_THUEXE;
using System.Data;
namespace BUS_THUEXE
{
    public class BUS_Car
    {
        DAL_Car dacar = new DAL_Car();
        public DataTable getCars()
        {
            return dacar.getCars();
        }
        public DataTable getCars(long makh)
        {
            return dacar.getCars(makh);
        }
        public DataTable getCars(String name,String bs)
        {
            return dacar.getCars(name,bs);
        }
        public bool insert(String name, String bienso, long makh)
        {
            return dacar.insert(name, bienso, makh);
        }
        public bool checkbs(String bs)
        {
            DataTable dacar = getCars();
            for (int i = 0; i < dacar.Rows.Count; i++)
                if (dacar.Rows[i]["bienso"].ToString().ToLower().Equals(bs.ToLower()))
                    return true;
            return false;
        }
        public bool update(long id, String name, String bienso, long makh)
        {
            return dacar.update(id, name, bienso, makh);
        }
        public bool delete(long id)
        {
            return dacar.delete(id);
        }
    }
}
