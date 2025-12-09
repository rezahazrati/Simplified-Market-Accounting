namespace MarketAccounting
{
    partial class FrmCorS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeeDetailC = new System.Windows.Forms.Button();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterC = new System.Windows.Forms.TextBox();
            this.btnDeleteC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeeDetailS = new System.Windows.Forms.Button();
            this.dgSellers = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterS = new System.Windows.Forms.TextBox();
            this.btnDeleteS = new System.Windows.Forms.Button();
            this.btnAddS = new System.Windows.Forms.Button();
            this.btnAddC = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSellers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddC);
            this.groupBox1.Controls.Add(this.btnSeeDetailC);
            this.groupBox1.Controls.Add(this.dgCustomers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFilterC);
            this.groupBox1.Controls.Add(this.btnDeleteC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSeeDetailC
            // 
            this.btnSeeDetailC.Location = new System.Drawing.Point(269, 48);
            this.btnSeeDetailC.Name = "btnSeeDetailC";
            this.btnSeeDetailC.Size = new System.Drawing.Size(50, 313);
            this.btnSeeDetailC.TabIndex = 6;
            this.btnSeeDetailC.Text = "see \r\ndetail";
            this.btnSeeDetailC.UseVisualStyleBackColor = true;
            this.btnSeeDetailC.Click += new System.EventHandler(this.btnSeeDetailC_Click);
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToAddRows = false;
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dgCustomers.Location = new System.Drawing.Point(6, 48);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.Size = new System.Drawing.Size(257, 313);
            this.dgCustomers.TabIndex = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "CustomerId";
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "CustomerName";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search :";
            // 
            // txtFilterC
            // 
            this.txtFilterC.Location = new System.Drawing.Point(135, 22);
            this.txtFilterC.Name = "txtFilterC";
            this.txtFilterC.Size = new System.Drawing.Size(184, 20);
            this.txtFilterC.TabIndex = 3;
            this.txtFilterC.TextChanged += new System.EventHandler(this.txtFilterC_TextChanged);
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.Location = new System.Drawing.Point(6, 19);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteC.TabIndex = 0;
            this.btnDeleteC.Text = "Delete";
            this.btnDeleteC.UseVisualStyleBackColor = true;
            this.btnDeleteC.Click += new System.EventHandler(this.btnDeleteC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddS);
            this.groupBox2.Controls.Add(this.btnSeeDetailS);
            this.groupBox2.Controls.Add(this.dgSellers);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFilterS);
            this.groupBox2.Controls.Add(this.btnDeleteS);
            this.groupBox2.Location = new System.Drawing.Point(343, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 399);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sellers";
            // 
            // btnSeeDetailS
            // 
            this.btnSeeDetailS.Location = new System.Drawing.Point(283, 54);
            this.btnSeeDetailS.Name = "btnSeeDetailS";
            this.btnSeeDetailS.Size = new System.Drawing.Size(50, 307);
            this.btnSeeDetailS.TabIndex = 7;
            this.btnSeeDetailS.Text = "see \r\ndetail";
            this.btnSeeDetailS.UseVisualStyleBackColor = true;
            this.btnSeeDetailS.Click += new System.EventHandler(this.btnSeeDetailS_Click);
            // 
            // dgSellers
            // 
            this.dgSellers.AllowUserToAddRows = false;
            this.dgSellers.AllowUserToDeleteRows = false;
            this.dgSellers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSellers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.sname});
            this.dgSellers.Location = new System.Drawing.Point(6, 54);
            this.dgSellers.Name = "dgSellers";
            this.dgSellers.ReadOnly = true;
            this.dgSellers.Size = new System.Drawing.Size(271, 307);
            this.dgSellers.TabIndex = 4;
            // 
            // sid
            // 
            this.sid.DataPropertyName = "SellerId";
            this.sid.HeaderText = "Column1";
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            this.sid.Visible = false;
            // 
            // sname
            // 
            this.sname.DataPropertyName = "SellerName";
            this.sname.HeaderText = "name";
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search :";
            // 
            // txtFilterS
            // 
            this.txtFilterS.Location = new System.Drawing.Point(140, 20);
            this.txtFilterS.Name = "txtFilterS";
            this.txtFilterS.Size = new System.Drawing.Size(192, 20);
            this.txtFilterS.TabIndex = 2;
            this.txtFilterS.TextChanged += new System.EventHandler(this.txtFilterS_TextChanged);
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.Location = new System.Drawing.Point(6, 20);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteS.TabIndex = 1;
            this.btnDeleteS.Text = "Delete";
            this.btnDeleteS.UseVisualStyleBackColor = true;
            this.btnDeleteS.Click += new System.EventHandler(this.btnDeleteS_Click);
            // 
            // btnAddS
            // 
            this.btnAddS.Location = new System.Drawing.Point(6, 370);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(326, 23);
            this.btnAddS.TabIndex = 8;
            this.btnAddS.Text = "Add";
            this.btnAddS.UseVisualStyleBackColor = true;
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
            // 
            // btnAddC
            // 
            this.btnAddC.Location = new System.Drawing.Point(6, 370);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(313, 23);
            this.btnAddC.TabIndex = 9;
            this.btnAddC.Text = "Add";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // FrmCorS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCorS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customers and Sellers";
            this.Load += new System.EventHandler(this.FrmCorS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSellers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeeDetailC;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterC;
        private System.Windows.Forms.Button btnDeleteC;
        private System.Windows.Forms.Button btnSeeDetailS;
        private System.Windows.Forms.DataGridView dgSellers;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterS;
        private System.Windows.Forms.Button btnDeleteS;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.Button btnAddS;
    }
}