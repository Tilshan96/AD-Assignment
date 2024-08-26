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
    public partial class frmManageCarPartsDetails : Form
    {
        public frmManageCarPartsDetails()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPartID.Text = "";
            txtPartName.Text = "";
            txtPartPrice.Text = "";
            txtPartQuality.Text = "";
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd= new SqlCommand("insert into tblManageCarPartsDetails values (@PartID, @PartName, @PartPrice, @PartQuality)", con);
            cmd.Parameters.AddWithValue("@PartID", (txtPartID.Text));
            cmd.Parameters.AddWithValue("@PartName", (txtPartName.Text));
            cmd.Parameters.AddWithValue("@PartPrice", (txtPartPrice.Text));
            cmd.Parameters.AddWithValue("@PartQuality", (txtPartQuality.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Saved Successfully....", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblManageCarPartsDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update tblManageCarPartsDetails set  PartName=@PartName, PartPrice=@PartPrice, PartQuality=@PartQuality where PartID=@PartID", con);
            cmd.Parameters.AddWithValue("@PartID", (txtPartID.Text));
            cmd.Parameters.AddWithValue("@PartName", (txtPartName.Text));
            cmd.Parameters.AddWithValue("@PartPrice", (txtPartPrice.Text));
            cmd.Parameters.AddWithValue("@PartQuality", (txtPartQuality.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Successfully....", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete tblManageCarPartsDetails where PartID=@PartID", con);
            cmd.Parameters.AddWithValue("@PartID", (txtPartID.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Successfully....", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void showData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblManageCarPartsDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void frmManageCarPartsDetails_Load(object sender, EventArgs e)
        {
            showData();
        }
        }
    }

