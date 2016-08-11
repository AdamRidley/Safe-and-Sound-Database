using System;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
        private bool dataFilled;

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
            dataFilled = false;
            this.titlesTableAdapter.Fill(this.safeandsounddb1DataSet.Titles);
            this.customersTableAdapter.Fill(this.safeandsounddb1DataSet.Customers);
            this.servicingTypeTableAdapter.Fill(this.safeandsounddb1DataSet.ServicingType);
            this.addressesTableAdapter.Fill(this.safeandsounddb1DataSet.addresses);
            this.custAddTableAdapter.Fill(this.safeandsounddb1DataSet.CustAdd);
            this.phone_NumbersTableAdapter.Fill(this.safeandsounddb1DataSet.Phone_Numbers);
            dataFilled = true;
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
            FilterPhoneNumbers();
        }

       /* private void PhoneFilter()
        {
            if (customersBindingSource.Current == null) return;
            int CustId;
            string AddrId = null;
            string PFilt = "";
            bool FilterAds = true;
            //List<int> CustAddrIds = new List<int>();
            if (addressesDataGridView.SelectedRows.Count == 0) { FilterAds = false; }
            CustId = ((safeandsounddb1DataSet.CustomersRow)((DataRowView)customersBindingSource.Current).Row).Customer_ID;
            if (FilterAds) { AddrId = addressesDataGridView.SelectedCells[0].OwningRow.Cells[0].Value.ToString(); }
            if (FilterAds & AddrId == null) { FilterAds = false; }
            foreach (DataRowView b in custAddBindingSource.List)
            {
                safeandsounddb1DataSet.CustAddRow a = (safeandsounddb1DataSet.CustAddRow)b.Row;
                if (a.IsCustomer_IDNull() | (FilterAds & a.IsAddress_IDNull())) { continue; }
                if (a.Customer_ID == CustId && (!FilterAds || (FilterAds & a.Address_ID.ToString() == AddrId)))
                {
                    //      CustAddrIds.Add(a.CustAdd_ID);
                    PFilt += ", " + a.CustAdd_ID;
                }
            }
            //
            //if (CustAddrIds.Count > 0)
            //{
            //    foreach(safeandsounddb1DataSet.Phone_NumbersRow b in safeandsounddb1DataSet.Phone_Numbers)
            //    {
            //        if (b.RowState!=DataRowState.Deleted)
            //        {

            //        }
            //    }
            //}
            
            PFilt = PFilt.Substring(Math.Min(PFilt.Length, 2));
            PFilt = (PFilt == "") ? "[CustAdd ID] = Null" : "[CustAdd ID] in (" + PFilt + ")";
            phone_NumbersBindingSource.Filter = PFilt;
        }
        */
        private void FilterAddresses()
        {
            if (customersBindingSource.Current == null) return;
            int custId;
            string adFilt = "";

            custId = ((safeandsounddb1DataSet.CustomersRow)((DataRowView)customersBindingSource.Current).Row).Customer_ID;
            custAddBindingSource.Filter = "[Customer ID] = " + custId.ToString();
            foreach (DataRowView b in custAddBindingSource.List)
            {
                safeandsounddb1DataSet.CustAddRow a = (safeandsounddb1DataSet.CustAddRow)b.Row;
                if (!a.IsAddress_IDNull() & !a.IsCustomer_IDNull())
                {
                    if (a.Customer_ID == custId)
                    {
                        adFilt += a.Address_ID.ToString() + ", ";
                    }
                }
            }
            adFilt = adFilt.Substring(0, Math.Max(adFilt.Length - 2, 0));
            adFilt = (adFilt == "") ? "[Address ID] = Null" : "[Address ID] in (" + adFilt + ")";
            addressesBindingSource.Filter = adFilt;

        }
        private void addressesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            bool flag = addressesDataGridView.SelectedCells.Count > 0;
            ButNumberAddressAdd.Enabled = flag;
            ButAddressView.Enabled = flag;
            if (dataFilled)
            {
                if (addressesDataGridView.SelectedCells.Count == 0 || addressesDataGridView.SelectedCells[0].ColumnIndex == -1 || addressesDataGridView.SelectedCells[0].RowIndex == -1)
                {
                    custAddBindingSource.Filter = "[Customer ID] = " + ((safeandsounddb1DataSet.CustomersRow)((DataRowView)customersBindingSource.Current).Row).Customer_ID.ToString();
                    //FilterAddresses();
                    //addressesDataGridView.ClearSelection();
                    FilterPhoneNumbers();
                }
                else
                {
                    if (addressesDataGridView.SelectedCells[0].OwningRow.Cells[addressIDDataGridViewTextBoxColumn.Index].Value != null)
                    {

                        custAddBindingSource.Filter = "[Customer ID] = " + ((safeandsounddb1DataSet.CustomersRow)((DataRowView)customersBindingSource.Current).Row).Customer_ID.ToString()
                            + " AND [Address ID] = " + addressesDataGridView.SelectedCells[0].OwningRow.Cells[addressIDDataGridViewTextBoxColumn.Index].Value.ToString();
                    }
                    else
                    {

                        System.Diagnostics.Debug.Print("Addresses row error/n" + addressesDataGridView.RowCount.ToString());
                    }
                    //FilterAddresses();
                    FilterPhoneNumbers();
                }
            }
        }

        private void FilterPhoneNumbers()
        {
            StringBuilder custAddIdStr = new StringBuilder("[CustAdd ID] in (");
            foreach (DataRowView a in custAddBindingSource.List)
            {
                safeandsounddb1DataSet.CustAddRow b = (safeandsounddb1DataSet.CustAddRow)a.Row;

                custAddIdStr.Append(b.CustAdd_ID + ", ");
            }
            if (custAddIdStr.Length > "[CustAdd ID] in (".Length)
            {
                custAddIdStr.Remove(custAddIdStr.Length - 2, 2);
                phone_NumbersBindingSource.Filter = custAddIdStr.ToString() + ")";
            }
            else
            {
                phone_NumbersBindingSource.Filter = "[CustAdd ID] = Null";
            }
            phone_NumbersDataGridView.ClearSelection();
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            safeandsounddb1DataSet.RejectChanges();
            CallingForm.Show();
            this.Dispose();
        }

        private void FormCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                ButCancel_Click(sender, e);
            }
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
            FilterPhoneNumbers();
        }

        private void addressesBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            customersBindingSource.EndEdit();
        }

        private void addressesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (addressesDataGridView.SelectedCells.Count > 0) { ButAddressView_Click(sender, e); }
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
        

        private void ButNumbersViewAll_Click(object sender, EventArgs e)
        {
            addressesDataGridView.ClearSelection();
        }


        private void ButNumberAddressAdd_Click(object sender, EventArgs e)
        {
            if (addressesDataGridView.SelectedCells.Count == 0 || addressesDataGridView.SelectedCells[0].ColumnIndex == -1 || addressesDataGridView.SelectedCells[0].RowIndex == -1) return;
            customersBindingSource.EndEdit();
            addressesBindingSource.EndEdit();
            custAddBindingSource.EndEdit();
            custAddBindingSource.Filter = "[Address ID] = " + addressesDataGridView.SelectedCells[0].OwningRow.Cells[0].Value.ToString() + " AND [Customer ID] = " + ((safeandsounddb1DataSet.CustomersRow)((DataRowView)customersBindingSource.Current).Row).Customer_ID.ToString();
            if (custAddBindingSource.Count == 0)
            {
                MessageBox.Show("Error, CustAdd binding source does not contain the entry");
                return;
            }
            string newNumber = GetNewUniqueNumber();
            if (newNumber == "") return;
            int custAddID = ((safeandsounddb1DataSet.CustAddRow)((DataRowView)custAddBindingSource.Current).Row).CustAdd_ID;
            phone_NumbersBindingSource.AddNew();
            phone_NumbersBindingSource.MoveLast();
            ((safeandsounddb1DataSet.Phone_NumbersRow)((DataRowView)phone_NumbersBindingSource.Current).Row).CustAdd_ID = custAddID;
            ((safeandsounddb1DataSet.Phone_NumbersRow)((DataRowView)phone_NumbersBindingSource.Current).Row).Phone_Number = newNumber;
            phone_NumbersBindingSource.EndEdit();
        }

        private void ButNumberCustomerAdd_Click(object sender, EventArgs e)
        {
            customersBindingSource.EndEdit();
            addressesBindingSource.EndEdit();
            custAddBindingSource.EndEdit();
            custAddBindingSource.Filter = "[Address ID] is NULL AND [Customer ID] = " + ((safeandsounddb1DataSet.CustomersRow)((DataRowView)customersBindingSource.Current).Row).Customer_ID.ToString();
            if (custAddBindingSource.Count == 0)
            {
                custAddBindingSource.Filter = "";
                custAddBindingSource.AddNew();
                custAddBindingSource.MoveLast();
                ((safeandsounddb1DataSet.CustAddRow)((DataRowView)custAddBindingSource.Current).Row).Customer_ID = ((safeandsounddb1DataSet.CustomersRow)((DataRowView)customersBindingSource.Current).Row).Customer_ID;
                custAddBindingSource.EndEdit();
            }
            custAddBindingSource.Filter = "[Address ID] is NULL AND [Customer ID] = " + ((safeandsounddb1DataSet.CustomersRow)((DataRowView)customersBindingSource.Current).Row).Customer_ID.ToString();
            if (custAddBindingSource.Count == 0)
            {
                MessageBox.Show("Error, CustAdd binding source does not contain the entry, failed to add correctly!");
                return;
            }
            string newNumber = GetNewUniqueNumber();
            if (newNumber == "") return;
            int custAddID = ((safeandsounddb1DataSet.CustAddRow)((DataRowView)custAddBindingSource.Current).Row).CustAdd_ID;
            phone_NumbersBindingSource.AddNew();
            phone_NumbersBindingSource.MoveLast();
            ((safeandsounddb1DataSet.Phone_NumbersRow)((DataRowView)phone_NumbersBindingSource.Current).Row).CustAdd_ID = custAddID;
            ((safeandsounddb1DataSet.Phone_NumbersRow)((DataRowView)phone_NumbersBindingSource.Current).Row).Phone_Number = newNumber;
            phone_NumbersBindingSource.EndEdit();

        }
        private string GetNewUniqueNumber()
        {
            string newNumber = "";
            string defVal = "";
            bool validNumber = false;
            while (!validNumber)
            {
                newNumber = Interaction.InputBox("Enter telephone number to add", "Enter telephone number", defVal);
                if (newNumber == "")
                {
                    validNumber = true;
                    continue;
                }
                newNumber = Program.GetDigits(newNumber);

                if (!(newNumber.Length == 10 || newNumber.Length == 11))
                {
                    MessageBox.Show("Invalid telephone number length", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    defVal = newNumber;
                    continue;
                }
                bool foundDuplicate = false;
                safeandsounddb1DataSet.Phone_NumbersRow foundRow = null;
                foreach (safeandsounddb1DataSet.Phone_NumbersRow row in safeandsounddb1DataSet.Phone_Numbers.Rows)
                {
                    if (row.Phone_Number == newNumber)
                    {
                        foundDuplicate = true;
                        foundRow = row;
                        break;
                    }
                }
                if (foundDuplicate)
                {
                    BindingSource tempAddressBindingSource = new BindingSource(safeandsounddb1DataSet, safeandsounddb1DataSet.addresses.ToString());
                    BindingSource tempCustomerBindingSource = new BindingSource(safeandsounddb1DataSet, safeandsounddb1DataSet.Customers.ToString());
                    BindingSource tempCustAddBindingSource = new BindingSource(safeandsounddb1DataSet, safeandsounddb1DataSet.CustAdd.ToString());
                    tempCustAddBindingSource.Filter = "[CustAdd ID] = " + foundRow.CustAdd_ID.ToString();

                    //Customer String
                    string strCustomer = GenerateCustomerString(tempCustomerBindingSource, tempCustAddBindingSource);

                    //Address String
                    string strAddress = GenerateAddressString(tempAddressBindingSource, tempCustAddBindingSource);
                    DialogResult resp = MessageBox.Show("Phone number already is use for: \n" + strCustomer + "\n" + strAddress + "\nPlease enter a new number.", "Phone number already in use", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (resp == DialogResult.Retry)
                    {
                        defVal = newNumber;
                        continue;
                    }
                    else
                    {
                        newNumber = "";
                        continue;
                    }
                }
                else
                {
                    validNumber = true;
                }
            }

            return newNumber;
        }

        private static String GenerateAddressString(BindingSource tempAddressBindingSource, BindingSource tempCustAddBindingSource)
        {
            StringBuilder strAddress = new StringBuilder("");
            if (!((safeandsounddb1DataSet.CustAddRow)((DataRowView)tempCustAddBindingSource.List[0]).Row).IsAddress_IDNull())
            {
                int tempAddressID = ((safeandsounddb1DataSet.CustAddRow)((DataRowView)tempCustAddBindingSource.List[0]).Row).Address_ID;
                tempAddressBindingSource.Filter = "[Address ID] = " + tempAddressID;
                safeandsounddb1DataSet.addressesRow address = (safeandsounddb1DataSet.addressesRow)((DataRowView)tempAddressBindingSource.List[0]).Row;

                if (!address.IsAddress_Line_1Null() && address.Address_Line_1 != "") strAddress.Append(address.Address_Line_1 + ", ");
                if (!address.IsAddress_Line_2Null() && address.Address_Line_2 != "") strAddress.Append(address.Address_Line_2 + ", ");
                if (!address.IsAddress_Line_3Null() && address.Address_Line_3 != "") strAddress.Append(address.Address_Line_3 + ", ");
                if (!address.IsTownNull() && address.Town != "") strAddress.Append(address.Town + ", ");
                if (!address.IsPost_CodeNull() && address.Post_Code != "") strAddress.Append(address.Post_Code + ", ");
                if (strAddress.Length > 2) strAddress = strAddress.Remove(strAddress.Length - 2, 2);
            }

            return strAddress.ToString();
        }

        private static string GenerateCustomerString(BindingSource tempCustomerBindingSource, BindingSource tempCustAddBindingSource)
        {
            string strCustomer;
            if (!((safeandsounddb1DataSet.CustAddRow)((DataRowView)tempCustAddBindingSource.List[0]).Row).IsCustomer_IDNull())
            {
                int tempCustomerID = ((safeandsounddb1DataSet.CustAddRow)((DataRowView)tempCustAddBindingSource.List[0]).Row).Customer_ID;
                tempCustomerBindingSource.Filter = "[Customer ID] = " + tempCustomerID;
                safeandsounddb1DataSet.CustomersRow customer = (safeandsounddb1DataSet.CustomersRow)((DataRowView)tempCustomerBindingSource.List[0]).Row;
                strCustomer = (customer.IsFirst_NameNull() ? "" : customer.First_Name + " ") + (customer.IsLast_NameNull() ? "" : customer.Last_Name);
                strCustomer = strCustomer.Trim();
            }
            else
            {
                strCustomer = "";
            }

            return strCustomer;
        }

    }
}
