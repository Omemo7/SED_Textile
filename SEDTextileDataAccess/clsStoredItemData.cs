using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDTextileDTOs;
using SEDTextileDTOs.StoredItem;

namespace SEDTextileDataAccess
{
    public class clsStoredItemData
    {
        public static bool getStoredItemByItemID(FindStoredItemDTO dto)

        {
            bool Found = false;


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select dbo.getSellingPriceForStoredItem(@StoredItemID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StoredItemID", dto.ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dto.RollLength = float.Parse(reader["RollLength"].ToString());
                            dto.Textile_VariantID = (int)reader["Textile_VariantID"];


                            Found = true;
                        }
                    }

                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return Found;
        }
        public static float getSellingPriceForStoredItem(int storedItemID)
        {
            float sellingPrice = -1;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select dbo.getSellingPriceForStoredItem(@storedItemID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@storedItemID",storedItemID);
                    sellingPrice = float.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return sellingPrice;
        }
        public static DataTable getAllStorageTable()
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from StorageView";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        dt.Load(reader);
                    }

                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return dt;
        }

    }
}
