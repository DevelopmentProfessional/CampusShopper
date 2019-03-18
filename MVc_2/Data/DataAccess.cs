using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using MVc_2.Contracts;

namespace MVc_2.Data
{
    public class DataAccess : IRepository
    {
        private SqlConnection sql_con = new SqlConnection(@"data source=localhost;initial catalog=CampusShop;integrated security=True;");
        public  bool Login(string username, string password)
        {
            try
            {
                
                sql_con.Open();
                using (SqlCommand comm = new SqlCommand("Login", sql_con))
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@Username", username);
                    comm.Parameters.AddWithValue("@Password", password);
                    comm.ExecuteNonQuery();
                    return true;
                }
            }
            catch (NullReferenceException)
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public void AddToCart(int UserID,int ItemID)
        {
            try
            {
                sql_con.Open();
                using (SqlCommand comm = new SqlCommand("Login", sql_con))
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@UserID", UserID);
                    comm.Parameters.AddWithValue("@ItemID", ItemID);
                    comm.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Delete(int id)
        {
            try
            {
                sql_con.Open();
                using (SqlCommand comm = new SqlCommand("Delete", sql_con))
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@ItemID", id);
                    comm.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void AddToInvoice(int AccountID)
        {
            try
            {
                sql_con.Open();
                using (SqlCommand comm = new SqlCommand("AddToInvoice", sql_con))
                {
                    comm.CommandType = System.Data.CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@AccountID", AccountID);
                    comm.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}