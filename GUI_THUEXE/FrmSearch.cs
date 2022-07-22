using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_THUEXE;
using System.Windows.Forms;

namespace GUI_THUEXE
{
    public partial class FrmSearch : Form
    {
        BUS_Customer buscus = new BUS_Customer();
        BUS_Car buscar = new BUS_Car();
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            rdcustomer.Checked = true;
            rdcar.Checked = false;
        }

        private void butfind_Click(object sender, EventArgs e)
        {
            if (rdcustomer.Checked)
            {
                if (buscus.getCustomers(txtname.Text).Rows.Count > 0) dgvCustomer.DataSource = buscus.getCustomers(txtname.Text);
                else MessageBox.Show("Not Found", "Info");
            }else if (rdcar.Checked)
            {
                if(buscar.getCars(txtcarname.Text,txtlicense.Text).Rows.Count>0)
                {
                    MessageBox.Show("Found complete", "Info");
                    dgvCustomer.DataSource = buscar.getCars(txtcarname.Text, txtlicense.Text);
                    txtcarname.Text = txtlicense.Text = "";
                    txtcarname.Focus();
                }
                else
                {
                    MessageBox.Show("Not Found", "Info");
                 
                    txtcarname.Text = txtlicense.Text = "";
                    txtcarname.Focus();
                }
            }
        }

        private void rdcustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdcustomer.Checked)
            {
                grbcustomer.Visible = true;
                grbcar.Visible = false;
                dgvCustomer.DataSource = buscus.getCustomers(txtname.Text);
            }
        }

        private void rdcar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdcar.Checked)
            {
                grbcar.Visible = true;
                grbcustomer.Visible = false;
                dgvCustomer.DataSource =buscar.getCars(txtcarname.Text,txtlicense.Text);
            }
        }
    }
}
