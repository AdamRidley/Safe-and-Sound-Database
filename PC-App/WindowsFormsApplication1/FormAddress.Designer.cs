namespace WindowsFormsApplication1
{
    partial class FormAddress
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
            System.Windows.Forms.Label address_Line_1Label;
            System.Windows.Forms.Label address_Line_2Label;
            System.Windows.Forms.Label address_Line_3Label;
            System.Windows.Forms.Label townLabel;
            System.Windows.Forms.Label post_CodeLabel;
            System.Windows.Forms.Label notesLabel;
            this.addressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.safeandsounddb1DataSet = new WindowsFormsApplication1.safeandsounddb1DataSet();
            this.addressesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.addressesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager();
            this.installation_Products_LinkTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Address_Product_LinkTableAdapter();
            this.prod_MakeTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Prod_MakeTableAdapter();
            this.prod_ModelTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Prod_ModelTableAdapter();
            this.prod_TypeTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Prod_TypeTableAdapter();
            this.productTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.ProductTableAdapter();
            this.zone_ListTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Zone_ListTableAdapter();
            this.zone_MappingsTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Zone_MappingsTableAdapter();
            this.zone_TypesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Zone_TypesTableAdapter();
            this.address_Line_1TextBox = new System.Windows.Forms.TextBox();
            this.address_Line_2TextBox = new System.Windows.Forms.TextBox();
            this.address_Line_3TextBox = new System.Windows.Forms.TextBox();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.post_CodeTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.installation_Products_LinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressintallationfrgnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installation_Products_LinkDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.prodTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Make = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.prodMakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Model = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.prodModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label2 = new System.Windows.Forms.Label();
            this.zone_MappingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zoneMappingsibfk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zone_MappingsDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zoneTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zoneDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zoneListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zoneMappingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butcancel = new System.Windows.Forms.Button();
            this.butsaveexit = new System.Windows.Forms.Button();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.ServicesTableAdapter();
            this.servicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButAddService = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ButViewService = new System.Windows.Forms.Button();
            this.ButDeleteService = new System.Windows.Forms.Button();
            address_Line_1Label = new System.Windows.Forms.Label();
            address_Line_2Label = new System.Windows.Forms.Label();
            address_Line_3Label = new System.Windows.Forms.Label();
            townLabel = new System.Windows.Forms.Label();
            post_CodeLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installation_Products_LinkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressintallationfrgnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installation_Products_LinkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodMakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone_MappingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoneMappingsibfk1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone_MappingsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoneTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoneListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoneMappingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // address_Line_1Label
            // 
            address_Line_1Label.AutoSize = true;
            address_Line_1Label.Location = new System.Drawing.Point(12, 15);
            address_Line_1Label.Name = "address_Line_1Label";
            address_Line_1Label.Size = new System.Drawing.Size(80, 13);
            address_Line_1Label.TabIndex = 3;
            address_Line_1Label.Text = "Address Line 1:";
            // 
            // address_Line_2Label
            // 
            address_Line_2Label.AutoSize = true;
            address_Line_2Label.Location = new System.Drawing.Point(12, 41);
            address_Line_2Label.Name = "address_Line_2Label";
            address_Line_2Label.Size = new System.Drawing.Size(80, 13);
            address_Line_2Label.TabIndex = 5;
            address_Line_2Label.Text = "Address Line 2:";
            // 
            // address_Line_3Label
            // 
            address_Line_3Label.AutoSize = true;
            address_Line_3Label.Location = new System.Drawing.Point(12, 67);
            address_Line_3Label.Name = "address_Line_3Label";
            address_Line_3Label.Size = new System.Drawing.Size(80, 13);
            address_Line_3Label.TabIndex = 7;
            address_Line_3Label.Text = "Address Line 3:";
            // 
            // townLabel
            // 
            townLabel.AutoSize = true;
            townLabel.Location = new System.Drawing.Point(12, 93);
            townLabel.Name = "townLabel";
            townLabel.Size = new System.Drawing.Size(37, 13);
            townLabel.TabIndex = 9;
            townLabel.Text = "Town:";
            // 
            // post_CodeLabel
            // 
            post_CodeLabel.AutoSize = true;
            post_CodeLabel.Location = new System.Drawing.Point(12, 119);
            post_CodeLabel.Name = "post_CodeLabel";
            post_CodeLabel.Size = new System.Drawing.Size(59, 13);
            post_CodeLabel.TabIndex = 11;
            post_CodeLabel.Text = "Post Code:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(204, 19);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 13;
            notesLabel.Text = "Notes:";
            // 
            // addressesBindingSource
            // 
            this.addressesBindingSource.DataMember = "addresses";
            this.addressesBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // safeandsounddb1DataSet
            // 
            this.safeandsounddb1DataSet.DataSetName = "safeandsounddb1DataSet";
            this.safeandsounddb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Address_Product_LinkTableAdapter = this.installation_Products_LinkTableAdapter;
            this.tableAdapterManager.Phone_NumbersTableAdapter = null;
            this.tableAdapterManager.Prod_MakeTableAdapter = this.prod_MakeTableAdapter;
            this.tableAdapterManager.Prod_ModelTableAdapter = this.prod_ModelTableAdapter;
            this.tableAdapterManager.Prod_TypeTableAdapter = this.prod_TypeTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.ServiceZoneMesTableAdapter = null;
            this.tableAdapterManager.TitlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zone_ListTableAdapter = this.zone_ListTableAdapter;
            this.tableAdapterManager.Zone_MappingsTableAdapter = this.zone_MappingsTableAdapter;
            this.tableAdapterManager.Zone_TypesTableAdapter = this.zone_TypesTableAdapter;
            // 
            // installation_Products_LinkTableAdapter
            // 
            this.installation_Products_LinkTableAdapter.ClearBeforeFill = true;
            // 
            // prod_MakeTableAdapter
            // 
            this.prod_MakeTableAdapter.ClearBeforeFill = true;
            // 
            // prod_ModelTableAdapter
            // 
            this.prod_ModelTableAdapter.ClearBeforeFill = true;
            // 
            // prod_TypeTableAdapter
            // 
            this.prod_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // zone_ListTableAdapter
            // 
            this.zone_ListTableAdapter.ClearBeforeFill = true;
            // 
            // zone_MappingsTableAdapter
            // 
            this.zone_MappingsTableAdapter.ClearBeforeFill = true;
            // 
            // zone_TypesTableAdapter
            // 
            this.zone_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // address_Line_1TextBox
            // 
            this.address_Line_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressesBindingSource, "Address Line 1", true));
            this.address_Line_1TextBox.Location = new System.Drawing.Point(98, 12);
            this.address_Line_1TextBox.Name = "address_Line_1TextBox";
            this.address_Line_1TextBox.Size = new System.Drawing.Size(100, 20);
            this.address_Line_1TextBox.TabIndex = 4;
            // 
            // address_Line_2TextBox
            // 
            this.address_Line_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressesBindingSource, "Address Line 2", true));
            this.address_Line_2TextBox.Location = new System.Drawing.Point(98, 38);
            this.address_Line_2TextBox.Name = "address_Line_2TextBox";
            this.address_Line_2TextBox.Size = new System.Drawing.Size(100, 20);
            this.address_Line_2TextBox.TabIndex = 6;
            // 
            // address_Line_3TextBox
            // 
            this.address_Line_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressesBindingSource, "Address Line 3", true));
            this.address_Line_3TextBox.Location = new System.Drawing.Point(98, 64);
            this.address_Line_3TextBox.Name = "address_Line_3TextBox";
            this.address_Line_3TextBox.Size = new System.Drawing.Size(100, 20);
            this.address_Line_3TextBox.TabIndex = 8;
            // 
            // townTextBox
            // 
            this.townTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressesBindingSource, "Town", true));
            this.townTextBox.Location = new System.Drawing.Point(98, 90);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(100, 20);
            this.townTextBox.TabIndex = 10;
            // 
            // post_CodeTextBox
            // 
            this.post_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressesBindingSource, "Post Code", true));
            this.post_CodeTextBox.Location = new System.Drawing.Point(98, 116);
            this.post_CodeTextBox.Name = "post_CodeTextBox";
            this.post_CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.post_CodeTextBox.TabIndex = 12;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressesBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(204, 35);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(675, 101);
            this.notesTextBox.TabIndex = 14;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 149);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(157, 13);
            this.Label1.TabIndex = 36;
            this.Label1.Text = "Components Installed at House:";
            // 
            // installation_Products_LinkBindingSource
            // 
            this.installation_Products_LinkBindingSource.AllowNew = true;
            this.installation_Products_LinkBindingSource.DataSource = this.addressintallationfrgnBindingSource;
            this.installation_Products_LinkBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.installation_Products_LinkBindingSource_ListChanged);
            // 
            // addressintallationfrgnBindingSource
            // 
            this.addressintallationfrgnBindingSource.DataMember = "addressintallationfrgn";
            this.addressintallationfrgnBindingSource.DataSource = this.addressesBindingSource;
            // 
            // installation_Products_LinkDataGridView
            // 
            this.installation_Products_LinkDataGridView.AllowUserToResizeRows = false;
            this.installation_Products_LinkDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.installation_Products_LinkDataGridView.AutoGenerateColumns = false;
            this.installation_Products_LinkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.installation_Products_LinkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.productDataGridViewTextBoxColumn,
            this.Type,
            this.Make,
            this.Model,
            this.quantityDataGridViewTextBoxColumn});
            this.installation_Products_LinkDataGridView.DataSource = this.installation_Products_LinkBindingSource;
            this.installation_Products_LinkDataGridView.Location = new System.Drawing.Point(12, 165);
            this.installation_Products_LinkDataGridView.Name = "installation_Products_LinkDataGridView";
            this.installation_Products_LinkDataGridView.RowHeadersWidth = 25;
            this.installation_Products_LinkDataGridView.Size = new System.Drawing.Size(984, 208);
            this.installation_Products_LinkDataGridView.TabIndex = 36;
            this.installation_Products_LinkDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.installation_Products_LinkDataGridView_CellContentClick);
            this.installation_Products_LinkDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.installation_Products_LinkDataGridView_CellValidated);
            this.installation_Products_LinkDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.installation_Products_LinkDataGridView_CellValueChanged);
            this.installation_Products_LinkDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.installation_Products_LinkDataGridView_RowValidating);
            this.installation_Products_LinkDataGridView.Enter += new System.EventHandler(this.installation_Products_LinkDataGridView_Enter);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Type
            // 
            this.Type.DataSource = this.prodTypeBindingSource;
            this.Type.DisplayMember = "Type";
            this.Type.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Type.DisplayStyleForCurrentCellOnly = true;
            this.Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ValueMember = "TypeID";
            // 
            // prodTypeBindingSource
            // 
            this.prodTypeBindingSource.DataMember = "Prod Type";
            this.prodTypeBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // Make
            // 
            this.Make.DataSource = this.prodMakeBindingSource;
            this.Make.DisplayMember = "Make";
            this.Make.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Make.DisplayStyleForCurrentCellOnly = true;
            this.Make.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Make.HeaderText = "Make";
            this.Make.Name = "Make";
            this.Make.ValueMember = "MakeID";
            // 
            // prodMakeBindingSource
            // 
            this.prodMakeBindingSource.DataMember = "Prod Make";
            this.prodMakeBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // Model
            // 
            this.Model.DataSource = this.prodModelBindingSource;
            this.Model.DisplayMember = "Model";
            this.Model.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Model.DisplayStyleForCurrentCellOnly = true;
            this.Model.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ValueMember = "ModelID";
            // 
            // prodModelBindingSource
            // 
            this.prodModelBindingSource.DataMember = "Prod Model";
            this.prodModelBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 376);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 37;
            this.Label2.Text = "Zones:";
            // 
            // zone_MappingsBindingSource
            // 
            this.zone_MappingsBindingSource.AllowNew = true;
            this.zone_MappingsBindingSource.DataSource = this.zoneMappingsibfk1BindingSource;
            // 
            // zoneMappingsibfk1BindingSource
            // 
            this.zoneMappingsibfk1BindingSource.DataMember = "zone mappings_ibfk_1";
            this.zoneMappingsibfk1BindingSource.DataSource = this.addressesBindingSource;
            // 
            // zone_MappingsDataGridView
            // 
            this.zone_MappingsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zone_MappingsDataGridView.AutoGenerateColumns = false;
            this.zone_MappingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zone_MappingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.zoneNumberDataGridViewTextBoxColumn,
            this.zoneTypeDataGridViewTextBoxColumn,
            this.zoneDescriptionDataGridViewTextBoxColumn});
            this.zone_MappingsDataGridView.DataSource = this.zone_MappingsBindingSource;
            this.zone_MappingsDataGridView.Location = new System.Drawing.Point(12, 392);
            this.zone_MappingsDataGridView.Name = "zone_MappingsDataGridView";
            this.zone_MappingsDataGridView.Size = new System.Drawing.Size(552, 151);
            this.zone_MappingsDataGridView.TabIndex = 37;
            this.zone_MappingsDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.zone_MappingsDataGridView_RowValidating);
            this.zone_MappingsDataGridView.Enter += new System.EventHandler(this.zone_MappingsDataGridView_Enter);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // zoneNumberDataGridViewTextBoxColumn
            // 
            this.zoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Zone Number";
            this.zoneNumberDataGridViewTextBoxColumn.HeaderText = "Zone Number";
            this.zoneNumberDataGridViewTextBoxColumn.Name = "zoneNumberDataGridViewTextBoxColumn";
            // 
            // zoneTypeDataGridViewTextBoxColumn
            // 
            this.zoneTypeDataGridViewTextBoxColumn.DataPropertyName = "Zone Type";
            this.zoneTypeDataGridViewTextBoxColumn.DataSource = this.zoneTypesBindingSource;
            this.zoneTypeDataGridViewTextBoxColumn.DisplayMember = "Type";
            this.zoneTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.zoneTypeDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.zoneTypeDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zoneTypeDataGridViewTextBoxColumn.HeaderText = "Zone Type";
            this.zoneTypeDataGridViewTextBoxColumn.Name = "zoneTypeDataGridViewTextBoxColumn";
            this.zoneTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zoneTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zoneTypeDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // zoneTypesBindingSource
            // 
            this.zoneTypesBindingSource.DataMember = "Zone Types";
            this.zoneTypesBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // zoneDescriptionDataGridViewTextBoxColumn
            // 
            this.zoneDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Zone Description";
            this.zoneDescriptionDataGridViewTextBoxColumn.DataSource = this.zoneListBindingSource;
            this.zoneDescriptionDataGridViewTextBoxColumn.DisplayMember = "Zone Description";
            this.zoneDescriptionDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.zoneDescriptionDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.zoneDescriptionDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zoneDescriptionDataGridViewTextBoxColumn.HeaderText = "Zone Description";
            this.zoneDescriptionDataGridViewTextBoxColumn.Name = "zoneDescriptionDataGridViewTextBoxColumn";
            this.zoneDescriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zoneDescriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zoneDescriptionDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // zoneListBindingSource
            // 
            this.zoneListBindingSource.DataMember = "Zone List";
            this.zoneListBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // zoneMappingsBindingSource
            // 
            this.zoneMappingsBindingSource.DataMember = "Zone Mappings";
            this.zoneMappingsBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // butcancel
            // 
            this.butcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butcancel.Location = new System.Drawing.Point(885, 67);
            this.butcancel.Name = "butcancel";
            this.butcancel.Size = new System.Drawing.Size(111, 26);
            this.butcancel.TabIndex = 40;
            this.butcancel.Text = "&Cancel";
            this.butcancel.UseVisualStyleBackColor = true;
            this.butcancel.Click += new System.EventHandler(this.butcancel_Click);
            // 
            // butsaveexit
            // 
            this.butsaveexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butsaveexit.Location = new System.Drawing.Point(885, 32);
            this.butsaveexit.Name = "butsaveexit";
            this.butsaveexit.Size = new System.Drawing.Size(111, 26);
            this.butsaveexit.TabIndex = 39;
            this.butsaveexit.Text = "&Save && Exit";
            this.butsaveexit.UseVisualStyleBackColor = true;
            this.butsaveexit.Click += new System.EventHandler(this.butsaveexit_Click);
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services_ibfk_1";
            this.servicesBindingSource.DataSource = this.addressesBindingSource;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // servicesDataGridView
            // 
            this.servicesDataGridView.AllowUserToAddRows = false;
            this.servicesDataGridView.AllowUserToResizeColumns = false;
            this.servicesDataGridView.AllowUserToResizeRows = false;
            this.servicesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesDataGridView.AutoGenerateColumns = false;
            this.servicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.servicesDataGridView.DataSource = this.servicesBindingSource;
            this.servicesDataGridView.Location = new System.Drawing.Point(570, 392);
            this.servicesDataGridView.MultiSelect = false;
            this.servicesDataGridView.Name = "servicesDataGridView";
            this.servicesDataGridView.ReadOnly = true;
            this.servicesDataGridView.Size = new System.Drawing.Size(309, 151);
            this.servicesDataGridView.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Service ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Service ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn2.HeaderText = "Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date of Service";
            this.dataGridViewTextBoxColumn3.HeaderText = "Service Dates";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ButAddService
            // 
            this.ButAddService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButAddService.Location = new System.Drawing.Point(885, 392);
            this.ButAddService.Name = "ButAddService";
            this.ButAddService.Size = new System.Drawing.Size(111, 26);
            this.ButAddService.TabIndex = 41;
            this.ButAddService.Text = "&Add Service";
            this.ButAddService.UseVisualStyleBackColor = true;
            this.ButAddService.Click += new System.EventHandler(this.ButAddService_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Activities:";
            // 
            // ButViewService
            // 
            this.ButViewService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButViewService.Location = new System.Drawing.Point(885, 424);
            this.ButViewService.Name = "ButViewService";
            this.ButViewService.Size = new System.Drawing.Size(111, 26);
            this.ButViewService.TabIndex = 43;
            this.ButViewService.Text = "&View Service";
            this.ButViewService.UseVisualStyleBackColor = true;
            this.ButViewService.Click += new System.EventHandler(this.ButViewService_Click);
            // 
            // ButDeleteService
            // 
            this.ButDeleteService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButDeleteService.Location = new System.Drawing.Point(885, 456);
            this.ButDeleteService.Name = "ButDeleteService";
            this.ButDeleteService.Size = new System.Drawing.Size(111, 26);
            this.ButDeleteService.TabIndex = 44;
            this.ButDeleteService.Text = "&Delete Service";
            this.ButDeleteService.UseVisualStyleBackColor = true;
            // 
            // FormAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 555);
            this.Controls.Add(this.ButDeleteService);
            this.Controls.Add(this.ButViewService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButAddService);
            this.Controls.Add(this.servicesDataGridView);
            this.Controls.Add(this.butcancel);
            this.Controls.Add(this.butsaveexit);
            this.Controls.Add(this.zone_MappingsDataGridView);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.installation_Products_LinkDataGridView);
            this.Controls.Add(this.Label1);
            this.Controls.Add(address_Line_1Label);
            this.Controls.Add(this.address_Line_1TextBox);
            this.Controls.Add(address_Line_2Label);
            this.Controls.Add(this.address_Line_2TextBox);
            this.Controls.Add(address_Line_3Label);
            this.Controls.Add(this.address_Line_3TextBox);
            this.Controls.Add(townLabel);
            this.Controls.Add(this.townTextBox);
            this.Controls.Add(post_CodeLabel);
            this.Controls.Add(this.post_CodeTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAddress";
            this.Text = "Addresses";
            this.Load += new System.EventHandler(this.FormAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installation_Products_LinkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressintallationfrgnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installation_Products_LinkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodMakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone_MappingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoneMappingsibfk1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zone_MappingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoneTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoneListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoneMappingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource addressesBindingSource;
        private safeandsounddb1DataSetTableAdapters.addressesTableAdapter addressesTableAdapter;
        private safeandsounddb1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox address_Line_1TextBox;
        private System.Windows.Forms.TextBox address_Line_2TextBox;
        private System.Windows.Forms.TextBox address_Line_3TextBox;
        private System.Windows.Forms.TextBox townTextBox;
        private System.Windows.Forms.TextBox post_CodeTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        internal System.Windows.Forms.Label Label1;
        private safeandsounddb1DataSetTableAdapters.Address_Product_LinkTableAdapter installation_Products_LinkTableAdapter;
        private System.Windows.Forms.BindingSource installation_Products_LinkBindingSource;
        private safeandsounddb1DataSetTableAdapters.Prod_TypeTableAdapter prod_TypeTableAdapter;
        private System.Windows.Forms.BindingSource addressintallationfrgnBindingSource;
        private System.Windows.Forms.DataGridView installation_Products_LinkDataGridView;
        private System.Windows.Forms.BindingSource prodTypeBindingSource;
        private safeandsounddb1DataSetTableAdapters.Prod_MakeTableAdapter prod_MakeTableAdapter;
        private System.Windows.Forms.BindingSource prodMakeBindingSource;
        private safeandsounddb1DataSetTableAdapters.Prod_ModelTableAdapter prod_ModelTableAdapter;
        private System.Windows.Forms.BindingSource prodModelBindingSource;
        private safeandsounddb1DataSetTableAdapters.Zone_MappingsTableAdapter zone_MappingsTableAdapter;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.BindingSource zone_MappingsBindingSource;
        private safeandsounddb1DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView zone_MappingsDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private safeandsounddb1DataSetTableAdapters.Zone_TypesTableAdapter zone_TypesTableAdapter;
        private System.Windows.Forms.BindingSource zoneMappingsibfk1BindingSource;
        private System.Windows.Forms.BindingSource zoneTypesBindingSource;
        private safeandsounddb1DataSetTableAdapters.Zone_ListTableAdapter zone_ListTableAdapter;
        private System.Windows.Forms.BindingSource zoneMappingsBindingSource;
        private System.Windows.Forms.BindingSource zoneListBindingSource;
        private safeandsounddb1DataSet safeandsounddb1DataSet;
        internal System.Windows.Forms.Button butcancel;
        internal System.Windows.Forms.Button butsaveexit;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn Make;
        private System.Windows.Forms.DataGridViewComboBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zoneTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zoneDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private safeandsounddb1DataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridView servicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button ButAddService;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButViewService;
        private System.Windows.Forms.Button ButDeleteService;
    }
}