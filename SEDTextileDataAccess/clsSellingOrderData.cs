using SEDTextileDTOs.Textile;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDTextileDTOs;
namespace SEDTextileDataAccess
{
    public class clsSellingOrderData
    {
        public static DataTable getAllSellingOrders()
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT * FROM AllSellingOrdersView";
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

        public static int AddNewSellingOrder(AddSellingOrderDTO dto)
        {
            int SellingOrderid = -1;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("spAddNewSellingOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                       
                        cmd.Parameters.AddWithValue("@EstimatedArrivalDate", dto.EstimatedArrivalDate);
                        cmd.Parameters.AddWithValue("@PaidPrice", dto.PaidPrice);
                        cmd.Parameters.AddWithValue("@DiscountPrice", dto.DiscountPrice);
                        cmd.Parameters.AddWithValue("@StoreID", dto.StoreID);
                        cmd.Parameters.AddWithValue("@DeliveryMethodID", dto.DeliveryMethodID);
                    

                        SqlParameter tvpParam = cmd.Parameters.AddWithValue("@ItemsToBeAdded", dto.ItemsToBeAdded);
                        tvpParam.SqlDbType = SqlDbType.Structured; 

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int r))
                        {
                            SellingOrderid = r;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return SellingOrderid;
        }
    }
}
