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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer fh = new frmCustomer();
            fh.Show();
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCustomerNIC.Text = "";
            txtCustomerName.Text = "";
            txtCustomerTP.Text = "";
            txtCustomerAddress.Text = "";
            txtVehicalNumber.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblManageCustomerDetails values (@CustomerNic, @CustomerName, @CustomerTP, @CustomerAddress, @CustomerVehicalNumber)", con);
            cmd.Parameters.AddWithValue("@CustomerNic", (txtCustomerNIC.Text));
            cmd.Parameters.AddWithValue("@CustomerName", (txtCustomerName.Text));
            cmd.Parameters.AddWithValue("@CustomerTP", (txtCustomerTP.Text));
            cmd.Parameters.AddWithValue("@CustomerAddress", (txtCustomerAddress.Text));
            cmd.Parameters.AddWithValue("@CustomerVehicalNumber", (txtVehicalNumber.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved Successfully....", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblManageCustomerDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update tblManageCustomerDetails set  CustomerName=@CustomerName, CustomerTP=@CustomerTP, CustomerTP=@CustomerTP, CustomerAddress=@CustomerAddress where CustomerNic=@CustomerNic", con);
            cmd.Parameters.AddWithValue("@CustomerNic", (txtCustomerNIC.Text));
            cmd.Parameters.AddWithValue("@CustomerName", (txtCustomerName.Text));
            cmd.Parameters.AddWithValue("@CustomerTP", (txtCustomerTP.Text));
            cmd.Parameters.AddWithValue("@CustomerAddress", (txtCustomerAddress.Text));
            cmd.Parameters.AddWithValue("@CustomerVehicalNumber", (txtVehicalNumber.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully....", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete tblManageCustomerDetails where CarID=@CarID", con);
            cmd.Parameters.AddWithValue("@CustomerNic", (txtCustomerNIC.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully....", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblManageCustomerDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void frmRegister_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
