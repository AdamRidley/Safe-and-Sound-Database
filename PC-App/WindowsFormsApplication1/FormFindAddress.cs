using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormFindAddress : Form
    {
        private int searchFor;
        public int foundId;

        public FormFindAddress()
        {
            InitializeComponent();
        }
        public FormFindAddress(int newSearchFor):this()
        {
            searchFor = newSearchFor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.addressesTableAdapter.Fill(this.safeandsounddb1DataSet.addresses);
            this.titlesTableAdapter.Fill(this.safeandsounddb1DataSet.Titles);
            this.customersTableAdapter.Fill(this.safeandsounddb1DataSet.Customers);
            this.custAddTableAdapter.Fill(this.safeandsounddb1DataSet.CustAdd);
            this.phone_NumbersTableAdapter.Fill(this.safeandsounddb1DataSet.Phone_Numbers);
        }

        private void Address_Line_1TextBox_TextChanged(object sender, EventArgs e)
        {
            FilterAddresses();
        }

        private void Address_Line_2TextBox_TextChanged(object sender, EventArgs e)
        {
            FilterAddresses();
        }

        private void Address_Line_3TextBox_TextChanged(object sender, EventArgs e)
        {
            FilterAddresses();
        }

        private void TownTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterAddresses();
        }

        private void Post_CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterAddresses();
        }

        private void NotesTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterAddresses();
        }
        private void FilterAddresses()
        {
            StringBuilder str = new StringBuilder();
            if ( Address_Line_1TextBox.Text != "")
            {
                str.Append("[Address Line 1] Like '*" + Address_Line_1TextBox.Text + "*' AND ");
            }
            if (Address_Line_2TextBox.Text != "")
            {
                str.Append("[Address Line 2] LIKE '*" + Address_Line_2TextBox.Text.Trim() + "*' AND ");
            }
            if (Address_Line_3TextBox.Text != "")
            {
                str.Append("[Address Line 3] LIKE '*" + Address_Line_3TextBox.Text.Trim() + "*' AND ");
            }
            if (TownTextBox.Text != "")
            {
                str.Append("[Town] LIKE '*" + TownTextBox.Text.Trim() + "*' AND ");
            }
            if (Post_CodeTextBox.Text != "")
            {
                string postCode = Post_CodeTextBox.Text.Trim();
                postCode = postCode.Replace(" ", "");
                Regex regex = new Regex("^([a-zA-Z]{1,2}\\d{1,2})(\\d[a-zA-Z]{1,2})$");
                Match match = regex.Match(postCode);
                if (match.Success)
                {
                    str.Append("[Post Code] LIKE '*" + match.Groups[0].Value+" "+match.Groups[1].Value + "*' AND ");
                }
                else if (postCode.Length>4)
                {
                    str.Append("[Post Code] LIKE '*" + postCode.Insert(4," ") + "*' AND ");
                }
                else
                {
                    str.Append("[Post Code] LIKE '*" + Post_CodeTextBox.Text.Trim() + "*' AND ");
                }                
            }
            if (NotesTextBox.Text != "")
            {
                    str.Append("[Notes] LIKE '*" + NotesTextBox.Text.Trim() + "*' AND ");
            }
            if (str.Length > 5)
            {
                str.Remove(str.Length - 5, 5);
            }
            addressesBindingSource.Filter = str.ToString();
        }

        private void AddressesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ButChooseSetVisibility();
            if (AddressesDataGridView.SelectedCells.Count == 0 || AddressesDataGridView.SelectedCells[0].ColumnIndex == -1 || AddressesDataGridView.SelectedCells[0].RowIndex == -1) { customersBindingSource.Filter = "[Customer ID] = Null";phone_NumbersBindingSource.Filter="[ID] = Null" ; return; }
            CustAddBindingSource.Filter = "[Address ID] = " + AddressesDataGridView.SelectedCells[0].OwningRow.Cells["addressIDDataGridViewTextBoxColumn"].Value.ToString();
            StringBuilder str = new StringBuilder("[Customer ID] in (");
            StringBuilder custAddIdStr = new StringBuilder("[CustAdd ID] in (");
            foreach (DataRowView a in CustAddBindingSource.List)
            {
                safeandsounddb1DataSet.CustAddRow b = (safeandsounddb1DataSet.CustAddRow)a.Row;
                if (!b.IsCustomer_IDNull())
                {
                    str.Append(((safeandsounddb1DataSet.CustAddRow)a.Row).Customer_ID + ", ");
                }
                custAddIdStr.Append(b.CustAdd_ID + ", ");
            }
            if (str.Length > "[Customer ID] in (".Length)
            {
                str.Remove(str.Length - 2, 2);
                customersBindingSource.Filter = str.ToString() + ")";
            }
            else
            {
                customersBindingSource.Filter = "[Customer ID] = Null";
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

        }

        private void ButChooseSetVisibility()
        {      
            //searchFor 1 - customer, 2 - address
            if (searchFor == 1 && CustomersDataGridView.SelectedCells.Count > 0 && !(CustomersDataGridView.SelectedCells[0].ColumnIndex == -1 || CustomersDataGridView.SelectedCells[0].RowIndex == -1))
            {
                ButChoose.Enabled = true;
                return;
            }
            else if (searchFor == 2 && AddressesDataGridView.SelectedCells.Count > 0 && !(AddressesDataGridView.SelectedCells[0].ColumnIndex == -1 || AddressesDataGridView.SelectedCells[0].RowIndex == -1))
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
    }
}
