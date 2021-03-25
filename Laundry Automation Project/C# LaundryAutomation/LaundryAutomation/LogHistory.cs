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
    public partial class LogHistoryForm : Form
    {
        string connectionString = @"Data Source=JAMORALIN;Initial Catalog=POSLaundry;Integrated Security=True";

        public LogHistoryForm()
        {
            InitializeComponent();
        }

        private void LogHistoryForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spOpenLogHistory", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();

            dataTable.Load(cmd.ExecuteReader());
            dgvloghistory.DataSource = dataTable;
            cmd.ExecuteNonQuery();
            conn.Close();

            dgvloghistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
