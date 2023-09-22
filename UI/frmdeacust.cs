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
    public partial class frmdeacust : Form
    {
        public frmdeacust()
        {
            InitializeComponent();
        }

        private void pictureboxclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        deacustBLL dc = new deacustBLL();
        deacustDAL dal = new deacustDAL();
        userDAL udal = new userDAL();
        private void btnadd_Click(object sender, EventArgs e)
        {
            dc.type = cmbtype.Text;
            dc.name = txtname.Text;
            dc.email = txtemail.Text;
            dc.contact = txtcontact.Text;
            dc.address = txtaddress.Text;
            dc.added_date = DateTime.Now;
            string loggeduser = frmlogin.loggedin;
            userBLL usr = udal.getidfromusername(loggeduser);
            dc.added_by = usr.id;
            bool success = dal.Insert(dc);
            if (success == true)
            {
                MessageBox.Show("New Dealer OR Customer Inserted Successfuly.");
                clear();
                DataTable dt = dal.Select();
                dgvdeacust.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed To Insert New Dealer OR Customer.");
            }
        }
        public void clear()
        {
            txtdeacustID.Text = "";
            cmbtype.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            txtsearch.Text = "";


        }

        private void frmdeacust_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvdeacust.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            dc.id = Convert.ToInt32(txtdeacustID.Text);
            dc.type = cmbtype.Text;
            dc.name = txtname.Text;
            dc.email = txtemail.Text;
            dc.contact = txtcontact.Text;
            dc.address = txtaddress.Text;
            dc.added_date = DateTime.Now;
            string loggeduser = frmlogin.loggedin;
            userBLL usr = udal.getidfromusername(loggeduser);
            dc.added_by = usr.id;
            //updating data into database


            bool success = dal.Update(dc);
            //if the data updated succefuly the value of succes will be true else it will be false
            if (success == true)
            { // the data updated successfully
                MessageBox.Show("Dealer OR customer Successfully Updated.");
                clear();
                DataTable dt = dal.Select();
            dgvdeacust.DataSource = dt;

            }
            else
            {// failled to update data
                MessageBox.Show("Failed To Update Dealer OR customer.");
            }
            // refreshing Data Grid View
            
        }

        private void dgvdeacust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int rowindex = e.RowIndex;
            txtdeacustID.Text = dgvdeacust.Rows[rowindex].Cells[0].Value.ToString();
            cmbtype.Text = dgvdeacust.Rows[rowindex].Cells[1].Value.ToString();
            txtname.Text = dgvdeacust.Rows[rowindex].Cells[2].Value.ToString();
            txtemail.Text = dgvdeacust.Rows[rowindex].Cells[3].Value.ToString();
            txtcontact.Text = dgvdeacust.Rows[rowindex].Cells[4].Value.ToString();
            txtaddress.Text = dgvdeacust.Rows[rowindex].Cells[5].Value.ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //getting the id of  who i want to delete
            dc.id = Convert.ToInt32(txtdeacustID.Text);
            //Deleting user from database
            bool success = dal.delete(dc);
            //if the data updated succefuly the value of succes will be true else it will be false
            if (success == true)
            { // the data insereted successfully
                MessageBox.Show("Dealer OR customer Successfully Deleted.");
                clear();

            }
            else
            {// failled to update data
                MessageBox.Show("Failed To Delete Dealer OR Customer.");
            }
            // refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvdeacust.DataSource = dt;
        }
    }
}
