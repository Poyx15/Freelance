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
    public partial class Login : Form
    {
        string connectionString = @"Data Source=JAMORALIN;Initial Catalog=POSLaundry;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand admincmd = new SqlCommand("spLogin", conn);
            admincmd.CommandType = CommandType.StoredProcedure;
            admincmd.Parameters.AddWithValue("@username", SqlDbType.NChar).Value = usernametb.Text.Trim();
            admincmd.Parameters.AddWithValue("@password", SqlDbType.NChar).Value = passwordtb.Text.Trim();
            DataTable afdt = new DataTable();
            afdt.Load(admincmd.ExecuteReader());

            if (afdt.Rows.Count == 1)
            {
                // Hide the Login Form
                this.Hide();
                //LoginLog();

                // Log the current user into the Log History
                LoginLog();

                // Create a form and call it
                Home home = new Home();
                home.FormBorderStyle = FormBorderStyle.FixedSingle;
                home.MaximizeBox = false;
                home.ShowDialog();

                // Restore the Login Form After mainform is closed
                this.Show();
                LogoutLog();
                //ClearLoginInfo();
            }
            else
            {
                MessageBox.Show("Incorrect Login Information!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            // Restore the Login Form After mainform is closed
            this.Show();

            // Clear the Textbox Fields
            usernametb.Text = "";
            passwordtb.Text = "";
        }

        private void createaccountlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide the Login Form
            this.Hide();

            // Create a form and call it
            CreateAccount createAccount = new CreateAccount();
            createAccount.FormBorderStyle = FormBorderStyle.FixedSingle;
            createAccount.MaximizeBox = false;
            createAccount.ShowDialog();

            // Restore the Login Form After mainform is closed
            this.Show();
        }

        private void LoginLog()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spEnterLog", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", SqlDbType.NChar).Value = usernametb.Text.Trim();
            cmd.Parameters.AddWithValue("@action", SqlDbType.NChar).Value = loginbtn.Text.Trim();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void LogoutLog()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spEnterLog", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", SqlDbType.NChar).Value = usernametb.Text.Trim();
            cmd.Parameters.AddWithValue("@action", SqlDbType.NChar).Value = "Logout";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
