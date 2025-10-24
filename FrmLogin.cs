using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Kullanıcı adı ve şifre giriniz.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            var user = db.Users
                .FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user != null)
            {
                // Giriş başarılı
                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Hatalı kullanıcı adı veya şifre!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}