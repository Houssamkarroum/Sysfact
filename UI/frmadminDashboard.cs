using Anystore.UI;
using System.Windows.Forms;
namespace Anystore
{
    public partial class frmadmindashboard : Form
    {
        public frmadmindashboard()
        {
            InitializeComponent();
        }

        private void lblfooter_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblloginuser.Text = frmlogin.loggedin;
        }

        private void lbllname_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers user = new frmUsers();
            user.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcategories category = new frmcategories();
            category.Show();
        }

        private void frmadmindashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Hide();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproducts prod = new frmproducts();
            prod.Show();
            
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdeacust deacust = new frmdeacust();
            deacust.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frminventory inven = new frminventory();
            inven.Show();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}