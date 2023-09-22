using Anystore.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anystore.DAL
{
    internal class productsDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select Data from Database
        public DataTable Select()
        {   //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            //to hold data from database
            DataTable dt = new DataTable();
            try
            {   //query to get data from database
                String sql = "SELECT * FROM tbl_products";
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
        #region Insert Data in Database
        public bool Insert(productsBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO tbl_products (name,category,description , rate , qty ,added_date, added_by) VALUES (@name, @category, @description,@rate,@qty , @added_date, @added_by) ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query is excuted the value
                //of rows will be greater tha 0 else it will be less tha 0 
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else { isSuccess = false; }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return isSuccess;


        }

        #endregion
        #region update data in database
        public bool Update(productsBLL p)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE tbl_products SET name= @name ,category=@category , description =@description, rate=@rate , qty=@qty,added_date= @added_date,added_by =@added_by WHERE id=@id ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query is excuted the value
                //of rows will be greater tha 0 else it will be less tha 0 
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else { isSuccess = false; }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;


        }


        #endregion
        #region Delete data from database
        public bool delete(productsBLL p)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM tbl_products WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", p.id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query is excuted the value
                //of rows will be greater tha 0 else it will be less tha 0 
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else { isSuccess = false; }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }



        #endregion
        #region Search search in  database using keywords
        public DataTable search(string keyword)
        {

            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            //to hold data from database
            DataTable dt = new DataTable();
            try
            {   //query to get data from database
                String sql = "SELECT * FROM tbl_products WHERE id like '%" + keyword + "%' OR name like '%" + keyword + "%' OR category like '%" + keyword + "%' OR description like '%" + keyword + "%' OR rate like '%" + keyword + "%' OR qty like '%" + keyword + "%' ";
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
        #region 
        public productsBLL searchproductfortransaction(string keyword)
        {
            productsBLL p = new productsBLL();
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            //to hold data from database
            DataTable dt = new DataTable();
            try
            {   //query to get data from database
                String sql = "SELECT name , rate , qty   FROM tbl_products WHERE id like '%" + keyword + "%' OR name like '%" + keyword + "%' ";
                //for executing command
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                // database connection open
                conn.Open();
                //fill data in our table
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
                    

                }
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
            return p;
        }
        #endregion
        #region to get current quantity from the database based en product ID 
        public decimal getproductqty(int productID)
        {
           
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal qty = 0;
            //to hold data from database
            DataTable dt = new DataTable();
            try
            {   //query to get data from database
                String sql = "SELECT qty   FROM tbl_products WHERE id = "+productID;
                //for executing command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // database connection open
                conn.Open();
                //fill data in our table
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                   
                    qty = decimal.Parse(dt.Rows[0]["qty"].ToString());


                }
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
            return qty;
        }


        #endregion
        #region to update quantity 
        public bool updatequantity(int productID , decimal qty)
        {
            bool success = false;
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            
            
           
            try
            {   //query to get data from database
                String sql = "UPDATE tbl_products SET qty = @qty WHERE id=@id";
                //for executing command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@qty",qty);
                cmd.Parameters.AddWithValue("@id", productID);
                //getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                // database connection open
                conn.Open();
                //fill data in our table
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {

                    success = true;


                }
                  
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
            return success;
        }


        #endregion
        #region to increase product
        public bool increaseproduct(int productID, decimal increaseqty)
        {
            bool success = false;
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstring);

          
            try
            {   decimal currentqty = getproductqty(productID);  
                decimal newqty = currentqty +increaseqty;   
                success = updatequantity(productID , newqty);

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
            return success;
        }


        #endregion
        #region to decrease product
        public bool decreaseproduct(int productID, decimal decreaseqty)
        {
            bool success = false;
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstring);


            try
            {
                decimal currentqty = getproductqty(productID);
                decimal newqty = currentqty - decreaseqty;
                success = updatequantity(productID, newqty);

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
            return success;
        }


        #endregion

        #region method to get product id based on product name 

        public productsBLL getproductidfromname(string productname)
        {
            productsBLL p = new productsBLL();


            SqlConnection conn = new SqlConnection(myconnstring);
            //to hold data from database
            DataTable dt = new DataTable();
            try
            {   //query to get data from database
                String sql = "SELECT id FROM tbl_products WHERE name ='" +productname+ "' ";
                //for executing command
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                // database connection open
                conn.Open();
                //fill data in our table
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());


                }
            }
            catch (Exception ex)
            {   // throw message if any erreur occurs
                MessageBox.Show("here is the rreur");

            }
            finally
            {
                //closing connection
                conn.Close();
            }
            //return the value in datatable
            return p;
        }


        #endregion


        #region display products based on cateory
        public DataTable displayproductbycategorie(string categorie)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            //to hold data from database
            DataTable dt = new DataTable();
            try
            {   //query to get data from database
                String sql = "SELECT * FROM tbl_products WHERE category ='" + categorie + "' ";
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

