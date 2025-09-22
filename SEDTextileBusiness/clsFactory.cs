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
    public class clsFactory
    {
        public int FactoryID { set; get; }
        public string Name { set; get; }
        public string Phone { set; get; }

        public clsFactory()
        {
            FactoryID = -1;
            Name = "";
            Phone = "";

        }
        private clsFactory(FindFactoryDTO DTO)
        {
            FactoryID = DTO.FactoryID;
            Name = DTO.Name;
            Phone = DTO.Phone;
        }

        public static clsFactory Find(int FactoryID)
        {

           FindFactoryDTO dto = new FindFactoryDTO();
            dto.FactoryID = FactoryID;


            bool IsFound = clsFactoryData.getFactoryByFactoryID(dto);


            if (IsFound)
                return new clsFactory(dto);
            else
                return null;
        }

        public static Dictionary<int,string> FactoryIDWithFactoryNamePairs()
        {
            return clsFactoryData.getFactoryIDWithFactoryNamePairs();
        }

        public DataTable ItemsProvidedByFactory()
        {
            return clsFactoryData.getItemsProvidedByFactory(this.FactoryID);
        }
        public static DataTable GetAllFactories()
        {
            return clsFactoryData.getAllFactoriesTable();
        }

    }
}
