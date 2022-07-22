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
    public partial class FrmCustomer : Form
    {
        bool tf, tf1;
        public FrmCustomer()
        {
            InitializeComponent();
            tf = tf1 = true;
            lock_unlock(tf);
            lock_unlock1(tf1);
        }
        BUS_Customer buscus = new BUS_Customer();
        void lock_unlock(bool tf)
        {
            butnew.Enabled = tf;
            butadd.Enabled = txtemail.Enabled = txtname.Enabled =txtphone.Enabled= !tf;
        }
        void lock_unlock1(bool tf1)
        {
            dgvCustomer.Enabled = tf1;
            butdelete.Enabled = txtemail.Enabled = txtname.Enabled =txtphone.Enabled= butupdate.Enabled = !tf1;
        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
           
            dgvCustomer.DataSource = buscus.getCustomers();
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            String name = txtname.Text;
            String phone = txtphone.Text;
            String email = txtemail.Text;
            bool kt = true;
            try { long sdt = long.Parse(phone); } catch { kt = false; }
            
            if (name == "" || phone == "" || email == "")
                MessageBox.Show("Please complete all information", "Note");
            else
            {
                if(!kt) MessageBox.Show("Phone number must be numeric characters", "Info");
                else if (buscus.checkemail(email)) MessageBox.Show("Email already exist", "Note");
                    else if (buscus.insert(name, phone, email))
                        {
                            dgvCustomer.DataSource = buscus.getCustomers();
                            txtemail.Text = txtname.Text = txtphone.Text = "";
                            txtname.Focus();
                            MessageBox.Show("Add success", "Info");
                        }else MessageBox.Show("Can not Add", "Info");

            }
        }

        private void FrmCustomer_Activated(object sender, EventArgs e)
        {
            txtname.Focus();
        }

        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            int i = dgvCustomer.CurrentRow.Index;
            txtname.Text = dgvCustomer[1, i].Value.ToString();
            txtphone.Text = dgvCustomer[2, i].Value.ToString();
            txtemail.Text = dgvCustomer[3, i].Value.ToString();
            if (tf)
            {
                tf1 = !tf1;
                lock_unlock1(tf1);

            }
            else MessageBox.Show("Adding \n please press reset to continue", "Note");

        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            String name = txtname.Text;
            String phone = txtphone.Text;
            String email = txtemail.Text;

            int i = dgvCustomer.CurrentRow.Index;
            long id = (long)dgvCustomer[0, i].Value;
            bool kt = true;
            //if(buscus.checkemail(email)) MessageBox.Show("Email already exist", "Note");
            try { long sdt = long.Parse(phone); } catch { kt = false; }

            if (name == "" || phone == "" || email == "")
                MessageBox.Show("Please complete all information", "Note");
            else
            {
                if (!kt) MessageBox.Show("Phone number must be numeric characters", "Info");
                else if (buscus.checkemail(id,email)) MessageBox.Show("Email already exist", "Note");
                else if (buscus.update(id,name,phone,email))
                        {
                            dgvCustomer.DataSource = buscus.getCustomers();
                            txtemail.Text = txtname.Text = txtphone.Text = "";
                            txtname.Focus();
                    
                            MessageBox.Show("Update success", "Info");
                            tf1 = !tf1;
                            lock_unlock1(tf1);
                        } else MessageBox.Show("Can not update", "Info");
            }
            
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            int i = dgvCustomer.CurrentRow.Index;
            if (i != null)
            {
                long id = (long)dgvCustomer[0, i].Value;
                if (buscus.delete(id))
                {
                    dgvCustomer.DataSource = buscus.getCustomers();
                    txtemail.Text = txtname.Text = txtphone.Text = "";
                    txtname.Focus();

                    MessageBox.Show("Delete success", "Info");
                    tf1 = !tf1;
                    lock_unlock1(tf1);
                }

            }
            else MessageBox.Show("please select customer before deleting", "Note");
        }

        private void butreset_Click(object sender, EventArgs e)
        {
            tf = tf1 = true;
            lock_unlock(tf);
            lock_unlock1(tf1);
            txtname.Text = txtemail.Text =txtphone.Text= "";
            txtname.Focus();
        }

        private void butclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butnew_Click(object sender, EventArgs e)
        {
            if (tf1)
            {
                tf = !tf;
                lock_unlock(tf);
                txtname.Text = txtemail.Text=txtphone.Text = "";
                txtname.Focus();
            }
            else MessageBox.Show("updating or deleting \n please press reset to continue", "Note");
        }
    }
}
