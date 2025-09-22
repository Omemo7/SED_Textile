using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileDTOs
{
    public class AddBuyingOrderDTO
    {
        public float PaidPrice { get; set; }
        public DateTime EstimatedArrivalDate { get; set; }
        public int FactoryID { get; set; }

        public DataTable ItemsToBeAdded { get; set; }
    }
}
