using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDTextileDTOs;
using SEDTextileDTOs.Factory;

namespace SEDTextileDataAccess
{
    public class clsFactoryData
    {
        public static Dictionary<int, string> getFactoryIDWithFactoryNamePairs()
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select FactoryID,Name from Factories";
                    SqlCommand cmd = new SqlCommand(query, conn);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pairs[(int)reader["FactoryID"]] = reader["Name"].ToString();
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
        public static bool getFactoryByFactoryID(FindFactoryDTO dto)

        {
            bool Found = false;


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from Factories where FactoryID=@FactoryID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FactoryID",dto.FactoryID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dto.Name = reader["Name"].ToString();
                            dto.Phone = reader["Phone"].ToString();

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
        public static DataTable getItemsProvidedByFactory(int FactoryID)
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from getItemsProvidedByThisFactory(@FactoryID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FactoryID",FactoryID);

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

    
        public static DataTable getAllFactoriesTable()
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from Factories";
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
