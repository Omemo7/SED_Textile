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
    public partial class frmFactories : Form
    {
        
        public frmFactories()
        {
            InitializeComponent();
        }
       
        private void frmFactories_Load(object sender, EventArgs e)
        {
            DataTable dt=clsFactory.GetAllFactories();
            dt.Columns["FactoryID"].ColumnName = "ID";
            ctrMyDataGridView1.DataSource = dt;
        }
    }
}
