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
    public partial class ClientInfo : Form
    {
        public ClientInfo(int idClient)
        {
            InitializeComponent();
            this.клиентTableAdapter.FillById(this.beautyStudioDataSet.Клиент,idClient);
            this.посещениеTableAdapter.FillByIdClient(this.beautyStudioDataSet.Посещение,idClient);
            this.процедуры_клиентаTableAdapter.Fill(this.beautyStudioDataSet.Процедуры_клиента);
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Тип_кожи". При необходимости она может быть перемещена или удалена.
            this.тип_кожиTableAdapter.Fill(this.beautyStudioDataSet.Тип_кожи);
            label1.Text = "";
            label1.Text += фамилияLabel.Text + " ";
            label1.Text += имяLabel.Text + " ";
            label1.Text += отчествоLabel.Text + " | ";
            label1.Text += дата_рожденияLabel.Text + " | ";
            label1.Text += "+7 "+ номер_телефонаLabel.Text;
            фамилияLabel.Visible = false;
            имяLabel.Visible = false;
            отчествоLabel.Visible = false;
            номер_телефонаLabel.Visible = false;
            дата_рожденияLabel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(номер_телефонаLabel.Text);   //копирование в буфер обмена
            MessageBox.Show("Номер телефона скопирован!");
        }
    }
}
