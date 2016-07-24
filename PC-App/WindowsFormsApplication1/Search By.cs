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
    public partial class Search_By : Form
    {
        public Search_By()
        {
            InitializeComponent();
        }
        int searchfor;
        public int foundId;

        public  Search_By(int newsearchfor):this()
        {
            searchfor = newsearchfor;
        }
        private void ButByCustomer_Click(object sender, EventArgs e)
        {
            FormFindCustomer f = new FormFindCustomer(searchfor);
            DialogResult resp = f.ShowDialog();
            if (resp !=DialogResult.OK) { return; }
            foundId = f.foundId;
            f.Dispose();
            DialogResult = DialogResult.OK;
        }

        private void ButByAddress_Click(object sender, EventArgs e)
        {
            FormFindAddress f = new FormFindAddress(searchfor);
            DialogResult resp = f.ShowDialog();
            if (resp != DialogResult.OK) { return; }
            foundId = f.foundId;
            f.Dispose();
            DialogResult = DialogResult.OK;
        }

        private void ButCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Search_By_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void Search_By_Load(object sender, EventArgs e)
        {

        }
    }
}
