using SEDTextileDTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDTextileDataAccess
{
    public class clsBuyingOrderData
    {

        public static bool PayFullPriceForBuyingOrder(int BuyingOrderID)
        {
            bool isPaid = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("spPayFullPriceForBuyingOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@BuyingOrderID", BuyingOrderID);
                        
                        SqlParameter returnVal = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        cmd.Parameters.Add(returnVal);
                        cmd.ExecuteNonQuery();
                        isPaid = (int)returnVal.Value > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return isPaid;
        }
        public static bool PayPartOfRemainingPriceForBuyingOrder(float PaidAmount,int BuyingOrderID)
        {
            bool isPaid = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("spPayPartOfRemainingPriceForBuyingOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@BuyingOrderID", BuyingOrderID);
                        cmd.Parameters.AddWithValue("@PaidAmount", PaidAmount);
                        SqlParameter returnVal = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        cmd.Parameters.Add(returnVal);
                        cmd.ExecuteNonQuery();
                        isPaid = (int)returnVal.Value > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return isPaid;
        }

        public static int getOrderState(int buyingOrderID)
        {
            int orderState = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("select dbo.getOrderStateForBuyingOrder(@BuyingOrderID)", conn))
                    {
                        cmd.Parameters.AddWithValue("@BuyingOrderID", buyingOrderID);

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int r))
                        {
                            orderState = r;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return orderState;
        }
        public static bool CancelOrder(int BuyingOrderID)
        {
            bool isCancelled = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("spCancelBuyingOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@BuyingOrderID", BuyingOrderID);
                        SqlParameter returnVal = new SqlParameter
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        cmd.Parameters.Add(returnVal);
                        cmd.ExecuteNonQuery();
                        isCancelled = (int)returnVal.Value > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return isCancelled;
        }
        
        public static bool SetOrderStateToCompletedOrCompletedWithDebt(int orderID)
        {
            bool isSet = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("spSetBuyingOrderStateCompletedWithOrWithoutDebtForOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@BuyingOrderID", orderID);
                        cmd.ExecuteNonQuery();
                        isSet = true;

                       
                    }

                }
            }
            catch (Exception ex)
            {
                isSet = false;
                throw;
            }
            return isSet;
        } 
        public static DataTable getAllBuyingOrders()
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT * FROM AllBuyingOrdersView";
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
        public static int AddNewBuyingOrder(AddBuyingOrderDTO dto)
        {
            int BuyingOrderid = -1;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("spAddNewBuyingOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@EstimatedArrivalDate", dto.EstimatedArrivalDate);
                        cmd.Parameters.AddWithValue("@PaidPrice", dto.PaidPrice);
                        cmd.Parameters.AddWithValue("@FactoryID", dto.FactoryID);

                        SqlParameter tvpParam = cmd.Parameters.AddWithValue("@ItemsToBeAdded", dto.ItemsToBeAdded);
                        tvpParam.SqlDbType = SqlDbType.Structured;

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int r))
                        {
                            BuyingOrderid = r;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return BuyingOrderid;
        }
    }
}
