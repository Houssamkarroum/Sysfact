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
    public partial class frminventory : Form
    {
        public frminventory()
        {
            InitializeComponent();
        }

        private void pictureboxclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        categoriesDAL cdal = new categoriesDAL();
        productsDAL pdal = new productsDAL();
        private void frminventory_Load(object sender, EventArgs e)
        {
            DataTable cdt = cdal.Select();
            cmbcategories.DataSource = cdt;
            cmbcategories.DisplayMember = "title";
            cmbcategories.ValueMember = "title";
            DataTable pdt = pdal.Select();
            dgvproduct.DataSource = pdt;
        }

        private void cmbcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbcategories.Text;
            DataTable dt = pdal.displayproductbycategorie(category);
            dgvproduct.DataSource = dt;
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            dgvproduct.DataSource = dt;
        }
    }
}
