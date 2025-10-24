namespace FinancialCrm
{
    partial class FrmSpendings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewSpendings = new System.Windows.Forms.DataGridView();
            this.txtSpendingId = new System.Windows.Forms.TextBox();
            this.txtSpendingTitle = new System.Windows.Forms.TextBox();
            this.txtSpendingAmount = new System.Windows.Forms.TextBox();
            this.dtpSpendingDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chartCategorySpendings = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpendings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategorySpendings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSpendings
            // 
            this.dataGridViewSpendings.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridViewSpendings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpendings.Location = new System.Drawing.Point(356, 4);
            this.dataGridViewSpendings.Name = "dataGridViewSpendings";
            this.dataGridViewSpendings.RowHeadersWidth = 51;
            this.dataGridViewSpendings.RowTemplate.Height = 24;
            this.dataGridViewSpendings.Size = new System.Drawing.Size(613, 309);
            this.dataGridViewSpendings.TabIndex = 0;
            this.dataGridViewSpendings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpendings_CellContentClick);
            // 
            // txtSpendingId
            // 
            this.txtSpendingId.BackColor = System.Drawing.Color.SeaShell;
            this.txtSpendingId.Location = new System.Drawing.Point(150, 46);
            this.txtSpendingId.Name = "txtSpendingId";
            this.txtSpendingId.Size = new System.Drawing.Size(200, 22);
            this.txtSpendingId.TabIndex = 1;
            // 
            // txtSpendingTitle
            // 
            this.txtSpendingTitle.BackColor = System.Drawing.Color.SeaShell;
            this.txtSpendingTitle.Location = new System.Drawing.Point(150, 94);
            this.txtSpendingTitle.Name = "txtSpendingTitle";
            this.txtSpendingTitle.Size = new System.Drawing.Size(200, 22);
            this.txtSpendingTitle.TabIndex = 2;
            this.txtSpendingTitle.TextChanged += new System.EventHandler(this.txtSpendingTitle_TextChanged);
            // 
            // txtSpendingAmount
            // 
            this.txtSpendingAmount.BackColor = System.Drawing.Color.SeaShell;
            this.txtSpendingAmount.Location = new System.Drawing.Point(150, 138);
            this.txtSpendingAmount.Name = "txtSpendingAmount";
            this.txtSpendingAmount.Size = new System.Drawing.Size(200, 22);
            this.txtSpendingAmount.TabIndex = 3;
            // 
            // dtpSpendingDate
            // 
            this.dtpSpendingDate.CalendarTitleBackColor = System.Drawing.Color.SeaShell;
            this.dtpSpendingDate.Location = new System.Drawing.Point(150, 193);
            this.dtpSpendingDate.Name = "dtpSpendingDate";
            this.dtpSpendingDate.Size = new System.Drawing.Size(200, 22);
            this.dtpSpendingDate.TabIndex = 4;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.SeaShell;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(150, 230);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 24);
            this.cmbCategory.TabIndex = 5;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.LightCoral;
            this.btnList.Location = new System.Drawing.Point(183, 276);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(129, 35);
            this.btnList.TabIndex = 6;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightCoral;
            this.btnAdd.Location = new System.Drawing.Point(183, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightCoral;
            this.btnUpdate.Location = new System.Drawing.Point(183, 358);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(183, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // chartCategorySpendings
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCategorySpendings.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCategorySpendings.Legends.Add(legend3);
            this.chartCategorySpendings.Location = new System.Drawing.Point(356, 328);
            this.chartCategorySpendings.Name = "chartCategorySpendings";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCategorySpendings.Series.Add(series3);
            this.chartCategorySpendings.Size = new System.Drawing.Size(325, 200);
            this.chartCategorySpendings.TabIndex = 10;
            this.chartCategorySpendings.Text = "chart1";
            this.chartCategorySpendings.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Harcama Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Harcama Başlığı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Harcama Miktarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Harcama Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Harcama Kategorisi:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(12, 502);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(141, 24);
            this.lblBakiye.TabIndex = 16;
            this.lblBakiye.Text = "Banka Bakiyesi:";
            this.lblBakiye.Click += new System.EventHandler(this.lblBakiye_Click);
            // 
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(981, 535);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartCategorySpendings);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.dtpSpendingDate);
            this.Controls.Add(this.txtSpendingAmount);
            this.Controls.Add(this.txtSpendingTitle);
            this.Controls.Add(this.txtSpendingId);
            this.Controls.Add(this.dataGridViewSpendings);
            this.Name = "FrmSpendings";
            this.Text = "FrmSpendings";
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpendings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategorySpendings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSpendings;
        private System.Windows.Forms.TextBox txtSpendingId;
        private System.Windows.Forms.TextBox txtSpendingTitle;
        private System.Windows.Forms.TextBox txtSpendingAmount;
        private System.Windows.Forms.DateTimePicker dtpSpendingDate;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategorySpendings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBakiye;
    }
}