using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MarketAccounting.DataLayer.Context;
using System.Text;
using System.Threading.Tasks;
using MarketAccounting.Buisinus;
using System.Windows.Forms;
using MarketAccounting.DataLayer;

namespace MarketAccounting.AdminCoPa
{
    public partial class FrmSeeD : Form
    {
        public int id;
        public FrmSeeD()
        {
            InitializeComponent();
        }

        private void FrmSeeD_Load(object sender, EventArgs e)
        {
            Product product;
            using(UnitOfWork db = new UnitOfWork())
            {
                 product = db.productRepository.GetById(id);
            }
            txtName.Text = product.ProductName;
            txtBC.Text = product.ProductBuyCost.ToString();
            txtSC.Text = product.ProductSellCost.ToString();
            txtBTN.Text = product.BoughtTillNow.ToString();
            txtSTN.Text = product.SoldTillNow.ToString();
            CalB cal = new CalB();
            txtBFTP.Text = cal.Cal(product.ProductId).ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }
    }
}
