using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADAssignment
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Monishka" && txtPassword.Text == "963384335V")
            {
                frmAdmin fh = new frmAdmin();
                fh.Show();
                this.Hide();
            }
            else if (txtUserName.Text == "Customer" && txtPassword.Text == "cust123")
            {
                frmCustomer fh = new frmCustomer();
                fh.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please check your username & password....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
