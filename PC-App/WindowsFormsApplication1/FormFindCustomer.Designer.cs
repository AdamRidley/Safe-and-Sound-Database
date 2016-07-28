namespace WindowsFormsApplication1
{
    partial class FormFindCustomer
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
            System.Windows.Forms.Label E_Mail_AddressLabel;
            System.Windows.Forms.Label TitleLabel;
            System.Windows.Forms.Label First_NameLabel;
            System.Windows.Forms.Label Last_NameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddressesDataGridView = new System.Windows.Forms.DataGridView();
            this.addressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.safeandsounddb1DataSet = new WindowsFormsApplication1.safeandsounddb1DataSet();
            this.TitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Phone_NumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneNumbersibfk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.TitleComboBox = new System.Windows.Forms.ComboBox();
            this.First_NameTextBox = new System.Windows.Forms.TextBox();
            this.Last_NameTextBox = new System.Windows.Forms.TextBox();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButCancel = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.E_Mail_AddressTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.ButChoose = new System.Windows.Forms.Button();
            this.Phone_NumbersDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TitlesTableAdapter();
            this.phone_NumbersTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Phone_NumbersTableAdapter();
            this.customersTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.CustomersTableAdapter();
            this.addressesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.addressesTableAdapter();
            this.custAddTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.CustAddTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager();
            this.customers_Friendly_ViewTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Customers_Friendly_ViewTableAdapter();
            E_Mail_AddressLabel = new System.Windows.Forms.Label();
            TitleLabel = new System.Windows.Forms.Label();
            First_NameLabel = new System.Windows.Forms.Label();
            Last_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddressesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone_NumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumbersibfk1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAddBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone_NumbersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // E_Mail_AddressLabel
            // 
            E_Mail_AddressLabel.AutoSize = true;
            E_Mail_AddressLabel.Location = new System.Drawing.Point(22, 76);
            E_Mail_AddressLabel.Name = "E_Mail_AddressLabel";
            E_Mail_AddressLabel.Size = new System.Drawing.Size(80, 13);
            E_Mail_AddressLabel.TabIndex = 47;
            E_Mail_AddressLabel.Text = "E-Mail Address:";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new System.Drawing.Point(8, 39);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new System.Drawing.Size(30, 13);
            TitleLabel.TabIndex = 36;
            TitleLabel.Text = "Title:";
            // 
            // First_NameLabel
            // 
            First_NameLabel.AutoSize = true;
            First_NameLabel.Location = new System.Drawing.Point(123, 39);
            First_NameLabel.Name = "First_NameLabel";
            First_NameLabel.Size = new System.Drawing.Size(60, 13);
            First_NameLabel.TabIndex = 38;
            First_NameLabel.Text = "First Name:";
            // 
            // Last_NameLabel
            // 
            Last_NameLabel.AutoSize = true;
            Last_NameLabel.Location = new System.Drawing.Point(373, 39);
            Last_NameLabel.Name = "Last_NameLabel";
            Last_NameLabel.Size = new System.Drawing.Size(61, 13);
            Last_NameLabel.TabIndex = 40;
            Last_NameLabel.Text = "Last Name:";
            // 
            // AddressesDataGridView
            // 
            this.AddressesDataGridView.AllowUserToAddRows = false;
            this.AddressesDataGridView.AllowUserToDeleteRows = false;
            this.AddressesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            this.AddressesDataGridView.DataSource = this.AddressesBindingSource;
            this.AddressesDataGridView.Location = new System.Drawing.Point(11, 333);
            this.AddressesDataGridView.MultiSelect = false;
            this.AddressesDataGridView.Name = "AddressesDataGridView";
            this.AddressesDataGridView.ReadOnly = true;
            this.AddressesDataGridView.RowHeadersWidth = 25;
            this.AddressesDataGridView.RowTemplate.Height = 33;
            this.AddressesDataGridView.Size = new System.Drawing.Size(649, 142);
            this.AddressesDataGridView.TabIndex = 45;
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
            // 
            // AddressesBindingSource
            // 
            this.AddressesBindingSource.DataMember = "addresses";
            this.AddressesBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // safeandsounddb1DataSet
            // 
            this.safeandsounddb1DataSet.DataSetName = "safeandsounddb1DataSet";
            this.safeandsounddb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TitlesBindingSource
            // 
            this.TitlesBindingSource.DataMember = "Titles";
            this.TitlesBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // Phone_NumbersBindingSource
            // 
            this.Phone_NumbersBindingSource.DataSource = this.phoneNumbersibfk1BindingSource;
            // 
            // phoneNumbersibfk1BindingSource
            // 
            this.phoneNumbersibfk1BindingSource.DataMember = "phone numbers_ibfk_1";
            this.phoneNumbersibfk1BindingSource.DataSource = this.custAddBindingSource;
            // 
            // custAddBindingSource
            // 
            this.custAddBindingSource.DataMember = "CustAdd";
            this.custAddBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(429, 95);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(231, 13);
            this.Label2.TabIndex = 43;
            this.Label2.Text = "Select a customer to view their phone numbers:";
            // 
            // TitleComboBox
            // 
            this.TitleComboBox.DataSource = this.TitlesBindingSource;
            this.TitleComboBox.DisplayMember = "Title";
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Location = new System.Drawing.Point(44, 36);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(67, 21);
            this.TitleComboBox.TabIndex = 37;
            this.TitleComboBox.ValueMember = "ID";
            this.TitleComboBox.TextChanged += new System.EventHandler(this.TitleComboBox_TextChanged);
            // 
            // First_NameTextBox
            // 
            this.First_NameTextBox.Location = new System.Drawing.Point(189, 36);
            this.First_NameTextBox.Name = "First_NameTextBox";
            this.First_NameTextBox.Size = new System.Drawing.Size(173, 20);
            this.First_NameTextBox.TabIndex = 39;
            this.First_NameTextBox.TextChanged += new System.EventHandler(this.First_NameTextBox_TextChanged);
            // 
            // Last_NameTextBox
            // 
            this.Last_NameTextBox.Location = new System.Drawing.Point(440, 36);
            this.Last_NameTextBox.Name = "Last_NameTextBox";
            this.Last_NameTextBox.Size = new System.Drawing.Size(173, 20);
            this.Last_NameTextBox.TabIndex = 41;
            this.Last_NameTextBox.TextChanged += new System.EventHandler(this.Last_NameTextBox_TextChanged);
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.AllowUserToAddRows = false;
            this.CustomersDataGridView.AllowUserToDeleteRows = false;
            this.CustomersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.eMailAddressDataGridViewTextBoxColumn});
            this.CustomersDataGridView.DataSource = this.CustomersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomersDataGridView.Location = new System.Drawing.Point(11, 111);
            this.CustomersDataGridView.MultiSelect = false;
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CustomersDataGridView.RowHeadersWidth = 25;
            this.CustomersDataGridView.Size = new System.Drawing.Size(496, 203);
            this.CustomersDataGridView.TabIndex = 42;
            this.CustomersDataGridView.SelectionChanged += new System.EventHandler(this.CustomersDataGridView_SelectionChanged);
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
            this.titleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.titleDataGridViewTextBoxColumn.Width = 40;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMailAddressDataGridViewTextBoxColumn
            // 
            this.eMailAddressDataGridViewTextBoxColumn.DataPropertyName = "E-Mail Address";
            this.eMailAddressDataGridViewTextBoxColumn.HeaderText = "E-Mail Address";
            this.eMailAddressDataGridViewTextBoxColumn.Name = "eMailAddressDataGridViewTextBoxColumn";
            this.eMailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMailAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DataMember = "Customers Friendly View";
            this.CustomersBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // ButCancel
            // 
            this.ButCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButCancel.Location = new System.Drawing.Point(567, 481);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(90, 25);
            this.ButCancel.TabIndex = 51;
            this.ButCancel.Text = "&Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            this.ButCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(103, 13);
            this.Label1.TabIndex = 50;
            this.Label1.Text = "Enter search details:";
            // 
            // E_Mail_AddressTextBox
            // 
            this.E_Mail_AddressTextBox.Location = new System.Drawing.Point(108, 73);
            this.E_Mail_AddressTextBox.Name = "E_Mail_AddressTextBox";
            this.E_Mail_AddressTextBox.Size = new System.Drawing.Size(213, 20);
            this.E_Mail_AddressTextBox.TabIndex = 49;
            this.E_Mail_AddressTextBox.TextChanged += new System.EventHandler(this.E_Mail_AddressTextBox_TextChanged);
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(11, 317);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(206, 13);
            this.Label3.TabIndex = 46;
            this.Label3.Text = "Select a customer to view their addresses:";
            // 
            // ButChoose
            // 
            this.ButChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButChoose.Enabled = false;
            this.ButChoose.Location = new System.Drawing.Point(471, 481);
            this.ButChoose.Name = "ButChoose";
            this.ButChoose.Size = new System.Drawing.Size(90, 25);
            this.ButChoose.TabIndex = 48;
            this.ButChoose.Text = "C&hoose";
            this.ButChoose.UseVisualStyleBackColor = true;
            this.ButChoose.Click += new System.EventHandler(this.ButChoose_Click);
            // 
            // Phone_NumbersDataGridView
            // 
            this.Phone_NumbersDataGridView.AllowUserToAddRows = false;
            this.Phone_NumbersDataGridView.AllowUserToDeleteRows = false;
            this.Phone_NumbersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Phone_NumbersDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Phone_NumbersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Phone_NumbersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Phone_NumbersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.custAddIDDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.Phone_NumbersDataGridView.DataSource = this.Phone_NumbersBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Phone_NumbersDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.Phone_NumbersDataGridView.Location = new System.Drawing.Point(513, 111);
            this.Phone_NumbersDataGridView.MultiSelect = false;
            this.Phone_NumbersDataGridView.Name = "Phone_NumbersDataGridView";
            this.Phone_NumbersDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Phone_NumbersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Phone_NumbersDataGridView.RowHeadersWidth = 25;
            this.Phone_NumbersDataGridView.Size = new System.Drawing.Size(147, 203);
            this.Phone_NumbersDataGridView.TabIndex = 44;
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
            this.phoneNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // titlesTableAdapter
            // 
            this.titlesTableAdapter.ClearBeforeFill = true;
            // 
            // phone_NumbersTableAdapter
            // 
            this.phone_NumbersTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // addressesTableAdapter
            // 
            this.addressesTableAdapter.ClearBeforeFill = true;
            // 
            // custAddTableAdapter
            // 
            this.custAddTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressesTableAdapter = this.addressesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.correspondent_products_linkTableAdapter = null;
            this.tableAdapterManager.correspondentsTableAdapter = null;
            this.tableAdapterManager.CustAddTableAdapter = this.custAddTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.Installation_Products_LinkTableAdapter = null;
            this.tableAdapterManager.Phone_NumbersTableAdapter = this.phone_NumbersTableAdapter;
            this.tableAdapterManager.Prod_MakeTableAdapter = null;
            this.tableAdapterManager.Prod_ModelTableAdapter = null;
            this.tableAdapterManager.Prod_TypeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.ServiceZoneMesTableAdapter = null;
            this.tableAdapterManager.TitlesTableAdapter = this.titlesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zone_ListTableAdapter = null;
            this.tableAdapterManager.Zone_MappingsTableAdapter = null;
            this.tableAdapterManager.Zone_TypesTableAdapter = null;
            // 
            // customers_Friendly_ViewTableAdapter
            // 
            this.customers_Friendly_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // FormFindCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 518);
            this.Controls.Add(this.AddressesDataGridView);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TitleComboBox);
            this.Controls.Add(this.First_NameTextBox);
            this.Controls.Add(this.Last_NameTextBox);
            this.Controls.Add(this.CustomersDataGridView);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.E_Mail_AddressTextBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(E_Mail_AddressLabel);
            this.Controls.Add(this.ButChoose);
            this.Controls.Add(TitleLabel);
            this.Controls.Add(First_NameLabel);
            this.Controls.Add(Last_NameLabel);
            this.Controls.Add(this.Phone_NumbersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFindCustomer";
            this.Text = "Find Customer";
            this.Load += new System.EventHandler(this.FormFindCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddressesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone_NumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumbersibfk1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAddBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone_NumbersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView AddressesDataGridView;
        internal System.Windows.Forms.BindingSource AddressesBindingSource;
        private safeandsounddb1DataSet safeandsounddb1DataSet;
        internal System.Windows.Forms.BindingSource TitlesBindingSource;
        internal System.Windows.Forms.BindingSource Phone_NumbersBindingSource;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox TitleComboBox;
        internal System.Windows.Forms.TextBox First_NameTextBox;
        internal System.Windows.Forms.TextBox Last_NameTextBox;
        internal System.Windows.Forms.DataGridView CustomersDataGridView;
        internal System.Windows.Forms.BindingSource CustomersBindingSource;
        internal System.Windows.Forms.Button ButCancel;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox E_Mail_AddressTextBox;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button ButChoose;
        internal System.Windows.Forms.DataGridView Phone_NumbersDataGridView;
        private safeandsounddb1DataSetTableAdapters.TitlesTableAdapter titlesTableAdapter;
        private safeandsounddb1DataSetTableAdapters.Phone_NumbersTableAdapter phone_NumbersTableAdapter;
        private safeandsounddb1DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private safeandsounddb1DataSetTableAdapters.addressesTableAdapter addressesTableAdapter;
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
        private System.Windows.Forms.BindingSource custAddBindingSource;
        private safeandsounddb1DataSetTableAdapters.CustAddTableAdapter custAddTableAdapter;
        private safeandsounddb1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private safeandsounddb1DataSetTableAdapters.Customers_Friendly_ViewTableAdapter customers_Friendly_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource phoneNumbersibfk1BindingSource;
    }
}