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
    public partial class FrmLogin : Form
    {
        
        public int id = 0;
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int Password = 3994;
            string userName = "hjreza";
            try
            {
                if (txtPassword.Text != "" && txtUserName.Text != "")
                {
                    if (int.Parse(txtPassword.Text.ToString()) == Password && txtUserName.Text.ToLower() == userName)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Informations are not correct");
                        DialogResult = DialogResult.Cancel;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter somthing");
                }
            }
            catch
            {
                MessageBox.Show("Opreatin faild !!!");
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
