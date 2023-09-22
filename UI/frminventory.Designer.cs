namespace Anystore.UI
{
    partial class frminventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminventory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureboxclose = new System.Windows.Forms.PictureBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.btnall = new System.Windows.Forms.Button();
            this.cmbcategories = new System.Windows.Forms.ComboBox();
            this.lbltransactiontype = new System.Windows.Forms.Label();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
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
            this.panel1.TabIndex = 3;
            // 
            // pictureboxclose
            // 
            this.pictureboxclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxclose.Image")));
            this.pictureboxclose.Location = new System.Drawing.Point(870, 3);
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
            this.lbltop.Size = new System.Drawing.Size(54, 21);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "Stocks";
            // 
            // btnall
            // 
            this.btnall.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnall.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnall.Location = new System.Drawing.Point(712, 76);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(115, 33);
            this.btnall.TabIndex = 20;
            this.btnall.Text = "AFFICHER TOUT";
            this.btnall.UseVisualStyleBackColor = false;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // cmbcategories
            // 
            this.cmbcategories.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbcategories.FormattingEnabled = true;
            this.cmbcategories.Location = new System.Drawing.Point(149, 81);
            this.cmbcategories.Name = "cmbcategories";
            this.cmbcategories.Size = new System.Drawing.Size(528, 25);
            this.cmbcategories.TabIndex = 19;
            this.cmbcategories.SelectedIndexChanged += new System.EventHandler(this.cmbcategories_SelectedIndexChanged);
            // 
            // lbltransactiontype
            // 
            this.lbltransactiontype.AutoSize = true;
            this.lbltransactiontype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltransactiontype.Location = new System.Drawing.Point(64, 82);
            this.lbltransactiontype.Name = "lbltransactiontype";
            this.lbltransactiontype.Size = new System.Drawing.Size(65, 17);
            this.lbltransactiontype.TabIndex = 18;
            this.lbltransactiontype.Text = "Categorie";
            // 
            // dgvproduct
            // 
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(64, 135);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.RowTemplate.Height = 25;
            this.dgvproduct.Size = new System.Drawing.Size(763, 244);
            this.dgvproduct.TabIndex = 17;
            // 
            // frminventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(895, 434);
            this.Controls.Add(this.btnall);
            this.Controls.Add(this.cmbcategories);
            this.Controls.Add(this.lbltransactiontype);
            this.Controls.Add(this.dgvproduct);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frminventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frminventory";
            this.Load += new System.EventHandler(this.frminventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureboxclose;
        private Label lbltop;
        private Button btnall;
        private ComboBox cmbcategories;
        private Label lbltransactiontype;
        private DataGridView dgvproduct;
    }
}