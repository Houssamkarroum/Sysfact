using Anystore.BLL;
using Anystore.DAL;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Anystore.UI
{
    public partial class frmpurchaseandsales : Form
    {
        public frmpurchaseandsales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureboxclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmpurchaseandsales_Load(object sender, EventArgs e)
        {    
            string type = frmuserdashboard.transactiontype;
            lbltop.Text = type;
            transactiondt.Columns.Add("Product Name");
            transactiondt.Columns.Add("Rate");
            transactiondt.Columns.Add("Quantity");
            transactiondt.Columns.Add("Total");
        }
        deacustDAL dcdal = new deacustDAL();
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {   
            string Keyword = txtsearch.Text;
            if(Keyword == "")
            {
                txtname.Text = "";
                txtemail.Text = "";
                txtcontact.Text = "";
                txtaddress.Text = "";
                return;
                
            }
            deacustBLL dc = dcdal.searchdeacustfortransaction(Keyword);
            txtname.Text = dc.name;
            txtemail.Text = dc.email;
            txtcontact.Text = dc.contact;
            txtaddress.Text = dc.address;
        }
        productsDAL pdal =new productsDAL();    
        private void txtseachproduct_TextChanged(object sender, EventArgs e)
        {
            string Keyword = txtseachproduct.Text; 
            if (Keyword == "")
            {
                txtproductname.Text = "";
                txtinventory.Text = "";
                txtrate.Text = "";
                txtqty.Text = "";
                return;

            }
           productsBLL p = pdal.searchproductfortransaction(Keyword);
            txtproductname.Text = p.name;
            txtinventory.Text = p.qty.ToString();
            txtrate.Text = p.rate.ToString();
           
        }
        DataTable transactiondt = new DataTable();
        private void btnadd_Click(object sender, EventArgs e)
        {
            string productname = txtproductname.Text;
            decimal rate = decimal.Parse(txtrate.Text);
            decimal qty = decimal.Parse(txtqty.Text);
            decimal total = rate * qty;
            decimal subtotal = decimal.Parse(txtsubtotal.Text);
            subtotal = subtotal + total;
            if (productname == "")
            {
                MessageBox.Show("SELECT A PRODUCT FIRST ? TRY AGAIN ...");
            }
            else
            {
                transactiondt.Rows.Add(productname, rate, qty , total);
                dgvaddedproducts.DataSource = transactiondt;

                txtsubtotal.Text = subtotal.ToString();

                txtseachproduct.Text = "";
                txtproductname.Text = "";
                txtrate.Text = "0.00";
                txtqty.Text = "0.00";
                txtinventory.Text = "";
                
            }
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            string value = txtdiscount.Text;
            if (value == ""){
                MessageBox.Show("Please ADD DISCOUNT FIRST");
            }
            else
            {
                decimal subtotal = decimal.Parse(txtsubtotal.Text);
                decimal discount = decimal.Parse(txtdiscount.Text);
                decimal grandtotal = ((100-discount)/100) * subtotal;
                txtgrandtotal.Text = grandtotal.ToString(); 
            }
        }

        private void txtvat_TextChanged(object sender, EventArgs e)
        {
            string check = txtgrandtotal.Text;
            if (check == "")
            {
                MessageBox.Show("Calculate the discount and set the grand total first");


            }
            else
            {   decimal previousGT = decimal.Parse(txtgrandtotal.Text);
                decimal vat = decimal.Parse(txtvat.Text);
                decimal grandtotalwithvat = (((100+vat))/100)*previousGT;   

                txtgrandtotal.Text=grandtotalwithvat.ToString();    


            }




        }

        private void txtpaidamount_TextChanged(object sender, EventArgs e)
        {
            decimal grandtotal = decimal.Parse(txtgrandtotal.Text);
            decimal paidamount = decimal.Parse(txtpaidamount.Text);
            decimal returnamount = paidamount - grandtotal ;
            txtreturnamount.Text = returnamount.ToString(); 
        }
        userDAL udal = new userDAL();
        transactionDAL tdal = new transactionDAL();
        transactiondetailDAL tdDAL = new transactiondetailDAL();
        private void button1_Click(object sender, EventArgs e)
        {
            transactionBLL transaction = new transactionBLL();
            transaction.type = lbltop.Text;
            string deacustname = txtname.Text;
            deacustBLL dc = dcdal.getdeacustidfromname(deacustname);

            transaction.dea_cust_id = dc.id;
            transaction.grandtotal = Math.Round(decimal.Parse(txtgrandtotal.Text),2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = decimal.Parse(txtvat.Text);
            transaction.discount = decimal.Parse(txtdiscount.Text);

            string username = frmlogin.loggedin;
            userBLL u = udal.getidfromusername(username);

            transaction.added_by = u.id;

            bool success = false;
            using (TransactionScope scope  = new TransactionScope())
            {
                int transactionID = -1;
                bool w = tdal.Insert_transaction(transaction ,out transactionID);

                for(int i =0; i<transactiondt.Rows.Count; i++)
                {
                    transactiondetailBLL transactiondetail = new transactiondetailBLL();
                    string productname = transactiondt.Rows[i][0].ToString();
                    productsBLL p = pdal.getproductidfromname(productname);
                    transactiondetail.product_id = p.id;
                    transactiondetail.rate = decimal.Parse(transactiondt.Rows[i][1].ToString());
                    transactiondetail.qty = decimal.Parse(transactiondt.Rows[i][2].ToString());
                    transactiondetail.total = Math.Round(decimal.Parse(transactiondt.Rows[i][3].ToString()),2);
                    transactiondetail.dea_cust_id = dc.id;
                    transactiondetail.added_date = DateTime.Now;
                    transaction.added_by = u.id;

                    //here increase or decrease product quality based on purchase or sales 
                    string transactiontype = lbltop.Text;
                    bool x = false;
                    if (productname=="Purchase")
                    {
                       x = pdal.increaseproduct(transactiondetail.product_id, transactiondetail.qty); 
                    }else
                    {
                       x = pdal.decreaseproduct(transactiondetail.product_id, transactiondetail.qty);
                    }








                    // insert data transaction details inside the database
                    bool y = tdDAL.Insert_transactiondetails(transactiondetail);
                     success = w &&  x && y;
                }
               
                if (success = true)
                { // transaction complete
                    scope.Complete();

                    // call to print bill
                    DGVPrinter printer = new DGVPrinter();


                    printer.Title = " \r\n\r\n\r\n\r\n Store de MINI PROJET";
                    printer.SubTitle = "HOUSSAM KARROUM \r\n PHONE: 0606060606\r\n\r\n ";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumberInHeader = false;
                    printer.PageNumbers = true;
                    printer.PorportionalColumns = true; 
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Discount : " + txtdiscount.Text + "% \r\n\r\n" + "VAT : " + txtvat.Text + "%\r\n\r\n" + "Grand Total : " +txtgrandtotal.Text+ "\r\n\r\n" + "NOUS COUS REMERCIER POUR VOTRE COLLABORATION";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(dgvaddedproducts);




                    MessageBox.Show("Transaction Completed Sucessfuly!");
                    dgvaddedproducts.DataSource=null;
                    dgvaddedproducts.Rows.Clear();
                    txtsearch.Text = "";
                    txtname.Text = "";
                    txtemail.Text = "";
                    txtcontact.Text = "";
                    txtaddress.Text = "";
                    txtseachproduct.Text = "";
                    txtproductname.Text = "";
                    txtrate.Text = "0.00";
                    txtqty.Text = "0.00";
                    txtinventory.Text = "00";
                    txtsubtotal.Text = "00";
                    txtdiscount.Text = "00";
                    txtvat.Text = "00";
                    txtgrandtotal.Text = "00.00";
                    txtpaidamount.Text = "00.00";
                    txtreturnamount.Text = "00.00";
                }
                else
                {  // transaction failled
                    MessageBox.Show("Transaction failled!");
                }

            }

        }
    }
}
