using MarketAccounting.DataLayer.Context;
using System;
using System.Windows.Forms;

namespace MarketAccounting
{
    public partial class FrmNewSOrB : Form
    {
        public int typeId = 1;
        public int total = 0;
        public int number = 0;
        public FrmNewSOrB()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmNewSOrB_Load(object sender, EventArgs e)
        {
            if (typeId == 2)
            {
                this.Text = "New Buy";
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            bool isc = true;
            FrmChosseProducts frmc = new FrmChosseProducts();
            while (isc)
            {
                frmc.typeId = typeId;
                if (frmc.ShowDialog() == DialogResult.OK)
                {
                    if (txtNumberOfProducts.Text == "" || txtTotalcost.Text == "")
                    {
                        txtNumberOfProducts.Text = frmc.number.ToString();
                        txtTotalcost.Text = frmc.total.ToString();
                    }
                    else
                    {
                        txtNumberOfProducts.Text = (int.Parse(txtNumberOfProducts.Text.ToString()) + frmc.number).ToString();
                        txtTotalcost.Text = (int.Parse(txtTotalcost.Text.ToString()) + frmc.total).ToString();
                    }
                }

                if (MessageBox.Show("Do you want another product ? ", "??", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    isc = false;
                }
                frmc.bind();
            }


        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNumberOfProducts.Text != "" && txtTotalcost.Text != "")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    DataLayer.SlAndBu neew = new DataLayer.SlAndBu();
                    neew.DateTime = DateTime.Now;
                    neew.NumberOfProduct = int.Parse(txtNumberOfProducts.Text.ToString());
                    neew.TotalCost = int.Parse(txtTotalcost.Text.ToString());
                    neew.TypeId = typeId;
                    db.bsRepository.Insert(neew);
                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please choose a product");
            }
        }
    }
}

