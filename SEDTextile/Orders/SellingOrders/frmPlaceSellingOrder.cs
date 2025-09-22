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

namespace SEDTextile.Orders.SellingOrders
{
    public partial class frmPlaceSellingOrder : Form
    {

       
        public frmPlaceSellingOrder()
        {
            InitializeComponent();
            ApplydtpEstimatedArrivalDateSettings();
           
        }

        void ApplydtpEstimatedArrivalDateSettings()
        {
            dtpEstimatedArrivalDate.MinDate = DateTime.Now;
            dtpEstimatedArrivalDate.MaxDate = DateTime.Today.AddMonths(6);
            dtpEstimatedArrivalDate.Value = DateTime.Today.AddDays(5);
        }

        private void btnChoose_Click_1(object sender, EventArgs e)
        {
            frmChooseItemsToSell frm;
            frm = new frmChooseItemsToSell(ctrMyDataGridView1.DataSource);

            frm.onSaveItems +=OnSaveItemsEventHandler ;
            frm.ShowDialog();
        }

        private void OnSaveItemsEventHandler(object sender, SaveItemsEventArgs e)
        {
        
            ctrMyDataGridView1.DataSource = e.ChosenItemsSummary;
            nudTotalPrice.Value = e.TotalPrice;
        }

       

        private void frmPlaceSellingOrder_Load(object sender, EventArgs e)
        {
           
            mycbStores.DataSource = clsStore.StoreIDWithStoreNamePairs();
            mycbDeliveryMethod.DataSource = clsDeliveryMethod.IDWithNamePairs();
        }

      

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to place this order?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;


            //todo, validation
            AddSellingOrderDTO dto = new AddSellingOrderDTO
            {
                EstimatedArrivalDate = dtpEstimatedArrivalDate.Value,
                PaidPrice=(float)nudPaidPrice.Value,
                DiscountPrice=(float)nudDiscountPrice.Value,
                StoreID=mycbStores.getSelectedItemID(),
                DeliveryMethodID=mycbDeliveryMethod.getSelectedItemID(),
                ItemsToBeAdded = ctrMyDataGridView1.DataSource.DefaultView.ToTable(true,"Item ID","Quantity"),
            };
            int AddedSellingOrderID = clsSellingOrder.AddNewSellingOrder(dto);
            if (AddedSellingOrderID!=-1)
            {
                //todo, find the object using this id
                MessageBox.Show("Order has been placed successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to place order!");
            }

        }

        private void nudTotalPrice_ValueChanged(object sender, EventArgs e)
        {
            nudDiscountPrice.Value = nudTotalPrice.Value;
        }
        void ResetOrder()
        {
            ctrMyDataGridView1.DataSource = null;
            nudTotalPrice.Value = 0;
            mycbStores.Reset();
            mycbDeliveryMethod.Reset();
            nudPaidPrice.Value = 0;
            dtpEstimatedArrivalDate.Value = DateTime.Today.AddDays(5);
        }
        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to reset order??", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            ResetOrder();

        }
       
    }
}
