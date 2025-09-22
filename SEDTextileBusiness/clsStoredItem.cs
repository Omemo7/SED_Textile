using SEDTextileDataAccess;
using SEDTextileDTOs.StoredItem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileBusiness
{
    public class clsStoredItem
    {
        public int StoredItemID { set; get; }
        public float RollLength { set; get; }
        public int Textile_VariantID { set; get; }

        public clsStoredItem()
        {
            StoredItemID = -1;
            RollLength = -1;
            Textile_VariantID = -1;

        }
        private clsStoredItem(FindStoredItemDTO dto)
        {
            StoredItemID = dto.ID;
            RollLength = dto.RollLength;
            Textile_VariantID = dto.Textile_VariantID;
        }

        public static clsStoredItem Find(int StoredItemID)
        {

            FindStoredItemDTO dto=new FindStoredItemDTO();
            dto.ID = StoredItemID;

            if (clsStoredItemData.getStoredItemByItemID(dto))
                return new clsStoredItem(dto);
            else
                return null;

        }
        public float getSellingPrice()
        {
            return clsStoredItemData.getSellingPriceForStoredItem(this.StoredItemID);
        }
        public static float getSellingPrice(int storedItemID)
        {
            float price= clsStoredItemData.getSellingPriceForStoredItem(storedItemID);
            if (price < 0)
                throw new Exception("No stored item with this id was found!!");
            return price;
        }
        public static DataTable GetStorage()
        {
            return clsStoredItemData.getAllStorageTable();
        }

    }
}
