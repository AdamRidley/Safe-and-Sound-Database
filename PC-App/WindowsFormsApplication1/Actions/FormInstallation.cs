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
    public partial class FormInstallation : Form
    {
        private Form callingForm;
        private int addressId;
        private int installationID;

        public FormInstallation()
        {
            InitializeComponent();
        }

        public FormInstallation(int newAddressID, int newInstallationID, Form newcallingForm) : this()
        {
            addressId = newAddressID;
            installationID = newInstallationID;
            callingForm = newcallingForm;
        }

        private void FormInstallation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'safeandsounddb1DataSet.CustAdd' table. You can move, or remove it, as needed.
            this.custAddTableAdapter.Fill(this.safeandsounddb1DataSet.CustAdd);
            // TODO: This line of code loads data into the 'safeandsounddb1DataSet.addresses' table. You can move, or remove it, as needed.
            this.servicingTypeTableAdapter.Fill(this.safeandsounddb1DataSet.ServicingType);
            this.addressesTableAdapter.Fill(this.safeandsounddb1DataSet.addresses);

        }

        private void addressesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addressesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.safeandsounddb1DataSet);

        }

        private void addressesBindingSource_CurrentChanged(object sender, EventArgs e)
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
