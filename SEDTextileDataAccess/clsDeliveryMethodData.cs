using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileDataAccess
{
    public class clsDeliveryMethodData
    {
        public static Dictionary<int, string> getDeliveryMethodIDWithNamePairs()
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select DeliveryMethodID,Name from DeliveryMethods";
                    SqlCommand cmd = new SqlCommand(query, conn);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pairs[(int)reader["DeliveryMethodID"]] = reader["Name"].ToString();
                        }

                    }

                }


            }
            catch (Exception ex)
            {
                throw;
            }
            return pairs;
        }
    }
}
