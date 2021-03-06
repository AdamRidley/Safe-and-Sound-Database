﻿namespace WindowsFormsApplication1
{
    partial class FormPhoneCall
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
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label dateLabel;
            this.butcancel = new System.Windows.Forms.Button();
            this.butsaveexit = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.safeandsounddb1DataSet = new WindowsFormsApplication1.safeandsounddb1DataSet();
            this.phoneCallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneCallTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.PhoneCallTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager();
            this.actionTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.ActionTableAdapter();
            this.addressesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.addressesTableAdapter();
            this.custAddTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.CustAddTableAdapter();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.actionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.CustomersTableAdapter();
            this.titlesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TitlesTableAdapter();
            this.servicingTypeTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.ServicingTypeTableAdapter();
            notesLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneCallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAddBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(12, 62);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 48;
            notesLabel.Text = "Notes:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 40);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 49;
            dateLabel.Text = "Date:";
            // 
            // butcancel
            // 
            this.butcancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butcancel.Location = new System.Drawing.Point(292, 47);
            this.butcancel.Name = "butcancel";
            this.butcancel.Size = new System.Drawing.Size(111, 26);
            this.butcancel.TabIndex = 46;
            this.butcancel.Text = "&Cancel";
            this.butcancel.UseVisualStyleBackColor = true;
            this.butcancel.Click += new System.EventHandler(this.butcancel_Click);
            // 
            // butsaveexit
            // 
            this.butsaveexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butsaveexit.Location = new System.Drawing.Point(175, 47);
            this.butsaveexit.Name = "butsaveexit";
            this.butsaveexit.Size = new System.Drawing.Size(111, 26);
            this.butsaveexit.TabIndex = 45;
            this.butsaveexit.Text = "&Save && Exit";
            this.butsaveexit.UseVisualStyleBackColor = true;
            this.butsaveexit.Click += new System.EventHandler(this.butsaveexit_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressLabel.Location = new System.Drawing.Point(12, 9);
            this.addressLabel.MinimumSize = new System.Drawing.Size(200, 2);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Padding = new System.Windows.Forms.Padding(3);
            this.addressLabel.Size = new System.Drawing.Size(200, 21);
            this.addressLabel.TabIndex = 47;
            this.addressLabel.Text = "Address: ";
            // 
            // safeandsounddb1DataSet
            // 
            this.safeandsounddb1DataSet.DataSetName = "safeandsounddb1DataSet";
            this.safeandsounddb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneCallBindingSource
            // 
            this.phoneCallBindingSource.DataMember = "PhoneCall";
            this.phoneCallBindingSource.DataSource = this.safeandsounddb1DataSet;
            // 
            // phoneCallTableAdapter
            // 
            this.phoneCallTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActionTableAdapter = this.actionTableAdapter;
            this.tableAdapterManager.ActionTypeTableAdapter = null;
            this.tableAdapterManager.Address_Product_LinkTableAdapter = null;
            this.tableAdapterManager.addressesTableAdapter = this.addressesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CallOutTableAdapter = null;
            this.tableAdapterManager.correspondent_products_linkTableAdapter = null;
            this.tableAdapterManager.correspondentsTableAdapter = null;
            this.tableAdapterManager.CustAddTableAdapter = this.custAddTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InstallationProductTableAdapter = null;
            this.tableAdapterManager.InstallationTableAdapter = null;
            this.tableAdapterManager.InstallationTypeTableAdapter = null;
            this.tableAdapterManager.Phone_NumbersTableAdapter = null;
            this.tableAdapterManager.PhoneCallTableAdapter = this.phoneCallTableAdapter;
            this.tableAdapterManager.Prod_MakeTableAdapter = null;
            this.tableAdapterManager.Prod_ModelTableAdapter = null;
            this.tableAdapterManager.Prod_TypeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.ServiceZoneMesTableAdapter = null;
            this.tableAdapterManager.ServicingTypeTableAdapter = null;
            this.tableAdapterManager.TitlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zone_ListTableAdapter = null;
            this.tableAdapterManager.Zone_MappingsTableAdapter = null;
            this.tableAdapterManager.Zone_TypesTableAdapter = null;
            // 
            // actionTableAdapter
            // 
            this.actionTableAdapter.ClearBeforeFill = true;
            // 
            // addressesTableAdapter
            // 
            this.addressesTableAdapter.ClearBeforeFill = true;
            // 
            // custAddTableAdapter
            // 
            this.custAddTableAdapter.ClearBeforeFill = true;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneCallBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(12, 79);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(391, 131);
            this.notesTextBox.TabIndex = 49;
            // 
            // actionBindingSource
            // 
            this.actionBindingSource.DataMember = "action_ibfk_5";
            this.actionBindingSource.DataSource = this.phoneCallBindingSource;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.actionBindingSource, "Date", true));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDateTimePicker.Location = new System.Drawing.Point(51, 36);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.dateDateTimePicker.TabIndex = 50;
            // 
            // addressesBindingSource
            // 
            this.addressesBindingSource.DataMember = "addresses";
            this.addressesBindingSource.DataSource = this.safeandsounddb1DataSet;
            this.addressesBindingSource.CurrentChanged += new System.EventHandler(this.addressesBindingSource_CurrentChanged);
            // 
            // custAddBindingSource
            // 
            this.custAddBindingSource.DataMember = "addressidfrgn";
            this.custAddBindingSource.DataSource = this.addressesBindingSource;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // titlesTableAdapter
            // 
            this.titlesTableAdapter.ClearBeforeFill = true;
            // 
            // servicingTypeTableAdapter
            // 
            this.servicingTypeTableAdapter.ClearBeforeFill = true;
            // 
            // FormPhoneCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 222);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.butcancel);
            this.Controls.Add(this.butsaveexit);
            this.MaximizeBox = false;
            this.Name = "FormPhoneCall";
            this.Text = "Phone Call";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPhoneCall_FormClosing);
            this.Load += new System.EventHandler(this.FormPhoneCall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneCallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAddBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button butcancel;
        internal System.Windows.Forms.Button butsaveexit;
        private System.Windows.Forms.Label addressLabel;
        private safeandsounddb1DataSet safeandsounddb1DataSet;
        private System.Windows.Forms.BindingSource phoneCallBindingSource;
        private safeandsounddb1DataSetTableAdapters.PhoneCallTableAdapter phoneCallTableAdapter;
        private safeandsounddb1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox notesTextBox;
        private safeandsounddb1DataSetTableAdapters.ActionTableAdapter actionTableAdapter;
        private System.Windows.Forms.BindingSource actionBindingSource;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private safeandsounddb1DataSetTableAdapters.addressesTableAdapter addressesTableAdapter;
        private System.Windows.Forms.BindingSource addressesBindingSource;
        private safeandsounddb1DataSetTableAdapters.CustAddTableAdapter custAddTableAdapter;
        private System.Windows.Forms.BindingSource custAddBindingSource;
        private safeandsounddb1DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private safeandsounddb1DataSetTableAdapters.TitlesTableAdapter titlesTableAdapter;
        private safeandsounddb1DataSetTableAdapters.ServicingTypeTableAdapter servicingTypeTableAdapter;
    }
}