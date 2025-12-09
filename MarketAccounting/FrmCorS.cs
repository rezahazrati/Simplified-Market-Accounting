using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MarketAccounting.DataLayer.Context;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAccounting
{
    public partial class FrmCorS : Form
    {
        public FrmCorS()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCorS_Load(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                dgCustomers.AutoGenerateColumns = false;
                dgCustomers.DataSource = db.CustomerRepository.GetCustomerName();
            }
            using (UnitOfWork db = new UnitOfWork())
            {
                dgSellers.AutoGenerateColumns = false;
                dgSellers.DataSource = db.SellerRepository.GetSellerName();
            }
        }

        private void txtFilterC_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomers.AutoGenerateColumns = false;
                dgCustomers.DataSource = db.CustomerRepository.GetCustomerName(txtFilterC.Text.ToString());
            }
        }

        private void txtFilterS_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgSellers.AutoGenerateColumns = false;
                dgSellers.DataSource = db.SellerRepository.GetSellerName(txtFilterS.Text.ToString());
            }
        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            if(dgCustomers.CurrentRow!=null)
            {
                if (MessageBox.Show("Are you sure about delet this person??") == DialogResult.OK) 
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.customerRepository.Delete(int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString()));
                        db.Save();
                    }
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        dgCustomers.AutoGenerateColumns = false;
                        dgCustomers.DataSource = db.CustomerRepository.GetCustomerName();
                    }
                }
            }
        }

        private void btnDeleteS_Click(object sender, EventArgs e)
        {
            if(dgSellers.CurrentRow!=null)
            {
                if(MessageBox.Show("Are you sure about delete this person??")==DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.sellerRepository.Delete(int.Parse(dgSellers.CurrentRow.Cells[0].Value.ToString()));
                        db.Save();
                    }
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        dgSellers.AutoGenerateColumns = false;
                        dgSellers.DataSource = db.SellerRepository.GetSellerName();
                    }
                }
            }
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            FrmAddP frmp = new FrmAddP();
            frmp.typeId = 2;
            if (frmp.ShowDialog() == DialogResult.OK)
            {

                using (UnitOfWork db = new UnitOfWork())
                {
                    dgCustomers.AutoGenerateColumns = false;
                    dgCustomers.DataSource = db.CustomerRepository.GetCustomerName();
                }
            }
        }

        private void btnAddS_Click(object sender, EventArgs e)
        {
            FrmAddP frmp = new FrmAddP();
            if (frmp.ShowDialog() == DialogResult.OK)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    dgSellers.AutoGenerateColumns = false;
                    dgSellers.DataSource = db.SellerRepository.GetSellerName();
                }
            }
        }

        private void btnSeeDetailC_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {
                FrmSeePD frm = new FrmSeePD();
                frm.type = 2;
                frm.id = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                frm.ShowDialog();
            }
        }

        private void btnSeeDetailS_Click(object sender, EventArgs e)
        {
            if(dgSellers.CurrentRow!=null)
            {
                FrmSeePD frm = new FrmSeePD();
                frm.type = 1;
                frm.id = int.Parse(dgSellers.CurrentRow.Cells[0].Value.ToString());
                frm.ShowDialog();
            }
        }
    }
}
