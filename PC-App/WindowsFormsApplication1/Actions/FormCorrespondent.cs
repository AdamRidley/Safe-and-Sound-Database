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
    public partial class FormCorrespondent : Form
    {
        private Form callingForm;
        private int addressId;
        private int correspondentId;

        public FormCorrespondent()
        {
            InitializeComponent();
        }
        public FormCorrespondent(int newAddressId, int newCorrespondentId, Form newCallingForm):this()
        {
            addressId = newAddressId;
            correspondentId = newCorrespondentId;
            callingForm = newCallingForm;
        }
    }
}
