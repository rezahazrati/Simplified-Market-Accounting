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
    public partial class FrmAddP : Form
    {
        public int typeId = 1; 
        public FrmAddP()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                if(typeId==1)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        PWYBF person = new PWYBF()
                        {
                            Name = textBox1.Text.ToString(),
                            SoldTillNow = 0
                        };
                        db.sellerRepository.Insert(person);
                        db.Save();
                    }
                }
                else if(typeId==2)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        Customers person1 = new Customers()
                        {
                            CustomerName= textBox1.Text.ToString(),
                            BoughtTillNow = 0
                        };
                        db.customerRepository.Insert(person1);
                        db.Save();
                    }
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please enter the name");
            }
        }

        private void FrmAddP_Load(object sender, EventArgs e)
        {

        }
    }
}
