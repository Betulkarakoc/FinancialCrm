using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;


namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            // --- Banka bakiyeleri ---
            var ziraatBankBalance = db.Banks
                .Where(x => x.BankTitle == "Ziraat Bankası")
                .Select(y => y.BankBalance)
                .FirstOrDefault();

            var vakifBankBalance = db.Banks
                .Where(x => x.BankTitle == "VakıfBank")
                .Select(y => y.BankBalance)
                .FirstOrDefault();

            var isBankasiBalance = db.Banks
                .Where(x => x.BankTitle == "İş Bankası")
                .Select(y => y.BankBalance)
                .FirstOrDefault();

            lblZiraatBankBalance.Text = $"{ziraatBankBalance:0.00} ₺";
            lblVakifBankBalance.Text = $"{vakifBankBalance:0.00} ₺";
            lblisBankasiBalance.Text = $"{isBankasiBalance:0.00} ₺";

            // --- Son işlem bilgisi ---
            var bankProcess1 = db.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Take(1)
                .FirstOrDefault();

            if (bankProcess1 != null)
            {
                lblBankProcess1.Text = $"{bankProcess1.Description} {bankProcess1.Amount}₺ - {bankProcess1.ProcessDate:d}";
            }
            else
            {
                lblBankProcess1.Text = "Henüz işlem yapılmadı.";
            }
            var bankProcess2 = db.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Take(2).Skip(1)
                .FirstOrDefault();

            if (bankProcess1 != null)
            {
                lblBankProcess2.Text = $"{bankProcess2.Description} {bankProcess2.Amount}₺ - {bankProcess2.ProcessDate:d}";
            }
            else
            {
                lblBankProcess2.Text = "Henüz işlem yapılmadı.";
            }
            var bankProcess3 = db.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Take(3).Skip(2)
                .FirstOrDefault();

            if (bankProcess3 != null)
            {
                lblBankProcess3.Text = $"{bankProcess3.Description} {bankProcess3.Amount}₺ - {bankProcess3.ProcessDate:d}";
            }
            else
            {
                lblBankProcess3.Text = "Henüz işlem yapılmadı.";
            }
            var bankProcess4 = db.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Take(4).Skip(3)
                .FirstOrDefault();

            if (bankProcess1 != null)
            {
                lblBankProcess4.Text = $"{bankProcess4.Description} {bankProcess4.Amount}₺ - {bankProcess4.ProcessDate:d}";
            }
            else
            {
                lblBankProcess4.Text = "Henüz işlem yapılmadı.";
            }
            var bankProcess5 = db.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Take(5).Skip(4)
                .FirstOrDefault();

            if (bankProcess1 != null)
            {
                lblBankProcess5.Text = $"{bankProcess5.Description} {bankProcess5.Amount}₺ - {bankProcess5.ProcessDate:d}";
            }
            else
            {
                lblBankProcess5.Text = "Henüz işlem yapılmadı.";
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {
            // İsteğe bağlı olay
        }
    }
}
