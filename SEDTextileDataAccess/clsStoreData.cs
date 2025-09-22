using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileDataAccess
{
    public class clsStoreData
    {
        public static Dictionary<int, string> getStoreIDWithStoreNamePairs()
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select StoreID,Name from Stores";
                    SqlCommand cmd = new SqlCommand(query, conn);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pairs[(int)reader["StoreID"]] = reader["Name"].ToString();
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
        public static DataTable getAllStoresTable()
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from Stores";
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
