using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace BeautyStudio
{
    public partial class ClientInfo : Form
    {

        int idClient;
        int idSkin;
        Clients client;

        public ClientInfo(int idClient, Clients client, int idSkin)
        {
            InitializeComponent();
            this.клиентTableAdapter.FillById(this.beautyStudioDataSet.Клиент,idClient);
            this.тип_кожиTableAdapter.FillByIdSkin(this.beautyStudioDataSet.Тип_кожи, idSkin);
            this.посещениеTableAdapter.FillByIdClient(this.beautyStudioDataSet.Посещение,idClient);
            this.idClient = idClient;
            this.idSkin = idSkin;
            this.client = client;
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet2.Пигменты". При необходимости она может быть перемещена или удалена.
            this.пигментыTableAdapter.Fill(this.beautyStudioDataSet2.Пигменты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet2.Процедура". При необходимости она может быть перемещена или удалена.
            this.процедураTableAdapter.Fill(this.beautyStudioDataSet2.Процедура);
            if (label9.Text != "label9")
                this.скидкаTableAdapter.FillByIdSale(this.beautyStudioDataSet2.Скидка, int.Parse(label9.Text));
            if (label6.Text != "label6")
                this.тип_иглыTableAdapter.FillByIdIgla(this.beautyStudioDataSet1.Тип_иглы, int.Parse(label6.Text));
            if (id_посещенияTextBox.Text != "")
                this.процедуры_клиентаTableAdapter.FillBy(this.beautyStudioDataSet.Процедуры_клиента,int.Parse(id_посещенияTextBox.Text));
            labelNameSet();
            Visitings();
        }

        private void ClientInfo_Activated(object sender, EventArgs e)
        {
            this.клиентTableAdapter.FillById(this.beautyStudioDataSet.Клиент, idClient);
            idSkin = (int)клиентTableAdapter.ScalarQuery(idClient);
            this.тип_кожиTableAdapter.FillByIdSkin(this.beautyStudioDataSet.Тип_кожи, idSkin);
            this.посещениеTableAdapter.FillByIdClient(this.beautyStudioDataSet.Посещение, idClient);
            if (id_посещенияTextBox.Text != "")
            {
                this.процедуры_клиентаTableAdapter.FillBy(this.beautyStudioDataSet.Процедуры_клиента, int.Parse(id_посещенияTextBox.Text));
                if (label9.Text != "label9")
                    this.скидкаTableAdapter.FillByIdSale(this.beautyStudioDataSet2.Скидка, int.Parse(label9.Text));
                if (label6.Text != "label6")
                    this.тип_иглыTableAdapter.FillByIdIgla(this.beautyStudioDataSet1.Тип_иглы, int.Parse(label6.Text));
            }
            labelNameSet();
            Visitings();
        }

        #region кнопки

        private void phnNumberBufer_Click(object sender, EventArgs e)
        {
            if (label1.Cursor == Cursors.Hand)
            {
                Clipboard.SetText("+7 "+номер_телефонаLabel.Text);   //копирование в буфер обмена
                MessageBox.Show("Номер телефона скопирован!");
            }
        } //копирование номера телефона в буфер обмена

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            AddClient addClient;
            if (int.TryParse(idSkin.ToString(), out int res))
                addClient = new AddClient(idClient, client, res);
            else
                addClient = new AddClient(idClient, client, 0);
            addClient.MdiParent = this.MdiParent;
            client.Enabled = false;
            ((MainForm)MdiParent).changeClient = addClient;
            addClient.Show();
        }

        private void btnOpewWord_Click(object sender, EventArgs e)
        {
            try
            {
                //запускаем Word и открываем шаблон файла   
                object fileName = Application.StartupPath + "\\Шаблон.docx";
                Word.Application WordApplication = new Word.Application();
                WordApplication.Visible = true; //выводим документ на экран
                Word.Document WordDocument = WordApplication.Documents.Open(fileName);
                //присваиваем значение полю
                WordDocument.Variables["SURNAME"].Value = фамилияLabel.Text + " " + имяLabel.Text + " " + отчествоLabel.Text;
                if (номер_телефонаLabel.Text == "")
                    WordDocument.Variables["NUMBER"].Value = " ";
                else
                    WordDocument.Variables["NUMBER"].Value = "+7 " + номер_телефонаLabel.Text;
                if (дата_рожденияLabel.Text == "")
                    WordDocument.Variables["DATA"].Value = " ";
                else
                    WordDocument.Variables["DATA"].Value = дата_рожденияLabel.Text;

                if (bindingNavigator1.BindingSource.Count == 0)
                {
                    WordDocument.Variables["VISITING"].Value = label4.Text;
                    WordDocument.Variables["PRICE"].Value = " ";
                    WordDocument.Variables["PRICENUM"].Value = " ";
                    WordDocument.Variables["SALE"].Value = " ";
                    WordDocument.Variables["SALENUM"].Value = " ";
                    WordDocument.Variables["PROCEDURE"].Value = " ";
                    WordDocument.Variables["ALLPRO"].Value = " ";
                }
                else
                {
                    WordDocument.Variables["VISITING"].Value = "Посещение " + label3.Text;
                    WordDocument.Variables["PRICE"].Value = "Цена:";
                    WordDocument.Variables["PRICENUM"].Value = label7.Text;
                    WordDocument.Variables["SALE"].Value = "Применена скидка:";
                    WordDocument.Variables["SALENUM"].Value = label8.Text;
                    WordDocument.Variables["PROCEDURE"].Value = "Процедуры:";
                    string s = "";
                    for (int i = 0; i < процедуры_клиентаDataGridView.Rows.Count - 1; i++)
                        s += процедуры_клиентаDataGridView.Rows[i].Cells[1].FormattedValue.ToString() + " " + процедуры_клиентаDataGridView.Rows[i].Cells[2].FormattedValue.ToString().ToLower() + ", ";
                    s += процедуры_клиентаDataGridView.Rows[процедуры_клиентаDataGridView.Rows.Count - 1].Cells[1].FormattedValue.ToString() + " " + процедуры_клиентаDataGridView.Rows[процедуры_клиентаDataGridView.Rows.Count - 1].Cells[2].FormattedValue.ToString().ToLower();

                    if (s != "")
                        WordDocument.Variables["ALLPRO"].Value = s;
                    else
                        WordDocument.Variables["ALLPRO"].Value = " ";

                }
                //обновляем поля документа
                WordDocument.Fields.Update();
            }
            catch
            {

            }
        } //выгрузка в шаблон Word

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

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
        } //отображение имени

        void Visitings()
        {
            if (bindingNavigator1.BindingSource.Count == 0)
            {
                label4.Visible = true;
                дата_и_время_посещенияLabel.Visible = false;
                label3.Visible = false;
                id_типа_иглыLabel.Visible = false;
                label5.Visible = false;
                итоговая_ценаLabel.Visible = false;
                label7.Visible = false;
                id_скидкиLabel.Visible = false;
                label8.Visible = false;
                процедуры_клиентаDataGridView.Visible = false;
                примечание_о_посещенииLabel.Visible = false;
                примечание_о_посещенииTextBox.Visible = false;
                btnChange.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                label4.Visible = false;
                дата_и_время_посещенияLabel.Visible = true;
                label3.Visible = true;
                id_типа_иглыLabel.Visible = true;
                label5.Visible = true;
                итоговая_ценаLabel.Visible = true;
                label7.Visible = true;
                id_скидкиLabel.Visible = true;
                label8.Visible = true;
                процедуры_клиентаDataGridView.Visible = true;
                примечание_о_посещенииLabel.Visible = true;
                примечание_о_посещенииTextBox.Visible = true;
                btnChange.Visible = true;
                btnDelete.Visible = true;
            }
        }   //отображение посещений


        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.тип_иглыTableAdapter.FillByIdIgla(this.beautyStudioDataSet1.Тип_иглы, int.Parse(label6.Text));
            this.скидкаTableAdapter.FillByIdSale(this.beautyStudioDataSet2.Скидка, int.Parse(label9.Text));
            this.процедуры_клиентаTableAdapter.FillBy(this.beautyStudioDataSet.Процедуры_клиента, int.Parse(id_посещенияTextBox.Text));
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.тип_иглыTableAdapter.FillByIdIgla(this.beautyStudioDataSet1.Тип_иглы, int.Parse(label6.Text));
            this.скидкаTableAdapter.FillByIdSale(this.beautyStudioDataSet2.Скидка, int.Parse(label9.Text));
            this.процедуры_клиентаTableAdapter.FillBy(this.beautyStudioDataSet.Процедуры_клиента, int.Parse(id_посещенияTextBox.Text));
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.тип_иглыTableAdapter.FillByIdIgla(this.beautyStudioDataSet1.Тип_иглы, int.Parse(label6.Text));
            this.скидкаTableAdapter.FillByIdSale(this.beautyStudioDataSet2.Скидка, int.Parse(label9.Text));
            this.процедуры_клиентаTableAdapter.FillBy(this.beautyStudioDataSet.Процедуры_клиента, int.Parse(id_посещенияTextBox.Text));
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.тип_иглыTableAdapter.FillByIdIgla(this.beautyStudioDataSet1.Тип_иглы, int.Parse(label6.Text));
            this.скидкаTableAdapter.FillByIdSale(this.beautyStudioDataSet2.Скидка, int.Parse(label9.Text));
            this.процедуры_клиентаTableAdapter.FillBy(this.beautyStudioDataSet.Процедуры_клиента, int.Parse(id_посещенияTextBox.Text));
        }


        private void процедуры_клиентаDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Password psw = new Password();
            if (psw.ShowDialog() == DialogResult.OK)
            {
                фамилияLabel.Visible = true;
                string Фамилия = фамилияLabel.Text;
                фамилияLabel.Visible = false;
                var res = MessageBox.Show("Вы уверены, что хотите удалить посещение?", $"Удалить посещение {label3.Text} {Фамилия}", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    посещениеTableAdapter.DeleteQuery(int.Parse(id_посещенияTextBox.Text));
                    MessageBox.Show("Посещение удалено");
                    ClientInfo_Activated(sender, e);
                }
            }
        }
    }
}
