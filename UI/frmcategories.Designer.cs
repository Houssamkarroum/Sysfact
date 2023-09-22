namespace Anystore.UI
{
    partial class frmcategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcategories));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureboxclose = new System.Windows.Forms.PictureBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtcategoryid = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvcategories = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategories)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(895, 30);
            this.panel1.TabIndex = 1;
            // 
            // pictureboxclose
            // 
            this.pictureboxclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxclose.Image")));
            this.pictureboxclose.Location = new System.Drawing.Point(869, 3);
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
            this.lbltop.Location = new System.Drawing.Point(405, 5);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(99, 21);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "CATEGORIES";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcategory.Location = new System.Drawing.Point(28, 67);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(87, 17);
            this.lblcategory.TabIndex = 2;
            this.lblcategory.Text = "Categories ID";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldescription.Location = new System.Drawing.Point(28, 237);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(74, 17);
            this.lbldescription.TabIndex = 3;
            this.lbldescription.Text = "Description";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.Location = new System.Drawing.Point(28, 152);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(34, 17);
            this.lbltitle.TabIndex = 4;
            this.lbltitle.Text = "Titre";
            // 
            // txtcategoryid
            // 
            this.txtcategoryid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcategoryid.Location = new System.Drawing.Point(146, 68);
            this.txtcategoryid.Name = "txtcategoryid";
            this.txtcategoryid.ReadOnly = true;
            this.txtcategoryid.Size = new System.Drawing.Size(180, 25);
            this.txtcategoryid.TabIndex = 5;
            // 
            // txttitle
            // 
            this.txttitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttitle.Location = new System.Drawing.Point(146, 152);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(180, 25);
            this.txttitle.TabIndex = 6;
            this.txttitle.TextChanged += new System.EventHandler(this.txttitle_TextChanged);
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdescription.Location = new System.Drawing.Point(146, 237);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(180, 76);
            this.txtdescription.TabIndex = 7;
            this.txtdescription.TextChanged += new System.EventHandler(this.txtdescription_TextChanged);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DarkRed;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(546, 363);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 30);
            this.btndelete.TabIndex = 36;
            this.btndelete.Text = "SUPPRIMER";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Chartreuse;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnupdate.Location = new System.Drawing.Point(392, 363);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(112, 30);
            this.btnupdate.TabIndex = 35;
            this.btnupdate.Text = "MODIFIER";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnadd.Location = new System.Drawing.Point(239, 363);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 30);
            this.btnadd.TabIndex = 34;
            this.btnadd.Text = "AJOUTER";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvcategories
            // 
            this.dgvcategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategories.Location = new System.Drawing.Point(405, 107);
            this.dgvcategories.Name = "dgvcategories";
            this.dgvcategories.RowTemplate.Height = 25;
            this.dgvcategories.Size = new System.Drawing.Size(478, 206);
            this.dgvcategories.TabIndex = 37;
            this.dgvcategories.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcategories_RowHeaderMouseClick);
            // 
            // txtsearch
            // 
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsearch.Location = new System.Drawing.Point(477, 68);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(406, 25);
            this.txtsearch.TabIndex = 39;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsearch.Location = new System.Drawing.Point(405, 68);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(66, 17);
            this.lblsearch.TabIndex = 38;
            this.lblsearch.Text = "Recercher";
            // 
            // frmcategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(895, 434);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.dgvcategories);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtcategoryid);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcategories";
            this.Load += new System.EventHandler(this.frmcategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureboxclose;
        private Label lbltop;
        private Label lblcategory;
        private Label lbldescription;
        private Label lbltitle;
        private TextBox txtcategoryid;
        private TextBox txttitle;
        private TextBox txtdescription;
        private Button btndelete;
        private Button btnupdate;
        private Button btnadd;
        private DataGridView dgvcategories;
        private TextBox txtsearch;
        private Label lblsearch;
    }
}