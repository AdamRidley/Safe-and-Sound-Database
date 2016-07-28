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
    public partial class FormAddress : Form
    {
        public FormAddress()
        {
            InitializeComponent();
        }

        private int passedId;
        private Form callingForm;

        public FormAddress(Int32 id, Form newCallingForm):this()
        { 
            passedId = id;
            callingForm = newCallingForm;
        }

        /*private void addressesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addressesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.safeandsounddb1DataSet);

        }*/
        private void getData()
        {
            
            this.zone_ListTableAdapter.Fill(this.safeandsounddb1DataSet.Zone_List);            
            this.zone_TypesTableAdapter.Fill(this.safeandsounddb1DataSet.Zone_Types);            
            this.productTableAdapter.Fill(this.safeandsounddb1DataSet.Product);
            this.addressesTableAdapter.Fill(this.safeandsounddb1DataSet.addresses);
            this.zone_MappingsTableAdapter.Fill(this.safeandsounddb1DataSet.Zone_Mappings);            
            this.prod_ModelTableAdapter.Fill(this.safeandsounddb1DataSet.Prod_Model);            
            this.prod_MakeTableAdapter.Fill(this.safeandsounddb1DataSet.Prod_Make);            
            this.prod_TypeTableAdapter.Fill(this.safeandsounddb1DataSet.Prod_Type);            
            this.installation_Products_LinkTableAdapter.Fill(this.safeandsounddb1DataSet.Address_Product_Link);
        }
        private void FormAddress_Load(object sender, EventArgs e)
        {
            getData();
            if (passedId == 0)
            {
                addressesBindingSource.AddNew();
                addressesBindingSource.MoveLast();
            }
            else
            {
                addressesBindingSource.Position = addressesBindingSource.Find("Address ID", passedId);
            }

        }

        private void installation_Products_LinkDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void installation_Products_LinkDataGridView__CurrentCellDirtyStateChanged(object sender,EventArgs e)
        {
            if (installation_Products_LinkDataGridView.IsCurrentCellDirty)
            {
                installation_Products_LinkDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void installation_Products_LinkDataGridView_Enter(object sender, EventArgs e)
        {
            addressesBindingSource.EndEdit();
        }

        private void installation_Products_LinkDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UpdateProduct(Int32 r)
        {
            //MessageBox.Show(installation_Products_LinkDataGridView.CurrentRow.Cells["Type"].Value.ToString());
            object typeId = installation_Products_LinkDataGridView.Rows[r].Cells["Type"].Value;
            object makeId = installation_Products_LinkDataGridView.Rows[r].Cells["Make"].Value;
            object modelId = installation_Products_LinkDataGridView.Rows[r].Cells["Model"].Value;
            if (typeId==null||makeId==null||modelId==null)
            {
                installation_Products_LinkDataGridView.Rows[r].Cells["productDataGridViewTextBoxColumn"].Value = DBNull.Value;
                return;
            }
            productBindingSource.Filter="[Make] = "+makeId.ToString()+" and [Model] = "+modelId.ToString()+" and [Type] = "+typeId.ToString();
            if ( productBindingSource.Count== 1)
            {
                installation_Products_LinkDataGridView.Rows[r].Cells["productDataGridViewTextBoxColumn"].Value = ((safeandsounddb1DataSet.ProductRow)((DataRowView)productBindingSource.List[0]).Row).ProdId;
                productBindingSource.RemoveFilter();
            }
            else
            {
                productBindingSource.RemoveFilter();
                productBindingSource.AddNew();
                productBindingSource.MoveLast();
                safeandsounddb1DataSet.ProductRow currentrow = (safeandsounddb1DataSet.ProductRow)((DataRowView)productBindingSource.Current).Row;
                currentrow.Type = (int)typeId;
                currentrow.Make = (int)makeId;
                currentrow.Model = (int)modelId;
                productBindingSource.EndEdit();
                installation_Products_LinkDataGridView.Rows[r].Cells["productDataGridViewTextBoxColumn"].Value = currentrow.ProdId;
            }
        }

        private void installation_Products_LinkDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow cur = installation_Products_LinkDataGridView.Rows[e.RowIndex];
            string msg="";
            if (cur.Cells[6].Value == DBNull.Value)
            {
                msg = "You must enter a value for Quantity";
            }
            if (cur.Cells[2].Value == DBNull.Value)
            {
                msg = "You must select a Type, Make and Model";
            }
            if (msg != "")
            {
                MessageBox.Show(msg);
                e.Cancel=true;
                return;
            }
                installation_Products_LinkBindingSource.EndEdit();
        }

        private void zone_MappingsDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            zoneMappingsBindingSource.EndEdit();
            foreach (DataGridViewCell c in zone_MappingsDataGridView.Rows[e.RowIndex].Cells)
            {
              //  flag=flag&c.
            }
        }

        private void butcancel_Click(object sender, EventArgs e)
        {
            safeandsounddb1DataSet.RejectChanges();
            callingForm.Show();
            this.Dispose();
        }

        private void butsaveexit_Click(object sender, EventArgs e)
        {
            this.Validate();
            installation_Products_LinkBindingSource.EndEdit();
            productBindingSource.EndEdit();
            zoneMappingsBindingSource.EndEdit();
            addressesBindingSource.EndEdit();
            if (safeandsounddb1DataSet.HasChanges())
            {
                tableAdapterManager.UpdateAll(safeandsounddb1DataSet);
            }
            safeandsounddb1DataSet.AcceptChanges();
            callingForm.Show();
            this.Dispose();
        }

        private void installation_Products_LinkDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5) { UpdateProduct(e.RowIndex); }
        }

        private void zone_MappingsDataGridView_Enter(object sender, EventArgs e)
        {
            addressesBindingSource.EndEdit();
        }

        private void installation_Products_LinkBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            foreach (DataGridViewRow row in installation_Products_LinkDataGridView.Rows)
            {
                if (row.Cells["productDataGridViewTextBoxColumn"].Value==null) { continue; }
                productBindingSource.Filter = "[ProdId] = " + row.Cells["productDataGridViewTextBoxColumn"].Value.ToString();
                row.Cells["Type"].Value = ((safeandsounddb1DataSet.ProductRow)((DataRowView)productBindingSource.List[0]).Row).Type;
                row.Cells["Make"].Value = ((safeandsounddb1DataSet.ProductRow)((DataRowView)productBindingSource.List[0]).Row).Make; 
                row.Cells["Model"].Value = ((safeandsounddb1DataSet.ProductRow)((DataRowView)productBindingSource.List[0]).Row).Model;


            }
        }

        private void ButAddService_Click(object sender, EventArgs e)
        {

            FormService FormAddServ = new FormService(((safeandsounddb1DataSet.addressesRow)((DataRowView)addressesBindingSource.Current).Row).Address_ID,0,this);
            this.Hide();
            FormAddServ.Show();
        }

        private void ButViewService_Click(object sender, EventArgs e)
        {

           // FormService FormViewServ = new FormService(((safeandsounddb1DataSet.addressesRow)((DataRowView)addressesBindingSource.Current).Row).Address_ID, (int)servicesDataGridView.SelectedCells[0].OwningRow.Cells["dataGridViewTextBoxColumn1"].Value, this);
            this.Hide();
            //FormViewServ.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
