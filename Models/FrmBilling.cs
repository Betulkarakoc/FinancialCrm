using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;
using System.Data.Entity;

namespace FinancialCrm.Models
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            string period = txtBillPeriod.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
          
            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme başarılı bir şekilde sisteme eklendi.",
                "Bilgi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme başarılı bir şekilde sistemdem silindi.",
                "Ödeme & Faturalar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            string period = txtBillPeriod.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            int id = int.Parse(txtBillId.Text);

            var values= db.Bills.Find(id);

            values.BillTitle = title;
            values.BillPeriod = period;
            values.BillAmount = amount;
            db.SaveChanges();
            MessageBox.Show("Ödeme başarılı bir şekilde sistemde güncellendi.",
                "Bilgi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            var value2 = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }
    }
}