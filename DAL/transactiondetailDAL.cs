using Anystore.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anystore.DAL
{
    internal class transactiondetailDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region 
        public bool Insert_transactiondetails(transactiondetailBLL td)
        {
            bool issuccess = false;
            
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO tbl_transaction_detail ( product_id ,rate , qty , dea_cust_id , total , added_date , added_by ) VALUES ( @product_id ,@rate , @qty , @dea_cust_id , @total , @added_date , @added_by )";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@product_id", td.product_id);
                cmd.Parameters.AddWithValue("@rate ", td.rate);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@dea_cust_id", td.dea_cust_id);
                
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if the query is excuted the value
                //of rows will be greater tha 0 else it will be less tha 0 
                if (rows > 0)
                {
                    issuccess = true;

                }
                else { issuccess = false; }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return issuccess;
        }
        #endregion


    }
}
