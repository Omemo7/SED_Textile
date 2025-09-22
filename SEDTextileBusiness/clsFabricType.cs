using SEDTextileDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileBusiness
{
    public class clsFabricType
    {
        static public clsFabricType Find(int FabricTypeID) 
        {
            return null;//todo implement
        }
        public static Dictionary<int, string> FabricTypeIDWithFabricNamePairs()
        {
            return clsFabricTypeData.getFabricTypeIDWithFabricNamePairs();
        }
    }
}
