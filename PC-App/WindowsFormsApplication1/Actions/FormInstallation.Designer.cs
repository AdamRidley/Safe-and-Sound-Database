namespace WindowsFormsApplication1
{
    partial class FormInstallation
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
            this.addressLabel = new System.Windows.Forms.Label();
            this.safeandsounddb1DataSet = new WindowsFormsApplication1.safeandsounddb1DataSet();
            this.addressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressesTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.addressesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.TableAdapterManager();
            this.custAddTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.CustAddTableAdapter();
            this.custAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicingTypeTableAdapter = new WindowsFormsApplication1.safeandsounddb1DataSetTableAdapters.ServicingTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAddBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.addressLabel.TabIndex = 24;
            this.addressLabel.Text = "Address: ";
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
            this.addressesBindingSource.CurrentChanged += new System.EventHandler(this.addressesBindingSource_CurrentChanged);
            // 
            // addressesTableAdapter
            // 
            this.addressesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InstallationProductTableAdapter = null;
            this.tableAdapterManager.InstallationTableAdapter = null;
            this.tableAdapterManager.InstallationTypeTableAdapter = null;
            this.tableAdapterManager.Phone_NumbersTableAdapter = null;
            this.tableAdapterManager.PhoneCallTableAdapter = null;
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
            // custAddTableAdapter
            // 
            this.custAddTableAdapter.ClearBeforeFill = true;
            // 
            // custAddBindingSource
            // 
            this.custAddBindingSource.DataMember = "addressidfrgn";
            this.custAddBindingSource.DataSource = this.addressesBindingSource;
            // 
            // servicingTypeTableAdapter
            // 
            this.servicingTypeTableAdapter.ClearBeforeFill = true;
            // 
            // FormInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 497);
            this.Controls.Add(this.addressLabel);
            this.Name = "FormInstallation";
            this.Text = "Installation";
            this.Load += new System.EventHandler(this.FormInstallation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.safeandsounddb1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custAddBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addressLabel;
        private safeandsounddb1DataSet safeandsounddb1DataSet;
        private System.Windows.Forms.BindingSource addressesBindingSource;
        private safeandsounddb1DataSetTableAdapters.addressesTableAdapter addressesTableAdapter;
        private safeandsounddb1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private safeandsounddb1DataSetTableAdapters.CustAddTableAdapter custAddTableAdapter;
        private System.Windows.Forms.BindingSource custAddBindingSource;
        private safeandsounddb1DataSetTableAdapters.ServicingTypeTableAdapter servicingTypeTableAdapter;
    }
}