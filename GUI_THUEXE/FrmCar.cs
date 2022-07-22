using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_THUEXE;
namespace GUI_THUEXE
{
    public partial class FrmCar : Form
    {
        bool tf, tf1;
        BUS_Car buscar = new BUS_Car();
        BUS_Customer buscus = new BUS_Customer();
        DataTable dtcar = new DataTable();
        public FrmCar()
        {
            InitializeComponent();
            tf = tf1 = true;
            lock_unlock(tf);
            lock_unlock1(tf1);
            dtcar = buscus.getCustomers();
        }
        void lock_unlock(bool tf)
        {
            butnew.Enabled = tf;
            butadd.Enabled = txtlicense.Enabled = txtname.Enabled = !tf;
        }
        void lock_unlock1(bool tf1)
        {
            dgvCar.Enabled = tf1;
            butdelete.Enabled = txtname.Enabled = txtlicense.Enabled = butupdate.Enabled = !tf1;
        }
        private void FrmCar_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < dtcar.Rows.Count; i++)
            {
                String kh = dtcar.Rows[i]["tenkh"].ToString()+"( ID="+ dtcar.Rows[i]["makh"].ToString()+" )";
                cmbcustomer.Items.Add(kh);
            }
            cmbcustomer.Text = dtcar.Rows[0]["tenkh"].ToString() + "( ID=" + dtcar.Rows[0]["makh"].ToString() + " )";
            dgvCar.DataSource = buscar.getCars((long)dtcar.Rows[0]["makh"]);
        }

        private void butnew_Click(object sender, EventArgs e)
        {
            if (tf1)
            {
                tf = !tf;
                lock_unlock(tf);
                txtname.Text = txtlicense.Text =  "";
                txtname.Focus();
            }
            else MessageBox.Show("updating or deleting \n please press reset to continue", "Note");
        }

        private void butreset_Click(object sender, EventArgs e)
        {
            tf = tf1 = true;
            lock_unlock(tf);
            lock_unlock1(tf1);
            txtname.Text = txtlicense.Text  = "";
            txtname.Focus();
        }

        private void butclose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void cmbcustomer_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show(dtcar.Rows[ cmbcustomer.SelectedIndex]["email"].ToString());
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            String name = txtname.Text;
            String bs = txtlicense.Text;
            long makh = (long)dtcar.Rows[cmbcustomer.SelectedIndex]["makh"];
            if (name==""||bs=="") MessageBox.Show("Please complete all information", "Note");
            else if(buscar.checkbs(bs)) MessageBox.Show("license plate already exists", "Note");
            else if (buscar.insert(name, bs, makh))
            {
                MessageBox.Show("Add success", "info");
                dgvCar.DataSource = buscar.getCars(makh);
                txtlicense.Text = txtname.Text = "";
                txtname.Focus();
            }else MessageBox.Show("Can not add", "info");

        }

        private void dgvCar_Click(object sender, EventArgs e)
        {
            int i = dgvCar.CurrentRow.Index;
            txtname.Text = dgvCar[1,i].Value.ToString();
            txtlicense.Text= dgvCar[2, i].Value.ToString();
            if (tf)
            {
                tf1 = !tf1;
                lock_unlock1(tf1);

            }
            else MessageBox.Show("Adding \n please press reset to continue", "Note");

        }



        private void cmbcustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please complete all information", "Note");
        }

        private void cmbcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Please complete all information", "Note");
        }

        private void cmbcustomer_MouseClick(object sender, MouseEventArgs e)
        {
            long makh=(long)dtcar.Rows[cmbcustomer.SelectedIndex]["makh"];
            dgvCar.DataSource = buscar.getCars(makh);
        }

        private void cmbcustomer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            long makh = (long)dtcar.Rows[cmbcustomer.SelectedIndex]["makh"];
            dgvCar.DataSource = buscar.getCars(makh);
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            String name = txtname.Text;
            String bs = txtlicense.Text;
            long makh = (long)dtcar.Rows[cmbcustomer.SelectedIndex]["makh"];
            int i = dgvCar.CurrentRow.Index;
            long id =(long) dgvCar[0, i].Value;
            if (makh != null)
            {
                if(id!=null)
                {
                    if (buscar.update(id, name, bs, makh))
                    {
                        MessageBox.Show("Update success", "info");
                        dgvCar.DataSource = buscar.getCars(makh);
                        txtlicense.Text = txtname.Text = "";
                        txtname.Focus();
                        tf1 = !tf1;
                        lock_unlock1(tf1);
                    }else MessageBox.Show("Can not update", "Note");
                }else MessageBox.Show("Please select car", "Note");
            }
            else MessageBox.Show("Please select customer", "Note");
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            int i = dgvCar.CurrentRow.Index;
            long id = (long)dgvCar[0, i].Value;
            if(id!=null)
            {
                if (buscar.delete(id))
                {
                    MessageBox.Show("Delete success", "info");
                    long makh = (long)dtcar.Rows[cmbcustomer.SelectedIndex]["makh"];
                    dgvCar.DataSource = buscar.getCars(makh);
                    txtlicense.Text = txtname.Text = "";
                    txtname.Focus();
                    tf1 = !tf1;
                    lock_unlock1(tf1);
                }else MessageBox.Show("Can not delete", "info");
            }else MessageBox.Show("Please select car", "Note");
        }

        private void FrmCar_Activated(object sender, EventArgs e)
        {
            txtname.Focus();
        }

        
    }
}
