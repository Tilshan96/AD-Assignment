using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAssignment
{
    public partial class frmGenerateReports : Form
    {
        public frmGenerateReports()
        {
            InitializeComponent();
        }

        private void frmGenerateReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ApplicationDevelopmentDataSet.tblManageCustomerOrderDetails' table. You can move, or remove it, as needed.
            this.tblManageCustomerOrderDetailsTableAdapter.Fill(this.ApplicationDevelopmentDataSet.tblManageCustomerOrderDetails);

            this.reportViewer1.RefreshReport();
        }
    }
}
