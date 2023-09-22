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
    public partial class frmcategories : Form
    {
        public frmcategories()
        {
            InitializeComponent();
        }

        private void txtdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureboxclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL(); 
        userDAL udal = new userDAL();   
        private void btnadd_Click(object sender, EventArgs e)
        {
            c.title = txttitle.Text;
            c.description = txtdescription.Text;
            c.added_date = DateTime.Now;
            string loggeduser = frmlogin.loggedin;
            userBLL usr = udal.getidfromusername(loggeduser);
            c.added_by = usr.id;
            bool success = dal.Insert(c);
            if(success== true)
            {
                MessageBox.Show("New Category Inserted Successfuly.");
                clear();
                DataTable dt = dal.Select();
                dgvcategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed To Insert New Category.");
            }
           

        }

        public void clear()
        {
            txtcategoryid.Text = "";
            txttitle.Text = "";
            txtdescription.Text = "";
            txtsearch.Text = "";
            
        }

        private void frmcategories_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvcategories.DataSource = dt;
        }

        private void dgvcategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the index of particular row 
         
           
            
        }

        private void dgvcategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
               int rowindex = e.RowIndex;
            txtcategoryid.Text = dgvcategories.Rows[rowindex].Cells[0].Value.ToString();
            txttitle.Text = dgvcategories.Rows[rowindex].Cells[1].Value.ToString();
            txtdescription.Text = dgvcategories.Rows[rowindex].Cells[2].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            c.id = Convert.ToInt32(txtcategoryid.Text);
            c.title = txttitle.Text;
            c.description = txtdescription.Text;
            c.added_date = DateTime.Now;
            string loggeduser = frmlogin.loggedin;
            userBLL usr = udal.getidfromusername(loggeduser); 
            c.added_by = usr.id;
            //updating data into database

              
            bool success = dal.Update(c);
            //if the data updated succefuly the value of succes will be true else it will be false
            if (success == true)
            { // the data updated successfully
                MessageBox.Show("Category Successfully Updated.");
                clear();

            }
            else
            {// failled to update data
                MessageBox.Show("Failed To Update Category.");
            }
            // refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvcategories.DataSource = dt;




        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //getting the id of user who i want to delete
            c.id = Convert.ToInt32(txtcategoryid.Text);
            //Deleting user from database
            bool success = dal.delete(c);
            //if the data updated succefuly the value of succes will be true else it will be false
            if (success == true)
            { // the data insereted successfully
                MessageBox.Show("Category Successfully Deleted.");
                clear();

            }
            else
            {// failled to update data
                MessageBox.Show("Failed To Delete Category.");
            }
            // refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvcategories.DataSource = dt;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //get the keyword from text box 
            string keyword = txtsearch.Text;
            // check if the keyword has value or not
            if (keyword != null)
            { // show the user based on keyword
                DataTable dt = dal.search(keyword);
                dgvcategories.DataSource = dt;
            }
            else
            {// Show all users from the database
                DataTable dt = dal.Select();
                dgvcategories.DataSource = dt;
            }
        }
    }
}
