using MarketAccounting.DataLayer;
using MarketAccounting.DataLayer.Context;
using System;
using System.Windows.Forms;
using ValidationComponents;

namespace MarketAccounting
{
    public partial class FrmChosseProducts : Form
    {
        public int typeId = 0;
        private int x;
        public int total = 0;
        public int number = 0;
        public FrmChosseProducts()
        {
            InitializeComponent();
        }


        private void FrmChosseProducts_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgPr.AutoGenerateColumns = false;
                dgPr.DataSource = db.ProductRepository.GetProductName();
            }
            
        }

        public void bind()
        {
            txtName.Text = "";
            txtNumber.Text = "";
            txtCost.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                Product product = Get(x);
                if (typeId == 1)
                {
                    product.SoldTillNow += int.Parse(txtNumber.Text.ToString());
                }
                else if (typeId == 2)
                {
                    product.BoughtTillNow += int.Parse(txtNumber.Text.ToString());
                }

                if (typeId == 1)
                {

                    total = int.Parse(txtNumber.Text.ToString()) * product.ProductSellCost;
                }
                else if (typeId == 2)
                {

                    total = int.Parse(txtNumber.Text.ToString()) * product.ProductBuyCost;
                }

                number = int.Parse(txtNumber.Text.ToString());
                using (UnitOfWork db = new UnitOfWork())
                {
                    db.productRepository.Update(product);
                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgPr.AutoGenerateColumns = false;
                dgPr.DataSource = db.ProductRepository.GetProductName(txtFilter.Text);

            }
        }

        private void dgPr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgPr.CurrentRow.Cells[1].Value.ToString();
            x = int.Parse(dgPr.CurrentRow.Cells[0].Value.ToString());
            
        }
         public Product Get(int id)
         {
            Product p;
            using (UnitOfWork db = new UnitOfWork())
            {
                p = db.productRepository.GetById(id);
            }
            return p;
         }
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Product product = Get(x);
                if (typeId == 1)
                {
                    txtCost.Text = (int.Parse(txtNumber.Text.ToString()) * product.ProductSellCost).ToString();
                }
                else if (typeId == 2)
                {
                    txtCost.Text = (int.Parse(txtNumber.Text.ToString()) * product.ProductBuyCost).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Please enter the values correctly");
            }
        }
    }
}
