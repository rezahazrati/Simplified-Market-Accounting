namespace MarketAccounting
{
    partial class FrmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddnp = new System.Windows.Forms.ToolStripButton();
            this.btnChangetp = new System.Windows.Forms.ToolStripButton();
            this.btnDeletetp = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddnp,
            this.btnChangetp,
            this.btnDeletetp,
            this.txtSearch,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(614, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddnp
            // 
            this.btnAddnp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddnp.Image = ((System.Drawing.Image)(resources.GetObject("btnAddnp.Image")));
            this.btnAddnp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddnp.Name = "btnAddnp";
            this.btnAddnp.Size = new System.Drawing.Size(106, 22);
            this.btnAddnp.Text = "Add new product ";
            this.btnAddnp.Click += new System.EventHandler(this.btnAddnp_Click);
            // 
            // btnChangetp
            // 
            this.btnChangetp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnChangetp.Image = ((System.Drawing.Image)(resources.GetObject("btnChangetp.Image")));
            this.btnChangetp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangetp.Name = "btnChangetp";
            this.btnChangetp.Size = new System.Drawing.Size(119, 22);
            this.btnChangetp.Text = "Change this product";
            this.btnChangetp.Click += new System.EventHandler(this.btnChangetp_Click);
            // 
            // btnDeletetp
            // 
            this.btnDeletetp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeletetp.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletetp.Image")));
            this.btnDeletetp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletetp.Name = "btnDeletetp";
            this.btnDeletetp.Size = new System.Drawing.Size(111, 22);
            this.btnDeletetp.Text = "Delete this product";
            this.btnDeletetp.Click += new System.EventHandler(this.btnDeletetp_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(48, 22);
            this.txtSearch.Text = "Search :";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AllowUserToDeleteRows = false;
            this.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.pname,
            this.bcost,
            this.scost});
            this.dgProducts.Location = new System.Drawing.Point(0, 28);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.Size = new System.Drawing.Size(614, 297);
            this.dgProducts.TabIndex = 1;
            this.dgProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducts_CellContentClick);
            // 
            // pid
            // 
            this.pid.DataPropertyName = "ProductId";
            this.pid.HeaderText = "Column1";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            this.pid.Visible = false;
            // 
            // pname
            // 
            this.pname.DataPropertyName = "ProductName";
            this.pname.HeaderText = "Product name";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            // 
            // bcost
            // 
            this.bcost.DataPropertyName = "ProductBuyCost";
            this.bcost.HeaderText = "Buy cost";
            this.bcost.Name = "bcost";
            this.bcost.ReadOnly = true;
            // 
            // scost
            // 
            this.scost.DataPropertyName = "ProductSellCost";
            this.scost.HeaderText = "Sell cost";
            this.scost.Name = "scost";
            this.scost.ReadOnly = true;
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 326);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View and change Products";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddnp;
        private System.Windows.Forms.ToolStripButton btnChangetp;
        private System.Windows.Forms.ToolStripButton btnDeletetp;
        private System.Windows.Forms.ToolStripLabel txtSearch;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn scost;
    }
}