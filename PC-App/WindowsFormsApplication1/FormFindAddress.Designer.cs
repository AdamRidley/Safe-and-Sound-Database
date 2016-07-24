namespace WindowsFormsApplication1
{
    partial class FormFindAddress
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label Address_Line_1Label;
            System.Windows.Forms.Label Address_Line_2Label;
            System.Windows.Forms.Label Address_Line_3Label;
            System.Windows.Forms.Label TownLabel;
            System.Windows.Forms.Label Post_CodeLabel;
            System.Windows.Forms.Label NotesLabel;
            this.Label2 = new System.Windows.Forms.Label();
            this.AddressesDataGridView = new System.Windows.Forms.DataGridView();
            this.Address_Line_1TextBox = new System.Windows.Forms.TextBox();
            this.Address_Line_2TextBox = new System.Windows.Forms.TextBox();
            this.Address_Line_3TextBox = new System.Windows.Forms.TextBox();
            this.TownTextBox = new System.Windows.Forms.TextBox();
            this.Post_CodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.Phone_NumbersDataGridView = new System.Windows.Forms.DataGridView();
            this.TitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButChoose = new System.Windows.Forms.Button();
            this.ButCancel = new System.Windows.Forms.Button();
            this.CustAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.safeandsounddb1DataSet = new WindowsFormsApplication1.safeandsounddb1DataSet();
            this.addressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.addressesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager();
            this.phone_NumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phone_NumbersTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Phone_NumbersTableAdapter();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.CustomersTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIntervalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Address_Line_1Label = new System.Windows.Forms.Label();
            Address_Line_2Label = new System.Windows.Forms.Label();
            Address_Line_3Label = new System.Windows.Forms.Label();
            TownLabel = new System.Windows.Forms.Label();
            Post_CodeLabel = new System.Windows.Forms.Label();
            NotesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddressesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone_NumbersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustAddBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_NumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Address_Line_1Label
            // 
            Address_Line_1Label.AutoSize = true;
            Address_Line_1Label.Location = new System.Drawing.Point(45, 32);
            Address_Line_1Label.Name = "Address_Line_1Label";
            Address_Line_1Label.Size = new System.Drawing.Size(80, 13);
            Address_Line_1Label.TabIndex = 37;
            Address_Line_1Label.Text = "Address Line 1:";
            // 
            // Address_Line_2Label
            // 
            Address_Line_2Label.AutoSize = true;
            Address_Line_2Label.Location = new System.Drawing.Point(269, 32);
            Address_Line_2Label.Name = "Address_Line_2Label";
            Address_Line_2Label.Size = new System.Drawing.Size(80, 13);
            Address_Line_2Label.TabIndex = 39;
            Address_Line_2Label.Text = "Address Line 2:";
            // 
            // Address_Line_3Label
            // 
            Address_Line_3Label.AutoSize = true;
            Address_Line_3Label.Location = new System.Drawing.Point(493, 32);
            Address_Line_3Label.Name = "Address_Line_3Label";
            Address_Line_3Label.Size = new System.Drawing.Size(80, 13);
            Address_Line_3Label.TabIndex = 41;
            Address_Line_3Label.Text = "Address Line 3:";
            // 
            // TownLabel
            // 
            TownLabel.AutoSize = true;
            TownLabel.Location = new System.Drawing.Point(88, 58);
            TownLabel.Name = "TownLabel";
            TownLabel.Size = new System.Drawing.Size(37, 13);
            TownLabel.TabIndex = 43;
            TownLabel.Text = "Town:";
            // 
            // Post_CodeLabel
            // 
            Post_CodeLabel.AutoSize = true;
            Post_CodeLabel.Location = new System.Drawing.Point(290, 58);
            Post_CodeLabel.Name = "Post_CodeLabel";
            Post_CodeLabel.Size = new System.Drawing.Size(59, 13);
            Post_CodeLabel.TabIndex = 45;
            Post_CodeLabel.Text = "Post Code:";
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Location = new System.Drawing.Point(535, 58);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new System.Drawing.Size(38, 13);
            NotesLabel.TabIndex = 47;
            NotesLabel.Text = "Notes:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 13);
            this.Label2.TabIndex = 51;
            this.Label2.Text = "Enter search details:";
            // 
            // AddressesDataGridView
            // 
            this.AddressesDataGridView.AllowUserToAddRows = false;
            this.AddressesDataGridView.AllowUserToDeleteRows = false;
            this.AddressesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressesDataGridView.AutoGenerateColumns = false;
            this.AddressesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressIDDataGridViewTextBoxColumn,
            this.addressLine1DataGridViewTextBoxColumn,
            this.addressLine2DataGridViewTextBoxColumn,
            this.addressLine3DataGridViewTextBoxColumn,
            this.townDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.AddressesDataGridView.DataSource = this.addressesBindingSource;
            this.AddressesDataGridView.Location = new System.Drawing.Point(11, 94);
            this.AddressesDataGridView.Name = "AddressesDataGridView";
            this.AddressesDataGridView.ReadOnly = true;
            this.AddressesDataGridView.RowHeadersWidth = 25;
            this.AddressesDataGridView.Size = new System.Drawing.Size(728, 185);
            this.AddressesDataGridView.TabIndex = 48;
            // 
            // Address_Line_1TextBox
            // 
            this.Address_Line_1TextBox.Location = new System.Drawing.Point(147, 29);
            this.Address_Line_1TextBox.Name = "Address_Line_1TextBox";
            this.Address_Line_1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Address_Line_1TextBox.TabIndex = 38;
            // 
            // Address_Line_2TextBox
            // 
            this.Address_Line_2TextBox.Location = new System.Drawing.Point(371, 29);
            this.Address_Line_2TextBox.Name = "Address_Line_2TextBox";
            this.Address_Line_2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Address_Line_2TextBox.TabIndex = 40;
            // 
            // Address_Line_3TextBox
            // 
            this.Address_Line_3TextBox.Location = new System.Drawing.Point(595, 29);
            this.Address_Line_3TextBox.Name = "Address_Line_3TextBox";
            this.Address_Line_3TextBox.Size = new System.Drawing.Size(100, 20);
            this.Address_Line_3TextBox.TabIndex = 42;
            // 
            // TownTextBox
            // 
            this.TownTextBox.Location = new System.Drawing.Point(147, 55);
            this.TownTextBox.Name = "TownTextBox";
            this.TownTextBox.Size = new System.Drawing.Size(100, 20);
            this.TownTextBox.TabIndex = 44;
            // 
            // Post_CodeMaskedTextBox
            // 
            this.Post_CodeMaskedTextBox.Location = new System.Drawing.Point(371, 55);
            this.Post_CodeMaskedTextBox.Name = "Post_CodeMaskedTextBox";
            this.Post_CodeMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.Post_CodeMaskedTextBox.TabIndex = 46;
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(595, 55);
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(100, 20);
            this.NotesTextBox.TabIndex = 49;
            // 
            // Phone_NumbersDataGridView
            // 
            this.Phone_NumbersDataGridView.AllowUserToAddRows = false;
            this.Phone_NumbersDataGridView.AllowUserToDeleteRows = false;
            this.Phone_NumbersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Phone_NumbersDataGridView.AutoGenerateColumns = false;
            this.Phone_NumbersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Phone_NumbersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.custAddIDDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.Phone_NumbersDataGridView.DataSource = this.phone_NumbersBindingSource;
            this.Phone_NumbersDataGridView.Location = new System.Drawing.Point(745, 94);
            this.Phone_NumbersDataGridView.Name = "Phone_NumbersDataGridView";
            this.Phone_NumbersDataGridView.ReadOnly = true;
            this.Phone_NumbersDataGridView.RowHeadersWidth = 25;
            this.Phone_NumbersDataGridView.Size = new System.Drawing.Size(137, 185);
            this.Phone_NumbersDataGridView.TabIndex = 54;
            // 
            // TitlesBindingSource
            // 
            this.TitlesBindingSource.DataMember = "Titles";
            // 
            // ButChoose
            // 
            this.ButChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButChoose.Enabled = false;
            this.ButChoose.Location = new System.Drawing.Point(745, 291);
            this.ButChoose.Name = "ButChoose";
            this.ButChoose.Size = new System.Drawing.Size(65, 32);
            this.ButChoose.TabIndex = 53;
            this.ButChoose.Text = "C&hoose";
            this.ButChoose.UseVisualStyleBackColor = true;
            // 
            // ButCancel
            // 
            this.ButCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButCancel.Location = new System.Drawing.Point(817, 291);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(65, 32);
            this.ButCancel.TabIndex = 52;
            this.ButCancel.Text = "&Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.AllowUserToAddRows = false;
            this.CustomersDataGridView.AllowUserToDeleteRows = false;
            this.CustomersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersDataGridView.AutoGenerateColumns = false;
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.eMailAddressDataGridViewTextBoxColumn,
            this.serviceIntervalDataGridViewTextBoxColumn});
            this.CustomersDataGridView.DataSource = this.customersBindingSource;
            this.CustomersDataGridView.Location = new System.Drawing.Point(11, 285);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.ReadOnly = true;
            this.CustomersDataGridView.RowHeadersWidth = 25;
            this.CustomersDataGridView.Size = new System.Drawing.Size(728, 43);
            this.CustomersDataGridView.TabIndex = 50;
            // 
            // safeandsounddb1DataSet
            // 
            this.safeandsounddb1DataSet.DataSetName = "safeandsounddb1DataSet";
            this.safeandsounddb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressesBindingSource
            // 
            this.addressesBindingSource.DataMember = "addresses";
            this.addressesBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // addressesTableAdapter
            // 
            this.addressesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressesTableAdapter = this.addressesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.correspondent_products_linkTableAdapter = null;
            this.tableAdapterManager.correspondentsTableAdapter = null;
            this.tableAdapterManager.CustAddTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.Installation_Products_LinkTableAdapter = null;
            this.tableAdapterManager.Phone_NumbersTableAdapter = this.phone_NumbersTableAdapter;
            this.tableAdapterManager.Prod_MakeTableAdapter = null;
            this.tableAdapterManager.Prod_ModelTableAdapter = null;
            this.tableAdapterManager.Prod_TypeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.ServiceZoneMesTableAdapter = null;
            this.tableAdapterManager.TitlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zone_ListTableAdapter = null;
            this.tableAdapterManager.Zone_MappingsTableAdapter = null;
            this.tableAdapterManager.Zone_TypesTableAdapter = null;
            // 
            // phone_NumbersBindingSource
            // 
            this.phone_NumbersBindingSource.DataMember = "Phone Numbers";
            this.phone_NumbersBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // phone_NumbersTableAdapter
            // 
            this.phone_NumbersTableAdapter.ClearBeforeFill = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 50;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // eMailAddressDataGridViewTextBoxColumn
            // 
            this.eMailAddressDataGridViewTextBoxColumn.DataPropertyName = "E-Mail Address";
            this.eMailAddressDataGridViewTextBoxColumn.HeaderText = "E-Mail Address";
            this.eMailAddressDataGridViewTextBoxColumn.Name = "eMailAddressDataGridViewTextBoxColumn";
            this.eMailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMailAddressDataGridViewTextBoxColumn.Width = 250;
            // 
            // serviceIntervalDataGridViewTextBoxColumn
            // 
            this.serviceIntervalDataGridViewTextBoxColumn.DataPropertyName = "Service Interval";
            this.serviceIntervalDataGridViewTextBoxColumn.HeaderText = "Service Interval";
            this.serviceIntervalDataGridViewTextBoxColumn.Name = "serviceIntervalDataGridViewTextBoxColumn";
            this.serviceIntervalDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIntervalDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressIDDataGridViewTextBoxColumn
            // 
            this.addressIDDataGridViewTextBoxColumn.DataPropertyName = "Address ID";
            this.addressIDDataGridViewTextBoxColumn.HeaderText = "Address ID";
            this.addressIDDataGridViewTextBoxColumn.Name = "addressIDDataGridViewTextBoxColumn";
            this.addressIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressLine1DataGridViewTextBoxColumn
            // 
            this.addressLine1DataGridViewTextBoxColumn.DataPropertyName = "Address Line 1";
            this.addressLine1DataGridViewTextBoxColumn.HeaderText = "Address Line 1";
            this.addressLine1DataGridViewTextBoxColumn.Name = "addressLine1DataGridViewTextBoxColumn";
            this.addressLine1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressLine2DataGridViewTextBoxColumn
            // 
            this.addressLine2DataGridViewTextBoxColumn.DataPropertyName = "Address Line 2";
            this.addressLine2DataGridViewTextBoxColumn.HeaderText = "Address Line 2";
            this.addressLine2DataGridViewTextBoxColumn.Name = "addressLine2DataGridViewTextBoxColumn";
            this.addressLine2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressLine3DataGridViewTextBoxColumn
            // 
            this.addressLine3DataGridViewTextBoxColumn.DataPropertyName = "Address Line 3";
            this.addressLine3DataGridViewTextBoxColumn.HeaderText = "Address Line 3";
            this.addressLine3DataGridViewTextBoxColumn.Name = "addressLine3DataGridViewTextBoxColumn";
            this.addressLine3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // townDataGridViewTextBoxColumn
            // 
            this.townDataGridViewTextBoxColumn.DataPropertyName = "Town";
            this.townDataGridViewTextBoxColumn.HeaderText = "Town";
            this.townDataGridViewTextBoxColumn.Name = "townDataGridViewTextBoxColumn";
            this.townDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "Post Code";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "Post Code";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            this.postCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 200;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // custAddIDDataGridViewTextBoxColumn
            // 
            this.custAddIDDataGridViewTextBoxColumn.DataPropertyName = "CustAdd ID";
            this.custAddIDDataGridViewTextBoxColumn.HeaderText = "CustAdd ID";
            this.custAddIDDataGridViewTextBoxColumn.Name = "custAddIDDataGridViewTextBoxColumn";
            this.custAddIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.custAddIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 338);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.AddressesDataGridView);
            this.Controls.Add(this.Address_Line_1TextBox);
            this.Controls.Add(this.Address_Line_2TextBox);
            this.Controls.Add(this.Address_Line_3TextBox);
            this.Controls.Add(this.TownTextBox);
            this.Controls.Add(this.Post_CodeMaskedTextBox);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.Phone_NumbersDataGridView);
            this.Controls.Add(Address_Line_1Label);
            this.Controls.Add(Address_Line_2Label);
            this.Controls.Add(Address_Line_3Label);
            this.Controls.Add(TownLabel);
            this.Controls.Add(Post_CodeLabel);
            this.Controls.Add(NotesLabel);
            this.Controls.Add(this.ButChoose);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.CustomersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Find Address";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddressesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone_NumbersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustAddBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_NumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView AddressesDataGridView;
        internal System.Windows.Forms.TextBox Address_Line_1TextBox;
        internal System.Windows.Forms.TextBox Address_Line_2TextBox;
        internal System.Windows.Forms.TextBox Address_Line_3TextBox;
        internal System.Windows.Forms.TextBox TownTextBox;
        internal System.Windows.Forms.MaskedTextBox Post_CodeMaskedTextBox;
        internal System.Windows.Forms.TextBox NotesTextBox;
        internal System.Windows.Forms.DataGridView Phone_NumbersDataGridView;
        internal System.Windows.Forms.BindingSource TitlesBindingSource;
        internal System.Windows.Forms.Button ButChoose;
        internal System.Windows.Forms.Button ButCancel;
        internal System.Windows.Forms.BindingSource CustAddBindingSource;
        internal System.Windows.Forms.DataGridView CustomersDataGridView;
        private safeandsounddb1DataSet safeandsounddb1DataSet;
        private System.Windows.Forms.BindingSource addressesBindingSource;
        private safeandsounddb1DataSetTableAdapters.addressesTableAdapter addressesTableAdapter;
        private safeandsounddb1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private safeandsounddb1DataSetTableAdapters.Phone_NumbersTableAdapter phone_NumbersTableAdapter;
        private System.Windows.Forms.BindingSource phone_NumbersBindingSource;
        private safeandsounddb1DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIntervalDataGridViewTextBoxColumn;
    }
}