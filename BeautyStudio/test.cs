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
