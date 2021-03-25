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
    public partial class InventoryForm : Form
    {
        string connectionString = @"Data Source=JAMORALIN;Initial Catalog=POSLaundry;Integrated Security=True";
        string role = "employee";

        public InventoryForm()
        {
            InitializeComponent();
        }

        private void chkenableadddelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkenableadddelete.Checked)
            {
                gbinitialize.Enabled = true;
                gbremove.Enabled = true;
                gbedit.Enabled = true;
            }
            else
            {
                gbinitialize.Enabled = false;
                gbremove.Enabled = false;
                gbedit.Enabled = false;
            }
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            chkenableadddelete.Checked = false;
            currentLoggedIn();
            refreshInventory();

            lbladmin.Text = role;

            if (role != "Admin")
            {
                chkenableadddelete.Enabled = false;
            }
        }

        private void refreshProductList()
        {
            // Product List Datagridview
            
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spShowProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();

            dataTable.Load(cmd.ExecuteReader());
            dgvProduct.DataSource = dataTable;
            cmd.ExecuteNonQuery();
            conn.Close();

            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void refreshDeliveryHistory()
        {
            // Delivery List Datagridview

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spShowHistory", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();

            dataTable.Load(cmd.ExecuteReader());
            dgvDeliveryHistory.DataSource = dataTable;
            cmd.ExecuteNonQuery();
            conn.Close();

            dgvDeliveryHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void refreshCommandHistory()
        {
            // Command List Datagridview

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spShowCommand", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();

            dataTable.Load(cmd.ExecuteReader());
            dgvCommandHistory.DataSource = dataTable;
            cmd.ExecuteNonQuery();
            conn.Close();

            dgvCommandHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;            
        }

        private void initializebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spInitializeItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", SqlDbType.NChar).Value = iinametb.Text.Trim();
            cmd.Parameters.AddWithValue("@code", SqlDbType.NChar).Value = iicodetb.Text.Trim();
            cmd.Parameters.AddWithValue("@price", SqlDbType.NChar).Value = iipricetb.Text.Trim();
            cmd.ExecuteNonQuery();
            conn.Close();

            
            LogCommandHistory(initializebtn.Text, iinametb.Text);

            iinametb.Text = "";
            iicodetb.Text = "";
            iipricetb.Text = "";
        }

        private void showASProductName()
        {
            // FIll the Combo box for Unit
            SqlConnection conn = new SqlConnection(connectionString);
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("spGetProductName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            cmd.ExecuteNonQuery();

            DataRow row = dataTable.NewRow();
            row[0] = "Select Product";
            dataTable.Rows.InsertAt(row, 0);

            asnamecmb.DataSource = dataTable;
            asnamecmb.DisplayMember = "Name";
            conn.Close();
        }

        private void showEIProductName()
        {
            // FIll the Combo box for Unit
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spGetProductName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            cmd.ExecuteNonQuery();

            DataRow row = dataTable.NewRow();
            row[0] = "Select Product";
            dataTable.Rows.InsertAt(row, 0);

            einamecmb.DataSource = dataTable;
            einamecmb.DisplayMember = "Name";
            conn.Close();
        }

        private void refreshInventory()
        {
            showASProductName();
            showRIProductName();
            showEIProductName();

            refreshProductList();
            refreshDeliveryHistory();
            refreshCommandHistory();
        }

        private void showRIProductName()
        {
            // FIll the Combo box for Unit
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spGetProductName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            cmd.ExecuteNonQuery();

            DataRow row = dataTable.NewRow();
            row[0] = "Select Product";
            dataTable.Rows.InsertAt(row, 0);

            rinamecmb.DataSource = dataTable;
            rinamecmb.DisplayMember = "Name";
            conn.Close();
        }

        private void rideletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spDeleteItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", SqlDbType.NChar).Value = rinamecmb.Text.Trim();
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            cmd.ExecuteNonQuery();
            conn.Close();
            
            LogCommandHistory(rideletebtn.Text, rinamecmb.Text);
        }

        private void asAddStock_Click(object sender, EventArgs e)
        {

            if (numquantity.Value > 0 && asnamecmb.SelectedIndex != 0)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();
                SqlCommand cmd = new SqlCommand("spAddDelivery", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", SqlDbType.NChar).Value = asnamecmb.Text.Trim();
                cmd.Parameters.AddWithValue("@quantity", SqlDbType.NChar).Value = numquantity.Value.ToString();
                cmd.Parameters.AddWithValue("@currentuser", SqlDbType.NChar).Value = InvisibleFirstname.Text.ToString();
                cmd.ExecuteNonQuery();
                conn.Close();


                numquantity.Value = 0;
                refreshInventory();
            }
            else
            {
                MessageBox.Show("Please FIllup Proper Values");
            }

            
        }

        


        private void currentLoggedIn()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spCurrentLoggedIn", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            InvisibleFirstname.Text = sdr["LastName"].ToString() + ", " + sdr["Firstname"].ToString();
            role = sdr["Role"].ToString();
            conn.Close();

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spEditProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", SqlDbType.NChar).Value = einamecmb.Text.Trim();
            cmd.Parameters.AddWithValue("@newname", SqlDbType.NChar).Value = einewname.Text.ToString();
            cmd.Parameters.AddWithValue("@price", SqlDbType.NChar).Value = eiprice.Text.ToString();
            cmd.ExecuteNonQuery();
            conn.Close();
            
            LogCommandHistory(editbtn.Text, einamecmb.Text);

        }

        private void einamecmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (einamecmb.SelectedIndex != 0)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetProductDetail", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", SqlDbType.NChar).Value = einamecmb.Text.Trim();

                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                einewname.Text = sdr["Name"].ToString();
                eiprice.Text = sdr["Price"].ToString();
                conn.Close();
            }
            else
            {

                einewname.Text = "";
                eiprice.Text = "";
            }            
        }

        private void LogCommandHistory(string command, string product)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spAddCommmand", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@command", SqlDbType.NChar).Value = command;
            cmd.Parameters.AddWithValue("@product", SqlDbType.NChar).Value = product;
            cmd.Parameters.AddWithValue("@currentuser", SqlDbType.NChar).Value = InvisibleFirstname.Text;
            cmd.ExecuteNonQuery();
            conn.Close();

            refreshInventory();
        }
    }
}
