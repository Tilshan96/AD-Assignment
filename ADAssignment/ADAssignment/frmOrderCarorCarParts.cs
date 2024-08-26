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
    public partial class frmOrderCarorCarParts : Form
    {
        public frmOrderCarorCarParts()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = "";
            txtCustomerNIC.Text = "";
            txtVehicalNumber.Text = "";
            txtOrderType.Text = "";
            txtWantedParts.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblOrderCarorParts values (@OrderID, @CustomerNic, @VehicalNumber, @OrderType, @WantedParts)", con);
            cmd.Parameters.AddWithValue("@OrderID", (txtOrderID.Text));
            cmd.Parameters.AddWithValue("@CustomerNic", (txtCustomerNIC.Text));
            cmd.Parameters.AddWithValue("@VehicalNumber", (txtVehicalNumber.Text));
            cmd.Parameters.AddWithValue("@OrderType", (txtOrderType.Text));
            cmd.Parameters.AddWithValue("@WantedParts", (txtWantedParts.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved Successfully....", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblOrderCarorParts", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update tblOrderCarorParts set  CustomerNic=@CustomerNic, VehicalNumber=@VehicalNumber, OrderType=@OrderType, WantedParts=@WantedParts where OrderID=@OrderID", con);
            cmd.Parameters.AddWithValue("@OrderID", (txtOrderID.Text));
            cmd.Parameters.AddWithValue("@CustomerNic", (txtCustomerNIC.Text));
            cmd.Parameters.AddWithValue("@VehicalNumber", (txtVehicalNumber.Text));
            cmd.Parameters.AddWithValue("@OrderType", (txtOrderType.Text));
            cmd.Parameters.AddWithValue("@WantedParts", (txtWantedParts.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully....", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete tblOrderCarorParts where OrderID=@OrderID", con);
            cmd.Parameters.AddWithValue("@OrderID", (txtOrderID.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully....", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void showData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblOrderCarorParts", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void frmOrderCarorCarParts_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
