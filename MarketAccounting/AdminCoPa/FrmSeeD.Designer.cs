namespace MarketAccounting.AdminCoPa
{
    partial class FrmSeeD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSC = new System.Windows.Forms.TextBox();
            this.txtBC = new System.Windows.Forms.TextBox();
            this.txtBTN = new System.Windows.Forms.TextBox();
            this.txtSTN = new System.Windows.Forms.TextBox();
            this.txtBFTP = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBFTP);
            this.groupBox1.Controls.Add(this.txtSTN);
            this.groupBox1.Controls.Add(this.txtBTN);
            this.groupBox1.Controls.Add(this.txtBC);
            this.groupBox1.Controls.Add(this.txtSC);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buy Cost :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sell Cost :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bought till now :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sold till now :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Benefits from this product :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 34);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(310, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtSC
            // 
            this.txtSC.Location = new System.Drawing.Point(59, 89);
            this.txtSC.Name = "txtSC";
            this.txtSC.ReadOnly = true;
            this.txtSC.Size = new System.Drawing.Size(304, 20);
            this.txtSC.TabIndex = 7;
            // 
            // txtBC
            // 
            this.txtBC.Location = new System.Drawing.Point(59, 60);
            this.txtBC.Name = "txtBC";
            this.txtBC.ReadOnly = true;
            this.txtBC.Size = new System.Drawing.Size(304, 20);
            this.txtBC.TabIndex = 8;
            // 
            // txtBTN
            // 
            this.txtBTN.Location = new System.Drawing.Point(94, 112);
            this.txtBTN.Name = "txtBTN";
            this.txtBTN.ReadOnly = true;
            this.txtBTN.Size = new System.Drawing.Size(269, 20);
            this.txtBTN.TabIndex = 9;
            // 
            // txtSTN
            // 
            this.txtSTN.Location = new System.Drawing.Point(81, 144);
            this.txtSTN.Name = "txtSTN";
            this.txtSTN.ReadOnly = true;
            this.txtSTN.Size = new System.Drawing.Size(282, 20);
            this.txtSTN.TabIndex = 10;
            this.txtSTN.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtBFTP
            // 
            this.txtBFTP.Location = new System.Drawing.Point(144, 171);
            this.txtBFTP.Name = "txtBFTP";
            this.txtBFTP.ReadOnly = true;
            this.txtBFTP.Size = new System.Drawing.Size(219, 20);
            this.txtBFTP.TabIndex = 11;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 220);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(369, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmSeeD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 244);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSeeD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "See Details";
            this.Load += new System.EventHandler(this.FrmSeeD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBFTP;
        private System.Windows.Forms.TextBox txtSTN;
        private System.Windows.Forms.TextBox txtBTN;
        private System.Windows.Forms.TextBox txtBC;
        private System.Windows.Forms.TextBox txtSC;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
    }
}