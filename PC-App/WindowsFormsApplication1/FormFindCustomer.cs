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
    public partial class FormFindCustomer : Form
    {
        private int searchFor;
        public int foundId;

        public FormFindCustomer()
        {
            InitializeComponent();
        }
        public FormFindCustomer(int newSearchFor):this()
        {
            searchFor = newSearchFor;
        }

        private void FormFindCustomer_Load(object sender, EventArgs e)
        {
            this.servicingTypeTableAdapter.Fill(this.safeandsounddb1DataSet.ServicingType);
            this.addressesTableAdapter.Fill(this.safeandsounddb1DataSet.addresses);
            this.titlesTableAdapter.Fill(this.safeandsounddb1DataSet.Titles);
            this.customers_Friendly_ViewTableAdapter.Fill(this.safeandsounddb1DataSet.Customers_Friendly_View);
            this.customersTableAdapter.Fill(this.safeandsounddb1DataSet.Customers);
            this.custAddTableAdapter.Fill(this.safeandsounddb1DataSet.CustAdd);
            this.phone_NumbersTableAdapter.Fill(this.safeandsounddb1DataSet.Phone_Numbers);
        }

        private void FilterCustomers()
        {
            StringBuilder str = new StringBuilder();
            if (TitleComboBox.SelectedIndex > -1&&TitleComboBox.Text!="")
            {
                str.Append("[Title] Like '*" + TitleComboBox.Text + "*' AND ");
            }
            if (First_NameTextBox.Text !="")
            {
                str.Append("[First Name] LIKE '*" + First_NameTextBox.Text.Trim()+ "*' AND ");
            }
            if (Last_NameTextBox.Text != "")
            {
                str.Append("[Last Name] LIKE '*" + Last_NameTextBox.Text.Trim() + "*' AND ");
            }
            if (E_Mail_AddressTextBox.Text != "")
            {
                str.Append("[E-Mail Address] LIKE '*" + E_Mail_AddressTextBox.Text.Trim() + "*' AND ");
            }
            if (str.Length > 5)
            {
                str.Remove(str.Length - 5, 5);
            }
            CustomersBindingSource.Filter = str.ToString();
        }

        private void First_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterCustomers();
        }

        private void Last_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterCustomers();
        }

        private void E_Mail_AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterCustomers();
        }

        private void TitleComboBox_TextChanged(object sender, EventArgs e)
        {

            FilterCustomers();
        }
        
        private void CustomersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CustomersDataGridView.SelectedCells.Count==0||CustomersDataGridView.SelectedCells[0].ColumnIndex==-1 ||CustomersDataGridView.SelectedCells[0].RowIndex==-1) { AddressesBindingSource.Filter = "[Address ID] = Null";Phone_NumbersBindingSource.Filter = "[ID] = Null"; ButChooseSetVisibility(); return;}
            custAddBindingSource.Filter = "[Customer ID] = " + CustomersDataGridView.SelectedCells[0].OwningRow.Cells["customerIDDataGridViewTextBoxColumn"].Value.ToString();
            StringBuilder addressIdStr = new StringBuilder("[Address ID] in (" );
            StringBuilder custAddIdStr = new StringBuilder("[CustAdd ID] in (" );
            foreach (DataRowView a in custAddBindingSource.List)
            {
                safeandsounddb1DataSet.CustAddRow b = (safeandsounddb1DataSet.CustAddRow)a.Row;
                if (!b.IsAddress_IDNull())
                {
                    addressIdStr.Append(b.Address_ID + ", ");
                }
                custAddIdStr.Append(b.CustAdd_ID+ ", ");
            }
            if (addressIdStr.Length> "[Address ID] in (".Length)
            {
                addressIdStr.Remove(addressIdStr.Length - 2, 2);
                AddressesBindingSource.Filter = addressIdStr.ToString() + ")";
            }
            else
            {
                AddressesBindingSource.Filter = "[Address ID] = Null";
            }
            if (custAddIdStr.Length > "[CustAdd ID] in (".Length)
            {
                custAddIdStr.Remove(custAddIdStr.Length - 2, 2);
                Phone_NumbersBindingSource.Filter = custAddIdStr.ToString() + ")";
            }
            else
            {
                Phone_NumbersBindingSource.Filter = "[CustAdd ID] = Null";
            }
            ButChooseSetVisibility();

        }

        private void ButChooseSetVisibility()
        {
            //searchFor 1 - customer, 2 - address
            if (searchFor == 1 && CustomersDataGridView.SelectedCells.Count > 0 && !(CustomersDataGridView.SelectedCells[0].ColumnIndex == -1 || CustomersDataGridView.SelectedCells[0].RowIndex == -1))
            {
                ButChoose.Enabled = true;
                return;
            }
            else if (searchFor==2&&AddressesDataGridView.SelectedCells.Count>0 && !(AddressesDataGridView.SelectedCells[0].ColumnIndex == -1 || AddressesDataGridView.SelectedCells[0].RowIndex == -1))
            {
                ButChoose.Enabled = true;
                return;
            }
            else
            ButChoose.Enabled = false;
        }

        private void ButChoose_Click(object sender, EventArgs e)
        {
            switch (searchFor)
            {
                case 1:
                    this.foundId = (int)CustomersDataGridView.SelectedCells[0].OwningRow.Cells["customerIDDataGridViewTextBoxColumn"].Value;
                    this.DialogResult = DialogResult.OK;
                    return;
                case 2:
                    this.foundId = (int)AddressesDataGridView.SelectedCells[0].OwningRow.Cells["addressIDDataGridViewTextBoxColumn"].Value;
                    this.DialogResult = DialogResult.OK;
                    return;
            }
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormFindCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                ButCancel_Click(sender, e);
            }
        }
    }
}
