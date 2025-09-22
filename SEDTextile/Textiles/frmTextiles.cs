using SEDTextile.Textiles;
using SEDTextileBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEDTextile
{
    public partial class frmTextiles : Form
    {
        int IDOfSelectedRowInContextMenu;
        public frmTextiles()
        {
            InitializeComponent();
            ctrMyDataGridView1.OnContextMenuItemSelected +=
                (ID) => { IDOfSelectedRowInContextMenu = ID; };
        }
       
        
        void OpenStorageForm(int TextileID)
        {
            frmStorageInfoForTextile frm=new frmStorageInfoForTextile(TextileID);
            frm.ShowDialog();
        }

        private void frmTextiles_Load(object sender, EventArgs e)
        {
            DataTable dt = clsTextile.TextileTable();


            dt.Columns["FabricType"].ColumnName = "Fabric Type";
            dt.Columns["FactoryName"].ColumnName = "Factory";
            dt.Columns["BuyingPrice"].ColumnName = "Buying Price";
            dt.Columns["SellingPrice"].ColumnName = "Selling Price";

            ctrMyDataGridView1.DataSource=dt;

            ToolStripItem[] MenuItems = new ToolStripItem[]
            {
                new ToolStripMenuItem("Storage",null,OpenStorageEventHandler),
                new ToolStripMenuItem("Add"),
                new ToolStripMenuItem("Update"),
                new ToolStripMenuItem("Delete"),
                new ToolStripMenuItem("Variants")
            };


            ctrMyDataGridView1.setContextMenuStrip(MenuItems);
           
        }
        
        private void OpenStorageEventHandler(object sender, EventArgs e)
        {
            OpenStorageForm(IDOfSelectedRowInContextMenu);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewTextile frm = new frmAddNewTextile();
            frm.ShowDialog();
        }
    }
}
