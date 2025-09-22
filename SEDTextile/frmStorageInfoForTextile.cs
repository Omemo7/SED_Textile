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
    public partial class frmStorageInfoForTextile : Form
    {
        clsTextile Textile=new clsTextile();
        public frmStorageInfoForTextile(int TextileID)
        {
            InitializeComponent();
            Textile = clsTextile.Find(TextileID);
            
        }

        private void frmStorage_Load(object sender, EventArgs e)
        {
           lblAlias.Text=Textile.Alias;
            lblCode.Text=Textile.Code;
            lblQuantity.Text = Textile.TotalQuantity().ToString();
            
            ctrMyDataGridView1.DataSource =Textile.StorageInfoForAllVariantsForThisTextile();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
