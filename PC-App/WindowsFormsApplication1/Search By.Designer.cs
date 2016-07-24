namespace WindowsFormsApplication1
{
    partial class Search_By
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
            this.ButByAddress = new System.Windows.Forms.Button();
            this.ButByCustomer = new System.Windows.Forms.Button();
            this.ButCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButByAddress
            // 
            this.ButByAddress.Location = new System.Drawing.Point(13, 61);
            this.ButByAddress.Name = "ButByAddress";
            this.ButByAddress.Size = new System.Drawing.Size(197, 37);
            this.ButByAddress.TabIndex = 8;
            this.ButByAddress.Text = "Search by &Address";
            this.ButByAddress.UseVisualStyleBackColor = true;
            this.ButByAddress.Click += new System.EventHandler(this.ButByAddress_Click);
            // 
            // ButByCustomer
            // 
            this.ButByCustomer.Location = new System.Drawing.Point(12, 12);
            this.ButByCustomer.Name = "ButByCustomer";
            this.ButByCustomer.Size = new System.Drawing.Size(197, 37);
            this.ButByCustomer.TabIndex = 7;
            this.ButByCustomer.Text = "Search by C&ustomer";
            this.ButByCustomer.UseVisualStyleBackColor = true;
            this.ButByCustomer.Click += new System.EventHandler(this.ButByCustomer_Click);
            // 
            // ButCancel
            // 
            this.ButCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButCancel.Location = new System.Drawing.Point(124, 106);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(85, 24);
            this.ButCancel.TabIndex = 6;
            this.ButCancel.Text = "&Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            this.ButCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // Search_By
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButCancel;
            this.ClientSize = new System.Drawing.Size(221, 145);
            this.Controls.Add(this.ButByAddress);
            this.Controls.Add(this.ButByCustomer);
            this.Controls.Add(this.ButCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search_By";
            this.Text = "Search by";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_By_FormClosing);
            this.Load += new System.EventHandler(this.Search_By_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button ButByAddress;
        internal System.Windows.Forms.Button ButByCustomer;
        internal System.Windows.Forms.Button ButCancel;
    }
}