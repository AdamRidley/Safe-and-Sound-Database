namespace WindowsFormsApplication1
{
    partial class FormMenu
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
            this.AddressesTab = new System.Windows.Forms.TabPage();
            this.ButAddressAdd = new System.Windows.Forms.Button();
            this.ButAddressEdit = new System.Windows.Forms.Button();
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.ButCustomerAdd = new System.Windows.Forms.Button();
            this.ButCustomerEdit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddressesTab.SuspendLayout();
            this.CustomersTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddressesTab
            // 
            this.AddressesTab.Controls.Add(this.ButAddressEdit);
            this.AddressesTab.Controls.Add(this.ButAddressAdd);
            this.AddressesTab.Location = new System.Drawing.Point(4, 22);
            this.AddressesTab.Name = "AddressesTab";
            this.AddressesTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddressesTab.Size = new System.Drawing.Size(192, 98);
            this.AddressesTab.TabIndex = 1;
            this.AddressesTab.Text = "Addresses";
            this.AddressesTab.UseVisualStyleBackColor = true;
            // 
            // ButAddressAdd
            // 
            this.ButAddressAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButAddressAdd.Location = new System.Drawing.Point(28, 18);
            this.ButAddressAdd.Name = "ButAddressAdd";
            this.ButAddressAdd.Size = new System.Drawing.Size(144, 26);
            this.ButAddressAdd.TabIndex = 2;
            this.ButAddressAdd.Text = "&Add Address";
            this.ButAddressAdd.UseVisualStyleBackColor = true;
            this.ButAddressAdd.Click += new System.EventHandler(this.ButAddressAdd_Click);
            // 
            // ButAddressEdit
            // 
            this.ButAddressEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButAddressEdit.Location = new System.Drawing.Point(28, 50);
            this.ButAddressEdit.Name = "ButAddressEdit";
            this.ButAddressEdit.Size = new System.Drawing.Size(144, 26);
            this.ButAddressEdit.TabIndex = 3;
            this.ButAddressEdit.Text = "&Edit/View Address";
            this.ButAddressEdit.UseVisualStyleBackColor = true;
            this.ButAddressEdit.Click += new System.EventHandler(this.ButAddressEdit_Click);
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.ButCustomerEdit);
            this.CustomersTab.Controls.Add(this.ButCustomerAdd);
            this.CustomersTab.Location = new System.Drawing.Point(4, 22);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTab.Size = new System.Drawing.Size(192, 98);
            this.CustomersTab.TabIndex = 0;
            this.CustomersTab.Text = "Customers";
            this.CustomersTab.UseVisualStyleBackColor = true;
            // 
            // ButCustomerAdd
            // 
            this.ButCustomerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButCustomerAdd.Location = new System.Drawing.Point(28, 18);
            this.ButCustomerAdd.Name = "ButCustomerAdd";
            this.ButCustomerAdd.Size = new System.Drawing.Size(144, 26);
            this.ButCustomerAdd.TabIndex = 0;
            this.ButCustomerAdd.Text = "&Add Customer";
            this.ButCustomerAdd.UseVisualStyleBackColor = true;
            this.ButCustomerAdd.Click += new System.EventHandler(this.ButCustomerAdd_Click);
            // 
            // ButCustomerEdit
            // 
            this.ButCustomerEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButCustomerEdit.Location = new System.Drawing.Point(28, 50);
            this.ButCustomerEdit.Name = "ButCustomerEdit";
            this.ButCustomerEdit.Size = new System.Drawing.Size(144, 26);
            this.ButCustomerEdit.TabIndex = 1;
            this.ButCustomerEdit.Text = "&Edit/View Customer";
            this.ButCustomerEdit.UseVisualStyleBackColor = true;
            this.ButCustomerEdit.Click += new System.EventHandler(this.ButCustomerEdit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.CustomersTab);
            this.tabControl1.Controls.Add(this.AddressesTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 124);
            this.tabControl1.TabIndex = 0;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 130);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.AddressesTab.ResumeLayout(false);
            this.CustomersTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage AddressesTab;
        private System.Windows.Forms.Button ButAddressEdit;
        private System.Windows.Forms.Button ButAddressAdd;
        private System.Windows.Forms.TabPage CustomersTab;
        private System.Windows.Forms.Button ButCustomerEdit;
        private System.Windows.Forms.Button ButCustomerAdd;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

