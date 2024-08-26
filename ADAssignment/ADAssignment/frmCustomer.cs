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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister fh = new frmRegister();
            fh.Show();
            this.Hide();
        }

        private void btnSearchCarDetails_Click(object sender, EventArgs e)
        {
            frmSearchCarDetails fh = new frmSearchCarDetails();
            fh.Show();
            this.Hide();
        }

        private void btnSearchCarPartsDetails_Click(object sender, EventArgs e)
        {
            frmSearchCarPartsDetails fh = new frmSearchCarPartsDetails();
            fh.Show();
            this.Hide();
        }

        private void btnOrderCarorCarParts_Click(object sender, EventArgs e)
        {
            frmOrderCarorCarParts fh = new frmOrderCarorCarParts();
            fh.Show();
            this.Hide();
        }

        private void btnViewOrderStatus_Click(object sender, EventArgs e)
        {
            frmViewOrderStatus fh = new frmViewOrderStatus();
            fh.Show();
            this.Hide();
        }
    }
}
