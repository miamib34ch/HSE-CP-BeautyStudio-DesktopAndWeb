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
    public partial class Visiting : Form
    {
        string position;
        Clients clients;

        public Visiting(string position, Clients clients)
        {
            InitializeComponent();
            this.посещениеTableAdapter.Fill(this.beautyStudioDataSet.Посещение);
            this.скидкаTableAdapter.Fill(this.beautyStudioDataSet.Скидка);
            this.тип_иглыTableAdapter.Fill(this.beautyStudioDataSet.Тип_иглы);
            посещениеBindingSource.AddNew();
            дата_и_время_посещенияDateTimePicker.Value = DateTime.Now;
            this.position = position;
            this.clients = clients;
        }

        private void Visiting_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Процедуры_в_посещении". При необходимости она может быть перемещена или удалена.
            this.процедуры_в_посещенииTableAdapter.Fill(this.beautyStudioDataSet.Процедуры_в_посещении);
            итоговая_ценаTextBox.Text = "0";
            id_клиентаTextBox.Text = position;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addProcedure_Click(object sender, EventArgs e)
        {
            посещениеBindingSource.EndEdit();
            посещениеTableAdapter.Update(this.beautyStudioDataSet.Посещение);
            Procedure procedure = new Procedure(id_посещенияTextBox.Text);
            procedure.MdiParent = this.MdiParent;
            procedure.Show();
        }

        private void Visiting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clients != null)
                clients.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            посещениеBindingSource.EndEdit();
            посещениеTableAdapter.Update(this.beautyStudioDataSet.Посещение);
            Close();
        }

        private void Visiting_Activated(object sender, EventArgs e)
        {
            if (посещениеTableAdapter.sumPrice(int.Parse(id_посещенияTextBox.Text)) == null)
            {
                итоговая_ценаTextBox.Text = "0";
            }
            else
                итоговая_ценаTextBox.Text = $"{посещениеTableAdapter.sumPrice(int.Parse(id_посещенияTextBox.Text))}";
        }
    }
}
