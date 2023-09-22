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
    internal class loginDAL
    {  // stattic string method to connect database
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public bool logincheck(loginBLL l)
        {
            // create a boolean variable and set it's value to false and return it 
            bool issuccess = false;
            // connecting to database 
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            { string sql  = "SELECT * FROM tbl_users WHERE username =@username AND password=@password AND user_type=@user_type";
                // creating sql command to pass value
                SqlCommand cmd =new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
                DataTable dt = new DataTable(); 
                adapter.Fill(dt);   //checking the row in datatable
                if (dt.Rows.Count > 0)
                {  //login successful
                    issuccess = true;

                }
                else
                {  //login failed
                    issuccess = false;
                     }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();   
            }

            return issuccess;
        }

    }
}
