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
    public partial class FormFindAddress : Form
    {
        public FormFindAddress()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'safeandsounddb1DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.safeandsounddb1DataSet.Customers);
            // TODO: This line of code loads data into the 'safeandsounddb1DataSet.Phone_Numbers' table. You can move, or remove it, as needed.
            this.phone_NumbersTableAdapter.Fill(this.safeandsounddb1DataSet.Phone_Numbers);
            // TODO: This line of code loads data into the 'safeandsounddb1DataSet.addresses' table. You can move, or remove it, as needed.
            this.addressesTableAdapter.Fill(this.safeandsounddb1DataSet.addresses);

        }
    }
}
