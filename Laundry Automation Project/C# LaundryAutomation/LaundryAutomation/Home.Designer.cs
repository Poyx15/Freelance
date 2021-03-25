namespace LaundryAutomation
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDryA = new System.Windows.Forms.Button();
            this.btnWashA = new System.Windows.Forms.Button();
            this.btnWashB = new System.Windows.Forms.Button();
            this.btnDryB = new System.Windows.Forms.Button();
            this.btnWashC = new System.Windows.Forms.Button();
            this.btnDryC = new System.Windows.Forms.Button();
            this.btnWashD = new System.Windows.Forms.Button();
            this.btnDryD = new System.Windows.Forms.Button();
            this.btnWashE = new System.Windows.Forms.Button();
            this.btnDryE = new System.Windows.Forms.Button();
            this.labelDryA = new System.Windows.Forms.Label();
            this.labelDryB = new System.Windows.Forms.Label();
            this.labelDryC = new System.Windows.Forms.Label();
            this.labelDryD = new System.Windows.Forms.Label();
            this.labelDryE = new System.Windows.Forms.Label();
            this.labelWashE = new System.Windows.Forms.Label();
            this.labelWashD = new System.Windows.Forms.Label();
            this.labelWashC = new System.Windows.Forms.Label();
            this.labelWashB = new System.Windows.Forms.Label();
            this.labelWashA = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.InvisibleFirstname = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.labelfullname = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labeltranscount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arduinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portscmb = new System.Windows.Forms.ToolStripComboBox();
            this.connecttsm = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.customernametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productnamecmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelsubtotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvcart = new System.Windows.Forms.DataGridView();
            this.addtocartbtn = new System.Windows.Forms.Button();
            this.labelamountdue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblchange = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.quantitytb = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbpaymenttype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltransactionno = new System.Windows.Forms.TextBox();
            this.cashtenderedtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDryA
            // 
            this.btnDryA.BackColor = System.Drawing.Color.Snow;
            this.btnDryA.Location = new System.Drawing.Point(14, 42);
            this.btnDryA.Name = "btnDryA";
            this.btnDryA.Size = new System.Drawing.Size(100, 100);
            this.btnDryA.TabIndex = 0;
            this.btnDryA.Text = "DryA";
            this.btnDryA.UseVisualStyleBackColor = false;
            this.btnDryA.Click += new System.EventHandler(this.btnClicked);
            // 
            // btnWashA
            // 
            this.btnWashA.BackColor = System.Drawing.Color.Snow;
            this.btnWashA.Location = new System.Drawing.Point(14, 240);
            this.btnWashA.Name = "btnWashA";
            this.btnWashA.Size = new System.Drawing.Size(100, 100);
            this.btnWashA.TabIndex = 1;
            this.btnWashA.Text = "WashA";
            this.btnWashA.UseVisualStyleBackColor = false;
            this.btnWashA.Click += new System.EventHandler(this.btnClicked);
            // 
            // btnWashB
            // 
            this.btnWashB.BackColor = System.Drawing.Color.Snow;
            this.btnWashB.Location = new System.Drawing.Point(161, 240);
            this.btnWashB.Name = "btnWashB";
            this.btnWashB.Size = new System.Drawing.Size(100, 100);
            this.btnWashB.TabIndex = 3;
            this.btnWashB.Text = "WashB";
            this.btnWashB.UseVisualStyleBackColor = false;
            this.btnWashB.Click += new System.EventHandler(this.btnClicked);
            // 
            // btnDryB
            // 
            this.btnDryB.BackColor = System.Drawing.Color.Snow;
            this.btnDryB.Location = new System.Drawing.Point(161, 42);
            this.btnDryB.Name = "btnDryB";
            this.btnDryB.Size = new System.Drawing.Size(100, 100);
            this.btnDryB.TabIndex = 2;
            this.btnDryB.Text = "DryB";
            this.btnDryB.UseVisualStyleBackColor = false;
            this.btnDryB.Click += new System.EventHandler(this.btnClicked);
            // 
            // btnWashC
            // 
            this.btnWashC.BackColor = System.Drawing.Color.Snow;
            this.btnWashC.Location = new System.Drawing.Point(308, 240);
            this.btnWashC.Name = "btnWashC";
            this.btnWashC.Size = new System.Drawing.Size(100, 100);
            this.btnWashC.TabIndex = 5;
            this.btnWashC.Text = "WashC";
            this.btnWashC.UseVisualStyleBackColor = false;
            this.btnWashC.Click += new System.EventHandler(this.btnClicked);
            // 
            // btnDryC
            // 
            this.btnDryC.BackColor = System.Drawing.Color.Snow;
            this.btnDryC.Location = new System.Drawing.Point(308, 42);
            this.btnDryC.Name = "btnDryC";
            this.btnDryC.Size = new System.Drawing.Size(100, 100);
            this.btnDryC.TabIndex = 4;
            this.btnDryC.Text = "DryC";
            this.btnDryC.UseVisualStyleBackColor = false;
            this.btnDryC.Click += new System.EventHandler(this.btnClicked);
            // 
            // btnWashD
            // 
            this.btnWashD.BackColor = System.Drawing.Color.Snow;
            this.btnWashD.Location = new System.Drawing.Point(455, 240);
            this.btnWashD.Name = "btnWashD";
            this.btnWashD.Size = new System.Drawing.Size(100, 100);
            this.btnWashD.TabIndex = 7;
            this.btnWashD.Text = "WashD";
            this.btnWashD.UseVisualStyleBackColor = false;
            this.btnWashD.Click += new System.EventHandler(this.btnClicked);
            // 
            // btnDryD
            // 
            this.btnDryD.BackColor = System.Drawing.Color.Snow;
            this.btnDryD.Location = new System.Drawing.Point(455, 42);
            this.btnDryD.Name = "btnDryD";
            this.btnDryD.Size = new System.Drawing.Size(100, 100);
            this.btnDryD.TabIndex = 6;
            this.btnDryD.Text = "DryD";
            this.btnDryD.UseVisualStyleBackColor = false;
            this.btnDryD.Click += new System.EventHandler(this.btnClicked);
            // 
            // btnWashE
            // 
            this.btnWashE.BackColor = System.Drawing.Color.Snow;
            this.btnWashE.Location = new System.Drawing.Point(602, 240);
            this.btnWashE.Name = "btnWashE";
            this.btnWashE.Size = new System.Drawing.Size(100, 100);
            this.btnWashE.TabIndex = 9;
            this.btnWashE.Text = "WashE";
            this.btnWashE.UseVisualStyleBackColor = false;
            this.btnWashE.Click += new System.EventHandler(this.btnClicked);
            // 
            // btnDryE
            // 
            this.btnDryE.BackColor = System.Drawing.Color.Snow;
            this.btnDryE.Location = new System.Drawing.Point(602, 42);
            this.btnDryE.Name = "btnDryE";
            this.btnDryE.Size = new System.Drawing.Size(100, 100);
            this.btnDryE.TabIndex = 8;
            this.btnDryE.Text = "DryE";
            this.btnDryE.UseVisualStyleBackColor = false;
            this.btnDryE.Click += new System.EventHandler(this.btnClicked);
            // 
            // labelDryA
            // 
            this.labelDryA.AutoSize = true;
            this.labelDryA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDryA.Location = new System.Drawing.Point(36, 22);
            this.labelDryA.Name = "labelDryA";
            this.labelDryA.Size = new System.Drawing.Size(64, 17);
            this.labelDryA.TabIndex = 10;
            this.labelDryA.Text = "00:00:00";
            // 
            // labelDryB
            // 
            this.labelDryB.AutoSize = true;
            this.labelDryB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDryB.Location = new System.Drawing.Point(183, 22);
            this.labelDryB.Name = "labelDryB";
            this.labelDryB.Size = new System.Drawing.Size(64, 17);
            this.labelDryB.TabIndex = 11;
            this.labelDryB.Text = "00:00:00";
            // 
            // labelDryC
            // 
            this.labelDryC.AutoSize = true;
            this.labelDryC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDryC.Location = new System.Drawing.Point(330, 22);
            this.labelDryC.Name = "labelDryC";
            this.labelDryC.Size = new System.Drawing.Size(64, 17);
            this.labelDryC.TabIndex = 12;
            this.labelDryC.Text = "00:00:00";
            // 
            // labelDryD
            // 
            this.labelDryD.AutoSize = true;
            this.labelDryD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDryD.Location = new System.Drawing.Point(477, 22);
            this.labelDryD.Name = "labelDryD";
            this.labelDryD.Size = new System.Drawing.Size(64, 17);
            this.labelDryD.TabIndex = 13;
            this.labelDryD.Text = "00:00:00";
            // 
            // labelDryE
            // 
            this.labelDryE.AutoSize = true;
            this.labelDryE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDryE.Location = new System.Drawing.Point(624, 22);
            this.labelDryE.Name = "labelDryE";
            this.labelDryE.Size = new System.Drawing.Size(64, 17);
            this.labelDryE.TabIndex = 14;
            this.labelDryE.Text = "00:00:00";
            // 
            // labelWashE
            // 
            this.labelWashE.AutoSize = true;
            this.labelWashE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWashE.Location = new System.Drawing.Point(624, 220);
            this.labelWashE.Name = "labelWashE";
            this.labelWashE.Size = new System.Drawing.Size(64, 17);
            this.labelWashE.TabIndex = 19;
            this.labelWashE.Text = "00:00:00";
            this.labelWashE.TextChanged += new System.EventHandler(this.labeltextchanged);
            // 
            // labelWashD
            // 
            this.labelWashD.AutoSize = true;
            this.labelWashD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWashD.Location = new System.Drawing.Point(477, 220);
            this.labelWashD.Name = "labelWashD";
            this.labelWashD.Size = new System.Drawing.Size(64, 17);
            this.labelWashD.TabIndex = 18;
            this.labelWashD.Text = "00:00:00";
            this.labelWashD.TextChanged += new System.EventHandler(this.labeltextchanged);
            // 
            // labelWashC
            // 
            this.labelWashC.AutoSize = true;
            this.labelWashC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWashC.Location = new System.Drawing.Point(330, 220);
            this.labelWashC.Name = "labelWashC";
            this.labelWashC.Size = new System.Drawing.Size(64, 17);
            this.labelWashC.TabIndex = 17;
            this.labelWashC.Text = "00:00:00";
            this.labelWashC.TextChanged += new System.EventHandler(this.labeltextchanged);
            // 
            // labelWashB
            // 
            this.labelWashB.AutoSize = true;
            this.labelWashB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWashB.Location = new System.Drawing.Point(183, 220);
            this.labelWashB.Name = "labelWashB";
            this.labelWashB.Size = new System.Drawing.Size(64, 17);
            this.labelWashB.TabIndex = 16;
            this.labelWashB.Text = "00:00:00";
            this.labelWashB.TextChanged += new System.EventHandler(this.labeltextchanged);
            // 
            // labelWashA
            // 
            this.labelWashA.AutoSize = true;
            this.labelWashA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWashA.Location = new System.Drawing.Point(36, 220);
            this.labelWashA.Name = "labelWashA";
            this.labelWashA.Size = new System.Drawing.Size(64, 17);
            this.labelWashA.TabIndex = 15;
            this.labelWashA.Text = "00:00:00";
            this.labelWashA.TextChanged += new System.EventHandler(this.labeltextchanged);
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(904, 518);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.Size = new System.Drawing.Size(688, 277);
            this.dgvHistory.TabIndex = 20;
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpDate.Location = new System.Drawing.Point(904, 470);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(304, 29);
            this.dtpDate.TabIndex = 21;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // InvisibleFirstname
            // 
            this.InvisibleFirstname.AutoSize = true;
            this.InvisibleFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InvisibleFirstname.Location = new System.Drawing.Point(666, 36);
            this.InvisibleFirstname.Name = "InvisibleFirstname";
            this.InvisibleFirstname.Size = new System.Drawing.Size(160, 24);
            this.InvisibleFirstname.TabIndex = 22;
            this.InvisibleFirstname.Text = "InvisibleFirstname";
            this.InvisibleFirstname.Visible = false;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labeldate.Location = new System.Drawing.Point(1179, 36);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(48, 24);
            this.labeldate.TabIndex = 23;
            this.labeldate.Text = "Date";
            // 
            // labelfullname
            // 
            this.labelfullname.AutoSize = true;
            this.labelfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelfullname.Location = new System.Drawing.Point(35, 36);
            this.labelfullname.Name = "labelfullname";
            this.labelfullname.Size = new System.Drawing.Size(89, 24);
            this.labelfullname.TabIndex = 24;
            this.labelfullname.Text = "Fullname";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(1382, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "Transaction Count:";
            // 
            // labeltranscount
            // 
            this.labeltranscount.AutoSize = true;
            this.labeltranscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labeltranscount.Location = new System.Drawing.Point(1556, 475);
            this.labeltranscount.Name = "labeltranscount";
            this.labeltranscount.Size = new System.Drawing.Size(50, 24);
            this.labeltranscount.TabIndex = 26;
            this.labeltranscount.Text = "0000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWashE);
            this.groupBox1.Controls.Add(this.btnDryA);
            this.groupBox1.Controls.Add(this.btnWashA);
            this.groupBox1.Controls.Add(this.btnDryB);
            this.groupBox1.Controls.Add(this.btnWashB);
            this.groupBox1.Controls.Add(this.btnDryC);
            this.groupBox1.Controls.Add(this.btnWashC);
            this.groupBox1.Controls.Add(this.btnDryD);
            this.groupBox1.Controls.Add(this.labelWashE);
            this.groupBox1.Controls.Add(this.btnWashD);
            this.groupBox1.Controls.Add(this.labelWashD);
            this.groupBox1.Controls.Add(this.btnDryE);
            this.groupBox1.Controls.Add(this.labelWashC);
            this.groupBox1.Controls.Add(this.labelDryA);
            this.groupBox1.Controls.Add(this.labelWashB);
            this.groupBox1.Controls.Add(this.labelDryB);
            this.groupBox1.Controls.Add(this.labelWashA);
            this.groupBox1.Controls.Add(this.labelDryC);
            this.groupBox1.Controls.Add(this.labelDryE);
            this.groupBox1.Controls.Add(this.labelDryD);
            this.groupBox1.Location = new System.Drawing.Point(890, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 350);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machines";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.arduinoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1620, 29);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyLogToolStripMenuItem,
            this.manageInventoryToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.inventoryToolStripMenuItem.Text = "Admin";
            // 
            // historyLogToolStripMenuItem
            // 
            this.historyLogToolStripMenuItem.Name = "historyLogToolStripMenuItem";
            this.historyLogToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.historyLogToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.historyLogToolStripMenuItem.Text = "Log History";
            this.historyLogToolStripMenuItem.Click += new System.EventHandler(this.historyLogToolStripMenuItem_Click);
            // 
            // manageInventoryToolStripMenuItem
            // 
            this.manageInventoryToolStripMenuItem.Name = "manageInventoryToolStripMenuItem";
            this.manageInventoryToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.manageInventoryToolStripMenuItem.Text = "Manage Inventory";
            this.manageInventoryToolStripMenuItem.Click += new System.EventHandler(this.manageInventoryToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // arduinoToolStripMenuItem
            // 
            this.arduinoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStripMenuItem,
            this.connecttsm});
            this.arduinoToolStripMenuItem.Name = "arduinoToolStripMenuItem";
            this.arduinoToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.arduinoToolStripMenuItem.Text = "Arduino";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portscmb});
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.portToolStripMenuItem.Text = "Port";
            // 
            // portscmb
            // 
            this.portscmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portscmb.Name = "portscmb";
            this.portscmb.Size = new System.Drawing.Size(121, 23);
            // 
            // connecttsm
            // 
            this.connecttsm.Name = "connecttsm";
            this.connecttsm.Size = new System.Drawing.Size(119, 22);
            this.connecttsm.Text = "Connect";
            this.connecttsm.Click += new System.EventHandler(this.connecttsm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Customer Name:";
            // 
            // customernametb
            // 
            this.customernametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.customernametb.Location = new System.Drawing.Point(170, 171);
            this.customernametb.Name = "customernametb";
            this.customernametb.Size = new System.Drawing.Size(227, 29);
            this.customernametb.TabIndex = 30;
            this.customernametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(84, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Product:";
            // 
            // productnamecmb
            // 
            this.productnamecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productnamecmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnamecmb.FormattingEnabled = true;
            this.productnamecmb.Location = new System.Drawing.Point(170, 221);
            this.productnamecmb.Name = "productnamecmb";
            this.productnamecmb.Size = new System.Drawing.Size(227, 32);
            this.productnamecmb.TabIndex = 32;
            this.productnamecmb.SelectedIndexChanged += new System.EventHandler(this.productnamecmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(106, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Price:";
            // 
            // labelprice
            // 
            this.labelprice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelprice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelprice.Location = new System.Drawing.Point(170, 277);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(227, 24);
            this.labelprice.TabIndex = 34;
            this.labelprice.Text = "0";
            this.labelprice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(81, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Quantity:";
            // 
            // labelsubtotal
            // 
            this.labelsubtotal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelsubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelsubtotal.Location = new System.Drawing.Point(170, 362);
            this.labelsubtotal.Name = "labelsubtotal";
            this.labelsubtotal.Size = new System.Drawing.Size(227, 24);
            this.labelsubtotal.TabIndex = 38;
            this.labelsubtotal.Text = "0.00";
            this.labelsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(69, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Sub Total:";
            // 
            // dgvcart
            // 
            this.dgvcart.AllowUserToAddRows = false;
            this.dgvcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcart.Location = new System.Drawing.Point(427, 96);
            this.dgvcart.Name = "dgvcart";
            this.dgvcart.ReadOnly = true;
            this.dgvcart.Size = new System.Drawing.Size(443, 406);
            this.dgvcart.TabIndex = 39;
            this.dgvcart.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvcart_RowsRemoved);
            // 
            // addtocartbtn
            // 
            this.addtocartbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocartbtn.Location = new System.Drawing.Point(170, 428);
            this.addtocartbtn.Name = "addtocartbtn";
            this.addtocartbtn.Size = new System.Drawing.Size(227, 70);
            this.addtocartbtn.TabIndex = 40;
            this.addtocartbtn.Text = "Add to Cart";
            this.addtocartbtn.UseVisualStyleBackColor = true;
            this.addtocartbtn.Click += new System.EventHandler(this.addtocartbtn_Click);
            // 
            // labelamountdue
            // 
            this.labelamountdue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelamountdue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelamountdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelamountdue.Location = new System.Drawing.Point(643, 518);
            this.labelamountdue.Name = "labelamountdue";
            this.labelamountdue.Size = new System.Drawing.Size(227, 24);
            this.labelamountdue.TabIndex = 42;
            this.labelamountdue.Text = "0.00";
            this.labelamountdue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(516, 518);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 24);
            this.label9.TabIndex = 41;
            this.label9.Text = "Amount Due:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(490, 625);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 24);
            this.label10.TabIndex = 43;
            this.label10.Text = "Cash Tendered:";
            // 
            // lblchange
            // 
            this.lblchange.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblchange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblchange.Location = new System.Drawing.Point(643, 676);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(227, 24);
            this.lblchange.TabIndex = 46;
            this.lblchange.Text = "0.00";
            this.lblchange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.Location = new System.Drawing.Point(555, 676);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 24);
            this.label13.TabIndex = 45;
            this.label13.Text = "Change:";
            // 
            // quantitytb
            // 
            this.quantitytb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.quantitytb.Location = new System.Drawing.Point(170, 318);
            this.quantitytb.Name = "quantitytb";
            this.quantitytb.Size = new System.Drawing.Size(227, 29);
            this.quantitytb.TabIndex = 47;
            this.quantitytb.Text = "1";
            this.quantitytb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantitytb.TextChanged += new System.EventHandler(this.quantitytb_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(643, 725);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(227, 70);
            this.btnConfirm.TabIndex = 48;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(501, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Payment Type:";
            // 
            // cmbpaymenttype
            // 
            this.cmbpaymenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpaymenttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpaymenttype.FormattingEnabled = true;
            this.cmbpaymenttype.Items.AddRange(new object[] {
            "Gcash",
            "Cash"});
            this.cmbpaymenttype.Location = new System.Drawing.Point(643, 568);
            this.cmbpaymenttype.Name = "cmbpaymenttype";
            this.cmbpaymenttype.Size = new System.Drawing.Size(227, 32);
            this.cmbpaymenttype.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(16, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Transaction No.:";
            // 
            // lbltransactionno
            // 
            this.lbltransactionno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbltransactionno.Location = new System.Drawing.Point(170, 115);
            this.lbltransactionno.Name = "lbltransactionno";
            this.lbltransactionno.ReadOnly = true;
            this.lbltransactionno.Size = new System.Drawing.Size(227, 29);
            this.lbltransactionno.TabIndex = 52;
            this.lbltransactionno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cashtenderedtb
            // 
            this.cashtenderedtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cashtenderedtb.Location = new System.Drawing.Point(643, 620);
            this.cashtenderedtb.Name = "cashtenderedtb";
            this.cashtenderedtb.Size = new System.Drawing.Size(227, 29);
            this.cashtenderedtb.TabIndex = 53;
            this.cashtenderedtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cashtenderedtb.TextChanged += new System.EventHandler(this.cashtenderedtb_TextChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 830);
            this.Controls.Add(this.cashtenderedtb);
            this.Controls.Add(this.lbltransactionno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbpaymenttype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.quantitytb);
            this.Controls.Add(this.lblchange);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelamountdue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addtocartbtn);
            this.Controls.Add(this.dgvcart);
            this.Controls.Add(this.labelsubtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productnamecmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customernametb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labeltranscount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelfullname);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.InvisibleFirstname);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDryA;
        private System.Windows.Forms.Button btnWashA;
        private System.Windows.Forms.Button btnWashB;
        private System.Windows.Forms.Button btnDryB;
        private System.Windows.Forms.Button btnWashC;
        private System.Windows.Forms.Button btnDryC;
        private System.Windows.Forms.Button btnWashD;
        private System.Windows.Forms.Button btnDryD;
        private System.Windows.Forms.Button btnWashE;
        private System.Windows.Forms.Button btnDryE;
        private System.Windows.Forms.Label labelDryA;
        private System.Windows.Forms.Label labelDryB;
        private System.Windows.Forms.Label labelDryC;
        private System.Windows.Forms.Label labelDryD;
        private System.Windows.Forms.Label labelDryE;
        private System.Windows.Forms.Label labelWashE;
        private System.Windows.Forms.Label labelWashD;
        private System.Windows.Forms.Label labelWashC;
        private System.Windows.Forms.Label labelWashB;
        private System.Windows.Forms.Label labelWashA;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label InvisibleFirstname;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labelfullname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labeltranscount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customernametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productnamecmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelsubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvcart;
        private System.Windows.Forms.Button addtocartbtn;
        private System.Windows.Forms.Label labelamountdue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblchange;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox quantitytb;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ToolStripMenuItem arduinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox portscmb;
        private System.Windows.Forms.ToolStripMenuItem connecttsm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbpaymenttype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lbltransactionno;
        private System.Windows.Forms.TextBox cashtenderedtb;
    }
}