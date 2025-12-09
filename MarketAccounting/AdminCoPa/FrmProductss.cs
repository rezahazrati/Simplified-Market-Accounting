using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MarketAccounting.DataLayer.Context;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAccounting.AdminCoPa
{
    public partial class FrmProductss : Form
    {
        public FrmProductss()
        {
            InitializeComponent();
        }

        private void btnSeeD_Click(object sender, EventArgs e)
        {
            if (dgProducts.CurrentRow != null)
            {
                FrmSeeD frmc = new FrmSeeD();
                frmc.id = int.Parse(dgProducts.CurrentRow.Cells[0].Value.ToString());
                frmc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose something");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FrmProductss_Load(object sender, EventArgs e)
        {
           using(UnitOfWork db = new UnitOfWork())
           {
                dgProducts.AutoGenerateColumns = false;
                dgProducts.DataSource = db.productRepository.Get();
           }
             
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgProducts.AutoGenerateColumns = false;
                dgProducts.DataSource = db.productRepository.Get(p=> p.ProductName.Contains(txtSearch.Text));
            }
        }
    }
}
