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
    public partial class frmSearchCarPartsDetails : Form
    {
        public frmSearchCarPartsDetails()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\manishka\Desktop\Esoft\Application Development\ADAssignment\ADAssignment\ApplicationDevelopment.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select PartName, PartPrice, PartQuality from tblManageCarPartsDetails where PartID=@idpar", con);
            cmd.Parameters.AddWithValue("idpar", txtPartID.Text.Trim());
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtPartName.Text = rd["PartName"].ToString();
                txtPartPrice.Text = rd["PartPrice"].ToString();
                txtPartQuality.Text = rd["PartQuality"].ToString();
            }
            else
            {
                txtPartName.Text = "";
                txtPartPrice.Text = "";
                txtPartQuality.Text = "";
                MessageBox.Show("No data found....", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
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
    }
}
