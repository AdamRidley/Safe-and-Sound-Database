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
    public partial class FormCallOut : Form
    {
            private Form callingForm;
            private int addressId;
            private int callOutID;

            public FormCallOut()
            {
                InitializeComponent();
            }

            public FormCallOut(int newAddressID, int newCallOutID, Form newcallingForm) : this()
            {
                addressId = newAddressID;
                callOutID = newCallOutID;
                callingForm = newcallingForm;
            }

        private void addressesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addressesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.safeandsounddb1DataSet);

        }

        private void FormCallOut_Load(object sender, EventArgs e)
        {
            addressLabel.Width = this.Width - 40;
            getData();
            addressesBindingSource.Position = addressesBindingSource.Find("Address ID", addressId);
            if (callOutID == 0)
            {
                callOutBindingSource.AddNew();
                callOutBindingSource.MoveLast();
                callOutBindingSource.EndEdit();
                actionBindingSource.AddNew();
                actionBindingSource.MoveLast();
                //safeandsounddb1DataSet.CallOutRow callOutRow = (safeandsounddb1DataSet.CallOutRow)((DataRowView)callOutBindingSource.Current).Row;
                safeandsounddb1DataSet.ActionRow actionRow = (safeandsounddb1DataSet.ActionRow)((DataRowView)actionBindingSource.Current).Row;
                safeandsounddb1DataSet.CustAddRow custAddRow = (safeandsounddb1DataSet.CustAddRow)((DataRowView)custAddBindingSource.List[0]).Row;
                actionRow.Date = DateTime.Today;
                dateDateTimePicker.Value = actionRow.Date;
                actionRow.CustAddID = custAddRow.CustAdd_ID;
            }
            else
            {
                callOutBindingSource.Position = callOutBindingSource.Find("ID", callOutID);
            }
        }

        private void getData()
        {
            this.callOutTableAdapter.Fill(this.safeandsounddb1DataSet.CallOut);
            this.actionTableAdapter.Fill(this.safeandsounddb1DataSet.Action);
            this.servicingTypeTableAdapter.Fill(this.safeandsounddb1DataSet.ServicingType);
            this.addressesTableAdapter.Fill(this.safeandsounddb1DataSet.addresses);
            this.titlesTableAdapter.Fill(this.safeandsounddb1DataSet.Titles);
            this.customersTableAdapter.Fill(this.safeandsounddb1DataSet.Customers);
            this.custAddTableAdapter.Fill(this.safeandsounddb1DataSet.CustAdd);

        }

        private void butsaveexit_Click(object sender, EventArgs e)
        {
            this.Validate();
            callOutBindingSource.EndEdit();
            actionBindingSource.EndEdit();
            if (safeandsounddb1DataSet.HasChanges())
            {
                tableAdapterManager.UpdateAll(safeandsounddb1DataSet);
            }
            safeandsounddb1DataSet.AcceptChanges();
            callingForm.Show();
            this.Dispose();
        }

        private void butcancel_Click(object sender, EventArgs e)
        {
            safeandsounddb1DataSet.RejectChanges();
            callingForm.Show();
            this.Dispose();
        }

        private void FormCallOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                butcancel_Click(sender, e);
            }
        }

        private void actionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            safeandsounddb1DataSet.addressesRow address = (safeandsounddb1DataSet.addressesRow)((DataRowView)addressesBindingSource.Current).Row;
            StringBuilder str = new StringBuilder("Address: ");
            if (!address.IsAddress_Line_1Null() && address.Address_Line_1 != "")
            {
                str.Append(address.Address_Line_1 + ", ");

            }
            if (!address.IsAddress_Line_2Null() && address.Address_Line_2 != "")
            {
                str.Append(address.Address_Line_2 + ", ");
            }
            if (!address.IsAddress_Line_3Null() && address.Address_Line_3 != "")
            {
                str.Append(address.Address_Line_3 + ", ");
            }
            if (!address.IsTownNull() && address.Town != "")
            {
                str.Append(address.Town + ", ");
            }
            if (!address.IsPost_CodeNull() && address.Post_Code != "")
            {
                str.Append(address.Post_Code + ", ");
            }
            addressLabel.Text = str.ToString();
        }
    }
}
