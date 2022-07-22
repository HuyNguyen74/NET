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
    public partial class Frmchangepass : Form
    {
        private String us;
        private String pass;

        public string Us { get => us; set => us = value; }
        public string Pass { get => pass; set => pass = value; }
        BUS_Admin busad = new BUS_Admin();
        public Frmchangepass(string us, string pass)
        {
            this.Us = us;
            this.Pass = pass;
            InitializeComponent();
        }

        public Frmchangepass()
        {
            InitializeComponent();
        }

        private void butchange_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "" || txtnewpass.Text == "")
            {
                MessageBox.Show("Please complete all information", "Note");
            }
            else
            {
                if (busad.ktDn(Us, txtpass.Text)&&txtpass.Text==Pass)
                {
                    if (busad.update(Us, txtnewpass.Text))
                    {

                        MessageBox.Show("Update success", "Info");
                        Close();
                    }else MessageBox.Show("Can not Update", "Info");

                }
                else { MessageBox.Show("Old password is not correct", "Info"); }
            }
        }

        private void Frmchangepass_Activated(object sender, EventArgs e)
        {
            txtname.Text = Us;
        }

        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpassnew.Checked)
            {
                txtnewpass.PasswordChar = (char)0;

            }
            else txtnewpass.PasswordChar = '*';
        }
    }
}
