using Anystore.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anystore.DAL
{
    internal class transactionDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region 
        public bool Insert_transaction(transactionBLL T, out int transactionID)
        {
            bool issuccess = false;
            transactionID = -1;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO tbl_transactions (type , dea_cust_id , grandtotal , transaction_date , tax , discount , added_by ) VALUES (@type , @dea_cust_id , @grandtotal , @transaction_date , @tax , @discount, @added_by ); SELECT @@IDENTITY";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type", T.type);
                cmd.Parameters.AddWithValue("@dea_cust_id ", T.dea_cust_id);
                cmd.Parameters.AddWithValue("@grandtotal", T.grandtotal);
                cmd.Parameters.AddWithValue("@transaction_date", T.transaction_date);
                cmd.Parameters.AddWithValue("@tax", T.tax);
                cmd.Parameters.AddWithValue("@discount", T.discount);
                cmd.Parameters.AddWithValue("@added_by", T.added_by);
                conn.Open();
                object o = cmd.ExecuteScalar();
                if(o!= null)
                {
                    transactionID = int.Parse(o.ToString());
                    issuccess = true;
                }
                else
                {
                    issuccess = false;
                }
            
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



        #region     to display all transaction

        public DataTable displayalltransaction()
        {
           


            SqlConnection conn = new SqlConnection(myconnstring);
            //to hold data from database
            DataTable dt = new DataTable();
            try
            {   //query to get data from database
                String sql = "SELECT * FROM tbl_transactions  ";
                //for executing command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // database connection open
                conn.Open();
                //fill data in our table
                adapter.Fill(dt);

                
            }
            catch (Exception ex)
            {   // throw message if any erreur occurs
                MessageBox.Show(ex.Message);

            }
            finally
            {
                //closing connection
                conn.Close();
            }
            //return the value in datatable
            return dt;
        }
        #endregion



        #region     to display all transaction by sales

        public DataTable displayalltransactiontype(string types)
        {



            SqlConnection conn = new SqlConnection(myconnstring);
            //to hold data from database
            DataTable dt = new DataTable();
            try
            {   //query to get data from database
                String sql = "SELECT * FROM tbl_transactions WHERE type ='"+types+"' ";
                //for executing command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // database connection open
                conn.Open();
                //fill data in our table
                adapter.Fill(dt);


            }
            catch (Exception ex)
            {   // throw message if any erreur occurs
                MessageBox.Show(ex.Message);

            }
            finally
            {
                //closing connection
                conn.Close();
            }
            //return the value in datatable
            return dt;
        }
        #endregion
    }
}
