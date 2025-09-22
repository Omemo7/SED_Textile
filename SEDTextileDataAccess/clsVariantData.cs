using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDTextileDTOs.Variant;

namespace SEDTextileDataAccess
{
    public class clsVariantData
    {
        static string ConnectionString=clsDataAccessSettings.ConnectionString;
        public static bool AddNewVariantsTable(DataTable dt)
        {
            bool added = false;

            // Establish connection to the database
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();

                    // Begin a transaction (optional, but recommended for bulk inserts)
                    transaction = conn.BeginTransaction();

                    // Create a command object
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;


                        cmd.CommandText = "spAddNewVariant";
                        cmd.CommandType = CommandType.StoredProcedure;


                        foreach (DataRow row in dt.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@Code", row["Code"].ToString());
                            cmd.Parameters.AddWithValue("@Alias", row["Alias"].ToString());

                            // Execute the insert command
                            cmd.ExecuteNonQuery();
                        }

                        // Commit the transaction
                        transaction.Commit();
                       
                        added = true;
                    }

                }
                catch (Exception ex)
                {
                   transaction.Rollback();
                    added = false;
                    throw; 
                }
            }
            return added;
        }
            static public int AddNewVariant(string Code, string Name)
        {
            int variantid = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    

                    using (SqlCommand cmd = new SqlCommand("spAddNewVariant", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        cmd.Parameters.AddWithValue("@Code", Code);
                        cmd.Parameters.AddWithValue("@Alias", Name);
                        object result =cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int r))
                        {
                            variantid = r;
                        }
                    }

                }


            }
            catch (Exception ex)
            {
                throw;
            }


            return variantid;

        }



        public static bool UpdateVariant(int VariantID, string Code, string Name)
        {

            int rowsAffected = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = @"Update  Variants  
                                set ,
Code = @Code,
Name = @Name
                                    where VariantID = @VariantID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@VariantID", VariantID);
                        cmd.Parameters.AddWithValue("@Code", Code);
                        cmd.Parameters.AddWithValue("@Name", Name);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }

            }

            catch (Exception ex)
            {
                throw;
            }

            return (rowsAffected > 0);
        }
        static public bool DeleteVariant(int VariantID)
        {
            bool deleted = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = @"delete Variants where VariantID= @VariantID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@VariantID", VariantID);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            deleted = true;
                        }
                    }

                }


            }
            catch (Exception ex)
            {
                throw;
            }


            return deleted;

        }

        public static Dictionary<int, string> getVariantIDWithVariantAliasPairs()
        {
            Dictionary<int,string>pairs = new Dictionary<int,string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select VariantID,Alias from Variants";
                    SqlCommand cmd = new SqlCommand(query, conn);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) 
                        {
                            pairs[(int)reader["VariantID"]] = reader["Alias"].ToString();
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

        public static bool getVariantByVariantID(FindVariantDTO dto)

        {
            bool Found = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from Variants where VariantID=@VariantID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@VariantID", dto.VariantID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dto.Code = reader["Code"].ToString();
                            dto.Name = reader["Name"].ToString();

                            Found = true;
                        }
                    }

                }


            }
            catch (Exception ex)
            {
                Found = false;
                throw;
            }

            return Found;
        }
        public static DataTable getAllVariantsTable()
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from Variants";
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
