namespace Anystore
{
    partial class frmadmindashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmindashboard));
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.lblfooter = new System.Windows.Forms.Label();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblloginuser = new System.Windows.Forms.Label();
            this.lblappfname = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblshead = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlfooter.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlfooter
            // 
            this.pnlfooter.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlfooter.Controls.Add(this.lblfooter);
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 628);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(1014, 30);
            this.pnlfooter.TabIndex = 0;
            // 
            // lblfooter
            // 
            this.lblfooter.AutoSize = true;
            this.lblfooter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfooter.Location = new System.Drawing.Point(689, 4);
            this.lblfooter.Name = "lblfooter";
            this.lblfooter.Size = new System.Drawing.Size(174, 17);
            this.lblfooter.TabIndex = 1;
            this.lblfooter.Text = "Developed By : H.KARROUM";
            this.lblfooter.Click += new System.EventHandler(this.lblfooter_Click);
            // 
            // menuStripTop
            // 
            this.menuStripTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1014, 24);
            this.menuStripTop.TabIndex = 1;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.userToolStripMenuItem.Text = "Utilisateur";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoryToolStripMenuItem.Text = "Categories";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.productsToolStripMenuItem.Text = "Produits";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.dealerAndCustomerToolStripMenuItem.Text = "Vendors et Clients";
            this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerAndCustomerToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.inventoryToolStripMenuItem.Text = "Stocks";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblUser.Location = new System.Drawing.Point(12, 120);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Utilisateur :";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblloginuser
            // 
            this.lblloginuser.AutoSize = true;
            this.lblloginuser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblloginuser.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblloginuser.Location = new System.Drawing.Point(85, 120);
            this.lblloginuser.Name = "lblloginuser";
            this.lblloginuser.Size = new System.Drawing.Size(0, 17);
            this.lblloginuser.TabIndex = 3;
            // 
            // lblappfname
            // 
            this.lblappfname.AutoSize = true;
            this.lblappfname.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblappfname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblappfname.Location = new System.Drawing.Point(646, 38);
            this.lblappfname.Name = "lblappfname";
            this.lblappfname.Size = new System.Drawing.Size(87, 37);
            this.lblappfname.TabIndex = 4;
            this.lblappfname.Text = "Projet";
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbllname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbllname.Location = new System.Drawing.Point(724, 38);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(50, 37);
            this.lbllname.TabIndex = 5;
            this.lbllname.Text = "C#";
            this.lbllname.Click += new System.EventHandler(this.lbllname_Click);
            // 
            // lblshead
            // 
            this.lblshead.AutoSize = true;
            this.lblshead.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblshead.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblshead.Location = new System.Drawing.Point(578, 75);
            this.lblshead.Name = "lblshead";
            this.lblshead.Size = new System.Drawing.Size(285, 25);
            this.lblshead.TabIndex = 6;
            this.lblshead.Text = "Systeme de Facturation en ligne";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(513, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 381);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(560, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sous la prevision de : Dr oubeda";
            // 
            // frmadmindashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblshead);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lblappfname);
            this.Controls.Add(this.lblloginuser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlfooter);
            this.Controls.Add(this.menuStripTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frmadmindashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmadmindashboard_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlfooter.ResumeLayout(false);
            this.pnlfooter.PerformLayout();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlfooter;
        private Label lblfooter;
        private MenuStrip menuStripTop;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private Label lblUser;
        private Label lblloginuser;
        private Label lblappfname;
        private Label lbllname;
        private Label lblshead;
        private ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}