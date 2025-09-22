using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileDataAccess
{
    public class clsTextile_VariantData
    {
        public static float getBuyingPriceForTextile_Variant(int Textile_VariantID)
        {
            float buyingPrice = -1;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select dbo.getBuyingPriceForThisTextile_Variant(@Textile_VariantID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Textile_VariantID", Textile_VariantID);
                    buyingPrice = float.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return buyingPrice;
        }
    }
}
