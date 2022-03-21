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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beautyStudioDataSet);

        }

        private void test_Load(object sender, EventArgs e)
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Процедуры_клиента". При необходимости она может быть перемещена или удалена.
            this.процедуры_клиентаTableAdapter.Fill(this.beautyStudioDataSet.Процедуры_клиента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Процедуры_в_посещении". При необходимости она может быть перемещена или удалена.
            this.процедуры_в_посещенииTableAdapter.Fill(this.beautyStudioDataSet.Процедуры_в_посещении);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Посещение". При необходимости она может быть перемещена или удалена.
            this.посещениеTableAdapter.Fill(this.beautyStudioDataSet.Посещение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.beautyStudioDataSet.Клиент);

        }

        private void button1_Click(object sender, EventArgs e)
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Процедуры_клиента". При необходимости она может быть перемещена или удалена.
            this.процедуры_клиентаTableAdapter.Update(this.beautyStudioDataSet.Процедуры_клиента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Процедуры_в_посещении". При необходимости она может быть перемещена или удалена.
            this.процедуры_в_посещенииTableAdapter.Update(this.beautyStudioDataSet.Процедуры_в_посещении);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Посещение". При необходимости она может быть перемещена или удалена.
            this.посещениеTableAdapter.Update(this.beautyStudioDataSet.Посещение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Update(this.beautyStudioDataSet.Клиент);
        }
    }
}
