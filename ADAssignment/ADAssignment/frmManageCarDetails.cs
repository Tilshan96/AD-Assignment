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
    public partial class frmManageCarDetails : Form
    {
        public frmManageCarDetails()
        {
            InitializeComponent();
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            frmAdmin fh = new frmAdmin();
            fh.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCarID.Text = "";
            txtCarModel.Text = "";
            txtGiyarSystem.Text = "";
            txtCarColour.Text = "";
            txtCarPrice.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd= new SqlCommand("insert into tblManageCarDetails values (@CarID, @CarModel, @GiyarSystem, @CarColour, @CarPrice)", con);
            cmd.Parameters.AddWithValue("@CarID", (txtCarID.Text));
            cmd.Parameters.AddWithValue("@CarModel", (txtCarModel.Text));
            cmd.Parameters.AddWithValue("@GiyarSystem", (txtGiyarSystem.Text));
            cmd.Parameters.AddWithValue("@CarColour", (txtCarColour.Text));
            cmd.Parameters.AddWithValue("@CarPrice", (txtCarPrice.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved Successfully....", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblManageCarDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update tblManageCarDetails set  CarModel=@CarModel, GiyarSystem=@GiyarSystem, CarColour=@CarColour, CarPrice=@CarPrice where CarID=@CarID", con);
            cmd.Parameters.AddWithValue("@CarID", (txtCarID.Text));
            cmd.Parameters.AddWithValue("@CarModel", (txtCarModel.Text));
            cmd.Parameters.AddWithValue("@GiyarSystem", (txtGiyarSystem.Text));
            cmd.Parameters.AddWithValue("@CarColour", (txtCarColour.Text));
            cmd.Parameters.AddWithValue("@CarPrice", (txtCarPrice.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully....", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete tblManageCarDetails where CarID=@CarID", con);
            cmd.Parameters.AddWithValue("@CarID", (txtCarID.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully....", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* this is a method that create for add database data to the datagrid when the form loaded */
        private void showData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblManageCarDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void frmManageCarDetails_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
