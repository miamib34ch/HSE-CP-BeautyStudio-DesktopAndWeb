using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace BeautyStudio
{
    public partial class Dictionaries : Form
    {
        bool wasImport = false;
        int importCount = 0;
        int countBeforeImport;
        public Dictionaries()
        {
            InitializeComponent();
            hideAllData();
            btnPrice.Select();  
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
            toolTip1.SetToolTip(btnImport, "Id названий должны начинаться с 0 и идти с шагом 0\nИначе файл прочитан не будет!");
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

            btnClose.Enabled = false;
            btnClose.Visible = false;

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

            btnClose.Enabled=true;
            btnClose.Visible=true;

            btnImport.Enabled = false;
            btnImport.Visible = false;
            btnExport.Enabled = false;
            btnExport.Visible = false;
            btnBack.Enabled = false;
            btnBack.Visible = false;
            btnSave.Enabled = false;
            btnSave.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (wasImport && this.тип_иглыDataGridView.Enabled == true)
            {
                for(int i = 0; i < importCount; i++)
                    тип_иглыTableAdapter.Delete(countBeforeImport+i);
            }
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
            this.тип_иглыDataGridView.Columns[0].Visible = false;
            btnImport.Enabled = true;
            btnImport.Visible = true;
            btnExport.Enabled = true;
            btnExport.Visible = true;
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
            wasImport = false;
        }

        private void процедураDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable("Тип иглы");
                dt.Columns.Add("Id типа иглы", typeof(int));
                dt.Columns.Add("Название типа иглы", typeof(string));

                for (int i = 0; i < тип_иглыDataGridView.Rows.Count-1; i++)
                    dt.Rows.Add(new object[] { int.Parse(тип_иглыDataGridView.Rows[i].Cells[0].Value.ToString()), (string)тип_иглыDataGridView.Rows[i].Cells[1].Value.ToString() });

                var dlg = new SaveFileDialog();

                dlg.Filter = "XML|*.xml";

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                using (var fs =
                new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    switch (Path.GetExtension(dlg.FileName))
                    {
                        case ".xml":
                            dt.WriteXml(new XmlTextWriter(fs,Encoding.UTF8));
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Нет данных");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!wasImport)
                    countBeforeImport = тип_иглыDataGridView.Rows.Count - 1;
                DataTable dt = new DataTable("Тип иглы");
                dt.Columns.Add("Id типа иглы", typeof(int));
                dt.Columns.Add("Название типа иглы", typeof(string));

                var dlg = new OpenFileDialog();

                dlg.Filter = "XML|*.xml";

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                using (var fs =
                new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    switch (Path.GetExtension(dlg.FileName))
                    {
                        case ".xml":
                            dt.ReadXml(fs);
                            break;
                    }
                }

                if (dt.Rows[0].ItemArray[0].ToString() != "0") 
                {
                    MessageBox.Show("Плохой файл!");
                    return;
                }
                else
                {
                    for (int i = 1; i < dt.Rows.Count; i++)
                        if (dt.Rows[i].ItemArray[0].ToString() != $"{i}")
                        {
                            MessageBox.Show("Плохой файл!");
                            return;
                        }
                }
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    тип_иглыTableAdapter.Insert(int.Parse(dt.Rows[i].ItemArray[0].ToString()) + тип_иглыDataGridView.Rows.Count-1, (string)dt.Rows[i].ItemArray[1]);
                    importCount++;
                }
                this.тип_иглыTableAdapter.Fill(this.beautyStudioDataSet.Тип_иглы);
                wasImport = true;
            }
            catch
            {
                MessageBox.Show("Плохой файл!");
            }
}
    }
}
