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
    public partial class frmStores : Form
    {
        public frmStores()
        {
            InitializeComponent();
        }

        private void frmStores_Load(object sender, EventArgs e)
        {
            DataTable dt = clsStore.GetAllStores();
            dt.Columns["StoreID"].ColumnName = "ID";
            ctrMyDataGridView1.DataSource = dt;
        }
    }
}
