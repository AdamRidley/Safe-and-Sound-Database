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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private int PassedId;
        private Form CallingForm;
        public FormCustomer(int id, Form newcallingform) : this()
        {
            PassedId = id;
            CallingForm = newcallingform;
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.safeandsounddb1DataSet);

        }

        private void GetData()
        {
            this.titlesTableAdapter.Fill(this.safeandsounddb1DataSet.Titles);
            this.customersTableAdapter.Fill(this.safeandsounddb1DataSet.Customers);
            this.addressesTableAdapter.Fill(this.safeandsounddb1DataSet.addresses);
            this.custAddTableAdapter.Fill(this.safeandsounddb1DataSet.CustAdd);
            this.phone_NumbersTableAdapter.Fill(this.safeandsounddb1DataSet.Phone_Numbers);
        }
        private void ClearData()
        {
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            GetData();
            if (PassedId == 0)
            {
                customersBindingSource.AddNew();
                customersBindingSource.MoveLast();
            }
            else
            {
                customersBindingSource.Position = customersBindingSource.Find("Customer ID", PassedId);
            }
            FilterAddresses();
            DeselectAddresses();
        }
        

        private void DeselectAddresses()
        {
            foreach (DataGridViewCell a in addressesDataGridView.SelectedCells)
            { 
                a.Selected = false;
            }
            PhoneFilter();
        }

        private void PhoneFilter()
        {
            if (customersBindingSource.Current == null) return;
            int CustId;
            string AddrId=null;
            string PFilt = "";
            bool FilterAds = true;
            //List<int> CustAddrIds = new List<int>();
            if (addressesDataGridView.SelectedRows.Count==0) { FilterAds = false; }
            CustId = ((safeandsounddb1DataSet.CustomersRow)((DataRowView)customersBindingSource.Current).Row).Customer_ID;
            if (FilterAds) { AddrId = addressesDataGridView.SelectedCells[0].OwningRow.Cells[0].Value.ToString(); }
            if (FilterAds & AddrId==null) { FilterAds = false; }
            foreach (DataRowView b in custAddBindingSource.List)
            {
                safeandsounddb1DataSet.CustAddRow a = (safeandsounddb1DataSet.CustAddRow)b.Row;
                if (a.IsCustomer_IDNull()|(FilterAds&a.IsAddress_IDNull())) { continue; }
                if (a.Customer_ID == CustId && (!FilterAds|| (FilterAds & a.Address_ID.ToString() == AddrId)))
                {
                    //      CustAddrIds.Add(a.CustAdd_ID);
                    PFilt += ", " + a.CustAdd_ID;
                }  
            }
            /*
            if (CustAddrIds.Count > 0)
            {
                foreach(safeandsounddb1DataSet.Phone_NumbersRow b in safeandsounddb1DataSet.Phone_Numbers)
                {
                    if (b.RowState!=DataRowState.Deleted)
                    {

                    }
                }
            }
            */
            PFilt = PFilt.Substring(Math.Min(PFilt.Length, 2));
            PFilt = (PFilt == "")? "[CustAdd ID] = Null": "[CustAdd ID] in (" + PFilt + ")";
            phone_NumbersBindingSource.Filter = PFilt;
        }

        private void FilterAddresses()
        {
            if (customersBindingSource.Current == null) return;
            int custId;
            string adFilt = "";
            
            custId = ((safeandsounddb1DataSet.CustomersRow)((DataRowView)customersBindingSource.Current).Row).Customer_ID;
            foreach (DataRowView b in custAddBindingSource.List)
            {
                safeandsounddb1DataSet.CustAddRow a = (safeandsounddb1DataSet.CustAddRow)b.Row;
                if (!a.IsAddress_IDNull() & !a.IsCustomer_IDNull())
                {
                    if (a.Customer_ID==custId)
                    {
                        adFilt += a.Address_ID.ToString() + ", ";
                    }
                }
            }
            adFilt = adFilt.Substring(0, Math.Max(adFilt.Length - 2, 0));
            adFilt = (adFilt == "") ? "[Address ID] = Null": "[Address ID] in (" + adFilt + ")";
            addressesBindingSource.Filter = adFilt;
            /*for (int a =0;a<custAddBindingSource.Count;a++)
            {
                if (!((safeandsounddb1DataSet.CustAddRow) custAddBindingSource.List[a]).IsAddress_IDNull() & !((safeandsounddb1DataSet.CustAddRow)custAddBindingSource.List[a]).IsCustomer_IDNull())
                {

                }
            }
            */

        }

        private void e_Mail_AddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void e_Mail_AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void last_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ButCancel_Click(object sender, EventArgs e)
        { 
            safeandsounddb1DataSet.RejectChanges();
            CallingForm.Show();
            this.Dispose();
        }

        private void FormCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ButCancel_Click(sender, e);
        }

        private void customersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            FilterAddresses();
        }

        private void ButSaveExit_Click(object sender, EventArgs e)
        {
            UpdateDataSet();
            CallingForm.Show();
            this.Dispose();
        }

        private void UpdateDataSet()
        {
            addressesBindingSource.Filter = "";
            this.Validate();
            titlesBindingSource.EndEdit();
            customersBindingSource.EndEdit();
            addressesBindingSource.EndEdit();
            custAddBindingSource.EndEdit();
            phone_NumbersBindingSource.EndEdit();
            if (safeandsounddb1DataSet.HasChanges())
            { 
                tableAdapterManager.UpdateAll(safeandsounddb1DataSet);
            }
            safeandsounddb1DataSet.AcceptChanges();
            FilterAddresses();
            PhoneFilter();
        }

        private void addressesBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            customersBindingSource.EndEdit();
        }

        private void addressesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (addressesDataGridView.SelectedCells.Count>0) { ButAddressView_Click(sender, e); }
        }

        private void ButAddressView_Click(object sender, EventArgs e)
        {
            if (addressesDataGridView.SelectedCells.Count == 0) { return; }
            addressesBindingSource.EndEdit();
            UpdateDataSet();

            //Merge Changes
           // addressesTableAdapter.ClearBeforeFill = false;
           // addressesTableAdapter.Fill(safeandsounddb1DataSet.addresses);
            //addressesTableAdapter.ClearBeforeFill = true;
            //safeandsounddb1DataSet.Clear();
            //GetData();
            MessageBox.Show(addressesDataGridView.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

        }

        private void addressesDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            custAddBindingSource.AddNew();
            custAddBindingSource.MoveLast();
            ((safeandsounddb1DataSet.CustAddRow)((DataRowView)custAddBindingSource.Current).Row).Customer_ID = ((safeandsounddb1DataSet.CustomersRow)((DataRowView)customersBindingSource.Current).Row).Customer_ID;
            addressesBindingSource.MoveLast();
            ((safeandsounddb1DataSet.CustAddRow)((DataRowView)custAddBindingSource.Current).Row).Address_ID = ((safeandsounddb1DataSet.addressesRow)((DataRowView)addressesBindingSource.Current).Row).Address_ID;
        }

        private void titleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titleComboBox_Validating(object sender, CancelEventArgs e)
        {
        }

        private void addressesDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void addressesDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //  addressesBindingSource.EndEdit();
            //  FilterAddresses();
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void addressesDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            addressesBindingSource.EndEdit();
            FilterAddresses();
            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void addressesDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void addressesDataGridView_Leave(object sender, EventArgs e)
        {

            System.Diagnostics.Debug.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        private void addressesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
