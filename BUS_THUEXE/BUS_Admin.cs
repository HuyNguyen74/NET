using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_THUEXE;
namespace BUS_THUEXE
{
    public class BUS_Admin
    {
        DAL_Admin da = new DAL_Admin();
        public bool ktDn(String us, String pass)
        {
            return da.ktDn(us, pass);
        }
        public bool update(String us, String pass)
        {
            return da.update(us, pass);
        }
    }
}
