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

        int idClient;

        public ClientInfo(int idClient)
        {
            InitializeComponent();
            this.клиентTableAdapter.FillById(this.beautyStudioDataSet.Клиент,idClient);
            this.тип_кожиTableAdapter.Fill(this.beautyStudioDataSet.Тип_кожи);
            this.посещениеTableAdapter.FillByIdClient(this.beautyStudioDataSet.Посещение,idClient);
            this.процедуры_клиентаTableAdapter.Fill(this.beautyStudioDataSet.Процедуры_клиента);
            this.idClient = idClient;
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            labelNameSet();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Cursor == Cursors.Hand)
            {
                Clipboard.SetText("+7 "+номер_телефонаLabel.Text);   //копирование в буфер обмена
                MessageBox.Show("Номер телефона скопирован!");
            }
        }

        void labelNameSet()
        {
            фамилияLabel.Visible = true;
            имяLabel.Visible = true;
            отчествоLabel.Visible = true;
            номер_телефонаLabel.Visible = true;
            дата_рожденияLabel.Visible = true;

            label1.Text = "";

            if (фамилияLabel.Text == "" || фамилияLabel.Text == " ")
                label1.Text += "- ";
            else
                label1.Text += фамилияLabel.Text + " ";

            if (имяLabel.Text == "" || имяLabel.Text == " ")
                label1.Text += "- ";
            else
                label1.Text += имяLabel.Text + " ";

            if (отчествоLabel.Text == "" || отчествоLabel.Text == " ")
                label1.Text += "- | ";
            else
                label1.Text += отчествоLabel.Text + " | ";


            if (дата_рожденияLabel.Text == "" || дата_рожденияLabel.Text == " ")
                label1.Text += "- | ";
            else
                label1.Text += дата_рожденияLabel.Text + " | ";

            if (номер_телефонаLabel.Text == "" || номер_телефонаLabel.Text == " ")
            {
                label1.Text += "-";
                label1.Cursor = Cursors.Default;
            }
            else
            {
                label1.Text += "+7 " + номер_телефонаLabel.Text;
                label1.Cursor = Cursors.Hand;
            }

            фамилияLabel.Visible = false;
            имяLabel.Visible = false;
            отчествоLabel.Visible = false;
            номер_телефонаLabel.Visible = false;
            дата_рожденияLabel.Visible = false;
        }

        private void ClientInfo_Activated(object sender, EventArgs e)
        {
            this.клиентTableAdapter.FillById(this.beautyStudioDataSet.Клиент, idClient);
            this.тип_кожиTableAdapter.Fill(this.beautyStudioDataSet.Тип_кожи);
            this.посещениеTableAdapter.FillByIdClient(this.beautyStudioDataSet.Посещение, idClient);
            this.процедуры_клиентаTableAdapter.Fill(this.beautyStudioDataSet.Процедуры_клиента);

            labelNameSet();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddClient addClient;
            if (int.TryParse(клиентDataGridView.CurrentRow.Cells[6].Value.ToString(), out int res))
                addClient = new AddClient(idClient, this, res);
            else
                addClient = new AddClient(idClient, this, 0);
            addClient.MdiParent = this.MdiParent;
            addClient.Show();
            this.Enabled = false;
            ((MainForm)MdiParent).changeClient = addClient;
        }*/
    }
}
