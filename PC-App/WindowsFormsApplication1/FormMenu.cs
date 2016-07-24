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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void ButCustomerAdd_Click(object sender, EventArgs e)
        {
            FormCustomer FormAddCust = new FormCustomer(0, this);
            this.Hide();
            FormAddCust.Show();
        }

        private void ButCustomerEdit_Click(object sender, EventArgs e)
        {
            Search_By f = new Search_By(1);
            DialogResult resp = f.ShowDialog();
            if (resp!=DialogResult.OK) { return; }
            FormCustomer formCust = new FormCustomer(f.foundId, this);
            formCust.Show();
            f.Dispose();
            this.Hide();

        }

        private void ButAddressAdd_Click(object sender, EventArgs e)
        {
            FormAddresses FormAddAddr = new FormAddresses(0, this);
            this.Hide();
            FormAddAddr.Show();
        }
    }
}
