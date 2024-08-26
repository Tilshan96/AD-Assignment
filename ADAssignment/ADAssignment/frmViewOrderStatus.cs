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
    public partial class frmViewOrderStatus : Form
    {
        public frmViewOrderStatus()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer fh = new frmCustomer();
            fh.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CustomerNic, VehicalNumber, OrderPrice, OrderStatus from tblManageCustomerOrderDetails where OrderID=@idpar", con);
            cmd.Parameters.AddWithValue("idpar", txtOrderID.Text.Trim());
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtCustomerNIC.Text = rd["CustomerNic"].ToString();
                txtVehicalNumber.Text = rd["VehicalNumber"].ToString();
                txtPrice.Text = rd["OrderPrice"].ToString();
                txtOrderStatus.Text = rd["OrderStatus"].ToString();
            }
            else
            {
                txtCustomerNIC.Text = "";
                txtVehicalNumber.Text = "";
                txtPrice.Text = "";
                txtOrderStatus.Text = "";
                MessageBox.Show("No data found....", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}
