using SEDTextileDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileBusiness
{
    public class clsTextile_Variant
    {
        public int Textile_VariantID { set; get; }
        public string TextileCode { set; get; }
        public string VariantCode { set; get; }

        public clsTextile_Variant()
        {
            Textile_VariantID = -1;
            TextileCode = "";
            VariantCode = "";

        }

        public static float getBuyingPrice(int Textile_VariantID)
        {
            float price = clsTextile_VariantData.getBuyingPriceForTextile_Variant(Textile_VariantID);
            if (price < 0)
                throw new Exception("No stored item with this id was found!!");
            return price;
        }
    }
}
