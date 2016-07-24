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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.ButCustomerEdit = new System.Windows.Forms.Button();
            this.ButCustomerAdd = new System.Windows.Forms.Button();
            this.AddressesTab = new System.Windows.Forms.TabPage();
            this.ButAddressEdit = new System.Windows.Forms.Button();
            this.ButAddressAdd = new System.Windows.Forms.Button();
            this.ServicesTab = new System.Windows.Forms.TabPage();
            this.ButServiceEdit = new System.Windows.Forms.Button();
            this.ButServiceAdd = new System.Windows.Forms.Button();
            this.InstallationsTab = new System.Windows.Forms.TabPage();
            this.ButInstallationEdit = new System.Windows.Forms.Button();
            this.ButInstallationAdd = new System.Windows.Forms.Button();
            this.CorrespondentsTab = new System.Windows.Forms.TabPage();
            this.ButCorrespondentEdit = new System.Windows.Forms.Button();
            this.ButCorrespondentAdd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.CustomersTab.SuspendLayout();
            this.AddressesTab.SuspendLayout();
            this.ServicesTab.SuspendLayout();
            this.InstallationsTab.SuspendLayout();
            this.CorrespondentsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.CustomersTab);
            this.tabControl1.Controls.Add(this.AddressesTab);
            this.tabControl1.Controls.Add(this.ServicesTab);
            this.tabControl1.Controls.Add(this.InstallationsTab);
            this.tabControl1.Controls.Add(this.CorrespondentsTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 215);
            this.tabControl1.TabIndex = 0;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.ButCustomerEdit);
            this.CustomersTab.Controls.Add(this.ButCustomerAdd);
            this.CustomersTab.Location = new System.Drawing.Point(4, 22);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTab.Size = new System.Drawing.Size(323, 189);
            this.CustomersTab.TabIndex = 0;
            this.CustomersTab.Text = "Customers";
            this.CustomersTab.UseVisualStyleBackColor = true;
            // 
            // ButCustomerEdit
            // 
            this.ButCustomerEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButCustomerEdit.Location = new System.Drawing.Point(42, 56);
            this.ButCustomerEdit.Name = "ButCustomerEdit";
            this.ButCustomerEdit.Size = new System.Drawing.Size(234, 26);
            this.ButCustomerEdit.TabIndex = 1;
            this.ButCustomerEdit.Text = "&Edit/View Customer";
            this.ButCustomerEdit.UseVisualStyleBackColor = true;
            this.ButCustomerEdit.Click += new System.EventHandler(this.ButCustomerEdit_Click);
            // 
            // ButCustomerAdd
            // 
            this.ButCustomerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButCustomerAdd.Location = new System.Drawing.Point(42, 24);
            this.ButCustomerAdd.Name = "ButCustomerAdd";
            this.ButCustomerAdd.Size = new System.Drawing.Size(234, 26);
            this.ButCustomerAdd.TabIndex = 0;
            this.ButCustomerAdd.Text = "&Add Customer";
            this.ButCustomerAdd.UseVisualStyleBackColor = true;
            this.ButCustomerAdd.Click += new System.EventHandler(this.ButCustomerAdd_Click);
            // 
            // AddressesTab
            // 
            this.AddressesTab.Controls.Add(this.ButAddressEdit);
            this.AddressesTab.Controls.Add(this.ButAddressAdd);
            this.AddressesTab.Location = new System.Drawing.Point(4, 22);
            this.AddressesTab.Name = "AddressesTab";
            this.AddressesTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddressesTab.Size = new System.Drawing.Size(323, 189);
            this.AddressesTab.TabIndex = 1;
            this.AddressesTab.Text = "Addresses";
            this.AddressesTab.UseVisualStyleBackColor = true;
            // 
            // ButAddressEdit
            // 
            this.ButAddressEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButAddressEdit.Location = new System.Drawing.Point(44, 56);
            this.ButAddressEdit.Name = "ButAddressEdit";
            this.ButAddressEdit.Size = new System.Drawing.Size(234, 26);
            this.ButAddressEdit.TabIndex = 3;
            this.ButAddressEdit.Text = "&Edit/View Address";
            this.ButAddressEdit.UseVisualStyleBackColor = true;
            // 
            // ButAddressAdd
            // 
            this.ButAddressAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButAddressAdd.Location = new System.Drawing.Point(44, 24);
            this.ButAddressAdd.Name = "ButAddressAdd";
            this.ButAddressAdd.Size = new System.Drawing.Size(234, 26);
            this.ButAddressAdd.TabIndex = 2;
            this.ButAddressAdd.Text = "&Add Address";
            this.ButAddressAdd.UseVisualStyleBackColor = true;
            this.ButAddressAdd.Click += new System.EventHandler(this.ButAddressAdd_Click);
            // 
            // ServicesTab
            // 
            this.ServicesTab.Controls.Add(this.ButServiceEdit);
            this.ServicesTab.Controls.Add(this.ButServiceAdd);
            this.ServicesTab.Location = new System.Drawing.Point(4, 22);
            this.ServicesTab.Name = "ServicesTab";
            this.ServicesTab.Size = new System.Drawing.Size(323, 189);
            this.ServicesTab.TabIndex = 2;
            this.ServicesTab.Text = "Services";
            this.ServicesTab.UseVisualStyleBackColor = true;
            // 
            // ButServiceEdit
            // 
            this.ButServiceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButServiceEdit.Location = new System.Drawing.Point(44, 56);
            this.ButServiceEdit.Name = "ButServiceEdit";
            this.ButServiceEdit.Size = new System.Drawing.Size(234, 26);
            this.ButServiceEdit.TabIndex = 5;
            this.ButServiceEdit.Text = "&Edit/View Service";
            this.ButServiceEdit.UseVisualStyleBackColor = true;
            // 
            // ButServiceAdd
            // 
            this.ButServiceAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButServiceAdd.Location = new System.Drawing.Point(44, 24);
            this.ButServiceAdd.Name = "ButServiceAdd";
            this.ButServiceAdd.Size = new System.Drawing.Size(234, 26);
            this.ButServiceAdd.TabIndex = 4;
            this.ButServiceAdd.Text = "&Add Service";
            this.ButServiceAdd.UseVisualStyleBackColor = true;
            // 
            // InstallationsTab
            // 
            this.InstallationsTab.Controls.Add(this.ButInstallationEdit);
            this.InstallationsTab.Controls.Add(this.ButInstallationAdd);
            this.InstallationsTab.Location = new System.Drawing.Point(4, 22);
            this.InstallationsTab.Name = "InstallationsTab";
            this.InstallationsTab.Size = new System.Drawing.Size(323, 189);
            this.InstallationsTab.TabIndex = 3;
            this.InstallationsTab.Text = "Installations";
            this.InstallationsTab.UseVisualStyleBackColor = true;
            // 
            // ButInstallationEdit
            // 
            this.ButInstallationEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButInstallationEdit.Location = new System.Drawing.Point(44, 56);
            this.ButInstallationEdit.Name = "ButInstallationEdit";
            this.ButInstallationEdit.Size = new System.Drawing.Size(234, 26);
            this.ButInstallationEdit.TabIndex = 7;
            this.ButInstallationEdit.Text = "&Edit/View Installation";
            this.ButInstallationEdit.UseVisualStyleBackColor = true;
            // 
            // ButInstallationAdd
            // 
            this.ButInstallationAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButInstallationAdd.Location = new System.Drawing.Point(44, 24);
            this.ButInstallationAdd.Name = "ButInstallationAdd";
            this.ButInstallationAdd.Size = new System.Drawing.Size(234, 26);
            this.ButInstallationAdd.TabIndex = 6;
            this.ButInstallationAdd.Text = "&Add Installation";
            this.ButInstallationAdd.UseVisualStyleBackColor = true;
            // 
            // CorrespondentsTab
            // 
            this.CorrespondentsTab.Controls.Add(this.ButCorrespondentEdit);
            this.CorrespondentsTab.Controls.Add(this.ButCorrespondentAdd);
            this.CorrespondentsTab.Location = new System.Drawing.Point(4, 22);
            this.CorrespondentsTab.Name = "CorrespondentsTab";
            this.CorrespondentsTab.Size = new System.Drawing.Size(323, 189);
            this.CorrespondentsTab.TabIndex = 4;
            this.CorrespondentsTab.Text = "Correspondents";
            this.CorrespondentsTab.UseVisualStyleBackColor = true;
            // 
            // ButCorrespondentEdit
            // 
            this.ButCorrespondentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButCorrespondentEdit.Location = new System.Drawing.Point(44, 56);
            this.ButCorrespondentEdit.Name = "ButCorrespondentEdit";
            this.ButCorrespondentEdit.Size = new System.Drawing.Size(234, 26);
            this.ButCorrespondentEdit.TabIndex = 9;
            this.ButCorrespondentEdit.Text = "&Edit/View Correspondent";
            this.ButCorrespondentEdit.UseVisualStyleBackColor = true;
            // 
            // ButCorrespondentAdd
            // 
            this.ButCorrespondentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButCorrespondentAdd.Location = new System.Drawing.Point(44, 24);
            this.ButCorrespondentAdd.Name = "ButCorrespondentAdd";
            this.ButCorrespondentAdd.Size = new System.Drawing.Size(234, 26);
            this.ButCorrespondentAdd.TabIndex = 8;
            this.ButCorrespondentAdd.Text = "&Add Correspondent";
            this.ButCorrespondentAdd.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 221);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.tabControl1.ResumeLayout(false);
            this.CustomersTab.ResumeLayout(false);
            this.AddressesTab.ResumeLayout(false);
            this.ServicesTab.ResumeLayout(false);
            this.InstallationsTab.ResumeLayout(false);
            this.CorrespondentsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CustomersTab;
        private System.Windows.Forms.Button ButCustomerEdit;
        private System.Windows.Forms.Button ButCustomerAdd;
        private System.Windows.Forms.TabPage AddressesTab;
        private System.Windows.Forms.Button ButAddressEdit;
        private System.Windows.Forms.Button ButAddressAdd;
        private System.Windows.Forms.TabPage ServicesTab;
        private System.Windows.Forms.Button ButServiceEdit;
        private System.Windows.Forms.Button ButServiceAdd;
        private System.Windows.Forms.TabPage InstallationsTab;
        private System.Windows.Forms.Button ButInstallationEdit;
        private System.Windows.Forms.Button ButInstallationAdd;
        private System.Windows.Forms.TabPage CorrespondentsTab;
        private System.Windows.Forms.Button ButCorrespondentEdit;
        private System.Windows.Forms.Button ButCorrespondentAdd;
    }
}

