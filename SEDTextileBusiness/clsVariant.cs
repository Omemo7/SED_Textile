using SEDTextileDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SEDTextileDTOs.Variant;

namespace SEDTextileBusiness
{
    public class clsVariant
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int VariantID { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }

        public clsVariant()
        {
            VariantID = -1;
            Code = "";
            Name = "";

            Mode = enMode.AddNew;

        }

        public clsVariant(FindVariantDTO dto)
        {
            VariantID =dto.VariantID;
            Code = dto.Code;
            Name = dto.Name;

            Mode = enMode.Update;
        }

        
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewVariant())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateVariant();

            }

            return false;
        }
        private bool AddNewVariant()
        {

            VariantID = clsVariantData.AddNewVariant(
                Code, Name);

            return (VariantID != -1);
        }
        public static bool AddNewVariantsTable(DataTable dt)
        {

            return clsVariantData.AddNewVariantsTable(dt);
        }
        private bool UpdateVariant()
        {

            return clsVariantData.UpdateVariant(VariantID, Code, Name);
        }
        public static bool DeleteVariant(int ID)
        {
            return clsVariantData.DeleteVariant(ID);
        }
        public static clsVariant Find(int VariantID)
        {

           FindVariantDTO dto = new FindVariantDTO();


            if (clsVariantData.getVariantByVariantID(dto))

                return new clsVariant(dto);
            else
                return null;
        }
        public static Dictionary<int,string> VariantIDWithVariantAliasPairs()
        {
            return clsVariantData.getVariantIDWithVariantAliasPairs();
        }

        public static DataTable GetAllVariants()
        {
            return clsVariantData.getAllVariantsTable();
        }

    }
}
