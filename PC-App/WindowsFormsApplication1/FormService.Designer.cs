namespace WindowsFormsApplication1
{
    partial class FormService
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
            System.Windows.Forms.Label service_IDLabel;
            System.Windows.Forms.Label addressLabel2;
            System.Windows.Forms.Label battery_Charging_VoltageLabel;
            System.Windows.Forms.Label battery_Draining_VoltageLabel;
            System.Windows.Forms.Label charging_Current_AmpsLabel;
            System.Windows.Forms.Label resting_Current_AmpsLabel;
            System.Windows.Forms.Label alarm_Current_AmpsLabel;
            System.Windows.Forms.Label bell_Tamper_Resistance_OhmsLabel;
            System.Windows.Forms.Label overall_Tamper_Resistance_OhmsLabel;
            System.Windows.Forms.Label label1;
            this.safeandsounddb1DataSet = new WindowsFormsApplication1.safeandsounddb1DataSet();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesibfk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.ServicesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager();
            this.addressesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.addressesTableAdapter();
            this.serviceZoneMesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.ServiceZoneMesTableAdapter();
            this.service_IDTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.date_of_ServiceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.battery_Charging_VoltageTextBox = new System.Windows.Forms.TextBox();
            this.battery_Draining_VoltageTextBox = new System.Windows.Forms.TextBox();
            this.charging_Current_AmpsTextBox = new System.Windows.Forms.TextBox();
            this.resting_Current_AmpsTextBox = new System.Windows.Forms.TextBox();
            this.alarm_Current_AmpsTextBox = new System.Windows.Forms.TextBox();
            this.bell_Tamper_Resistance_OhmsTextBox = new System.Windows.Forms.TextBox();
            this.overall_Tamper_Resistance_OhmsTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.serviceZoneMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceZoneMesDataGridView = new System.Windows.Forms.DataGridView();
            this.zoneMappingsFriendlyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butcancel = new System.Windows.Forms.Button();
            this.butsaveexit = new System.Windows.Forms.Button();
            this.zone_Mappings_FriendlyTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Zone_Mappings_FriendlyTableAdapter();
            this.serviceZoneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.resistanceOhmsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamperResistanceOhmsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zone_MappingsTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Zone_MappingsTableAdapter();
            this.zone_ListTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Zone_ListTableAdapter();
            this.zone_TypesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.Zone_TypesTableAdapter();
            service_IDLabel = new System.Windows.Forms.Label();
            addressLabel2 = new System.Windows.Forms.Label();
            battery_Charging_VoltageLabel = new System.Windows.Forms.Label();
            battery_Draining_VoltageLabel = new System.Windows.Forms.Label();
            charging_Current_AmpsLabel = new System.Windows.Forms.Label();
            resting_Current_AmpsLabel = new System.Windows.Forms.Label();
            alarm_Current_AmpsLabel = new System.Windows.Forms.Label();
            bell_Tamper_Resistance_OhmsLabel = new System.Windows.Forms.Label();
            overall_Tamper_Resistance_OhmsLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesibfk1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceZoneMesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceZoneMesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoneMappingsFriendlyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // service_IDLabel
            // 
            service_IDLabel.AutoSize = true;
            service_IDLabel.Location = new System.Drawing.Point(405, 35);
            service_IDLabel.Name = "service_IDLabel";
            service_IDLabel.Size = new System.Drawing.Size(60, 13);
            service_IDLabel.TabIndex = 1;
            service_IDLabel.Text = "Service ID:";
            // 
            // addressLabel2
            // 
            addressLabel2.AutoSize = true;
            addressLabel2.Location = new System.Drawing.Point(417, 61);
            addressLabel2.Name = "addressLabel2";
            addressLabel2.Size = new System.Drawing.Size(48, 13);
            addressLabel2.TabIndex = 3;
            addressLabel2.Text = "Address:";
            // 
            // battery_Charging_VoltageLabel
            // 
            battery_Charging_VoltageLabel.AutoSize = true;
            battery_Charging_VoltageLabel.Location = new System.Drawing.Point(218, 41);
            battery_Charging_VoltageLabel.Name = "battery_Charging_VoltageLabel";
            battery_Charging_VoltageLabel.Size = new System.Drawing.Size(104, 13);
            battery_Charging_VoltageLabel.TabIndex = 7;
            battery_Charging_VoltageLabel.Text = "Battery Charging (V):";
            battery_Charging_VoltageLabel.Click += new System.EventHandler(this.battery_Charging_VoltageLabel_Click);
            // 
            // battery_Draining_VoltageLabel
            // 
            battery_Draining_VoltageLabel.AutoSize = true;
            battery_Draining_VoltageLabel.Location = new System.Drawing.Point(218, 70);
            battery_Draining_VoltageLabel.Name = "battery_Draining_VoltageLabel";
            battery_Draining_VoltageLabel.Size = new System.Drawing.Size(101, 13);
            battery_Draining_VoltageLabel.TabIndex = 9;
            battery_Draining_VoltageLabel.Text = "Battery Draining (V):";
            // 
            // charging_Current_AmpsLabel
            // 
            charging_Current_AmpsLabel.AutoSize = true;
            charging_Current_AmpsLabel.Location = new System.Drawing.Point(214, 96);
            charging_Current_AmpsLabel.Name = "charging_Current_AmpsLabel";
            charging_Current_AmpsLabel.Size = new System.Drawing.Size(105, 13);
            charging_Current_AmpsLabel.TabIndex = 11;
            charging_Current_AmpsLabel.Text = "Charging Current (A):";
            // 
            // resting_Current_AmpsLabel
            // 
            resting_Current_AmpsLabel.AutoSize = true;
            resting_Current_AmpsLabel.Location = new System.Drawing.Point(220, 122);
            resting_Current_AmpsLabel.Name = "resting_Current_AmpsLabel";
            resting_Current_AmpsLabel.Size = new System.Drawing.Size(99, 13);
            resting_Current_AmpsLabel.TabIndex = 13;
            resting_Current_AmpsLabel.Text = "Resting Current (A):";
            // 
            // alarm_Current_AmpsLabel
            // 
            alarm_Current_AmpsLabel.AutoSize = true;
            alarm_Current_AmpsLabel.Location = new System.Drawing.Point(51, 70);
            alarm_Current_AmpsLabel.Name = "alarm_Current_AmpsLabel";
            alarm_Current_AmpsLabel.Size = new System.Drawing.Size(89, 13);
            alarm_Current_AmpsLabel.TabIndex = 15;
            alarm_Current_AmpsLabel.Text = "Alarm Current (A):";
            // 
            // bell_Tamper_Resistance_OhmsLabel
            // 
            bell_Tamper_Resistance_OhmsLabel.AutoSize = true;
            bell_Tamper_Resistance_OhmsLabel.Location = new System.Drawing.Point(56, 96);
            bell_Tamper_Resistance_OhmsLabel.Name = "bell_Tamper_Resistance_OhmsLabel";
            bell_Tamper_Resistance_OhmsLabel.Size = new System.Drawing.Size(84, 13);
            bell_Tamper_Resistance_OhmsLabel.TabIndex = 17;
            bell_Tamper_Resistance_OhmsLabel.Text = "Bell Tamper (Ω):";
            // 
            // overall_Tamper_Resistance_OhmsLabel
            // 
            overall_Tamper_Resistance_OhmsLabel.AutoSize = true;
            overall_Tamper_Resistance_OhmsLabel.Location = new System.Drawing.Point(40, 122);
            overall_Tamper_Resistance_OhmsLabel.Name = "overall_Tamper_Resistance_OhmsLabel";
            overall_Tamper_Resistance_OhmsLabel.Size = new System.Drawing.Size(100, 13);
            overall_Tamper_Resistance_OhmsLabel.TabIndex = 19;
            overall_Tamper_Resistance_OhmsLabel.Text = "Overall Tamper (Ω):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 13);
            label1.TabIndex = 21;
            label1.Text = "Date of Service:";
            // 
            // safeandsounddb1DataSet
            // 
            this.safeandsounddb1DataSet.DataSetName = "safeandsounddb1DataSet";
            this.safeandsounddb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.AllowNew = true;
            this.servicesBindingSource.DataSource = this.servicesibfk1BindingSource;
            this.servicesBindingSource.CurrentChanged += new System.EventHandler(this.servicesBindingSource_CurrentChanged);
            // 
            // servicesibfk1BindingSource
            // 
            this.servicesibfk1BindingSource.DataMember = "services_ibfk_1";
            this.servicesibfk1BindingSource.DataSource = this.addressesBindingSource;
            // 
            // addressesBindingSource
            // 
            this.addressesBindingSource.DataMember = "addresses";
            this.addressesBindingSource.DataSource = this.safeandsounddb1DataSet;
            this.addressesBindingSource.CurrentChanged += new System.EventHandler(this.addressesBindingSource_CurrentChanged);
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressesTableAdapter = this.addressesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.correspondent_products_linkTableAdapter = null;
            this.tableAdapterManager.correspondentsTableAdapter = null;
            this.tableAdapterManager.CustAddTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Address_Product_LinkTableAdapter = null;
            this.tableAdapterManager.Phone_NumbersTableAdapter = null;
            this.tableAdapterManager.Prod_MakeTableAdapter = null;
            this.tableAdapterManager.Prod_ModelTableAdapter = null;
            this.tableAdapterManager.Prod_TypeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.ServiceZoneMesTableAdapter = this.serviceZoneMesTableAdapter;
            this.tableAdapterManager.TitlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zone_ListTableAdapter = null;
            this.tableAdapterManager.Zone_MappingsTableAdapter = null;
            this.tableAdapterManager.Zone_TypesTableAdapter = null;
            // 
            // addressesTableAdapter
            // 
            this.addressesTableAdapter.ClearBeforeFill = true;
            // 
            // serviceZoneMesTableAdapter
            // 
            this.serviceZoneMesTableAdapter.ClearBeforeFill = true;
            // 
            // service_IDTextBox
            // 
            this.service_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Service ID", true));
            this.service_IDTextBox.Location = new System.Drawing.Point(471, 32);
            this.service_IDTextBox.Name = "service_IDTextBox";
            this.service_IDTextBox.Size = new System.Drawing.Size(70, 20);
            this.service_IDTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(471, 58);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(70, 20);
            this.addressTextBox.TabIndex = 4;
            // 
            // date_of_ServiceDateTimePicker
            // 
            this.date_of_ServiceDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.date_of_ServiceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.servicesBindingSource, "Date of Service", true));
            this.date_of_ServiceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_of_ServiceDateTimePicker.Location = new System.Drawing.Point(102, 35);
            this.date_of_ServiceDateTimePicker.Name = "date_of_ServiceDateTimePicker";
            this.date_of_ServiceDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.date_of_ServiceDateTimePicker.TabIndex = 6;
            this.date_of_ServiceDateTimePicker.ValueChanged += new System.EventHandler(this.date_of_ServiceDateTimePicker_ValueChanged);
            // 
            // battery_Charging_VoltageTextBox
            // 
            this.battery_Charging_VoltageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Battery Charging Voltage", true));
            this.battery_Charging_VoltageTextBox.Location = new System.Drawing.Point(328, 41);
            this.battery_Charging_VoltageTextBox.Name = "battery_Charging_VoltageTextBox";
            this.battery_Charging_VoltageTextBox.Size = new System.Drawing.Size(52, 20);
            this.battery_Charging_VoltageTextBox.TabIndex = 8;
            this.battery_Charging_VoltageTextBox.TextChanged += new System.EventHandler(this.battery_Charging_VoltageTextBox_TextChanged);
            // 
            // battery_Draining_VoltageTextBox
            // 
            this.battery_Draining_VoltageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Battery Draining Voltage", true));
            this.battery_Draining_VoltageTextBox.Location = new System.Drawing.Point(328, 67);
            this.battery_Draining_VoltageTextBox.Name = "battery_Draining_VoltageTextBox";
            this.battery_Draining_VoltageTextBox.Size = new System.Drawing.Size(52, 20);
            this.battery_Draining_VoltageTextBox.TabIndex = 10;
            this.battery_Draining_VoltageTextBox.TextChanged += new System.EventHandler(this.battery_Draining_VoltageTextBox_TextChanged);
            // 
            // charging_Current_AmpsTextBox
            // 
            this.charging_Current_AmpsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Charging Current Amps", true));
            this.charging_Current_AmpsTextBox.Location = new System.Drawing.Point(328, 93);
            this.charging_Current_AmpsTextBox.Name = "charging_Current_AmpsTextBox";
            this.charging_Current_AmpsTextBox.Size = new System.Drawing.Size(52, 20);
            this.charging_Current_AmpsTextBox.TabIndex = 12;
            // 
            // resting_Current_AmpsTextBox
            // 
            this.resting_Current_AmpsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Resting Current Amps", true));
            this.resting_Current_AmpsTextBox.Location = new System.Drawing.Point(328, 119);
            this.resting_Current_AmpsTextBox.Name = "resting_Current_AmpsTextBox";
            this.resting_Current_AmpsTextBox.Size = new System.Drawing.Size(52, 20);
            this.resting_Current_AmpsTextBox.TabIndex = 14;
            // 
            // alarm_Current_AmpsTextBox
            // 
            this.alarm_Current_AmpsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Alarm Current Amps", true));
            this.alarm_Current_AmpsTextBox.Location = new System.Drawing.Point(146, 68);
            this.alarm_Current_AmpsTextBox.Name = "alarm_Current_AmpsTextBox";
            this.alarm_Current_AmpsTextBox.Size = new System.Drawing.Size(52, 20);
            this.alarm_Current_AmpsTextBox.TabIndex = 16;
            // 
            // bell_Tamper_Resistance_OhmsTextBox
            // 
            this.bell_Tamper_Resistance_OhmsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Bell Tamper Resistance Ohms", true));
            this.bell_Tamper_Resistance_OhmsTextBox.Location = new System.Drawing.Point(146, 94);
            this.bell_Tamper_Resistance_OhmsTextBox.Name = "bell_Tamper_Resistance_OhmsTextBox";
            this.bell_Tamper_Resistance_OhmsTextBox.Size = new System.Drawing.Size(52, 20);
            this.bell_Tamper_Resistance_OhmsTextBox.TabIndex = 18;
            // 
            // overall_Tamper_Resistance_OhmsTextBox
            // 
            this.overall_Tamper_Resistance_OhmsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Overall Tamper Resistance Ohms", true));
            this.overall_Tamper_Resistance_OhmsTextBox.Location = new System.Drawing.Point(146, 120);
            this.overall_Tamper_Resistance_OhmsTextBox.Name = "overall_Tamper_Resistance_OhmsTextBox";
            this.overall_Tamper_Resistance_OhmsTextBox.Size = new System.Drawing.Size(52, 20);
            this.overall_Tamper_Resistance_OhmsTextBox.TabIndex = 20;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressLabel.Location = new System.Drawing.Point(12, 9);
            this.addressLabel.MinimumSize = new System.Drawing.Size(550, 2);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Padding = new System.Windows.Forms.Padding(3);
            this.addressLabel.Size = new System.Drawing.Size(550, 21);
            this.addressLabel.TabIndex = 22;
            this.addressLabel.Text = "Address: ";
            // 
            // serviceZoneMesBindingSource
            // 
            this.serviceZoneMesBindingSource.AllowNew = true;
            this.serviceZoneMesBindingSource.DataMember = "servicefrgn";
            this.serviceZoneMesBindingSource.DataSource = this.servicesBindingSource;
            // 
            // serviceZoneMesDataGridView
            // 
            this.serviceZoneMesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceZoneMesDataGridView.AutoGenerateColumns = false;
            this.serviceZoneMesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceZoneMesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceZoneIDDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.zoneNumberDataGridViewTextBoxColumn,
            this.resistanceOhmsDataGridViewTextBoxColumn,
            this.tamperResistanceOhmsDataGridViewTextBoxColumn,
            this.voltageDataGridViewTextBoxColumn});
            this.serviceZoneMesDataGridView.DataSource = this.serviceZoneMesBindingSource;
            this.serviceZoneMesDataGridView.Location = new System.Drawing.Point(12, 146);
            this.serviceZoneMesDataGridView.MultiSelect = false;
            this.serviceZoneMesDataGridView.Name = "serviceZoneMesDataGridView";
            this.serviceZoneMesDataGridView.RowHeadersWidth = 25;
            this.serviceZoneMesDataGridView.Size = new System.Drawing.Size(550, 254);
            this.serviceZoneMesDataGridView.TabIndex = 22;
            this.serviceZoneMesDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.serviceZoneMesDataGridView_RowValidating);
            // 
            // zoneMappingsFriendlyBindingSource
            // 
            this.zoneMappingsFriendlyBindingSource.AllowNew = false;
            this.zoneMappingsFriendlyBindingSource.DataMember = "FK_addresses_Zone Mappings Friendly";
            this.zoneMappingsFriendlyBindingSource.DataSource = this.addressesBindingSource;
            // 
            // butcancel
            // 
            this.butcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butcancel.Location = new System.Drawing.Point(430, 114);
            this.butcancel.Name = "butcancel";
            this.butcancel.Size = new System.Drawing.Size(111, 26);
            this.butcancel.TabIndex = 42;
            this.butcancel.Text = "&Cancel";
            this.butcancel.UseVisualStyleBackColor = true;
            this.butcancel.Click += new System.EventHandler(this.butcancel_Click);
            // 
            // butsaveexit
            // 
            this.butsaveexit.Location = new System.Drawing.Point(430, 82);
            this.butsaveexit.Name = "butsaveexit";
            this.butsaveexit.Size = new System.Drawing.Size(111, 26);
            this.butsaveexit.TabIndex = 41;
            this.butsaveexit.Text = "&Save && Exit";
            this.butsaveexit.UseVisualStyleBackColor = true;
            this.butsaveexit.Click += new System.EventHandler(this.butsaveexit_Click);
            // 
            // zone_Mappings_FriendlyTableAdapter
            // 
            this.zone_Mappings_FriendlyTableAdapter.ClearBeforeFill = true;
            // 
            // serviceZoneIDDataGridViewTextBoxColumn
            // 
            this.serviceZoneIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceZoneID";
            this.serviceZoneIDDataGridViewTextBoxColumn.HeaderText = "ServiceZoneID";
            this.serviceZoneIDDataGridViewTextBoxColumn.Name = "serviceZoneIDDataGridViewTextBoxColumn";
            this.serviceZoneIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.Width = 70;
            // 
            // zoneNumberDataGridViewTextBoxColumn
            // 
            this.zoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Zone Number";
            this.zoneNumberDataGridViewTextBoxColumn.DataSource = this.zoneMappingsFriendlyBindingSource;
            this.zoneNumberDataGridViewTextBoxColumn.DisplayMember = "Zone";
            this.zoneNumberDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.zoneNumberDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.zoneNumberDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zoneNumberDataGridViewTextBoxColumn.HeaderText = "Zone Number";
            this.zoneNumberDataGridViewTextBoxColumn.Name = "zoneNumberDataGridViewTextBoxColumn";
            this.zoneNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zoneNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zoneNumberDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // resistanceOhmsDataGridViewTextBoxColumn
            // 
            this.resistanceOhmsDataGridViewTextBoxColumn.DataPropertyName = "Resistance Ohms";
            this.resistanceOhmsDataGridViewTextBoxColumn.HeaderText = "Resistance (Ω)";
            this.resistanceOhmsDataGridViewTextBoxColumn.Name = "resistanceOhmsDataGridViewTextBoxColumn";
            this.resistanceOhmsDataGridViewTextBoxColumn.Width = 70;
            // 
            // tamperResistanceOhmsDataGridViewTextBoxColumn
            // 
            this.tamperResistanceOhmsDataGridViewTextBoxColumn.DataPropertyName = "Tamper Resistance Ohms";
            this.tamperResistanceOhmsDataGridViewTextBoxColumn.HeaderText = "Tamper (Ω)";
            this.tamperResistanceOhmsDataGridViewTextBoxColumn.Name = "tamperResistanceOhmsDataGridViewTextBoxColumn";
            this.tamperResistanceOhmsDataGridViewTextBoxColumn.Width = 70;
            // 
            // voltageDataGridViewTextBoxColumn
            // 
            this.voltageDataGridViewTextBoxColumn.DataPropertyName = "Voltage";
            this.voltageDataGridViewTextBoxColumn.HeaderText = "Voltage (V)";
            this.voltageDataGridViewTextBoxColumn.Name = "voltageDataGridViewTextBoxColumn";
            this.voltageDataGridViewTextBoxColumn.Width = 70;
            // 
            // zone_MappingsTableAdapter
            // 
            this.zone_MappingsTableAdapter.ClearBeforeFill = true;
            // 
            // zone_ListTableAdapter
            // 
            this.zone_ListTableAdapter.ClearBeforeFill = true;
            // 
            // zone_TypesTableAdapter
            // 
            this.zone_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butcancel;
            this.ClientSize = new System.Drawing.Size(574, 412);
            this.Controls.Add(this.butcancel);
            this.Controls.Add(this.butsaveexit);
            this.Controls.Add(this.serviceZoneMesDataGridView);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(label1);
            this.Controls.Add(service_IDLabel);
            this.Controls.Add(this.service_IDTextBox);
            this.Controls.Add(addressLabel2);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.date_of_ServiceDateTimePicker);
            this.Controls.Add(battery_Charging_VoltageLabel);
            this.Controls.Add(this.battery_Charging_VoltageTextBox);
            this.Controls.Add(battery_Draining_VoltageLabel);
            this.Controls.Add(this.battery_Draining_VoltageTextBox);
            this.Controls.Add(charging_Current_AmpsLabel);
            this.Controls.Add(this.charging_Current_AmpsTextBox);
            this.Controls.Add(resting_Current_AmpsLabel);
            this.Controls.Add(this.resting_Current_AmpsTextBox);
            this.Controls.Add(alarm_Current_AmpsLabel);
            this.Controls.Add(this.alarm_Current_AmpsTextBox);
            this.Controls.Add(bell_Tamper_Resistance_OhmsLabel);
            this.Controls.Add(this.bell_Tamper_Resistance_OhmsTextBox);
            this.Controls.Add(overall_Tamper_Resistance_OhmsLabel);
            this.Controls.Add(this.overall_Tamper_Resistance_OhmsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormService";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.FormService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesibfk1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceZoneMesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceZoneMesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoneMappingsFriendlyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private safeandsounddb1DataSet safeandsounddb1DataSet;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private safeandsounddb1DataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private safeandsounddb1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox service_IDTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox battery_Charging_VoltageTextBox;
        private System.Windows.Forms.TextBox battery_Draining_VoltageTextBox;
        private System.Windows.Forms.TextBox charging_Current_AmpsTextBox;
        private System.Windows.Forms.TextBox resting_Current_AmpsTextBox;
        private System.Windows.Forms.TextBox alarm_Current_AmpsTextBox;
        private System.Windows.Forms.TextBox bell_Tamper_Resistance_OhmsTextBox;
        private System.Windows.Forms.TextBox overall_Tamper_Resistance_OhmsTextBox;
        private System.Windows.Forms.DateTimePicker date_of_ServiceDateTimePicker;
        private System.Windows.Forms.Label addressLabel;
        private safeandsounddb1DataSetTableAdapters.addressesTableAdapter addressesTableAdapter;
        private System.Windows.Forms.BindingSource addressesBindingSource;
        private safeandsounddb1DataSetTableAdapters.ServiceZoneMesTableAdapter serviceZoneMesTableAdapter;
        private System.Windows.Forms.BindingSource serviceZoneMesBindingSource;
        private System.Windows.Forms.DataGridView serviceZoneMesDataGridView;
        internal System.Windows.Forms.Button butcancel;
        internal System.Windows.Forms.Button butsaveexit;
        private System.Windows.Forms.BindingSource zoneMappingsFriendlyBindingSource;
        private safeandsounddb1DataSetTableAdapters.Zone_Mappings_FriendlyTableAdapter zone_Mappings_FriendlyTableAdapter;
        private System.Windows.Forms.BindingSource servicesibfk1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceZoneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resistanceOhmsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamperResistanceOhmsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn;
        private safeandsounddb1DataSetTableAdapters.Zone_MappingsTableAdapter zone_MappingsTableAdapter;
        private safeandsounddb1DataSetTableAdapters.Zone_ListTableAdapter zone_ListTableAdapter;
        private safeandsounddb1DataSetTableAdapters.Zone_TypesTableAdapter zone_TypesTableAdapter;
    }
}