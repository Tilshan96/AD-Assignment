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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnManageCarDetails_Click(object sender, EventArgs e)
        {
            frmManageCarDetails fh = new frmManageCarDetails();
            fh.Show();
            this.Hide();
        }

        private void btnManageCustomerOrderDetails_Click(object sender, EventArgs e)
        {
            frmManageCustomerOrderDetails fh = new frmManageCustomerOrderDetails();
            fh.Show();
            this.Hide();
        }

        private void btnManageCustomerDetails_Click(object sender, EventArgs e)
        {
            frmManageCustomerDetails fh = new frmManageCustomerDetails();
            fh.Show();
            this.Hide();
        }

        private void btnManageCarPartsDetails_Click(object sender, EventArgs e)
        {
            frmManageCarPartsDetails fh = new frmManageCarPartsDetails();
            fh.Show();
            this.Hide();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            frmGenerateReports fh = new frmGenerateReports();
            fh.Show();
            this.Hide();
        }
    }
}
