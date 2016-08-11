namespace WindowsFormsApplication1
{
    partial class FormCustomer
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label e_Mail_AddressLabel;
            System.Windows.Forms.Label service_IntervalLabel;
            this.safeandsounddb1DataSet = new WindowsFormsApplication1.safeandsounddb1DataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager();
            this.addressesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.addressesTableAdapter();
            this.custAddTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.CustAddTableAdapter();
            this.phone_NumbersTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Phone_NumbersTableAdapter();
            this.titlesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TitlesTableAdapter();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.titlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.e_Mail_AddressTextBox = new System.Windows.Forms.TextBox();
            this.addressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressesDataGridView = new System.Windows.Forms.DataGridView();
            this.addressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.servicingTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_NumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phone_NumbersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButAddressView = new System.Windows.Forms.Button();
            this.ButNumbersViewAll = new System.Windows.Forms.Button();
            this.ButNumberAddressAdd = new System.Windows.Forms.Button();
            this.ButCancel = new System.Windows.Forms.Button();
            this.ButSaveExit = new System.Windows.Forms.Button();
            this.ButNumberCustomerAdd = new System.Windows.Forms.Button();
            this.custAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicingTypeTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.ServicingTypeTableAdapter();
            this.service_IntervalTextBox = new System.Windows.Forms.TextBox();
            titleLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            e_Mail_AddressLabel = new System.Windows.Forms.Label();
            service_IntervalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicingTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_NumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_NumbersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAddBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(74, 9);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 2;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(204, 9);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 4;
            last_NameLabel.Text = "Last Name:";
            // 
            // e_Mail_AddressLabel
            // 
            e_Mail_AddressLabel.AutoSize = true;
            e_Mail_AddressLabel.Location = new System.Drawing.Point(334, 9);
            e_Mail_AddressLabel.Name = "e_Mail_AddressLabel";
            e_Mail_AddressLabel.Size = new System.Drawing.Size(80, 13);
            e_Mail_AddressLabel.TabIndex = 6;
            e_Mail_AddressLabel.Text = "E-Mail Address:";
            // 
            // service_IntervalLabel
            // 
            service_IntervalLabel.AutoSize = true;
            service_IntervalLabel.Location = new System.Drawing.Point(555, 9);
            service_IntervalLabel.Name = "service_IntervalLabel";
            service_IntervalLabel.Size = new System.Drawing.Size(120, 13);
            service_IntervalLabel.TabIndex = 16;
            service_IntervalLabel.Text = "Service Interval (Years):";
            // 
            // safeandsounddb1DataSet
            // 
            this.safeandsounddb1DataSet.DataSetName = "safeandsounddb1DataSet";
            this.safeandsounddb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.safeandsounddb1DataSet;
            this.customersBindingSource.PositionChanged += new System.EventHandler(this.customersBindingSource_PositionChanged);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActionTableAdapter = null;
            this.tableAdapterManager.ActionTypeTableAdapter = null;
            this.tableAdapterManager.Address_Product_LinkTableAdapter = null;
            this.tableAdapterManager.addressesTableAdapter = this.addressesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CallOutTableAdapter = null;
            this.tableAdapterManager.correspondent_products_linkTableAdapter = null;
            this.tableAdapterManager.correspondentsTableAdapter = null;
            this.tableAdapterManager.CustAddTableAdapter = this.custAddTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.InstallationProductTableAdapter = null;
            this.tableAdapterManager.InstallationTableAdapter = null;
            this.tableAdapterManager.InstallationTypeTableAdapter = null;
            this.tableAdapterManager.Phone_NumbersTableAdapter = this.phone_NumbersTableAdapter;
            this.tableAdapterManager.PhoneCallTableAdapter = null;
            this.tableAdapterManager.Prod_MakeTableAdapter = null;
            this.tableAdapterManager.Prod_ModelTableAdapter = null;
            this.tableAdapterManager.Prod_TypeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.ServiceZoneMesTableAdapter = null;
            this.tableAdapterManager.ServicingTypeTableAdapter = null;
            this.tableAdapterManager.TitlesTableAdapter = this.titlesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zone_ListTableAdapter = null;
            this.tableAdapterManager.Zone_MappingsTableAdapter = null;
            this.tableAdapterManager.Zone_TypesTableAdapter = null;
            // 
            // addressesTableAdapter
            // 
            this.addressesTableAdapter.ClearBeforeFill = true;
            // 
            // custAddTableAdapter
            // 
            this.custAddTableAdapter.ClearBeforeFill = true;
            // 
            // phone_NumbersTableAdapter
            // 
            this.phone_NumbersTableAdapter.ClearBeforeFill = true;
            // 
            // titlesTableAdapter
            // 
            this.titlesTableAdapter.ClearBeforeFill = true;
            // 
            // titleComboBox
            // 
            this.titleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customersBindingSource, "Title", true));
            this.titleComboBox.DataSource = this.titlesBindingSource;
            this.titleComboBox.DisplayMember = "Title";
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Location = new System.Drawing.Point(15, 25);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(55, 21);
            this.titleComboBox.TabIndex = 2;
            this.titleComboBox.ValueMember = "ID";
            this.titleComboBox.SelectedIndexChanged += new System.EventHandler(this.titleComboBox_SelectedIndexChanged);
            this.titleComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.titleComboBox_Validating);
            // 
            // titlesBindingSource
            // 
            this.titlesBindingSource.DataMember = "Titles";
            this.titlesBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(77, 25);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(124, 20);
            this.first_NameTextBox.TabIndex = 3;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(207, 25);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(124, 20);
            this.last_NameTextBox.TabIndex = 5;
            // 
            // e_Mail_AddressTextBox
            // 
            this.e_Mail_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "E-Mail Address", true));
            this.e_Mail_AddressTextBox.Location = new System.Drawing.Point(337, 25);
            this.e_Mail_AddressTextBox.Name = "e_Mail_AddressTextBox";
            this.e_Mail_AddressTextBox.Size = new System.Drawing.Size(215, 20);
            this.e_Mail_AddressTextBox.TabIndex = 7;
            // 
            // addressesBindingSource
            // 
            this.addressesBindingSource.DataMember = "addresses";
            this.addressesBindingSource.DataSource = this.safeandsounddb1DataSet;
            this.addressesBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.addressesBindingSource_AddingNew);
            // 
            // addressesDataGridView
            // 
            this.addressesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressesDataGridView.AutoGenerateColumns = false;
            this.addressesDataGridView.ColumnHeadersHeight = 21;
            this.addressesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressIDDataGridViewTextBoxColumn,
            this.addressLine1DataGridViewTextBoxColumn,
            this.addressLine2DataGridViewTextBoxColumn,
            this.addressLine3DataGridViewTextBoxColumn,
            this.townDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.notesDataGridViewTextBoxColumn});
            this.addressesDataGridView.DataSource = this.addressesBindingSource;
            this.addressesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.addressesDataGridView.Location = new System.Drawing.Point(15, 52);
            this.addressesDataGridView.MultiSelect = false;
            this.addressesDataGridView.Name = "addressesDataGridView";
            this.addressesDataGridView.RowHeadersWidth = 25;
            this.addressesDataGridView.RowTemplate.Height = 33;
            this.addressesDataGridView.Size = new System.Drawing.Size(773, 255);
            this.addressesDataGridView.TabIndex = 8;
            this.addressesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.addressesDataGridView_CellMouseDoubleClick);
            this.addressesDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.addressesDataGridView_CellValidated);
            this.addressesDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.addressesDataGridView_CellValidating);
            this.addressesDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.addressesDataGridView_RowValidated);
            this.addressesDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.addressesDataGridView_RowValidating);
            this.addressesDataGridView.SelectionChanged += new System.EventHandler(this.addressesDataGridView_SelectionChanged);
            this.addressesDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.addressesDataGridView_UserAddedRow);
            this.addressesDataGridView.Leave += new System.EventHandler(this.addressesDataGridView_Leave);
            // 
            // addressIDDataGridViewTextBoxColumn
            // 
            this.addressIDDataGridViewTextBoxColumn.DataPropertyName = "Address ID";
            this.addressIDDataGridViewTextBoxColumn.HeaderText = "Address ID";
            this.addressIDDataGridViewTextBoxColumn.Name = "addressIDDataGridViewTextBoxColumn";
            this.addressIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressLine1DataGridViewTextBoxColumn
            // 
            this.addressLine1DataGridViewTextBoxColumn.DataPropertyName = "Address Line 1";
            this.addressLine1DataGridViewTextBoxColumn.HeaderText = "Address Line 1";
            this.addressLine1DataGridViewTextBoxColumn.Name = "addressLine1DataGridViewTextBoxColumn";
            // 
            // addressLine2DataGridViewTextBoxColumn
            // 
            this.addressLine2DataGridViewTextBoxColumn.DataPropertyName = "Address Line 2";
            this.addressLine2DataGridViewTextBoxColumn.HeaderText = "Address Line 2";
            this.addressLine2DataGridViewTextBoxColumn.Name = "addressLine2DataGridViewTextBoxColumn";
            // 
            // addressLine3DataGridViewTextBoxColumn
            // 
            this.addressLine3DataGridViewTextBoxColumn.DataPropertyName = "Address Line 3";
            this.addressLine3DataGridViewTextBoxColumn.HeaderText = "Address Line 3";
            this.addressLine3DataGridViewTextBoxColumn.Name = "addressLine3DataGridViewTextBoxColumn";
            // 
            // townDataGridViewTextBoxColumn
            // 
            this.townDataGridViewTextBoxColumn.DataPropertyName = "Town";
            this.townDataGridViewTextBoxColumn.HeaderText = "Town";
            this.townDataGridViewTextBoxColumn.Name = "townDataGridViewTextBoxColumn";
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "Post Code";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "Post Code";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            this.postCodeDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Servicing Type";
            this.dataGridViewTextBoxColumn1.DataSource = this.servicingTypeBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "Type";
            this.dataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn1.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataGridViewTextBoxColumn1.HeaderText = "Servicing Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "ID";
            // 
            // servicingTypeBindingSource
            // 
            this.servicingTypeBindingSource.DataMember = "ServicingType";
            this.servicingTypeBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 150;
            // 
            // phone_NumbersBindingSource
            // 
            this.phone_NumbersBindingSource.DataMember = "Phone Numbers";
            this.phone_NumbersBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // phone_NumbersDataGridView
            // 
            this.phone_NumbersDataGridView.AllowUserToAddRows = false;
            this.phone_NumbersDataGridView.AllowUserToDeleteRows = false;
            this.phone_NumbersDataGridView.AllowUserToResizeColumns = false;
            this.phone_NumbersDataGridView.AllowUserToResizeRows = false;
            this.phone_NumbersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phone_NumbersDataGridView.AutoGenerateColumns = false;
            this.phone_NumbersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phone_NumbersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.phone_NumbersDataGridView.DataSource = this.phone_NumbersBindingSource;
            this.phone_NumbersDataGridView.Location = new System.Drawing.Point(794, 52);
            this.phone_NumbersDataGridView.MultiSelect = false;
            this.phone_NumbersDataGridView.Name = "phone_NumbersDataGridView";
            this.phone_NumbersDataGridView.ReadOnly = true;
            this.phone_NumbersDataGridView.RowHeadersWidth = 25;
            this.phone_NumbersDataGridView.Size = new System.Drawing.Size(156, 165);
            this.phone_NumbersDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CustAdd ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "CustAdd ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Phone Number";
            this.dataGridViewTextBoxColumn10.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // ButAddressView
            // 
            this.ButAddressView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButAddressView.Location = new System.Drawing.Point(794, 272);
            this.ButAddressView.Name = "ButAddressView";
            this.ButAddressView.Size = new System.Drawing.Size(75, 35);
            this.ButAddressView.TabIndex = 10;
            this.ButAddressView.Text = "Save && &View Address";
            this.ButAddressView.UseVisualStyleBackColor = true;
            this.ButAddressView.Click += new System.EventHandler(this.ButAddressView_Click);
            // 
            // ButNumbersViewAll
            // 
            this.ButNumbersViewAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButNumbersViewAll.Location = new System.Drawing.Point(794, 231);
            this.ButNumbersViewAll.Name = "ButNumbersViewAll";
            this.ButNumbersViewAll.Size = new System.Drawing.Size(75, 35);
            this.ButNumbersViewAll.TabIndex = 11;
            this.ButNumbersViewAll.Text = "View All &Numbers";
            this.ButNumbersViewAll.UseVisualStyleBackColor = true;
            this.ButNumbersViewAll.Click += new System.EventHandler(this.ButNumbersViewAll_Click);
            // 
            // ButNumberAddressAdd
            // 
            this.ButNumberAddressAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButNumberAddressAdd.Location = new System.Drawing.Point(875, 231);
            this.ButNumberAddressAdd.Name = "ButNumberAddressAdd";
            this.ButNumberAddressAdd.Size = new System.Drawing.Size(75, 35);
            this.ButNumberAddressAdd.TabIndex = 12;
            this.ButNumberAddressAdd.Text = "Add Number to &Address";
            this.ButNumberAddressAdd.UseVisualStyleBackColor = true;
            this.ButNumberAddressAdd.Click += new System.EventHandler(this.ButNumberAddressAdd_Click);
            // 
            // ButCancel
            // 
            this.ButCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButCancel.Location = new System.Drawing.Point(839, 17);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(111, 29);
            this.ButCancel.TabIndex = 13;
            this.ButCancel.Text = "&Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            this.ButCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // ButSaveExit
            // 
            this.ButSaveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButSaveExit.Location = new System.Drawing.Point(722, 16);
            this.ButSaveExit.Name = "ButSaveExit";
            this.ButSaveExit.Size = new System.Drawing.Size(111, 29);
            this.ButSaveExit.TabIndex = 14;
            this.ButSaveExit.Text = "&Save && Exit";
            this.ButSaveExit.UseVisualStyleBackColor = true;
            this.ButSaveExit.Click += new System.EventHandler(this.ButSaveExit_Click);
            // 
            // ButNumberCustomerAdd
            // 
            this.ButNumberCustomerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButNumberCustomerAdd.Location = new System.Drawing.Point(875, 272);
            this.ButNumberCustomerAdd.Name = "ButNumberCustomerAdd";
            this.ButNumberCustomerAdd.Size = new System.Drawing.Size(75, 35);
            this.ButNumberCustomerAdd.TabIndex = 15;
            this.ButNumberCustomerAdd.Text = "Add Number to &Customer";
            this.ButNumberCustomerAdd.UseVisualStyleBackColor = true;
            this.ButNumberCustomerAdd.Click += new System.EventHandler(this.ButNumberCustomerAdd_Click);
            // 
            // custAddBindingSource
            // 
            this.custAddBindingSource.DataMember = "CustAdd";
            this.custAddBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // servicingTypeTableAdapter
            // 
            this.servicingTypeTableAdapter.ClearBeforeFill = true;
            // 
            // service_IntervalTextBox
            // 
            this.service_IntervalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Service Interval", true));
            this.service_IntervalTextBox.Location = new System.Drawing.Point(558, 25);
            this.service_IntervalTextBox.Name = "service_IntervalTextBox";
            this.service_IntervalTextBox.Size = new System.Drawing.Size(100, 20);
            this.service_IntervalTextBox.TabIndex = 17;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 319);
            this.Controls.Add(service_IntervalLabel);
            this.Controls.Add(this.service_IntervalTextBox);
            this.Controls.Add(this.ButNumberCustomerAdd);
            this.Controls.Add(this.ButSaveExit);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.ButNumberAddressAdd);
            this.Controls.Add(this.ButNumbersViewAll);
            this.Controls.Add(this.ButAddressView);
            this.Controls.Add(this.phone_NumbersDataGridView);
            this.Controls.Add(this.addressesDataGridView);
            this.Controls.Add(e_Mail_AddressLabel);
            this.Controls.Add(this.e_Mail_AddressTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleComboBox);
            this.Name = "FormCustomer";
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustomer_FormClosing);
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicingTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_NumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone_NumbersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAddBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private safeandsounddb1DataSet safeandsounddb1DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private safeandsounddb1DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private safeandsounddb1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private safeandsounddb1DataSetTableAdapters.TitlesTableAdapter titlesTableAdapter;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.BindingSource titlesBindingSource;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox e_Mail_AddressTextBox;
        private System.Windows.Forms.BindingSource addressesBindingSource;
        private safeandsounddb1DataSetTableAdapters.addressesTableAdapter addressesTableAdapter;
        private System.Windows.Forms.DataGridView addressesDataGridView;
        private System.Windows.Forms.BindingSource phone_NumbersBindingSource;
        private safeandsounddb1DataSetTableAdapters.Phone_NumbersTableAdapter phone_NumbersTableAdapter;
        private System.Windows.Forms.DataGridView phone_NumbersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button ButAddressView;
        private System.Windows.Forms.Button ButNumbersViewAll;
        private System.Windows.Forms.Button ButNumberAddressAdd;
        private System.Windows.Forms.Button ButCancel;
        private System.Windows.Forms.Button ButSaveExit;
        private System.Windows.Forms.Button ButNumberCustomerAdd;
        private System.Windows.Forms.BindingSource custAddBindingSource;
        private safeandsounddb1DataSetTableAdapters.CustAddTableAdapter custAddTableAdapter;
        private safeandsounddb1DataSetTableAdapters.ServicingTypeTableAdapter servicingTypeTableAdapter;
        private System.Windows.Forms.TextBox service_IntervalTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource servicingTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}