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
using System.IO.Ports;

namespace LaundryAutomation
{
    
    public partial class Home : Form
    {
        string connectionString = @"Data Source=JAMORALIN;Initial Catalog=POSLaundry;Integrated Security=True";
        double operating_time_minutes = 0.10;
        IDictionary<string, Button> namebutton = new Dictionary<string, Button>();
        IDictionary<string, Label> namelabel = new Dictionary<string, Label>();
        IDictionary<Button, string> offbutton = new Dictionary<Button, string>();
        DataTable data_transaction = new DataTable();
        SerialPort ComPort = new SerialPort();


        public Home()
        {
            InitializeComponent();
            initialize_machines();
        }


        private void Home_Load(object sender, EventArgs e)
        {
            refrehDataGrid();
            labeldate.Text = DateTime.Today.ToString("dddd, dd MMMM yyyy");
            labelfullname.Text = "Emmanuel Jamoralin";

            check_timers();
            InitTimer();
            currentLoggedIn();
            showProductName();

            // Transaction Datagridview (OUT)
            data_transaction.Columns.Add("Product", typeof(string));
            data_transaction.Columns.Add("Price", typeof(string));
            data_transaction.Columns.Add("Quantity", typeof(string));
            data_transaction.Columns.Add("Subtotal", typeof(string));

            dgvcart.DataSource = data_transaction;
            dgvcart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            cmbpaymenttype.SelectedIndex = 1;
            lbltransactionno.Text = GenerateRandomNumber();


            // Arduino
            try
            {
                getPortNames();
            }
            catch
            {
                MessageBox.Show("Connect the ARDUINO into the USB Port");
            }

            
        }

        private void btnClicked(object sender, EventArgs e)
        {
            // Inserting the transaction into the database

            Button button = (Button)sender;
            DateTime currentTime = DateTime.Now;

            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                // Arduino
                ComPort.WriteLine(button.Text);

                conn.Open();
                SqlCommand cmd = new SqlCommand("spOperateMachine", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@machine", SqlDbType.NChar).Value = button.Text.Trim();
                cmd.Parameters.AddWithValue("@customer", SqlDbType.NChar).Value = customernametb.Text.Trim();
                cmd.Parameters.AddWithValue("@operatingtime", SqlDbType.NChar).Value = operating_time_minutes;
                cmd.Parameters.AddWithValue("@timestart", SqlDbType.NChar).Value = currentTime.ToString("HH:mm:ss");
                cmd.Parameters.AddWithValue("@timeend", SqlDbType.NChar).Value = currentTime.AddMinutes(operating_time_minutes).ToString("HH:mm:ss");
                cmd.Parameters.AddWithValue("@currentdate", SqlDbType.NChar).Value = currentTime.ToString("MM/dd/yyyy");
                cmd.Parameters.AddWithValue("@handledby", SqlDbType.NChar).Value = InvisibleFirstname.Text;
                cmd.ExecuteNonQuery();
                conn.Close();

                //MessageBox.Show("Account Registered Successfully!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);


                button.Text = currentTime.AddMinutes(operating_time_minutes).ToString("HH:mm:ss");
                button.BackColor = Color.Green;
                button.Enabled = false;

                refrehDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        private void refrehDataGrid()
        {
            // Transaction History

            string formatted_date = dtpDate.Value.ToString("yyyy-MM-dd");
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spShowTransaction", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@formatted_date", SqlDbType.NChar).Value = formatted_date;
            DataTable dataTable = new DataTable();

            dataTable.Load(cmd.ExecuteReader());
            dgvHistory.DataSource = dataTable;
            cmd.ExecuteNonQuery();
            conn.Close();

            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            labeltranscount.Text = dgvHistory.RowCount.ToString();
            
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            refrehDataGrid();
        }


        private void initialize_machines()
        {
            List<Button> lstbuttons = new List<Button>
            {
                btnDryA, btnDryB, btnDryC, btnDryD, btnDryE, btnWashA, btnWashB, btnWashC, btnWashD, btnWashE
            };
            
            for (int x = 0; x < lstbuttons.Count; x++)
            {
                lstbuttons[x].BackColor = Color.Snow;
            }

            

            // Dictionary String Button
            namebutton.Add("DryA", btnDryA); 
            namebutton.Add("DryB", btnDryB);
            namebutton.Add("DryC", btnDryC);
            namebutton.Add("DryD", btnDryD);
            namebutton.Add("DryE", btnDryE);
            namebutton.Add("WashA", btnWashA);
            namebutton.Add("WashB", btnWashB);
            namebutton.Add("WashC", btnWashC);
            namebutton.Add("WashD", btnWashD);
            namebutton.Add("WashE", btnWashE);

            // Dictionary String Label
            namelabel.Add("DryA", labelDryA);
            namelabel.Add("DryB", labelDryB);
            namelabel.Add("DryC", labelDryC);
            namelabel.Add("DryD", labelDryD);
            namelabel.Add("DryE", labelDryE);
            namelabel.Add("WashA", labelWashA);
            namelabel.Add("WashB", labelWashB);
            namelabel.Add("WashC", labelWashC);
            namelabel.Add("WashD", labelWashD);
            namelabel.Add("WashE", labelWashE);

            // Dictionary Button String
            offbutton.Add(btnDryA, "OffDA");
            offbutton.Add(btnDryB, "OffDB");
            offbutton.Add(btnDryC, "OffDC");
            offbutton.Add(btnDryD, "OffDD");
            offbutton.Add(btnDryE, "OffDE");
            offbutton.Add(btnWashA, "OffWA");
            offbutton.Add(btnWashB, "OffWB");
            offbutton.Add(btnWashC, "OffWC");
            offbutton.Add(btnWashD, "OffWD");
            offbutton.Add(btnWashE, "OffWE");
        }

        private void check_timers()
        {            
            DateTime currentTime = DateTime.Now;
            TimeSpan tscurrent = TimeSpan.Parse(currentTime.ToString("HH:mm:ss"));

            if (dtpDate.Value.ToString("yyyy-MM-dd") == currentTime.ToString("yyyy-MM-dd"))
            {
                // Put the datagridview in ascending order to validate only the last transactions
                dgvHistory.Sort(dgvHistory.Columns[0], ListSortDirection.Ascending);

                foreach (DataGridViewRow row in dgvHistory.Rows)
                {
                    TimeSpan tsendtime = TimeSpan.Parse(row.Cells["TimeEnd"].Value.ToString());
                    if (tsendtime < tscurrent)
                    {
                        namebutton[row.Cells["Machine"].Value.ToString()].BackColor = Color.Snow;

                        namelabel[row.Cells["Machine"].Value.ToString()].Text = "Inactive";
                        namebutton[row.Cells["Machine"].Value.ToString()].Enabled = true;

                    }
                    else
                    {
                        namebutton[row.Cells["Machine"].Value.ToString()].BackColor = Color.Green;
                        namelabel[row.Cells["Machine"].Value.ToString()].Text = row.Cells["TimeEnd"].Value.ToString();
                        namebutton[row.Cells["Machine"].Value.ToString()].Text = row.Cells["Machine"].Value.ToString();

                        namebutton[row.Cells["Machine"].Value.ToString()].Enabled = false;
                    }

                    
                }

                // Rearage the datagridview to descending order for easier view. (default view)
                dgvHistory.Sort(dgvHistory.Columns[0], ListSortDirection.Descending);
            }

            if (connecttsm.Text == "Disconnect")
            {
                closeDigitalPins();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            check_timers();
        }

        private Timer timer1;

        private void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            check_timers();
        }

        private void historyLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogHistoryForm logHistory = new LogHistoryForm();
            logHistory.FormBorderStyle = FormBorderStyle.FixedSingle;
            logHistory.MaximizeBox = false;
            logHistory.Show();
        }

