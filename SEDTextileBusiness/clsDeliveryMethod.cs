using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDTextileDataAccess;

namespace SEDTextileBusiness
{
    public class clsDeliveryMethod
    {
        public int ID { get; set; }
        public string Name { get; set; }

        
        public static clsDeliveryMethod Find(int id)
        {
            throw new NotImplementedException();
        }
        public static Dictionary<int, string> IDWithNamePairs()
        {
            return clsDeliveryMethodData.getDeliveryMethodIDWithNamePairs();
        }
    }
}
