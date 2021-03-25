namespace LaundryAutomation
{
    partial class LogHistoryForm
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
            this.dgvloghistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloghistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvloghistory
            // 
            this.dgvloghistory.AllowUserToAddRows = false;
            this.dgvloghistory.AllowUserToDeleteRows = false;
            this.dgvloghistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloghistory.Location = new System.Drawing.Point(27, 88);
            this.dgvloghistory.Name = "dgvloghistory";
            this.dgvloghistory.ReadOnly = true;
            this.dgvloghistory.Size = new System.Drawing.Size(577, 307);
            this.dgvloghistory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(241, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Log History";
            // 
            // LogHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvloghistory);
            this.Name = "LogHistoryForm";
            this.Text = "LogHistory";
            this.Load += new System.EventHandler(this.LogHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvloghistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvloghistory;
        private System.Windows.Forms.Label label1;
    }
}