        private void manageInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryForm inventory = new InventoryForm();
            inventory.FormBorderStyle = FormBorderStyle.FixedSingle;
            inventory.MaximizeBox = false;
            inventory.ShowDialog();
            showProductName();
        }

        private void currentLoggedIn()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spCurrentLoggedIn", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            labelfullname.Text = sdr["LastName"].ToString() + ", " + sdr["Firstname"].ToString();
            InvisibleFirstname.Text = sdr["Firstname"].ToString();
            string role = sdr["Role"].ToString();
            conn.Close();
            
        }

        private void showProductName()
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

            productnamecmb.DataSource = dataTable;
            productnamecmb.DisplayMember = "Name";
            conn.Close();
        }

        private void productnamecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productnamecmb.SelectedIndex != 0)
            {
                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();
                SqlCommand cmd = new SqlCommand("spGetProductDetail", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", SqlDbType.NChar).Value = productnamecmb.Text.Trim();

                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                labelprice.Text = sdr["Price"].ToString();
                conn.Close();
                addtocartbtn.Enabled = true;
            }
            else
            {
                labelprice.Text = "0";
                addtocartbtn.Enabled = false;
            }

            labelsubtotal.Text = (Int32.Parse(labelprice.Text) * Int32.Parse(quantitytb.Text)).ToString();
        }

        private void quantitytb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelsubtotal.Text = (Int32.Parse(labelprice.Text) * Int32.Parse(quantitytb.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Enter a proper amount for quantity. Numeric Only");
                quantitytb.Text = "1";
            }
        }

        private void addtocartbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand("spGetProductDetail", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", SqlDbType.NChar).Value = productnamecmb.Text.Trim();

            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            int stock = int.Parse(sdr["Stock"].ToString());
            MessageBox.Show(stock.ToString());
            conn.Close();

            if(int.Parse(quantitytb.Text) < stock)
            {
                //MessageBox.Show(sdr["StockIndicator"].ToString());
                //MessageBox.Show(stock); // Debug purpose

                String searchValue = productnamecmb.Text;
                int rowIndex = -1;
                bool checker = false;
                foreach (DataGridViewRow row in dgvcart.Rows)
                {
                    if (row.Cells["Product"].Value != null) // Need to check for null if new row is exposed
                    {
                        if (row.Cells["Product"].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            checker = true;
                            dgvcart.Rows.RemoveAt(row.Index);
                            MessageBox.Show("Item already exist, deleting the previous entry.");
                        }
                    }
                }


                DataRow drToAddOUT = data_transaction.NewRow();

                data_transaction.Rows.Add(productnamecmb.Text, labelprice.Text, quantitytb.Text, labelsubtotal.Text);
                dgvcart.DataSource = data_transaction;

                productnamecmb.SelectedIndex = 0;
                quantitytb.Text = "1";
                getAmountDue();
            }
            else
            {
                MessageBox.Show("Insuficient stocks. Number of Stocks remaining: " + stock.ToString());
            }

            
        }

        private void getAmountDue()
        {
            int sum = 0;
            for (int row = 0; row < Int16.Parse(data_transaction.Rows.Count.ToString()); row++)
            {
                sum += Int32.Parse(dgvcart.Rows[row].Cells["Subtotal"].Value.ToString());
                //MessageBox.Show(row.ToString());
            }
            labelamountdue.Text = sum.ToString();
        }

        private void dgvcart_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int sum = 0;
            for (int row = 0; row < Int16.Parse((data_transaction.Rows.Count - 1).ToString()); row++)
            {
                sum += Int32.Parse(dgvcart.Rows[row].Cells["Subtotal"].Value.ToString());
                //MessageBox.Show(row.ToString());
            }
            labelamountdue.Text = sum.ToString();
        }

        // Arduino

        private void getPortNames()
        {
            string[] PortNames = null;
            int index = -1;
            string ComPortName = null;

            PortNames = SerialPort.GetPortNames();

            do
            {
                index += 1;
                portscmb.Items.Add(PortNames[index]);
            } while (!((PortNames[index] == ComPortName) || (index == PortNames.GetUpperBound(0))));

            Array.Sort(PortNames);

            if (index == PortNames.GetUpperBound(0))
            {
                ComPortName = PortNames[0];
            }
        }

        private void connecttsm_Click(object sender, EventArgs e)
        {
            if(connecttsm.Text == "Connect")
            {
                ComPort.PortName = Convert.ToString(portscmb.Text);
                ComPort.BaudRate = 9600;
                ComPort.Open();
                connecttsm.Text = "Disconnect";
            }
            else
            {
                ComPort.Close();
                connecttsm.Text = "Connect";
            }
        }

        private void closeDigitalPins()
        {
            List<Button> lstbuttons = new List<Button>
            {
                 btnWashA, btnWashB, btnWashC, btnWashD, btnWashE, btnDryA, btnDryB, btnDryC, btnDryD, btnDryE
            };

            for (int x = 0; x < lstbuttons.Count; x++)
            {
                if(lstbuttons[x].BackColor != Color.Green)
                {
                    ComPort.WriteLine(offbutton[lstbuttons[x]]);
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        private void labeltextchanged(object sender, EventArgs e)
        {
            //if (connecttsm.Text == "Disconnect")
            //{
            //    closeDigitalPins();
            //}
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            foreach (DataGridViewRow row in dgvcart.Rows)
            {
                // Add item to transaction dvg
                try
                {
                    // Entering the details to table
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("spTransactHistory", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", SqlDbType.NChar).Value = lbltransactionno.Text.Trim();
                    cmd.Parameters.AddWithValue("@csname", SqlDbType.NChar).Value = customernametb.Text.Trim();
                    // DGV Transact
                    cmd.Parameters.AddWithValue("@product", SqlDbType.NChar).Value = row.Cells["Product"].Value;
                    cmd.Parameters.AddWithValue("@price", SqlDbType.NChar).Value = row.Cells["Price"].Value;
                    cmd.Parameters.AddWithValue("@quantity", SqlDbType.NChar).Value = row.Cells["Quantity"].Value;
                    cmd.Parameters.AddWithValue("@subtotal", SqlDbType.NChar).Value = row.Cells["Subtotal"].Value;
                    cmd.Parameters.AddWithValue("@paymenttype", SqlDbType.NChar).Value = cmbpaymenttype.Text;
                    cmd.Parameters.AddWithValue("@handledby", SqlDbType.NChar).Value = InvisibleFirstname.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Item/s Registered Successfully!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
            // Reset the fields

            data_transaction.Clear();
            dgvcart.DataSource = data_transaction;
            customernametb.Text = "";

            lbltransactionno.Text = GenerateRandomNumber();
            cmbpaymenttype.SelectedIndex = 1;
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm Report = new ReportForm();
            Report.FormBorderStyle = FormBorderStyle.FixedSingle;
            Report.MaximizeBox = false;
            Report.Show();
        }

        private string GenerateRandomNumber()
        {
            var dateTime = DateTime.Now.ToString("M-d-yyyy");
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            finalString = dateTime +" "+ finalString;
            return finalString;
        }

        private void cashtenderedtb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblchange.Text = (float.Parse(cashtenderedtb.Text) - float.Parse(labelamountdue.Text)).ToString();
            }
            catch
            {

            }
        }
    }
}
