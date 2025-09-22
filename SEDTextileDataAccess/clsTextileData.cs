using SEDTextileDTOs.Textile;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileDataAccess
{
    public class clsTextileData
    {
        public static float getTotalQuantityForTextile(int textileID)
        {
            float totalQuantity = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT dbo.getTotalQuantityForTextile(@textileID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@textileID", textileID);
                    totalQuantity= float.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return totalQuantity;
        }
        public static bool getTextileByTextileID(FindTextileDTO dto)

        {
            bool Found = false;


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from Textiles where TextileID=@TextileID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TextileID", dto.TextileID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dto.Code = (string)reader["Code"];
                            dto.Alias = (string)reader["Alias"];
                            dto.BuyingPrice = float.Parse(reader["BuyingPrice"].ToString());
                            dto.SellingPrice = float.Parse(reader["SellingPrice"].ToString());
                            dto.FactoryID = (int)reader["FactoryID"];
                            dto.FabricTypeID = (int)reader["FabricTypeID"];


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
        public static DataTable getStorageInfoForAllVariantsForThisTextile(int textileID)
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT * FROM [dbo].[getStorageInfoForAllVariantsForThisTextile](@textileID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@textileID", textileID);

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

        public static int AddNewTextile(AddTextileDTO dto)
        {
            int textileid = -1;
            
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("spAddNewTextile", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Code", dto.Code);
                        cmd.Parameters.AddWithValue("@Alias", dto.Alias);
                        cmd.Parameters.AddWithValue("@BuyingPrice", dto.BuyingPrice);
                        cmd.Parameters.AddWithValue("@SellingPrice", dto.SellingPrice);
                        cmd.Parameters.AddWithValue("@FactoryID", dto.FactoryID);
                        cmd.Parameters.AddWithValue("@FabricTypeID", dto.FabricTypeID);

                        cmd.Parameters.AddWithValue("@VariantsIDsJoinedAsString",string.Join( ",",dto.VariantsIDs));

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int r))
                        {
                            textileid = r;
                        }
                    }

                    }
            }
            catch (Exception ex)
            {
                throw;
            }
            return textileid;
        }


        public static DataTable getAllVariantsForThisTextile(int textileID)
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT * FROM [dbo].[getAllVariantsForThisTextile](@textileID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@textileID", textileID);

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

        public static DataTable getTextileTable()
        {
            DataTable dt=new DataTable();

            try
            {
                using(SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    con.Open();
                    string query = @"select *from textileview";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows) 
                            {
                                dt.Load(reader);
                            }

                        }
                    }

                }
            }
            
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;

        }
    }
}
