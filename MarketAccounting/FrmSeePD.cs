using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketAccounting.DataLayer.Context;
using MarketAccounting.DataLayer;

namespace MarketAccounting
{
    public partial class FrmSeePD : Form
    {
        public int type = 1;
        public int id;

        public FrmSeePD()
        {
            InitializeComponent();
        }

        private void FrmSeePD_Load(object sender, EventArgs e)
        {
            using(UnitOfWork db =new UnitOfWork())
            {
                if(type==1)
                {
                    PWYBF seller;

                   seller= db.sellerRepository.GetById(id);
                    txtName.Text = seller.Name;
                    txtBoStn.Text = seller.SoldTillNow.ToString();
                }
                else if(type ==2)
                {
                    Customers customer;
                    customer = db.customerRepository.GetById(id);
                    txtName.Text = customer.CustomerName;
                    txtBoStn.Text = customer.BoughtTillNow.ToString();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            
        }
    }
}
