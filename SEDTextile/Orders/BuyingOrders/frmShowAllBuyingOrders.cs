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

namespace SEDTextile.Orders.BuyingOrders
{
    public partial class frmShowAllBuyingOrders : Form
    {
        int ChosenItemForContextMenuOrderID=-1;
        public frmShowAllBuyingOrders()
        {
            InitializeComponent();
            ctrMyDataGridView1.OnContextMenuOpening += OnContextMenuOpeningHandler;
        }

        private void OnContextMenuOpeningHandler(int OrderID)
        {
            ChosenItemForContextMenuOrderID = OrderID;
            SetContextMenuForDataGrid();
        }
        void LoadData()
        {
            ctrMyDataGridView1.DataSource = clsBuyingOrder.AllBuyingOrders();
        }
        private void frmShowAllBuyingOrders_Load(object sender, EventArgs e)
        {
            LoadData();
             SetContextMenuForDataGrid();
           
        }

        void SetContextMenuForDataGrid()
        {
            ToolStripMenuItem orderStateMenu = new ToolStripMenuItem("Order State");
            if(ChosenItemForContextMenuOrderID!=-1)
                orderStateMenu.Enabled=clsBuyingOrder.GetOrderState(ChosenItemForContextMenuOrderID)==clsBuyingOrder.enOrderState.InProgress;
            orderStateMenu.DropDownItems.Add(new ToolStripMenuItem("Completed",null, OnOrderStateCompletedEventHandler));
            orderStateMenu.DropDownItems.Add(new ToolStripMenuItem("Cancelled",null,OnOrderStateCancelledEventHandler));

            ToolStripMenuItem PayFullPriceItem = new ToolStripMenuItem("Pay full price", null, OnPayFullPriceEventHandler);
            //todo PayFullPriceItem.Enabled=
            ToolStripItem[] MenuItems = new ToolStripItem[]
           {
               orderStateMenu,
                new ToolStripMenuItem("Details"),
                PayFullPriceItem,
                
           };
            ctrMyDataGridView1.setContextMenuStrip(MenuItems);
        }


        private void OnOrderStateCancelledEventHandler(object sender, EventArgs e)
        {
            clsBuyingOrder.CancelOrder(ChosenItemForContextMenuOrderID);
            LoadData();
        }

        private void OnPayFullPriceEventHandler(object sender, EventArgs e)
        {
            clsBuyingOrder.PayFullPrice(ChosenItemForContextMenuOrderID);
            LoadData();
        }

        private void OnOrderStateCompletedEventHandler(object sender, EventArgs e)
        {
            clsBuyingOrder.SetBuyingOrderStateCompletedWithOrWithoutDebtForOrder(ChosenItemForContextMenuOrderID);
            LoadData();
        }

        private void ctrMyDataGridView1_Load(object sender, EventArgs e)
        {

        }
    }
}
