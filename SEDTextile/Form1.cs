using SEDTextile.Orders.BuyingOrders;
using SEDTextile.Orders.SellingOrders;
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
    public partial class frmNavigation : Form
    {
        
        public frmNavigation()
        {
            InitializeComponent();
            
        }

       
      

        private void textilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTextiles frm = new frmTextiles();
            frm.ShowDialog();
        }

        private void frmNavigation_Load(object sender, EventArgs e)
        {

        }
        public void ShowFormInPanel(Form childForm)
        {
           
          
        }
        private void factoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactories frm = new frmFactories();
            frm.ShowDialog();
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStores frm = new frmStores();
            frm.ShowDialog();
        }

       

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceSellingOrder();  
        }
        void PlaceSellingOrder()
        {
            frmPlaceSellingOrder frm = new frmPlaceSellingOrder();
            frm.ShowDialog();
        }
        void ShowAllSellingOrders()
        {
            frmShowAllSellingOrders frm = new frmShowAllSellingOrders();
            frm.ShowDialog();
        }

        private void allOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllSellingOrders();
        }
       

        private void btnPlaceSellingOrder_Click(object sender, EventArgs e)
        {
            PlaceSellingOrder();
        }

        private void btnShowAllSellingOrders_Click(object sender, EventArgs e)
        {
            ShowAllSellingOrders();
        }

        void PlaceBuyingOrder()
        {
            frmPlaceBuyingOrder frm = new frmPlaceBuyingOrder();
            frm.ShowDialog();
        }

        private void buyingOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceBuyingOrder();
        }

        private void btnPlaceBuyingOrder_Click(object sender, EventArgs e)
        {
            PlaceBuyingOrder();
        }

        void ShowAllBuyingOrders()
        {
            frmShowAllBuyingOrders frm=new frmShowAllBuyingOrders();
            frm.ShowDialog();
        }
        private void btnShowBuyingOrders_Click(object sender, EventArgs e)
        {
            ShowAllBuyingOrders();
        }
    }
}
