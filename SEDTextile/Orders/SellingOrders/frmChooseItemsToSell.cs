
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
using System.Xml;

namespace SEDTextile.Orders.SellingOrders
{
    public partial class frmChooseItemsToSell : Form
    {
        public frmChooseItemsToSell()
        {
            InitializeComponent();
        }
        public event EventHandler<SaveItemsEventArgs> onSaveItems;
        
        public frmChooseItemsToSell(DataTable AlreadyChosenItemsSummary = null)
        {
            InitializeComponent();
            ctrChooseItemsWithQuantities1.onSaveItems += ChooseItemsSaveEventHandler;
           
            ctrChooseItemsWithQuantities1.setDataSource(clsStoredItem.GetStorage(), "SellingPrice");


            if (AlreadyChosenItemsSummary == null)
                return;

            decimal totalPrice = AlreadyChosenItemsSummary.AsEnumerable().Sum(r => r.Field<decimal>("Price"));
            ctrChooseItemsWithQuantities1.setAlreadyChosenItemsWithTotalPrice(AlreadyChosenItemsSummary.Copy(), totalPrice);




        }


        private void ChooseItemsSaveEventHandler(object sender, SaveItemsEventArgs e)
        {
            onSaveItems?.Invoke(this, e);
            this.Close();
        }



        private void frmChooseItemsToSell_Load(object sender, EventArgs e)
        {

        }
    }
}
