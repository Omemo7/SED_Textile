using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileDTOs
{
    public class AddSellingOrderDTO
    {
       
        public float PaidPrice { get; set; }   
        public DateTime EstimatedArrivalDate { get; set; }
        
        public float DiscountPrice { get; set; }

        public int StoreID { get; set; }
        public int DeliveryMethodID { get; set; }

        public DataTable ItemsToBeAdded { get; set; }

        

    }
}
