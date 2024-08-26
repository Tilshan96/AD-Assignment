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
    public partial class frmManageCustomerOrderDetails : Form
    {
        public frmManageCustomerOrderDetails()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            frmAdmin fh = new frmAdmin();
            fh.Show();
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = "";
            txtCustomerNIC.Text = "";
            txtVehicalNumber.Text = "";
            txtPrice.Text = "";
            txtOrderStatus.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblManageCustomerOrderDetails values (@OrderID, @CustomerNic, @VehicalNumber, @OrderPrice, @OrderStatus)", con);
            cmd.Parameters.AddWithValue("@OrderID", (txtOrderID.Text));
            cmd.Parameters.AddWithValue("@CustomerNic", (txtCustomerNIC.Text));
            cmd.Parameters.AddWithValue("@VehicalNumber", (txtVehicalNumber.Text));
            cmd.Parameters.AddWithValue("@OrderPrice", (txtPrice.Text));
            cmd.Parameters.AddWithValue("@OrderStatus", (txtOrderStatus.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved Successfully....", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblManageCustomerOrderDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update tblManageCustomerOrderDetails set  CustomerNic=@CustomerNic, VehicalNumber=@VehicalNumber, OrderPrice=@OrderPrice, OrderStatus=@OrderStatus where OrderID=@OrderID", con);
            cmd.Parameters.AddWithValue("@OrderID", (txtOrderID.Text));
            cmd.Parameters.AddWithValue("@CustomerNic", (txtCustomerNIC.Text));
            cmd.Parameters.AddWithValue("@VehicalNumber", (txtVehicalNumber.Text));
            cmd.Parameters.AddWithValue("@OrderPrice", (txtPrice.Text));
            cmd.Parameters.AddWithValue("@OrderStatus", (txtOrderStatus.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully....", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete tblManageCustomerOrderDetails where OrderID=@OrderID", con);
            cmd.Parameters.AddWithValue("@OrderID", (txtOrderID.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully....", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblManageCustomerOrderDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand cmd1 = new SqlCommand("select * from tblOrderCarorParts", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }

        private void frmManageCustomerOrderDetails_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
