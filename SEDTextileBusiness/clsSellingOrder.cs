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
    public class clsSellingOrder
    {
        public int SellingOrderID { get; set; }
        public DateTime OrderingDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public float PaidPrice { get; set; }
        public float DiscountPrice { get; set; }

        public clsStore Store { get; set; }
        public clsDeliveryMethod DeliveryMethod { get; set; }

        public int OrderState { get; set; }

        public clsSellingOrder()
        {
            SellingOrderID = -1;
            OrderingDate =DateTime.Now;
            ArrivalDate = DateTime.Now;
            PaidPrice = -1;
            DiscountPrice = -1;
            Store=new clsStore();
            DeliveryMethod=new clsDeliveryMethod();
            OrderState = -1;

        }
       

        public static DataTable AllSellingOrders()
        {
            return clsSellingOrderData.getAllSellingOrders();
        }
        public static int AddNewSellingOrder(AddSellingOrderDTO dto)
        {

            return clsSellingOrderData.AddNewSellingOrder(dto);
            
        }
       
    }
}
