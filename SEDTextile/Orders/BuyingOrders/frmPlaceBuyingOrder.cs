using SEDTextileBusiness;
using SEDTextileDTOs;
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
    public partial class frmPlaceBuyingOrder : Form
    {
        public frmPlaceBuyingOrder()
        {
            InitializeComponent();
            ctrMyDataGridView1.OnRowStateChanged += CtrMyDataGridView1_OnRowStateChanged;
            ctrMyDataGridView1.DataSource = null;

        }

        private void CtrMyDataGridView1_OnRowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            bool IsNullDataSource = ctrMyDataGridView1.DataSource == null;

            cbFactory.Enabled = IsNullDataSource;
            
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            frmChooseItemsToBuy frm;
            frm = new frmChooseItemsToBuy(cbFactory.getSelectedItemID(), ctrMyDataGridView1.DataSource);

            frm.onSaveItems += frmChooseItemsToBuy_SaveItems;
            frm.ShowDialog();
        }

        private void frmChooseItemsToBuy_SaveItems(object sender, SaveItemsEventArgs e)
        {
            ctrMyDataGridView1.DataSource = e.ChosenItemsSummary;
            nudTotalPrice.Value = e.TotalPrice;
        }

       

        private void frmPlaceBuyingOrder_Load(object sender, EventArgs e)
        {
            cbFactory.DataSource = clsFactory.FactoryIDWithFactoryNamePairs();
        }
        void ResetOrder()
        {
            ctrMyDataGridView1.DataSource = null;
            nudTotalPrice.Value = 0;

           
            cbFactory.Enabled=true;
            cbFactory.Reset();
        }
        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to reset order??","Confirm",MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            ResetOrder();

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to place order??", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            //todo validation


            AddBuyingOrderDTO dto = new AddBuyingOrderDTO
            {
                FactoryID = cbFactory.getSelectedItemID(),
                PaidPrice = (float)nudPaidPrice.Value,
                ItemsToBeAdded = ctrMyDataGridView1.DataSource.DefaultView.ToTable(true,"Item ID","Quantity"),
                EstimatedArrivalDate = dtpEstimatedArrivalDate.Value,
                
            };
            int orderId=clsBuyingOrder.AddNewBuyingOrder(dto);
            if (orderId!=-1)
            {
                MessageBox.Show("Order placed successfully!");
                ResetOrder();
            }
            else
            {
                MessageBox.Show("Order could not be placed!");
            }

        }

        private void nudTotalPrice_ValueChanged(object sender, EventArgs e)
        { 
            nudPaidPrice.Value = nudTotalPrice.Value;
        }
    }
}
