using MarketAccounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAccounting.AdminCoPa
{
    public partial class FrmSorB : Form
    {
        public int typeId = 1;

        public FrmSorB()
        {
            InitializeComponent();
        }

        private void FrmSorB_Load(object sender, EventArgs e)
        {
            if (typeId == 1)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    dgBAS.AutoGenerateColumns = false;
                    dgBAS.DataSource = db.bsRepository.Get(s => s.TypeId == 1);
                }
            }
            else if (typeId == 2)
            {
                this.Text = "Buys";
                using (UnitOfWork db = new UnitOfWork())
                {
                    dgBAS.AutoGenerateColumns = false;
                    dgBAS.DataSource = db.bsRepository.Get(s => s.TypeId == 2);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgBAS.CurrentRow!=null)
            {
                using(UnitOfWork db = new UnitOfWork())
                {
                    db.bsRepository.Delete(int.Parse(dgBAS.CurrentRow.Cells[0].Value.ToString()));
                }
            }
            else
            {
                MessageBox.Show("Slecte something");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
