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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProductss frmp = new FrmProductss();
            frmp.ShowDialog();
        }

        private void btnBuys_Click(object sender, EventArgs e)
        {
            FrmSorB frmb = new FrmSorB();
            frmb.typeId = 2;
            frmb.ShowDialog();
        }

        private void btnSells_Click(object sender, EventArgs e)
        {
            FrmSorB frmc = new FrmSorB();
            frmc.ShowDialog();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
