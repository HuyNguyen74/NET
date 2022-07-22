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
    public partial class FrmLogin : Form
    {
        BUS_Admin busad = new BUS_Admin();
        public FrmLogin()
        {
            
            InitializeComponent();
            
        }
        
        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpass.Checked)
            {
                txtpass.PasswordChar = (char)0;
                
            }
            else txtpass.PasswordChar = '*';
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtpass.Focus();
        }

        private void FrmLogin_Activated(object sender, EventArgs e)
        {
            txtname.Focus();
        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "") MessageBox.Show("username not empty", "error");
            else if (txtpass.Text == "") MessageBox.Show("password not empty", "error");
           else if (busad.ktDn(txtname.Text, txtpass.Text))
            {
                Mysave.KT = !Mysave.KT;
                //new Admin(txtname.Text, txtpass.Text);
                Admin.Us = txtname.Text;
                Admin.Pass = txtpass.Text;
                MessageBox.Show("Login Success","Info");
                Close();
            }
            else MessageBox.Show("Username or password not correct", "error");

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void butclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
