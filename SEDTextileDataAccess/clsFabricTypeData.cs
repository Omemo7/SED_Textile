using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileDataAccess
{
    public class clsFabricTypeData
    {
        public static Dictionary<int, string> getFabricTypeIDWithFabricNamePairs()
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select FabricTypeID,Name from FabricTypes";
                    SqlCommand cmd = new SqlCommand(query, conn);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pairs[(int)reader["FabricTypeID"]] = reader["Name"].ToString();
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
