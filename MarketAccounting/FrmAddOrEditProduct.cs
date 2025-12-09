using MarketAccounting.DataLayer;
using MarketAccounting.DataLayer.Context;
using System;
using System.Windows.Forms;

namespace MarketAccounting
{
    public partial class FrmAddOrEditProduct : Form
    {
        public int pId = 0;
        public FrmAddOrEditProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBC.Text != "" && txtPN.Text != "" && txtSC.Text != "")
            {
                if (pId == 0)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        Product product = new Product();
                        product.ProductName = txtPN.Text;
                        product.ProductBuyCost = int.Parse(txtBC.Text.ToString());
                        product.ProductSellCost = int.Parse(txtSC.Text.ToString());
                        product.SoldTillNow = 0;
                        product.BoughtTillNow = 0;
                        db.productRepository.Insert(product);
                        db.Save();
                    }
                }
                else
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        Product product = new Product();
                        product.ProductName = txtPN.Text;
                        product.ProductId = pId;
                        product.ProductBuyCost = int.Parse(txtBC.Text.ToString());
                        product.ProductSellCost = int.Parse(txtSC.Text.ToString());
                        db.productRepository.Update(product);
                        db.Save();
                    }
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Fill the blanks");
            }
        }

        private void FrmAddOrEditProduct_Load(object sender, EventArgs e)
        {
            if (pId != 0)
            {
                this.Text = "Change a product";
                btnAdd.Text = "Change";
                using(UnitOfWork db = new UnitOfWork())
                {
                    var product = db.productRepository.GetById(pId);
                    txtPN.Text = product.ProductName;
                    txtBC.Text = product.ProductBuyCost.ToString();
                    txtSC.Text = product.ProductSellCost.ToString();
                }
            }
        }
    }
}

