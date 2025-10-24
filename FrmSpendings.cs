using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialCrm
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void txtSpendingTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSpendings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            LoadCategories();
            RefreshGrid();
            LoadCategoryChart();
            ClearInputs();
        }
        private void LoadCategories()
        {
            var categories = db.Categories
                .Select(c => new { c.CategoryId, c.CategoryName })
                .ToList();

            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = categories;
        }

        private void RefreshGrid()
        {
            var list = db.Spendings
                .Select(s => new
                {
                    s.SpendingId,
                    s.SpendingTitle,
                    s.SpendingAmount,
                    s.SpendingDate,
                    Category = s.Categories.CategoryName
                })
                .OrderByDescending(s => s.SpendingDate)
                .ToList();

            dataGridViewSpendings.DataSource = list;

            dataGridViewSpendings.Columns["SpendingId"].HeaderText = "ID";
            dataGridViewSpendings.Columns["SpendingTitle"].HeaderText = "Başlık";
            dataGridViewSpendings.Columns["SpendingAmount"].HeaderText = "Tutar (₺)";
            dataGridViewSpendings.Columns["SpendingDate"].HeaderText = "Tarih";
            dataGridViewSpendings.Columns["Category"].HeaderText = "Kategori";
        }

        private void ClearInputs()
        {
            txtSpendingId.Text = "";
            txtSpendingTitle.Text = "";
            txtSpendingAmount.Text = "";
            dtpSpendingDate.Value = DateTime.Now;
            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;
        }

        private bool ValidateInputs(out decimal amount)
        {
            amount = 0;

            if (string.IsNullOrWhiteSpace(txtSpendingTitle.Text))
            {
                MessageBox.Show("Lütfen bir başlık giriniz.");
                return false;
            }

            if (!decimal.TryParse(txtSpendingAmount.Text, out amount))
            {
                MessageBox.Show("Geçerli bir tutar giriniz.");
                return false;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out decimal amount))
                return;

            Spendings s = new Spendings
            {
                SpendingTitle = txtSpendingTitle.Text.Trim(),
                SpendingAmount = amount,
                SpendingDate = dtpSpendingDate.Value,
                CategoryId = (int)cmbCategory.SelectedValue
            };

            db.Spendings.Add(s);
            db.SaveChanges();

            MessageBox.Show("Harcama eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshGrid();
            LoadCategoryChart();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpendingId.Text))
            {
                MessageBox.Show("Güncellenecek kaydı seçiniz.");
                return;
            }

            if (!ValidateInputs(out decimal amount))
                return;

            int id = int.Parse(txtSpendingId.Text);
            var spending = db.Spendings.Find(id);

            if (spending == null)
            {
                MessageBox.Show("Kayıt bulunamadı.");
                return;
            }

            spending.SpendingTitle = txtSpendingTitle.Text.Trim();
            spending.SpendingAmount = amount;
            spending.SpendingDate = dtpSpendingDate.Value;
            spending.CategoryId = (int)cmbCategory.SelectedValue;

            db.SaveChanges();

            MessageBox.Show("Harcama güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshGrid();
            LoadCategoryChart();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpendingId.Text))
            {
                MessageBox.Show("Silinecek kaydı seçiniz.");
                return;
            }

            int id = int.Parse(txtSpendingId.Text);
            var spending = db.Spendings.Find(id);

            if (spending == null)
            {
                MessageBox.Show("Kayıt bulunamadı.");
                return;
            }

            var confirm = MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz?",
                                          "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                db.Spendings.Remove(spending);
                db.SaveChanges();

                MessageBox.Show("Harcama silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
                LoadCategoryChart();
                ClearInputs();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dataGridViewSpendings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dataGridViewSpendings.Rows[e.RowIndex];

            txtSpendingId.Text = row.Cells["SpendingId"].Value.ToString();
            txtSpendingTitle.Text = row.Cells["SpendingTitle"].Value.ToString();
            txtSpendingAmount.Text = row.Cells["SpendingAmount"].Value.ToString();
            dtpSpendingDate.Value = Convert.ToDateTime(row.Cells["SpendingDate"].Value);

            // Kategori seçimini otomatik eşleştir
            string catName = row.Cells["Category"].Value.ToString();
            var cat = db.Categories.FirstOrDefault(c => c.CategoryName == catName);
            if (cat != null)
                cmbCategory.SelectedValue = cat.CategoryId;
        }

        private void LoadCategoryChart()
        {
            var data = db.Spendings
                .GroupBy(s => s.Categories.CategoryName)
                .Select(g => new { Category = g.Key, Total = g.Sum(s => s.SpendingAmount) })
                .ToList();

            chartCategorySpendings.Series.Clear();
            var series = chartCategorySpendings.Series.Add("Kategoriler");
            series.ChartType = SeriesChartType.Pie;
            series.Label = "#VALX: #PERCENT";

            foreach (var item in data)
            {
                int pointIndex = series.Points.AddY(item.Total);
                series.Points[pointIndex].AxisLabel = item.Category;
                series.Points[pointIndex].LegendText = item.Category;
                series.Points[pointIndex].ToolTip = $"{item.Category} - {item.Total:0.00} ₺";
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs(out decimal amount))
                return;

            using (var db = new FinancialCrmDbEntities())
            {
                // Yeni harcamayı oluştur
                Spendings s = new Spendings
                {
                    SpendingTitle = txtSpendingTitle.Text,
                    SpendingAmount = amount,
                    SpendingDate = dtpSpendingDate.Value,
                    CategoryId = (int)cmbCategory.SelectedValue
                };

                db.Spendings.Add(s);

                // Banka bakiyesinden düş
                var bank = db.Banks.FirstOrDefault(); // Örnek: tek banka varsa
                if (bank != null)
                {
                    bank.BankBalance -= s.SpendingAmount;
                }

                db.SaveChanges();

                MessageBox.Show("Harcama eklendi ve banka bakiyesi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshGrid();
                LoadCategoryChart();
                BakiyeGuncelle(); // Label'da güncelle
                ClearInputs();
            }
         }

        private void lblBakiye_Click(object sender, EventArgs e)
        {

        }
        private void BakiyeGuncelle()
        {
            using (var db = new FinancialCrmDbEntities())
            {
                var bank = db.Banks.FirstOrDefault();
                if (bank != null)
                    lblBakiye.Text = $"Banka Bakiyesi: {bank.BankBalance:0.00} ₺";
                else
                    lblBakiye.Text = "Banka Bakiyesi: 0 ₺";
            }
        }

    }
}
