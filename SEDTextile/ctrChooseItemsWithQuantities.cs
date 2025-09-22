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
   
    public partial class ctrChooseItemsWithQuantities : UserControl
    {
       
        
        public event EventHandler<SaveItemsEventArgs> onSaveItems;
        DataTable OrderSummaryTable = new DataTable();
        decimal? MaximumQuantityForCurrentItem=null;
        string SellingOrBuyingPriceColumnName="";
        public DataTable DataSource
        {
            get => ctrMyDataGridViewItems.DataSource;
         
        }
        public void setDataSource(DataTable dt,string PriceColumnName)
        {
            if(!dt.Columns.Contains(PriceColumnName))
            {
                throw new Exception("Price column with this name doesn't exist");
            }

            SellingOrBuyingPriceColumnName =PriceColumnName;
            ctrMyDataGridViewItems.DataSource = dt;

            
        }

        int currentItemID = 0;
        decimal TotalOrderPrice = 0;

        public ctrChooseItemsWithQuantities()
        {

            InitializeComponent();
            ctrMyDataGridViewChosenItems.OnRowClicked += OnMyDataGridChosenItemsRowClicked;
            ctrMyDataGridViewItems.OnRowClicked += OnMyDataGridItemsRowClicked;
            CreateSummaryTableStructure();
            ctrMyDataGridViewChosenItems.DataSource = null;
            
        }

        private void OnMyDataGridChosenItemsRowClicked(int obj)
        {
           ctrMyDataGridViewItems.FilterRowByItemID(obj);
        }

        public void setAlreadyChosenItemsWithTotalPrice (DataTable summaryTableForChosenItems, decimal totalOrderPrice)
        {
            
            TotalOrderPrice = totalOrderPrice;
            OrderSummaryTable = summaryTableForChosenItems;
            
            UpdateUIBasedOnVariablesChange();


        }
        
       
        void CreateSummaryTableStructure()
        {
            OrderSummaryTable.Columns.AddRange(new DataColumn[] {

                new DataColumn("Item ID",typeof(int)),
                new DataColumn("Quantity",typeof(decimal)),
                new DataColumn("Price",typeof(decimal)),
            }

           );
        }

        private void OnMyDataGridItemsRowClicked(int ItemID)
        {
            currentItemID = ItemID;
            lblSelectedItemID.Text = currentItemID.ToString();
            decimal? QuantityOfClickedItem = OrderSummaryTable.AsEnumerable().Where(r => r.Field<int>("Item ID") == currentItemID).Select(r => r.Field<decimal?>("Quantity")).FirstOrDefault();

            nudQuantity.Value = QuantityOfClickedItem ?? 0;//null coalescing operator, if value was null assigns 0 instead
            nudQuantity.Select(0, nudQuantity.Text.Length);
            nudQuantity.Focus();
        }

        void UpdateTotalOrderPrice()
        {
            TotalOrderPrice = OrderSummaryTable.AsEnumerable()
                .Select(r => r.Field<decimal>("Price")).Sum();
        }
        void DeleteDataRowWithCurrentItemIDInSummaryTable()
        {
            OrderSummaryTable.AsEnumerable()
                   .Where(row => row.Field<int>("Item ID") == currentItemID).ToList()
                   .ForEach(row => row.Delete());
            OrderSummaryTable.AcceptChanges();
        }
        void ValidateQuantityInput()
        {
            

            if (MaximumQuantityForCurrentItem!=null && nudQuantity.Value > MaximumQuantityForCurrentItem )
            {
                MessageBox.Show($"The value you entered exceeds the maximum which is ({MaximumQuantityForCurrentItem})\n " +
                    $"Value will be set to maximum.");
                nudQuantity.Value = MaximumQuantityForCurrentItem??0;

            }
            if (nudQuantity.Value < 0)
            {
                MessageBox.Show($"Negative values are not allowed!!");
                nudQuantity.Value = 0;

            }

        }


        void AddOrModifyDataRowWithCurrentItemIDInSummaryTable()
        {
            decimal CurrentItemPrice =(decimal)
    ctrMyDataGridViewItems.DataSource.AsEnumerable()
    .Where(r => r.Field<int>("ItemID") == currentItemID)
    .Select(r => r.Field<double>(SellingOrBuyingPriceColumnName))
    .FirstOrDefault();


            decimal TotalPriceForCurrentItemBasedOnQuantity = nudQuantity.Value *CurrentItemPrice;


            DataRow existingRow = OrderSummaryTable.AsEnumerable()
                .FirstOrDefault(r => r.Field<int>("Item ID") == currentItemID);

            if (existingRow == null)
            {

                OrderSummaryTable.Rows.Add(currentItemID, nudQuantity.Value, TotalPriceForCurrentItemBasedOnQuantity);
            }
            else
            {

                existingRow["Quantity"] = nudQuantity.Value;
                existingRow["Price"] = TotalPriceForCurrentItemBasedOnQuantity;
            }
        }
        void UpdateUIBasedOnVariablesChange()
        {

            ctrMyDataGridViewChosenItems.DataSource = OrderSummaryTable;

            lblTotalPrice.Text = TotalOrderPrice.ToString();
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            OrderSummaryTable.Clear();
            ctrMyDataGridViewChosenItems.DataSource=null;
            nudQuantity.Value = 0;
            UpdateTotalOrderPrice();
            UpdateUIBasedOnVariablesChange();


        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TotalOrderPrice == 0)
            {
                MessageBox.Show("No items were choosen!!");
                return;
            }


            onSaveItems?.Invoke(this,new SaveItemsEventArgs { ChosenItemsSummary=OrderSummaryTable,TotalPrice=TotalOrderPrice});
           

        }

        

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            nudQuantity.Value = 0;
        }

       
        private void ctrChooseItemsWithQuantities_Load(object sender, EventArgs e)
        {
            ctrMyDataGridViewItems.SelectFirstRecord();
        }

        private void nudQuantity_ValueChanged_1(object sender, EventArgs e)
        {
            ValidateQuantityInput();

            if (nudQuantity.Value == 0)
                DeleteDataRowWithCurrentItemIDInSummaryTable();
            else
                AddOrModifyDataRowWithCurrentItemIDInSummaryTable();


            UpdateTotalOrderPrice();
            UpdateUIBasedOnVariablesChange();
        }

        private void ctrMyDataGridViewChosenItems_Load(object sender, EventArgs e)
        {

        }

        private void ctrMyDataGridViewItems_Load(object sender, EventArgs e)
        {

        }
    }
    public class SaveItemsEventArgs : EventArgs
    {
        public DataTable ChosenItemsSummary { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
