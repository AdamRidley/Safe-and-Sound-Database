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
            this.addressesTableAdapter.Fill(this.safeandsounddb1DataSet.addresses);
            this.titlesTableAdapter.Fill(this.safeandsounddb1DataSet.Titles);
            this.customers_Friendly_ViewTableAdapter.Fill(this.safeandsounddb1DataSet.Customers_Friendly_View);
            this.customersTableAdapter.Fill(this.safeandsounddb1DataSet.Customers);
            this.custAddTableAdapter.Fill(this.safeandsounddb1DataSet.CustAdd);
            this.phone_NumbersTableAdapter.Fill(this.safeandsounddb1DataSet.Phone_Numbers);
        }

        private void TitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // FilterCustomers();
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
    }
}
