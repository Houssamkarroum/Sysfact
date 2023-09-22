namespace Anystore.UI
{
    partial class frmpurchaseandsales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpurchaseandsales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureboxclose = new System.Windows.Forms.PictureBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.pnldeacust = new System.Windows.Forms.Panel();
            this.dtpbilldate = new System.Windows.Forms.DateTimePicker();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblnam = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldeacusttitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtinventory = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtseachproduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.lblinventory = new System.Windows.Forms.Label();
            this.lblrate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblproducttitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvaddedproducts = new System.Windows.Forms.DataGridView();
            this.lbldgvttitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlcalculation = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtreturnamount = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcalculationtitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxclose)).BeginInit();
            this.pnldeacust.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaddedproducts)).BeginInit();
            this.pnlcalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureboxclose);
            this.panel1.Controls.Add(this.lbltop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 30);
            this.panel1.TabIndex = 4;
            // 
            // pictureboxclose
            // 
            this.pictureboxclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxclose.Image")));
            this.pictureboxclose.Location = new System.Drawing.Point(1150, 3);
            this.pictureboxclose.Name = "pictureboxclose";
            this.pictureboxclose.Size = new System.Drawing.Size(22, 22);
            this.pictureboxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxclose.TabIndex = 1;
            this.pictureboxclose.TabStop = false;
            this.pictureboxclose.Click += new System.EventHandler(this.pictureboxclose_Click);
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltop.Location = new System.Drawing.Point(528, 4);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(128, 21);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "ACHAT ET VENTE";
            // 
            // pnldeacust
            // 
            this.pnldeacust.Controls.Add(this.dtpbilldate);
            this.pnldeacust.Controls.Add(this.txtaddress);
            this.pnldeacust.Controls.Add(this.txtemail);
            this.pnldeacust.Controls.Add(this.txtname);
            this.pnldeacust.Controls.Add(this.txtcontact);
            this.pnldeacust.Controls.Add(this.txtsearch);
            this.pnldeacust.Controls.Add(this.lbladdress);
            this.pnldeacust.Controls.Add(this.label4);
            this.pnldeacust.Controls.Add(this.lblemail);
            this.pnldeacust.Controls.Add(this.lblcontact);
            this.pnldeacust.Controls.Add(this.lblnam);
            this.pnldeacust.Controls.Add(this.lblname);
            this.pnldeacust.Controls.Add(this.lbldeacusttitle);
            this.pnldeacust.Location = new System.Drawing.Point(5, 46);
            this.pnldeacust.Name = "pnldeacust";
            this.pnldeacust.Size = new System.Drawing.Size(1164, 100);
            this.pnldeacust.TabIndex = 5;
            // 
            // dtpbilldate
            // 
            this.dtpbilldate.Location = new System.Drawing.Point(957, 29);
            this.dtpbilldate.Name = "dtpbilldate";
            this.dtpbilldate.Size = new System.Drawing.Size(200, 23);
            this.dtpbilldate.TabIndex = 12;
            this.dtpbilldate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtaddress.Location = new System.Drawing.Point(643, 26);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(202, 62);
            this.txtaddress.TabIndex = 11;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtemail.Location = new System.Drawing.Point(357, 26);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(210, 25);
            this.txtemail.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtname.Location = new System.Drawing.Point(91, 63);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(184, 25);
            this.txtname.TabIndex = 9;
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcontact.Location = new System.Drawing.Point(356, 63);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(210, 25);
            this.txtcontact.TabIndex = 8;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsearch.Location = new System.Drawing.Point(91, 29);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(184, 25);
            this.txtsearch.TabIndex = 7;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbladdress.Location = new System.Drawing.Point(579, 29);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(55, 17);
            this.lbladdress.TabIndex = 6;
            this.lbladdress.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(853, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date de Facture";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblemail.Location = new System.Drawing.Point(298, 29);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(39, 17);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Email";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcontact.Location = new System.Drawing.Point(298, 63);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(52, 17);
            this.lblcontact.TabIndex = 3;
            this.lblcontact.Text = "Contact";
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnam.Location = new System.Drawing.Point(12, 63);
            this.lblnam.Name = "lblnam";
            this.lblnam.Size = new System.Drawing.Size(37, 17);
            this.lblnam.TabIndex = 2;
            this.lblnam.Text = "Nom";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblname.Location = new System.Drawing.Point(12, 29);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(73, 17);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Rechercher";
            // 
            // lbldeacusttitle
            // 
            this.lbldeacusttitle.AutoSize = true;
            this.lbldeacusttitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldeacusttitle.Location = new System.Drawing.Point(3, -3);
            this.lbldeacusttitle.Name = "lbldeacusttitle";
            this.lbldeacusttitle.Size = new System.Drawing.Size(162, 17);
            this.lbldeacusttitle.TabIndex = 0;
            this.lbldeacusttitle.Text = "Vendeur et Client Details";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtproductname);
            this.panel2.Controls.Add(this.txtrate);
            this.panel2.Controls.Add(this.txtqty);
            this.panel2.Controls.Add(this.txtinventory);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.txtseachproduct);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblproductname);
            this.panel2.Controls.Add(this.lblqty);
            this.panel2.Controls.Add(this.lblinventory);
            this.panel2.Controls.Add(this.lblrate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblproducttitle);
            this.panel2.Location = new System.Drawing.Point(5, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 74);
            this.panel2.TabIndex = 6;
            // 
            // txtproductname
            // 
            this.txtproductname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtproductname.Location = new System.Drawing.Point(271, 25);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(140, 25);
            this.txtproductname.TabIndex = 46;
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtrate.Location = new System.Drawing.Point(711, 25);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(95, 25);
            this.txtrate.TabIndex = 45;
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtqty.Location = new System.Drawing.Point(884, 25);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(125, 25);
            this.txtqty.TabIndex = 44;
            // 
            // txtinventory
            // 
            this.txtinventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtinventory.Location = new System.Drawing.Point(509, 25);
            this.txtinventory.Name = "txtinventory";
            this.txtinventory.Size = new System.Drawing.Size(145, 25);
            this.txtinventory.TabIndex = 43;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnadd.Location = new System.Drawing.Point(1063, 21);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(87, 31);
            this.btnadd.TabIndex = 42;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtseachproduct
            // 
            this.txtseachproduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtseachproduct.Location = new System.Drawing.Point(91, 25);
            this.txtseachproduct.Name = "txtseachproduct";
            this.txtseachproduct.Size = new System.Drawing.Size(118, 25);
            this.txtseachproduct.TabIndex = 25;
            this.txtseachproduct.TextChanged += new System.EventHandler(this.txtseachproduct_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(298, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 23;
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblproductname.Location = new System.Drawing.Point(222, 22);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(37, 17);
            this.lblproductname.TabIndex = 22;
            this.lblproductname.Text = "Nom";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblqty.Location = new System.Drawing.Point(822, 25);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(57, 17);
            this.lblqty.TabIndex = 17;
            this.lblqty.Text = "Quantité";
            // 
            // lblinventory
            // 
            this.lblinventory.AutoSize = true;
            this.lblinventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblinventory.Location = new System.Drawing.Point(425, 22);
            this.lblinventory.Name = "lblinventory";
            this.lblinventory.Size = new System.Drawing.Size(71, 17);
            this.lblinventory.TabIndex = 16;
            this.lblinventory.Text = "Stocks qtie";
            // 
            // lblrate
            // 
            this.lblrate.AutoSize = true;
            this.lblrate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblrate.Location = new System.Drawing.Point(671, 22);
            this.lblrate.Name = "lblrate";
            this.lblrate.Size = new System.Drawing.Size(34, 17);
            this.lblrate.TabIndex = 15;
            this.lblrate.Text = "Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rechercher";
            // 
            // lblproducttitle
            // 
            this.lblproducttitle.AutoSize = true;
            this.lblproducttitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblproducttitle.Location = new System.Drawing.Point(3, -3);
            this.lblproducttitle.Name = "lblproducttitle";
            this.lblproducttitle.Size = new System.Drawing.Size(130, 17);
            this.lblproducttitle.TabIndex = 13;
            this.lblproducttitle.Text = "l\'intitulé de Produit";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvaddedproducts);
            this.panel3.Controls.Add(this.lbldgvttitle);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(5, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 351);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dgvaddedproducts
            // 
            this.dgvaddedproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvaddedproducts.Location = new System.Drawing.Point(10, 30);
            this.dgvaddedproducts.Name = "dgvaddedproducts";
            this.dgvaddedproducts.RowTemplate.Height = 25;
            this.dgvaddedproducts.Size = new System.Drawing.Size(545, 309);
            this.dgvaddedproducts.TabIndex = 48;
            // 
            // lbldgvttitle
            // 
            this.lbldgvttitle.AutoSize = true;
            this.lbldgvttitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldgvttitle.Location = new System.Drawing.Point(1, -4);
            this.lbldgvttitle.Name = "lbldgvttitle";
            this.lbldgvttitle.Size = new System.Drawing.Size(99, 17);
            this.lbldgvttitle.TabIndex = 47;
            this.lbldgvttitle.Text = "Produit Ajouté";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 47;
            // 
            // pnlcalculation
            // 
            this.pnlcalculation.Controls.Add(this.button1);
            this.pnlcalculation.Controls.Add(this.txtreturnamount);
            this.pnlcalculation.Controls.Add(this.txtsubtotal);
            this.pnlcalculation.Controls.Add(this.txtdiscount);
            this.pnlcalculation.Controls.Add(this.txtvat);
            this.pnlcalculation.Controls.Add(this.txtpaidamount);
            this.pnlcalculation.Controls.Add(this.txtgrandtotal);
            this.pnlcalculation.Controls.Add(this.label11);
            this.pnlcalculation.Controls.Add(this.label10);
            this.pnlcalculation.Controls.Add(this.label9);
            this.pnlcalculation.Controls.Add(this.label8);
            this.pnlcalculation.Controls.Add(this.label7);
            this.pnlcalculation.Controls.Add(this.label3);
            this.pnlcalculation.Controls.Add(this.label2);
            this.pnlcalculation.Controls.Add(this.lblcalculationtitle);
            this.pnlcalculation.Location = new System.Drawing.Point(584, 252);
            this.pnlcalculation.Name = "pnlcalculation";
            this.pnlcalculation.Size = new System.Drawing.Size(585, 351);
            this.pnlcalculation.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(251, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 47;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtreturnamount
            // 
            this.txtreturnamount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtreturnamount.ForeColor = System.Drawing.Color.DarkRed;
            this.txtreturnamount.Location = new System.Drawing.Point(143, 247);
            this.txtreturnamount.Name = "txtreturnamount";
            this.txtreturnamount.ReadOnly = true;
            this.txtreturnamount.Size = new System.Drawing.Size(411, 39);
            this.txtreturnamount.TabIndex = 62;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsubtotal.Location = new System.Drawing.Point(143, 26);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(411, 25);
            this.txtsubtotal.TabIndex = 61;
            this.txtsubtotal.Text = "0";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdiscount.Location = new System.Drawing.Point(143, 68);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(411, 25);
            this.txtdiscount.TabIndex = 60;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // txtvat
            // 
            this.txtvat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtvat.Location = new System.Drawing.Point(143, 112);
            this.txtvat.Name = "txtvat";
            this.txtvat.Size = new System.Drawing.Size(411, 25);
            this.txtvat.TabIndex = 59;
            this.txtvat.TextChanged += new System.EventHandler(this.txtvat_TextChanged);
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpaidamount.Location = new System.Drawing.Point(143, 201);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(411, 25);
            this.txtpaidamount.TabIndex = 58;
            this.txtpaidamount.TextChanged += new System.EventHandler(this.txtpaidamount_TextChanged);
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtgrandtotal.Location = new System.Drawing.Point(143, 156);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.ReadOnly = true;
            this.txtgrandtotal.Size = new System.Drawing.Size(411, 25);
            this.txtgrandtotal.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(21, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "Montant du retour";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(251, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(21, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Montant payé";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(21, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Sub Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Discount (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "VAT (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Grand Total";
            // 
            // lblcalculationtitle
            // 
            this.lblcalculationtitle.AutoSize = true;
            this.lblcalculationtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcalculationtitle.Location = new System.Drawing.Point(3, 0);
            this.lblcalculationtitle.Name = "lblcalculationtitle";
            this.lblcalculationtitle.Size = new System.Drawing.Size(147, 17);
            this.lblcalculationtitle.TabIndex = 49;
            this.lblcalculationtitle.Text = " Details de Calculation";
            // 
            // frmpurchaseandsales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1174, 622);
            this.Controls.Add(this.pnlcalculation);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnldeacust);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmpurchaseandsales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase And Sales";
            this.Load += new System.EventHandler(this.frmpurchaseandsales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxclose)).EndInit();
            this.pnldeacust.ResumeLayout(false);
            this.pnldeacust.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaddedproducts)).EndInit();
            this.pnlcalculation.ResumeLayout(false);
            this.pnlcalculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureboxclose;
        private Label lbltop;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblnam;
        private Panel pnldeacust;
        private Label lblname;
        private Label lbldeacusttitle;
        private Label lbladdress;
        private Label label4;
        private Label lblemail;
        private Label lblcontact;
        private DateTimePicker dtpbilldate;
        private TextBox txtaddress;
        private TextBox txtemail;
        private TextBox txtname;
        private TextBox txtcontact;
        private TextBox txtsearch;
        private TextBox txtseachproduct;
        private Label label6;
        private Label lblproductname;
        private Label lblqty;
        private Label lblinventory;
        private Label lblrate;
        private Label label5;
        private Label lblproducttitle;
        private TextBox txtproductname;
        private TextBox txtrate;
        private TextBox txtqty;
        private TextBox txtinventory;
        private Button btnadd;
        private Panel panel3;
        private DataGridView dgvaddedproducts;
        private Label lbldgvttitle;
        private Label label1;
        private Panel pnlcalculation;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label lblcalculationtitle;
        private Button button1;
        private TextBox txtreturnamount;
        private TextBox txtsubtotal;
        private TextBox txtdiscount;
        private TextBox txtvat;
        private TextBox txtpaidamount;
        private TextBox txtgrandtotal;
        private Label label11;
        private Label label10;
        private Label label9;
    }
}