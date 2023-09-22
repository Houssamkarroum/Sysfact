using Anystore.BLL;
using Anystore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anystore.UI
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        loginBLL l =new loginBLL(); 
        loginDAL dal = new loginDAL();
       public  static string loggedin;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            l.username=txtusername.Text.Trim();    
            l.password=txtpassword.Text.Trim();
            l.user_type = cmbusertype.Text.Trim();
            //checking the login credentials
            bool success = dal.logincheck(l);
            if (success == true)
            {
                MessageBox.Show("Login Successful");
                loggedin = l.username;    

                //open respective forms based on user type
                switch (l.user_type)
                { case "Admin":
                        {
                            //display admin dashboard
                            frmadmindashboard admin = new frmadmindashboard();
                            admin.Show();
                            this.Hide();
                            
                        }break;
                  case "User":
                        {
                            frmuserdashboard user = new frmuserdashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            // display an erreur
                            MessageBox.Show("Invalid Type User");
                        }
                        break;

                }
            }
            else
            {
                MessageBox.Show("login failed. Try Again");
            }
        }
    }
}
