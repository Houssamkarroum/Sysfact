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
    public partial class frmproducts : Form
    {
        public frmproducts()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureboxclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        categoriesDAL cdal = new categoriesDAL();       
        private void frmproducts_Load(object sender, EventArgs e)
        {
            DataTable categoriesDT = cdal.Select();
            cmbcategory.DataSource = categoriesDT;
            cmbcategory.DisplayMember = "title";
            cmbcategory.ValueMember = "title";
            cmbcategory.Text = "";
            DataTable dt = pdal.Select();
            dgvproduct.DataSource = dt;
        }
        productsBLL p = new productsBLL();
        productsDAL pdal = new productsDAL();
        userDAL udal = new userDAL();
        private void btnadd_Click(object sender, EventArgs e)
        {
            p.name = txtname.Text;
            p.category = cmbcategory.Text;
            p.description = txtdescription.Text;
            p.rate = decimal.Parse(txtrate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;
            string loggeduser = frmlogin.loggedin;
            userBLL usr = udal.getidfromusername(loggeduser);
            p.added_by = usr.id;
            bool success = pdal.Insert(p);
            if (success == true)
            {
                MessageBox.Show("New Product Inserted Successfuly.");
                clear();
                DataTable dt = pdal.Select();
                dgvproduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed To Insert New Product.");
            }
        }

        public void clear()
        {
            txtname.Text = "";
            txtdescription.Text = "";
            txtrate.Text = "";
            cmbcategory.Text = "";
            txtsearch.Text = "";


        }

        private void dgvproduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtproductid.Text = dgvproduct.Rows[rowindex].Cells[0].Value.ToString();
            txtname.Text = dgvproduct.Rows[rowindex].Cells[1].Value.ToString();
            cmbcategory.Text = dgvproduct.Rows[rowindex].Cells[2].Value.ToString();
            txtdescription.Text = dgvproduct.Rows[rowindex].Cells[3].Value.ToString();
            txtrate.Text = dgvproduct.Rows[rowindex].Cells[4].Value.ToString();
            
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            p.id = Convert.ToInt32(txtproductid.Text);
            p.name = txtname.Text;
            p.description = txtdescription.Text;
            p.added_date = DateTime.Now;
            p.rate = decimal.Parse(txtrate.Text);
            p.category=cmbcategory.Text;
            p.qty = 0;
            string loggeduser = frmlogin.loggedin;
            userBLL usr = udal.getidfromusername(loggeduser);
            p.added_by = usr.id;
            //updating data into database


            bool success = pdal.Update(p);
            //if the data updated succefuly the value of succes will be true else it will be false
            if (success == true)
            { // the data updated successfully
                MessageBox.Show("Product Successfully Updated.");
                clear();

            }
            else
            {// failled to update data
                MessageBox.Show("Failed To Update Product.");
            }
            // refreshing Data Grid View
            DataTable dt = pdal.Select();
            dgvproduct.DataSource = dt;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //getting the id of user who i want to delete
            p.id = Convert.ToInt32(txtproductid.Text);
            //Deleting user from database
            bool success = pdal.delete(p);
            //if the data updated succefuly the value of succes will be true else it will be false
            if (success == true)
            { // the data insereted successfully
                MessageBox.Show("Product Successfully Deleted.");
                clear();

            }
            else
            {// failled to update data
                MessageBox.Show("Failed To Delete Product.");
            }
            // refreshing Data Grid View
            DataTable dt = pdal.Select();
            dgvproduct.DataSource = dt;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //get the keyword from text box 
            string keyword = txtsearch.Text;
            // check if the keyword has value or not
            if (keyword != null)
            { // show the user based on keyword
                DataTable dt = pdal.search(keyword);
                dgvproduct.DataSource = dt;
            }
            else
            {// Show all users from the database
                DataTable dt = pdal.Select();
                dgvproduct.DataSource = dt;
            }
        }
    }
}
