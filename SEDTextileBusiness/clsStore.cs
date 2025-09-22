using SEDTextileDataAccess;
using SEDTextileDTOs.Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileBusiness
{
    public class clsStore
    {
        public int StoreID { set; get; }
        public string Name { set; get; }
        public string Phone { set; get; }

        public clsStore()
        {
            StoreID = -1;
            Name = "";
            Phone = "";

        }
        public static clsStore Find(int id)
        {
            throw new NotImplementedException();
        }
        public static Dictionary<int, string> StoreIDWithStoreNamePairs()
        {
            return clsStoreData.getStoreIDWithStoreNamePairs();
        }
        public static DataTable GetAllStores()
        {
            return clsStoreData.getAllStoresTable();
        }

    }
}
