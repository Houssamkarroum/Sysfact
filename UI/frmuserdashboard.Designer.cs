namespace Anystore
{
    partial class frmuserdashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuserdashboard));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblloginuser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.lblfooter = new System.Windows.Forms.Label();
            this.dgvtransactions = new System.Windows.Forms.DataGridView();
            this.lbltransactiontype = new System.Windows.Forms.Label();
            this.cmbtransactiontype = new System.Windows.Forms.ComboBox();
            this.btnall = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripTop.SuspendLayout();
            this.pnlfooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(1036, 24);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.purchaseToolStripMenuItem.Text = "Achat";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.salesToolStripMenuItem.Text = "Vente";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.inventoryToolStripMenuItem.Text = "Stocks";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // lblloginuser
            // 
            this.lblloginuser.AutoSize = true;
            this.lblloginuser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblloginuser.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblloginuser.Location = new System.Drawing.Point(51, 138);
            this.lblloginuser.Name = "lblloginuser";
            this.lblloginuser.Size = new System.Drawing.Size(0, 17);
            this.lblloginuser.TabIndex = 8;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblUser.Location = new System.Drawing.Point(12, 138);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 17);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User :";
            // 
            // pnlfooter
            // 
            this.pnlfooter.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlfooter.Controls.Add(this.lblfooter);
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 506);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(1036, 30);
            this.pnlfooter.TabIndex = 12;
            // 
            // lblfooter
            // 
            this.lblfooter.AutoSize = true;
            this.lblfooter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfooter.ForeColor = System.Drawing.Color.White;
            this.lblfooter.Location = new System.Drawing.Point(613, 4);
            this.lblfooter.Name = "lblfooter";
            this.lblfooter.Size = new System.Drawing.Size(174, 17);
            this.lblfooter.TabIndex = 1;
            this.lblfooter.Text = "Developed By : H.KARROUM";
            // 
            // dgvtransactions
            // 
            this.dgvtransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransactions.Location = new System.Drawing.Point(328, 173);
            this.dgvtransactions.Name = "dgvtransactions";
            this.dgvtransactions.RowTemplate.Height = 25;
            this.dgvtransactions.Size = new System.Drawing.Size(791, 278);
            this.dgvtransactions.TabIndex = 13;
            // 
            // lbltransactiontype
            // 
            this.lbltransactiontype.AutoSize = true;
            this.lbltransactiontype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltransactiontype.Location = new System.Drawing.Point(328, 122);
            this.lbltransactiontype.Name = "lbltransactiontype";
            this.lbltransactiontype.Size = new System.Drawing.Size(124, 17);
            this.lbltransactiontype.TabIndex = 14;
            this.lbltransactiontype.Text = "Type de Transaction";
            // 
            // cmbtransactiontype
            // 
            this.cmbtransactiontype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbtransactiontype.FormattingEnabled = true;
            this.cmbtransactiontype.Items.AddRange(new object[] {
            "Purchase",
            "Sales"});
            this.cmbtransactiontype.Location = new System.Drawing.Point(458, 122);
            this.cmbtransactiontype.Name = "cmbtransactiontype";
            this.cmbtransactiontype.Size = new System.Drawing.Size(661, 25);
            this.cmbtransactiontype.TabIndex = 15;
            this.cmbtransactiontype.SelectedIndexChanged += new System.EventHandler(this.cmbtransactiontype_SelectedIndexChanged);
            // 
            // btnall
            // 
            this.btnall.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnall.Location = new System.Drawing.Point(1138, 121);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(131, 25);
            this.btnall.TabIndex = 16;
            this.btnall.Text = "Show All";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmuserdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 536);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnall);
            this.Controls.Add(this.cmbtransactiontype);
            this.Controls.Add(this.lbltransactiontype);
            this.Controls.Add(this.dgvtransactions);
            this.Controls.Add(this.pnlfooter);
            this.Controls.Add(this.lblloginuser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frmuserdashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "table de bord d\'utilisateur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmuserdashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmuserdashboard_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.pnlfooter.ResumeLayout(false);
            this.pnlfooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripTop;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private Label lblloginuser;
        private Label lblUser;
        private Panel pnlfooter;
        private Label lblfooter;
        private ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
        private DataGridView dgvtransactions;
        private Label lbltransactiontype;
        private ComboBox cmbtransactiontype;
        private Button btnall;
        private PictureBox pictureBox1;
    }
}