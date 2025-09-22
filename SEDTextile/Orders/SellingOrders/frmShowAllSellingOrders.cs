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

namespace SEDTextile.Orders.SellingOrders
{
    public partial class frmShowAllSellingOrders : Form
    {
        public frmShowAllSellingOrders()
        {
            InitializeComponent();
            
        }

        private void frmShowAllSellingOrders_Load(object sender, EventArgs e)
        {
            ctrMyDataGridView1.DataSource = clsSellingOrder.AllSellingOrders();
        }

      
        private void ctrMyDataGridView1_Load(object sender, EventArgs e)
        {

        }
    }
}
