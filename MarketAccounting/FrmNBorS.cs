using System;
using System.Collections.Generic;
using System.ComponentModel;
using MarketAccounting.ViewModels;
using System.Data;
using MarketAccounting.DataLayer.Context;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketAccounting.DataLayer;
using ValidationComponents;

namespace MarketAccounting
{
    public partial class FrmNBorS : Form
    {
        private int x;
        List<Prod> pr = new List<Prod>();
        public int typeId = 2;
        public int n = 0;
        public int t = 0;
        public FrmNBorS()
        {
            InitializeComponent();
        }

        private void FrmNBorS_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgPr.AutoGenerateColumns = false;
                dgPr.DataSource = db.ProductRepository.GetProductName();
            }
            if (typeId == 1)
            {
                this.Text = "Sell";
                tabPage2.Text = "Sell detail";
            }
            List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
            list.Add(new ListCustomerViewModel()
            {
                CustomerId = 0,
                CustomerName = "Unknow"
            });
            List<ListSellerViewModel> list1 = new List<ListSellerViewModel>();
            list1.Add(new ListSellerViewModel()
            {
                SellerId = 0,
                SellerName = "Unknow"
            });
            if (typeId == 1)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    list.AddRange(db.CustomerRepository.GetCustomerName());
                }
                cbCorS.DataSource = list;
                cbCorS.DisplayMember = "CustomerName";
                cbCorS.ValueMember = "CustomerId";
            }
            else if (typeId == 2)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    list1.AddRange(db.SellerRepository.GetSellerName());
                }
                cbCorS.DataSource = list1;
                cbCorS.DisplayMember = "SellerName";
                cbCorS.ValueMember = "SellerId";
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

        private void dgPr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgPr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgPr.CurrentRow.Cells[1].Value.ToString();
            x = int.Parse(dgPr.CurrentRow.Cells[0].Value.ToString());
        }
        private void Bind()
        {
            dgPrr.AutoGenerateColumns = false;

            dgPrr.DataSource = pr;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Bind();
        }

        private void dgPrr_MouseHover(object sender, EventArgs e)
        {
            Bind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                Product product;
                using (UnitOfWork db = new UnitOfWork())
                {
                    product = Get(x);
                }

                Prod p = new Prod();
                p.productId = product.ProductId;
                p.numberOfPro = int.Parse(txtNumber.Text.ToString());
                p.productName = txtName.Text;
                if (typeId == 1)
                {
                    p.totalcost = (int.Parse(txtNumber.Text.ToString())) * (product.ProductSellCost);
                }
                else if (typeId == 2)
                {
                    p.totalcost = (int.Parse(txtNumber.Text.ToString())) * (product.ProductBuyCost);
                }
                pr.Add(p);
                t += p.totalcost;
                n += int.Parse(txtNumber.Text.ToString());
                txtNumberOfProducts.Text = n.ToString();
                txtTotalcost.Text = t.ToString();
                Bind();
                txtName.Text = "";
                txtNumber.Text = "";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            foreach (Prod p in pr)
            {
                Product product;
                using (UnitOfWork db = new UnitOfWork())
                {
                    product = db.productRepository.GetById(p.productId);
                }
                if (typeId == 2)
                {
                    product.BoughtTillNow += p.numberOfPro;
                }
                else if (typeId == 1)
                {
                    product.SoldTillNow += p.numberOfPro;
                }
                using (UnitOfWork db = new UnitOfWork())
                {
                    db.productRepository.Update(product);
                    db.Save();
                }
            }
            if ((int)cbCorS.SelectedValue != 0)
            {
                if (typeId == 1)
                {
                    Customers customer;
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        customer = db.customerRepository.GetById((int)cbCorS.SelectedValue);
                    }
                    customer.BoughtTillNow += int.Parse(txtNumberOfProducts.Text.ToString());
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.customerRepository.Update(customer);
                        db.Save();
                    }
                }
                else if (typeId == 2)
                {
                    PWYBF seller;
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        seller = db.sellerRepository.GetById((int)cbCorS.SelectedValue);
                    }
                    seller.SoldTillNow += int.Parse(txtNumberOfProducts.Text.ToString());
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.sellerRepository.Update(seller);
                        db.Save();
                    }
                }
            }
            using (UnitOfWork db = new UnitOfWork())
            {
                SlAndBu neew = new DataLayer.SlAndBu();
                neew.DateTime = DateTime.Now;
                neew.NumberOfProduct = int.Parse(txtNumberOfProducts.Text.ToString());
                neew.TotalCost = int.Parse(txtTotalcost.Text.ToString());
                neew.TypeId = typeId;
                neew.NameOfCustomer = cbCorS.Text;
                db.bsRepository.Insert(neew);
                db.Save();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
