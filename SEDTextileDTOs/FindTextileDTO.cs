using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileDTOs.Textile
{
    public class FindTextileDTO
    {
        public int TextileID { set; get; }
        public string Code { set; get; }
        public string Alias { set; get; }

        public float BuyingPrice { set; get; }
        public float SellingPrice { set; get; }
        public int FactoryID { set; get; }
        public int FabricTypeID { set; get; }

    }

}
