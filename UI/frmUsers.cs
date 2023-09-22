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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();
        private void pictureboxclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbladdress_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        { 


            // getting dta from UI
            u.first_name = txtfirstname.Text; 
            u.last_name = txtlastname.Text;
            u.email = txtemail.Text;
            u.username = txtusername.Text;
            u.password = txtpassword.Text;
            u.contact = txtcontact.Text;
            u.address = txtaddress.Text;
            u.gender = cmbgender.Text;
            u.user_type = cmbusertype.Text;
            u.added_date = DateTime.Now;
            // getting the username of the logged user
            string loggeduser = frmlogin.loggedin;
            userBLL usr = dal.getidfromusername(loggeduser);
            u.added_by = usr.id;

            // inserting data into database
            bool success = dal.Insert(u);
            //if the data inserted succefuly the value of succes will be true else it will be false
            if(success==true)
            { // the data insereted successfully
                MessageBox.Show("User Successfully Created.");
                clear();

            }
            else
            {// failled to insert data
                MessageBox.Show("Failed To ADD new User.");
            }
            // refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvusers.DataSource = dt;




        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvusers.DataSource = dt;


        }
        private void clear()
        {
            txtuserid.Text = "";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtemail.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            cmbgender.Text = "";
            cmbusertype.Text = "";
        }

        private void dgvusers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // get the index of particular row 
            int rowindex = e.RowIndex;
            txtuserid.Text = dgvusers.Rows[rowindex].Cells[0].Value.ToString();
            txtfirstname.Text = dgvusers.Rows[rowindex].Cells[1].Value.ToString();
            txtlastname.Text = dgvusers.Rows[rowindex].Cells[2].Value.ToString();
            txtemail.Text = dgvusers.Rows[rowindex].Cells[3].Value.ToString();
            txtusername.Text = dgvusers.Rows[rowindex].Cells[4].Value.ToString();
            txtpassword.Text = dgvusers.Rows[rowindex].Cells[5].Value.ToString();
            txtcontact.Text = dgvusers.Rows[rowindex].Cells[6].Value.ToString();
            txtaddress.Text = dgvusers.Rows[rowindex].Cells[7].Value.ToString();
            cmbgender.Text = dgvusers.Rows[rowindex].Cells[8].Value.ToString();
            cmbusertype.Text = dgvusers.Rows[rowindex].Cells[9].Value.ToString();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // get the value from user UI 
            u.id = Convert.ToInt32(txtuserid.Text);
            u.first_name = txtfirstname.Text;
            u.last_name= txtlastname.Text;
            u.email = txtemail.Text;
            u.username = txtusername.Text;
            u.password = txtpassword.Text;
            u.contact = txtcontact.Text;
            u.address= txtaddress.Text;
            u.gender = cmbgender.Text;
            u.user_type = cmbusertype.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            //updating data into database

            bool success = dal.Update(u);
            //if the data updated succefuly the value of succes will be true else it will be false
            if (success == true)
            { // the data updated successfully
                MessageBox.Show("User Successfully Updated.");
                clear();

            }
            else
            {// failled to update data
                MessageBox.Show("Failed To Update User.");
            }
            // refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvusers.DataSource = dt;




        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //getting the id of user who i want to delete
            u.id = Convert.ToInt32(txtuserid.Text);
            //Deleting user from database
            bool success = dal.delete(u);
            //if the data updated succefuly the value of succes will be true else it will be false
            if (success == true)
            { // the data insereted successfully
                MessageBox.Show("User Successfully Deleted.");
                clear();

            }
            else
            {// failled to update data
                MessageBox.Show("Failed To Delete User.");
            }
            // refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvusers.DataSource = dt;

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //get the keyword from text box 
            string keyword = txtsearch.Text;
            // check if the keyword has value or not
            if (keyword != null)
            { // show the user based on keyword
                DataTable dt = dal.search(keyword);
                dgvusers.DataSource=dt;
            }
            else
            {// Show all users from the database
                DataTable dt = dal.Select();
                dgvusers.DataSource = dt;
            }
        }
    }
    }

