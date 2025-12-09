using System;
using MarketAccounting.AdminCoPa;
using System.Windows.Forms;

namespace MarketAccounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adminCP_Click(object sender, EventArgs e)
        {
            FrmLogin frml = new FrmLogin();
            if (frml.ShowDialog() == DialogResult.OK)
            {
                FrmAdmin frma = new FrmAdmin();
                frma.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sorry but you can not visit Admin Control Panel");
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FrmProducts frmp = new FrmProducts();
            frmp.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnNewSell_Click(object sender, EventArgs e)
        {
            FrmNBorS frms = new FrmNBorS();
            frms.typeId = 1;
            if(frms.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Succes");
            }
            else { MessageBox.Show("faild"); }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmNBorS frmb = new FrmNBorS();
            
            if (frmb.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Succes");
            }
            else { MessageBox.Show("faild"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStart.Text = " Hello and Welcome to HjReza  Market accounting app";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello and Welcome to my app");
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FrmCorS frm = new FrmCorS();
            frm.ShowDialog();
        }
    }
}
