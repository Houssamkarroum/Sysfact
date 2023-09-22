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
    internal class categoriesDAL
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
                String sql = "SELECT * FROM tbl_categories";
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
        public bool Insert(categoriesBLL c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO tbl_categories (title,description,added_date, added_by) VALUES (@title, @description, @added_date, @added_by) ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
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
        public bool Update(categoriesBLL c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE tbl_categories SET title= @title , description =@description ,added_date= @added_date,added_by =@added_by WHERE id=@id ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);
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
        public bool delete(categoriesBLL c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM tbl_categories WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", c.id);
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
                String sql = "SELECT * FROM tbl_categories WHERE id like '%" + keyword + "%' OR title like '%" + keyword + "%' OR description like '%" + keyword + "%'  ";
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
        public userBLL getidfromusername(string username)
        {
            userBLL u = new userBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT id FROM tbl_users WHERE username='" + username + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    u.id = int.Parse(dt.Rows[0]["id"].ToString());
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
            return u;
        }
        #endregion
    }
}
