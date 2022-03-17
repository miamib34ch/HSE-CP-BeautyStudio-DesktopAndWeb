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
    public partial class AddClient : Form
    {

        public Clients clients { get; set; }
        int id = 0;

        public AddClient()
        {
            InitializeComponent();
            this.клиентTableAdapter.Fill(this.beautyStudioDataSet.Клиент);
            клиентBindingSource.AddNew();
            this.Text = "Добавление клиента";
            дата_рожденияDateTimePicker.Value = DateTime.Now;
        }

        public AddClient(Clients clients)
        {
            InitializeComponent();
            this.клиентTableAdapter.Fill(this.beautyStudioDataSet.Клиент);
            клиентBindingSource.AddNew();
            this.Text = "Добавление клиента";
            this.clients = clients;
            дата_рожденияDateTimePicker.Value = DateTime.Now;
        }

        public AddClient(int position, Clients clients, int id)
        {
            InitializeComponent();
            this.клиентTableAdapter.Fill(this.beautyStudioDataSet.Клиент);
            клиентBindingSource.Position = position;
            this.id = id;
            this.Text = "Изменение информации о клиенте";
            this.clients = clients;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            клиентBindingSource.EndEdit();
            клиентTableAdapter.Update(this.beautyStudioDataSet.Клиент);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clients != null)
                clients.Enabled = true;
        }

        private void AddClient_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            Invalidate();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Тип_кожи". При необходимости она может быть перемещена или удалена.
            this.тип_кожиTableAdapter.Fill(this.beautyStudioDataSet.Тип_кожи);
            Invalidate();
            comboBoxType.SelectedIndex = id;
        }
    }
}
