using Anystore.DAL;
using Anystore.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anystore
{
    public partial class frmuserdashboard : Form
    {
        public frmuserdashboard()
        {
            InitializeComponent();
        }
        transactionDAL tdal = new transactionDAL();
        private void frmuserdashboard_Load(object sender, EventArgs e)
        {
            lblloginuser.Text = frmlogin.loggedin;


            //display all the transaction 
            //transactionDAL  
            DataTable dt = tdal.displayalltransaction();
            dgvtransactions.DataSource = dt;
        }

        private void frmuserdashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Hide();
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmdeacust deacust = new frmdeacust();
            deacust.Show();
        }
        public static string transactiontype ;
        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {   transactiontype = "Purchase";
            frmpurchaseandsales purchase = new frmpurchaseandsales();
            purchase.Show();
            
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {   transactiontype = "Sales";
            frmpurchaseandsales sales = new frmpurchaseandsales();
            sales.Show();
            
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            DataTable dt = tdal.displayalltransaction();
            dgvtransactions.DataSource = dt;
        }

        private void cmbtransactiontype_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbtransactiontype.Text;
            DataTable dt = tdal.displayalltransactiontype(type);
            dgvtransactions.DataSource = dt;
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frminventory inven = new frminventory();
            inven.Show();
        }
    }
}
