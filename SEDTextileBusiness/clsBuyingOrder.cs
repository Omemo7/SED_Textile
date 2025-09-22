using SEDTextileDataAccess;
using SEDTextileDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileBusiness
{
    public class clsBuyingOrder
    {
        public enum enOrderState {InProgress=1,CompletedWithDebt,Completed,Cancelled}
        public int BuyingOrderID { get; set; }
        public DateTime OrderingDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime EstimatedArrivalDate { get; set; }
        public float PaidPrice { get; set; }
        public clsFactory Factory { get; set; }
       
        public enOrderState OrderState { get; set; }

        public clsBuyingOrder()
        {
            BuyingOrderID = -1;
            OrderingDate = DateTime.Now;
            ArrivalDate = DateTime.Now;
            PaidPrice = -1;
            Factory = new clsFactory();
            OrderState = enOrderState.InProgress;

        }
        public static bool SetBuyingOrderStateCompletedWithOrWithoutDebtForOrder(int orderID)
        {
            return clsBuyingOrderData.SetOrderStateToCompletedOrCompletedWithDebt(orderID);
        }
        public static DataTable AllBuyingOrders()
        {
            return clsBuyingOrderData.getAllBuyingOrders();
        }

        public static bool PayPartOfRemainingPriceForOrder(float PaidAmount,int BuyingPriceID)
        {
           return clsBuyingOrderData.PayPartOfRemainingPriceForBuyingOrder(PaidAmount, BuyingPriceID);
        }
        public static bool PayFullPrice(int BuyingOrder)
        {
            return clsBuyingOrderData.PayFullPriceForBuyingOrder(BuyingOrder);
        }
        public static enOrderState GetOrderState(int id)
        {
            return (enOrderState)clsBuyingOrderData.getOrderState(id);
        }
        public static bool CancelOrder(int orderID)
        {
            return clsBuyingOrderData.CancelOrder(orderID);
        }
        public static int AddNewBuyingOrder(AddBuyingOrderDTO dto)
        {
            return clsBuyingOrderData.AddNewBuyingOrder(dto);

        }

    }
}

