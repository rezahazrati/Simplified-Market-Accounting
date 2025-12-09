namespace MarketAccounting.AdminCoPa
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnProduct = new System.Windows.Forms.ToolStripButton();
            this.btnBuys = new System.Windows.Forms.ToolStripButton();
            this.btnSells = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProduct,
            this.btnBuys,
            this.btnSells});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(677, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnProduct
            // 
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(58, 51);
            this.btnProduct.Text = "Products";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnBuys
            // 
            this.btnBuys.Image = ((System.Drawing.Image)(resources.GetObject("btnBuys.Image")));
            this.btnBuys.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBuys.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuys.Name = "btnBuys";
            this.btnBuys.Size = new System.Drawing.Size(36, 51);
            this.btnBuys.Text = "Buys";
            this.btnBuys.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuys.Click += new System.EventHandler(this.btnBuys_Click);
            // 
            // btnSells
            // 
            this.btnSells.Image = ((System.Drawing.Image)(resources.GetObject("btnSells.Image")));
            this.btnSells.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSells.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSells.Name = "btnSells";
            this.btnSells.Size = new System.Drawing.Size(36, 51);
            this.btnSells.Text = "Sells";
            this.btnSells.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSells.Click += new System.EventHandler(this.btnSells_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 235);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(524, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 180);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 304);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Control Panel";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnProduct;
        private System.Windows.Forms.ToolStripButton btnBuys;
        private System.Windows.Forms.ToolStripButton btnSells;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}