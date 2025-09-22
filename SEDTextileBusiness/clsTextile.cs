using SEDTextileDataAccess;
using SEDTextileDTOs.Textile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileBusiness
{
    public class clsTextile
    {
        public int TextileID {  get; set; }
       
        public string Code { get; set; }

        public string Alias { get; set; }
        
        public float BuyingPrice {  get; set; }

        public float SellingPrice {  get; set; }

        public clsFactory Factory { get; set; }

        public clsFabricType FabricType { get; set; }

        
        public clsTextile() { }
        private clsTextile(FindTextileDTO dto)
        {
            TextileID = dto.TextileID;
            Code = dto.Code;
            Alias = dto.Alias;
            BuyingPrice = dto.BuyingPrice;
            SellingPrice = dto.SellingPrice;
            Factory = clsFactory.Find(dto.FactoryID);
            FabricType = clsFabricType.Find(dto.FabricTypeID);

        }
        public static bool AddNew(AddTextileDTO dto)
        {
          int newTextileID= clsTextileData.AddNewTextile(dto);

           return newTextileID != -1;
        }



        public static DataTable TextileTable()
        {
            return clsTextileData.getTextileTable();
        }
        public static clsTextile Find(int TextileID)
        {
            FindTextileDTO dto = new FindTextileDTO();
            dto.TextileID = TextileID;
            if (clsTextileData.getTextileByTextileID(dto))

                return new clsTextile(dto);
            else
                return null;
        }
        public float TotalQuantity()
        {
            return clsTextileData.getTotalQuantityForTextile(this.TextileID);
        }
        public DataTable StorageInfoForAllVariantsForThisTextile()
        {
            return clsTextileData.getStorageInfoForAllVariantsForThisTextile(this.TextileID);
        }
        public DataTable AllVariantsForTextile()
        {
            return clsTextileData.getAllVariantsForThisTextile(this.TextileID);
        }
    }
}
