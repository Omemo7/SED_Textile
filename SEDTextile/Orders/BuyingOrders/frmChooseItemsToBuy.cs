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
    public partial class frmChooseItemsToBuy : Form
    {
        public event EventHandler<SaveItemsEventArgs> onSaveItems;
        clsFactory Factory;
        public frmChooseItemsToBuy(int FactoryID, DataTable AlreadyChosenItemsSummary=null)
        {
            InitializeComponent();
            ctrChooseItemsWithQuantities1.onSaveItems += ChooseItemsSaveEventHandler;
            Factory = clsFactory.Find(FactoryID);
            ctrChooseItemsWithQuantities1.setDataSource(Factory.ItemsProvidedByFactory(), "BuyingPrice");


            if (AlreadyChosenItemsSummary == null)
                return;

            decimal totalPrice = AlreadyChosenItemsSummary.AsEnumerable().Sum(r=>r.Field<decimal>("Price"));
            ctrChooseItemsWithQuantities1.setAlreadyChosenItemsWithTotalPrice(AlreadyChosenItemsSummary.Copy(), totalPrice);
              
        }
      

        private void ChooseItemsSaveEventHandler(object sender, SaveItemsEventArgs e)
        {
            onSaveItems?.Invoke(this,e);
            this.Close();
        }

       

        private void frmChooseItemsToBuy_Load(object sender, EventArgs e)
        {
             
            
        }

        private void ctrChooseItemsWithQuantities1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
