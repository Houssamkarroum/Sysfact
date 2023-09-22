using Anystore.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;

namespace Anystore.DAL
{
    internal class deacustDAL
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
                String sql = "SELECT * FROM tbl_dea_cust";
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
        public bool Insert(deacustBLL dc)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO tbl_dea_cust (type , name ,email , contact , address ,added_date, added_by) VALUES (@type, @name, @email , @contact , @address , @added_date, @added_by) ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
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
        public bool Update(deacustBLL dc)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE tbl_dea_cust SET type=@type , name=@name ,email=@email , contact=@contact , address =@address ,added_date= @added_date,added_by =@added_by WHERE id=@id ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);
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
        public bool delete(deacustBLL dc)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM tbl_dea_cust WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", dc.id);
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
                String sql = "SELECT * FROM tbl_dea_cust WHERE id like '%" + keyword + "%' OR type like '%" + keyword + "%' OR name like '%" + keyword + "%' OR email like '%" + keyword + "%' OR contact like '%" + keyword + "%' OR name address '%" + keyword + "%'";
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

        #region Search search in  database using keywords for transaction
        public deacustBLL searchdeacustfortransaction(string keyword)
        {
            deacustBLL dc = new deacustBLL();
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            //to hold data from database
            DataTable dt = new DataTable();
            try
            {   //query to get data from database
                String sql = "SELECT name , email , contact , address  FROM tbl_dea_cust WHERE id like '%" + keyword + "%' OR name like '%" + keyword + "%' ";
                //for executing command
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(sql , conn);
                // database connection open
                conn.Open();
                //fill data in our table
                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.address = dt.Rows[0]["address"].ToString();

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
            return dc;
        }

        #endregion
        #region method to get id of dealer or custumor based on name 

        public deacustBLL getdeacustidfromname(string name)
        {
            deacustBLL dc = new deacustBLL();


            SqlConnection conn = new SqlConnection(myconnstring);
            //to hold data from database
            DataTable dt = new DataTable();
            try
            {   //query to get data from database
                String sql = "SELECT id FROM tbl_dea_cust WHERE name ='" + name + "' ";
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
                    dc.id = int.Parse(dt.Rows[0]["id"].ToString());
                    

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
            return dc;
        }



           #endregion


    }

       

 }

