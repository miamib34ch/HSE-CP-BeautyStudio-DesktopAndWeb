using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyStudio
{
    public partial class Dictionaries : Form
    {
        public Dictionaries()
        {
            InitializeComponent();
            hideAllData();
            btnPrice.Select();  
        }

        private void пигментыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пигментыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beautyStudioDataSet);
        }

        private void Dictionaries_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Тип_процедуры". При необходимости она может быть перемещена или удалена.
            this.тип_процедурыTableAdapter.Fill(this.beautyStudioDataSet.Тип_процедуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Тип_кожи". При необходимости она может быть перемещена или удалена.
            this.тип_кожиTableAdapter.Fill(this.beautyStudioDataSet.Тип_кожи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Тип_иглы". При необходимости она может быть перемещена или удалена.
            this.тип_иглыTableAdapter.Fill(this.beautyStudioDataSet.Тип_иглы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Скидка". При необходимости она может быть перемещена или удалена.
            this.скидкаTableAdapter.Fill(this.beautyStudioDataSet.Скидка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Процедура". При необходимости она может быть перемещена или удалена.
            this.процедураTableAdapter.Fill(this.beautyStudioDataSet.Процедура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Пигменты". При необходимости она может быть перемещена или удалена.
            this.пигментыTableAdapter.Fill(this.beautyStudioDataSet.Пигменты);
        }

        void hideAllData()
        {
            this.пигментыDataGridView.Visible = false;
            this.пигментыDataGridView.Enabled = false;

            this.процедураDataGridView.Visible = false;
            this.процедураDataGridView.Enabled = false;

            this.скидкаDataGridView.Visible = false;
            this.скидкаDataGridView.Enabled = false;

            this.тип_иглыDataGridView.Visible = false;
            this.тип_иглыDataGridView.Enabled = false;

            this.тип_кожиDataGridView.Visible = false;
            this.тип_кожиDataGridView.Enabled = false;

            this.тип_процедурыDataGridView.Visible = false;
            this.тип_процедурыDataGridView.Enabled = false;

            btnBack.Enabled = false;
            btnBack.Visible = false;
            btnSave.Enabled = false;
            btnSave.Visible = false;
        }
        void hideAllBtn()
        {
            btnIgla.Enabled = false;
            btnIgla.Visible = false;

            btnPgmnt.Enabled = false;
            btnPgmnt.Visible = false;

            btnPrice.Enabled = false;
            btnPrice.Visible = false;

            btnProcedure.Enabled = false;
            btnProcedure.Visible = false;

            btnSale.Enabled = false;
            btnSale.Visible = false;

            btnSkin.Enabled = false;
            btnSkin.Visible = false;

            btnBack.Enabled = true;
            btnBack.Visible = true;
            btnSave.Enabled = true;
            btnSave.Visible = true;
        }
        void ComebackAllBtn()
        {
            btnIgla.Enabled = true;
            btnIgla.Visible = true;

            btnPgmnt.Enabled = true;
            btnPgmnt.Visible = true;

            btnPrice.Enabled = true;
            btnPrice.Visible = true;

            btnProcedure.Enabled = true;
            btnProcedure.Visible = true;

            btnSale.Enabled = true;
            btnSale.Visible = true;

            btnSkin.Enabled = true;
            btnSkin.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            hideAllData();
            ComebackAllBtn();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            hideAllBtn();
            this.процедураTableAdapter.Fill(this.beautyStudioDataSet.Процедура);
            процедураDataGridView.Enabled = true;
            процедураDataGridView.Visible = true;
            процедураDataGridView.Columns[0].Visible = false;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            hideAllBtn();
            this.скидкаTableAdapter.Fill(this.beautyStudioDataSet.Скидка);
            this.скидкаDataGridView.Visible = true;
            this.скидкаDataGridView.Enabled = true;
            скидкаDataGridView.Columns[0].Visible = false;
        }

        private void btnPgmnt_Click(object sender, EventArgs e)
        {
            hideAllBtn();
            this.пигментыTableAdapter.Fill(this.beautyStudioDataSet.Пигменты);
            this.пигментыDataGridView.Visible = true;
            this.пигментыDataGridView.Enabled = true;
            пигментыDataGridView.Columns[0].Visible = false;
        }

        private void btnIgla_Click(object sender, EventArgs e)
        {
            hideAllBtn();
            this.тип_иглыTableAdapter.Fill(this.beautyStudioDataSet.Тип_иглы);
            this.тип_иглыDataGridView.Visible = true;
            this.тип_иглыDataGridView.Enabled = true;
            тип_иглыDataGridView.Columns[0].Visible = false;
        }

        private void btnSkin_Click(object sender, EventArgs e)
        {
            hideAllBtn();
            this.тип_кожиTableAdapter.Fill(this.beautyStudioDataSet.Тип_кожи);
            this.тип_кожиDataGridView.Visible = true;
            this.тип_кожиDataGridView.Enabled = true;
            тип_кожиDataGridView.Columns[0].Visible = false;
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            hideAllBtn();
            this.тип_процедурыTableAdapter.Fill(this.beautyStudioDataSet.Тип_процедуры);
            this.тип_процедурыDataGridView.Visible = true;
            this.тип_процедурыDataGridView.Enabled = true;
            тип_процедурыDataGridView.Columns[0].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Тип_процедуры". При необходимости она может быть перемещена или удалена.
            this.тип_процедурыTableAdapter.Update(this.beautyStudioDataSet.Тип_процедуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Тип_кожи". При необходимости она может быть перемещена или удалена.
            this.тип_кожиTableAdapter.Update(this.beautyStudioDataSet.Тип_кожи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Тип_иглы". При необходимости она может быть перемещена или удалена.
            this.тип_иглыTableAdapter.Update(this.beautyStudioDataSet.Тип_иглы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Скидка". При необходимости она может быть перемещена или удалена.
            this.скидкаTableAdapter.Update(this.beautyStudioDataSet.Скидка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Процедура". При необходимости она может быть перемещена или удалена.
            this.процедураTableAdapter.Update(this.beautyStudioDataSet.Процедура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Пигменты". При необходимости она может быть перемещена или удалена.
            this.пигментыTableAdapter.Update(this.beautyStudioDataSet.Пигменты);
        }

        private void процедураDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
