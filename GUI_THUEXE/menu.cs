using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_THUEXE
{
    public partial class menu : Form
    {
        public menu()
        {
            
            InitializeComponent();
            Lock_Unlock(Mysave.KT);
        }
        void Lock_Unlock(Boolean kt)
        {
            mnlogin.Enabled = kt;
            mncustomer.Enabled = mnsearch.Enabled = mnreport.Enabled = mnlogout.Enabled = mnchange.Enabled = !kt;
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin lg = new FrmLogin();
            lg.Show();
            Lock_Unlock(Mysave.KT);
        }

        private void menu_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(Mysave.KT);
        }

        private void mnlogout_Click(object sender, EventArgs e)
        {
            Mysave.KT = !Mysave.KT;
            Lock_Unlock(Mysave.KT);
        }

        private void mnchange_Click(object sender, EventArgs e)
        {
           
            Frmchangepass ch = new Frmchangepass(Admin.Us,Admin.Pass);
            ch.Show();
        }

        private void mnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mncus_Click(object sender, EventArgs e)
        {
            FrmCustomer cus = new FrmCustomer();
            cus.Show();
        }

        private void mncar_Click(object sender, EventArgs e)
        {
            FrmCar c = new FrmCar();
            c.Show();
        }

        private void mnsearch_Click(object sender, EventArgs e)
        {
            FrmSearch s = new FrmSearch();
            s.Show();
        }

        private void mnreport_Click(object sender, EventArgs e)
        {
            FrmReport r = new FrmReport();
            r.Show();
        }
    }
}
