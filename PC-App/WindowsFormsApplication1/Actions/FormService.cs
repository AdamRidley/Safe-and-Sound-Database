using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormService : Form
    {
        private Form callingForm;
        private int addressId;
        private int serviceId;
       
        public FormService()
        {
            InitializeComponent();
        }
        public FormService(int newAddressId,int newServiceId,Form newCallingForm):this()
        {
            addressId = newAddressId;
            serviceId = newServiceId;
            callingForm = newCallingForm;
        }

        private void servicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.safeandsounddb1DataSet);

        }

        private void FormService_Load(object sender, EventArgs e)
        {
            addressLabel.Width = this.Width - 40;
            getData();
            addressesBindingSource.Position = addressesBindingSource.Find("Address ID", addressId);
            if (serviceId == 0)
            {
                servicesBindingSource.AddNew();
                servicesBindingSource.MoveLast();
                servicesBindingSource.EndEdit();
                actionBindingSource.AddNew();
                actionBindingSource.MoveLast();
                //safeandsounddb1DataSet.ServicesRow serviceRow = (safeandsounddb1DataSet.ServicesRow)((DataRowView)servicesBindingSource.Current).Row;
                safeandsounddb1DataSet.ActionRow actionRow = (safeandsounddb1DataSet.ActionRow)((DataRowView)actionBindingSource.Current).Row;
                safeandsounddb1DataSet.CustAddRow custAddRow = (safeandsounddb1DataSet.CustAddRow)((DataRowView)custAddBindingSource.List[0]).Row;
                actionRow.Date = DateTime.Today;
                date_of_ServiceDateTimePicker.Value = actionRow.Date;
                actionRow.CustAddID = custAddRow.CustAdd_ID;
            }
            else
            {
                servicesBindingSource.Position = servicesBindingSource.Find("Service ID", serviceId);
            }
        }

        private void getData()
        {
            this.servicingTypeTableAdapter.Fill(this.safeandsounddb1DataSet.ServicingType);
            this.addressesTableAdapter.Fill(this.safeandsounddb1DataSet.addresses);
            this.zone_Mappings_FriendlyTableAdapter.Fill(this.safeandsounddb1DataSet.Zone_Mappings_Friendly);
            this.zone_ListTableAdapter.Fill(this.safeandsounddb1DataSet.Zone_List);
            this.zone_TypesTableAdapter.Fill(this.safeandsounddb1DataSet.Zone_Types);
            this.zone_MappingsTableAdapter.Fill(this.safeandsounddb1DataSet.Zone_Mappings);
            this.servicesTableAdapter.Fill(this.safeandsounddb1DataSet.Services);
            this.serviceZoneMesTableAdapter.Fill(this.safeandsounddb1DataSet.ServiceZoneMes);
            this.actionTableAdapter.Fill(this.safeandsounddb1DataSet.Action);
            this.titlesTableAdapter.Fill(this.safeandsounddb1DataSet.Titles);
            this.customersTableAdapter.Fill(this.safeandsounddb1DataSet.Customers);
            this.custAddTableAdapter.Fill(this.safeandsounddb1DataSet.CustAdd);
        }
        

        private void butcancel_Click(object sender, EventArgs e)
        {
            safeandsounddb1DataSet.RejectChanges();
            callingForm.Show();
            this.Dispose();
        }

        private void butsaveexit_Click(object sender, EventArgs e)
        {
            this.Validate();
            serviceZoneMesBindingSource.EndEdit();
            servicesBindingSource.EndEdit();
            actionBindingSource.EndEdit();
            if (safeandsounddb1DataSet.HasChanges())
            {
                tableAdapterManager.UpdateAll(safeandsounddb1DataSet);
            }
            safeandsounddb1DataSet.AcceptChanges();
            callingForm.Show();
            this.Dispose();
        }

        private void addressesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            safeandsounddb1DataSet.addressesRow address = (safeandsounddb1DataSet.addressesRow)((DataRowView)addressesBindingSource.Current).Row;
            StringBuilder str = new StringBuilder("Address: ");
            if (!address.IsAddress_Line_1Null() && address.Address_Line_1 != "")
            {
                str.Append(address.Address_Line_1 + ", ");

            }
            if (!address.IsAddress_Line_2Null()&&address.Address_Line_2 != "")
            {
                str.Append(address.Address_Line_2 + ", ");
            }
            if (!address.IsAddress_Line_3Null()&&address.Address_Line_3 != "")
            {
                str.Append(address.Address_Line_3 + ", ");
            }
            if (!address.IsTownNull()&&address.Town != "")
            {
                str.Append(address.Town + ", ");
            }
            if (!address.IsPost_CodeNull()&&address.Post_Code != "")
            {
                str.Append(address.Post_Code + ", ");
            }
            addressLabel.Text = str.ToString();
        }

        private void serviceZoneMesDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //MessageBox.Show("Test");
        }

        private void FormService_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                butcancel_Click(sender, e);
            }
        }

        private void serviceZoneMesDataGridView_Enter(object sender, EventArgs e)
        {
            servicesBindingSource.EndEdit();
        }
        
    }
}
