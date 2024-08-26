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
    public partial class frmSearchCarDetails : Form
    {
        public frmSearchCarDetails()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select CarModel, GiyarSystem, CarColour, CarPrice from tblManageCarDetails where CarID=@idpar",con);
            cmd.Parameters.AddWithValue("idpar", txtCarID.Text.Trim());
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtCarModel.Text = rd["CarModel"].ToString();
                txtGiyarSystem.Text = rd["GiyarSystem"].ToString();
                txtCarColour.Text = rd["CarColour"].ToString();
                txtCarPrice.Text = rd["CarPrice"].ToString();
            }
            else
            {
                txtCarModel.Text = "";
                txtGiyarSystem.Text = "";
                txtCarColour.Text = "";
                txtCarPrice.Text = "";
                 MessageBox.Show("No data found....", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer fh = new frmCustomer();
            fh.Show();
            this.Hide();
        }
    }
}
