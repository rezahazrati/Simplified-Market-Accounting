using MarketAccounting.DataLayer.Context;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MarketAccounting
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgProducts.AutoGenerateColumns = false;
                dgProducts.DataSource = db.productRepository.Get().ToList();
            }
        }

        private void btnDeletetp_Click(object sender, EventArgs e)
        {
            if (dgProducts.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgProducts.CurrentRow.Cells[1].Value.ToString();
                    if (MessageBox.Show($"Are you sure about deleting {name}??", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        int pid = int.Parse(dgProducts.CurrentRow.Cells[0].Value.ToString());
                        db.productRepository.Delete(pid);
                        db.Save();
                    }
                }
                BindGrid();
            }
            else
            {
                MessageBox.Show("Choose something");
            }
        }

        private void btnAddnp_Click(object sender, EventArgs e)
        {
            FrmAddOrEditProduct frmn = new FrmAddOrEditProduct();
            if (frmn.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }


        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgProducts.DataSource = db.productRepository.Get(p => p.ProductName.Contains(toolStripTextBox1.Text)).ToList();
            }
        }

        private void btnChangetp_Click(object sender, EventArgs e)
        {
            if (dgProducts.CurrentRow != null)
            {
                FrmAddOrEditProduct frmc = new FrmAddOrEditProduct();
                frmc.pId = int.Parse(dgProducts.CurrentRow.Cells[0].Value.ToString());
                if (frmc.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("Choose something");
            }
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
