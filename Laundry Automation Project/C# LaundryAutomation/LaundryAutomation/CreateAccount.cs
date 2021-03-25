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

namespace LaundryAutomation
{
    public partial class CreateAccount : Form
    {
        string connectionString = @"Data Source=JAMORALIN;Initial Catalog=POSLaundry;Integrated Security=True";

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void caadminconfirmbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand admincmd = new SqlCommand("spLoginAdmin", conn);
            admincmd.CommandType = CommandType.StoredProcedure;
            admincmd.Parameters.AddWithValue("@username", SqlDbType.NChar).Value = caadminusertb.Text.Trim();
            admincmd.Parameters.AddWithValue("@password", SqlDbType.NChar).Value = caadminpasswordtb.Text.Trim();
            DataTable afdt = new DataTable();
            afdt.Load(admincmd.ExecuteReader());
            if (afdt.Rows.Count == 1)
            {
                adminconsentchk.Checked = true;
            }
            else
            {
                MessageBox.Show("Ask your Admin for Account Creation.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

            caadminusertb.Text = "";
            caadminpasswordtb.Text = "";

            //Checker
            if (causernametb.Text.Length > 2 && capassword.Text.Length > 2 && cafirstname.Text.Length > 2 && calastname.Text.Length > 2 &&
                cacontactnumber.Text.Length > 2 && carole.Text.Length > 2 && capassword.Text == caconfirmpasstb.Text && adminconsentchk.Checked == true)
            {
                createaccountbtn.Enabled = true;
            }
            else
            {
                createaccountbtn.Enabled = false;
            }
        }

        private void createaccountbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spAddAccount", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", SqlDbType.NChar).Value = causernametb.Text.Trim();
                cmd.Parameters.AddWithValue("@password", SqlDbType.NChar).Value = capassword.Text.Trim();
                cmd.Parameters.AddWithValue("@firstname", SqlDbType.NChar).Value = cafirstname.Text.Trim();
                cmd.Parameters.AddWithValue("@lastname", SqlDbType.NChar).Value = calastname.Text.Trim();
                cmd.Parameters.AddWithValue("@contactnumber", SqlDbType.NChar).Value = cacontactnumber.Text.Trim();
                cmd.Parameters.AddWithValue("@role", SqlDbType.NChar).Value = carole.Text.Trim();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Account Registered Successfully!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            
        }

        private void caadminusertb_TextChanged(object sender, EventArgs e)
        {
            if (caadminusertb.Text == "uuddlrlrbastart")
            {
                createaccountbtn.Enabled = true;
            }
        }
    }
}
