namespace LaundryAutomation
{
    partial class InventoryForm
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
            this.iicodetb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iinametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbinitialize = new System.Windows.Forms.GroupBox();
            this.initializebtn = new System.Windows.Forms.Button();
            this.iipricetb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbremove = new System.Windows.Forms.GroupBox();
            this.rinamecmb = new System.Windows.Forms.ComboBox();
            this.rideletebtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numquantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.asnamecmb = new System.Windows.Forms.ComboBox();
            this.asAddStock = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chkenableadddelete = new System.Windows.Forms.CheckBox();
            this.dgvDeliveryHistory = new System.Windows.Forms.DataGridView();
            this.InvisibleFirstname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbedit = new System.Windows.Forms.GroupBox();
            this.eiprice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.einewname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.einamecmb = new System.Windows.Forms.ComboBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvCommandHistory = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.lbladmin = new System.Windows.Forms.Label();
            this.gbinitialize.SuspendLayout();
            this.gbremove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryHistory)).BeginInit();
            this.gbedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // iicodetb
            // 
            this.iicodetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.iicodetb.Location = new System.Drawing.Point(164, 80);
            this.iicodetb.Name = "iicodetb";
            this.iicodetb.Size = new System.Drawing.Size(227, 29);
            this.iicodetb.TabIndex = 34;
            this.iicodetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(47, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Item Code:";
            // 
            // iinametb
            // 
            this.iinametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.iinametb.Location = new System.Drawing.Point(164, 41);
            this.iinametb.Name = "iinametb";
            this.iinametb.Size = new System.Drawing.Size(227, 29);
            this.iinametb.TabIndex = 36;
            this.iinametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(42, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Item Name:";
            // 
            // gbinitialize
            // 
            this.gbinitialize.Controls.Add(this.initializebtn);
            this.gbinitialize.Controls.Add(this.iipricetb);
            this.gbinitialize.Controls.Add(this.label3);
            this.gbinitialize.Controls.Add(this.iicodetb);
            this.gbinitialize.Controls.Add(this.iinametb);
            this.gbinitialize.Controls.Add(this.label1);
            this.gbinitialize.Controls.Add(this.label2);
            this.gbinitialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbinitialize.Location = new System.Drawing.Point(12, 212);
            this.gbinitialize.Name = "gbinitialize";
            this.gbinitialize.Size = new System.Drawing.Size(426, 209);
            this.gbinitialize.TabIndex = 37;
            this.gbinitialize.TabStop = false;
            this.gbinitialize.Text = "Initialize Item";
            // 
            // initializebtn
            // 
            this.initializebtn.Location = new System.Drawing.Point(164, 158);
            this.initializebtn.Name = "initializebtn";
            this.initializebtn.Size = new System.Drawing.Size(227, 46);
            this.initializebtn.TabIndex = 39;
            this.initializebtn.Text = "Add Item";
            this.initializebtn.UseVisualStyleBackColor = true;
            this.initializebtn.Click += new System.EventHandler(this.initializebtn_Click);
            // 
            // iipricetb
            // 
            this.iipricetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.iipricetb.Location = new System.Drawing.Point(164, 119);
            this.iipricetb.Name = "iipricetb";
            this.iipricetb.Size = new System.Drawing.Size(227, 29);
            this.iipricetb.TabIndex = 38;
            this.iipricetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(90, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Price:";
            // 
            // gbremove
            // 
            this.gbremove.Controls.Add(this.rinamecmb);
            this.gbremove.Controls.Add(this.rideletebtn);
            this.gbremove.Controls.Add(this.label6);
            this.gbremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbremove.Location = new System.Drawing.Point(12, 641);
            this.gbremove.Name = "gbremove";
            this.gbremove.Size = new System.Drawing.Size(426, 153);
            this.gbremove.TabIndex = 40;
            this.gbremove.TabStop = false;
            this.gbremove.Text = "Remove Item";
            // 
            // rinamecmb
            // 
            this.rinamecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rinamecmb.FormattingEnabled = true;
            this.rinamecmb.Location = new System.Drawing.Point(164, 28);
            this.rinamecmb.Name = "rinamecmb";
            this.rinamecmb.Size = new System.Drawing.Size(227, 32);
            this.rinamecmb.TabIndex = 40;
            // 
            // rideletebtn
            // 
            this.rideletebtn.Location = new System.Drawing.Point(164, 75);
            this.rideletebtn.Name = "rideletebtn";
            this.rideletebtn.Size = new System.Drawing.Size(227, 46);
            this.rideletebtn.TabIndex = 39;
            this.rideletebtn.Text = "Delete Item";
            this.rideletebtn.UseVisualStyleBackColor = true;
            this.rideletebtn.Click += new System.EventHandler(this.rideletebtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(42, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Item Name:";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(468, 323);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(800, 249);
            this.dgvProduct.TabIndex = 41;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numquantity);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.asnamecmb);
            this.groupBox3.Controls.Add(this.asAddStock);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 194);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Stock to an Exisiting Item";
            // 
            // numquantity
            // 
            this.numquantity.Location = new System.Drawing.Point(164, 85);
            this.numquantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numquantity.Name = "numquantity";
            this.numquantity.Size = new System.Drawing.Size(227, 29);
            this.numquantity.TabIndex = 42;
            this.numquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(65, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "Quantity:";
            // 
            // asnamecmb
            // 
            this.asnamecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.asnamecmb.FormattingEnabled = true;
            this.asnamecmb.Location = new System.Drawing.Point(164, 37);
            this.asnamecmb.Name = "asnamecmb";
            this.asnamecmb.Size = new System.Drawing.Size(227, 32);
            this.asnamecmb.TabIndex = 40;
            // 
            // asAddStock
            // 
            this.asAddStock.Location = new System.Drawing.Point(164, 132);
            this.asAddStock.Name = "asAddStock";
            this.asAddStock.Size = new System.Drawing.Size(227, 46);
            this.asAddStock.TabIndex = 39;
            this.asAddStock.Text = "Add Stock";
            this.asAddStock.UseVisualStyleBackColor = true;
            this.asAddStock.Click += new System.EventHandler(this.asAddStock_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(42, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Item Name:";
            // 
            // chkenableadddelete
            // 
            this.chkenableadddelete.AutoSize = true;
            this.chkenableadddelete.Checked = true;
            this.chkenableadddelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkenableadddelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkenableadddelete.ForeColor = System.Drawing.Color.Crimson;
            this.chkenableadddelete.Location = new System.Drawing.Point(12, 800);
            this.chkenableadddelete.Name = "chkenableadddelete";
            this.chkenableadddelete.Size = new System.Drawing.Size(361, 28);
            this.chkenableadddelete.TabIndex = 42;
            this.chkenableadddelete.Text = "Enable Adding/Deleting/Editing of Items";
            this.chkenableadddelete.UseVisualStyleBackColor = true;
            this.chkenableadddelete.CheckedChanged += new System.EventHandler(this.chkenableadddelete_CheckedChanged);
            // 
            // dgvDeliveryHistory
            // 
            this.dgvDeliveryHistory.AllowUserToAddRows = false;
            this.dgvDeliveryHistory.AllowUserToDeleteRows = false;
            this.dgvDeliveryHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveryHistory.Location = new System.Drawing.Point(468, 39);
            this.dgvDeliveryHistory.Name = "dgvDeliveryHistory";
            this.dgvDeliveryHistory.ReadOnly = true;
            this.dgvDeliveryHistory.Size = new System.Drawing.Size(800, 241);
            this.dgvDeliveryHistory.TabIndex = 43;
            // 
            // InvisibleFirstname
            // 
            this.InvisibleFirstname.AutoSize = true;
            this.InvisibleFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InvisibleFirstname.Location = new System.Drawing.Point(939, 292);
            this.InvisibleFirstname.Name = "InvisibleFirstname";
            this.InvisibleFirstname.Size = new System.Drawing.Size(160, 24);
            this.InvisibleFirstname.TabIndex = 44;
            this.InvisibleFirstname.Text = "InvisibleFirstname";
            this.InvisibleFirstname.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(464, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 45;
            this.label7.Text = "Product List";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(464, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "Delivery History";
            // 
            // gbedit
            // 
            this.gbedit.Controls.Add(this.eiprice);
            this.gbedit.Controls.Add(this.label11);
            this.gbedit.Controls.Add(this.einewname);
            this.gbedit.Controls.Add(this.label10);
            this.gbedit.Controls.Add(this.einamecmb);
            this.gbedit.Controls.Add(this.editbtn);
            this.gbedit.Controls.Add(this.label9);
            this.gbedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbedit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbedit.Location = new System.Drawing.Point(12, 427);
            this.gbedit.Name = "gbedit";
            this.gbedit.Size = new System.Drawing.Size(426, 208);
            this.gbedit.TabIndex = 47;
            this.gbedit.TabStop = false;
            this.gbedit.Text = "Edit Item";
            // 
            // eiprice
            // 
            this.eiprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.eiprice.Location = new System.Drawing.Point(164, 117);
            this.eiprice.Name = "eiprice";
            this.eiprice.Size = new System.Drawing.Size(227, 29);
            this.eiprice.TabIndex = 41;
            this.eiprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(90, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 24);
            this.label11.TabIndex = 40;
            this.label11.Text = "Price:";
            // 
            // einewname
            // 
            this.einewname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.einewname.Location = new System.Drawing.Point(164, 74);
            this.einewname.Name = "einewname";
            this.einewname.Size = new System.Drawing.Size(227, 29);
            this.einewname.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(42, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 24);
            this.label10.TabIndex = 41;
            this.label10.Text = "New Name:";
            // 
            // einamecmb
            // 
            this.einamecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.einamecmb.FormattingEnabled = true;
            this.einamecmb.Location = new System.Drawing.Point(164, 28);
            this.einamecmb.Name = "einamecmb";
            this.einamecmb.Size = new System.Drawing.Size(227, 32);
            this.einamecmb.TabIndex = 40;
            this.einamecmb.SelectedIndexChanged += new System.EventHandler(this.einamecmb_SelectedIndexChanged);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(164, 152);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(227, 46);
            this.editbtn.TabIndex = 39;
            this.editbtn.Text = "Edit Item";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(42, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "Item Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(464, 581);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 24);
            this.label12.TabIndex = 48;
            this.label12.Text = "Command History";
            // 
            // dgvCommandHistory
            // 
            this.dgvCommandHistory.AllowUserToAddRows = false;
            this.dgvCommandHistory.AllowUserToDeleteRows = false;
            this.dgvCommandHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandHistory.Location = new System.Drawing.Point(468, 611);
            this.dgvCommandHistory.Name = "dgvCommandHistory";
            this.dgvCommandHistory.ReadOnly = true;
            this.dgvCommandHistory.Size = new System.Drawing.Size(800, 211);
            this.dgvCommandHistory.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.Location = new System.Drawing.Point(939, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 24);
            this.label13.TabIndex = 50;
            this.label13.Text = "Access Type:";
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbladmin.Location = new System.Drawing.Point(1070, 9);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(75, 24);
            this.lbladmin.TabIndex = 51;
            this.lbladmin.Text = "Admin?";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 834);
            this.Controls.Add(this.lbladmin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvCommandHistory);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gbedit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InvisibleFirstname);
            this.Controls.Add(this.dgvDeliveryHistory);
            this.Controls.Add(this.chkenableadddelete);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.gbremove);
            this.Controls.Add(this.gbinitialize);
            this.Name = "InventoryForm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.gbinitialize.ResumeLayout(false);
            this.gbinitialize.PerformLayout();
            this.gbremove.ResumeLayout(false);
            this.gbremove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryHistory)).EndInit();
            this.gbedit.ResumeLayout(false);
            this.gbedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iicodetb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iinametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbinitialize;
        private System.Windows.Forms.Button initializebtn;
        private System.Windows.Forms.TextBox iipricetb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbremove;
        private System.Windows.Forms.ComboBox rinamecmb;
        private System.Windows.Forms.Button rideletebtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox asnamecmb;
        private System.Windows.Forms.Button asAddStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkenableadddelete;
        private System.Windows.Forms.NumericUpDown numquantity;
        private System.Windows.Forms.DataGridView dgvDeliveryHistory;
        private System.Windows.Forms.Label InvisibleFirstname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbedit;
        private System.Windows.Forms.TextBox eiprice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox einewname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox einamecmb;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvCommandHistory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbladmin;
    }
}