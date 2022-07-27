using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BeautyStudio
{
    public partial class Visiting : Form
    {
        string idClient;
        Clients clients;
        ClientInfo clientInfo;
        bool itsNotChange = true;
        int idVisiting;

        public Visiting(string idClient, string surname, Clients clients)
        {
            InitializeComponent();
            itsNotChange = true;
            this.посещениеTableAdapter.Fill(this.beautyStudioDataSet.Посещение);
            this.скидкаTableAdapter.Fill(this.beautyStudioDataSet.Скидка);
            this.тип_иглыTableAdapter.Fill(this.beautyStudioDataSet.Тип_иглы);
            посещениеBindingSource.AddNew();
            this.idClient = idClient;
            this.clients = clients;
            this.Text = $"Добавление посещения для {surname}";
        }

        public Visiting(string surname, int idVisiting, Clients clients, ClientInfo clientInfo)
        {
            this.InitializeComponent();
            this.itsNotChange = false;
            this.посещениеTableAdapter.FillByIdVisiting(this.beautyStudioDataSet.Посещение, idVisiting);
            this.скидкаTableAdapter.Fill(this.beautyStudioDataSet.Скидка);
            this.тип_иглыTableAdapter.Fill(this.beautyStudioDataSet.Тип_иглы);
            this.clients = clients;
            this.clientInfo = clientInfo;
            this.button3.Enabled = false;
            this.idVisiting = idVisiting;
            this.Text = $"Изменение посещения для {surname}";
        }

        private void Visiting_Load(object sender, EventArgs e)
        {

            this.процедураTableAdapter.Fill(this.beautyStudioDataSet1.Процедура);
            this.пигментыTableAdapter.Fill(this.beautyStudioDataSet.Пигменты);
            this.процедураTableAdapter.Fill(this.beautyStudioDataSet.Процедура);
            this.скидкаTableAdapter.Fill(this.beautyStudioDataSet1.Скидка);
            this.процедуры_клиентаTableAdapter.FillBy(this.beautyStudioDataSet.Процедуры_клиента, int.Parse(id_посещенияTextBox.Text));
            this.процедуры_в_посещенииTableAdapter.Fill(this.beautyStudioDataSet.Процедуры_в_посещении);

            if (this.itsNotChange)
            {
                итоговая_ценаTextBox.Text = "0";
                comboBox1.SelectedItem = 0;
                comboBox1.SelectedValue = 0;
                maskedTextBox1.Text = DeleteSeconds();
                id_клиентаTextBox.Text = idClient;
            }
            else
            {
                maskedTextBox1.Text = ChangeVisablity();
                this.comboBox2.SelectedItem = (object)this.посещениеTableAdapter.ScalarQuery(this.idVisiting);
                this.comboBox2.SelectedValue = (object)this.посещениеTableAdapter.ScalarQuery(this.idVisiting);
            }
        }

        private void Visiting_Activated(object sender, EventArgs e)
        {
            updateMoney();
            посещениеBindingSource.EndEdit();
            посещениеTableAdapter.Update(this.beautyStudioDataSet.Посещение);
            this.процедуры_клиентаTableAdapter.FillBy(this.beautyStudioDataSet.Процедуры_клиента, int.Parse(id_посещенияTextBox.Text));
        }

        private void Visiting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clients != null)
                clients.Enabled = true;
        }


        private void addProcedure_Click(object sender, EventArgs e)
        {
            посещениеBindingSource.EndEdit();
            посещениеTableAdapter.Update(this.beautyStudioDataSet.Посещение);
            Procedure procedure = new Procedure(id_посещенияTextBox.Text, this);
            procedure.MdiParent = this.MdiParent;
            this.Enabled = false;
            procedure.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Не указано" && процедуры_клиентаDataGridView.Rows.Count != 0)
            {
                var res = MessageBox.Show("Вы уверены, что хотите добавить данное посещение?", "Добавление посещение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    посещениеBindingSource.EndEdit();
                    посещениеTableAdapter.Update(this.beautyStudioDataSet.Посещение);
                    if (!this.itsNotChange)
                    {
                        this.clients.Enabled = true;
                        this.clientInfo.ClientInfo_Load(sender, e);
                        this.clientInfo.ClientInfo_Activated(sender, e);
                    }
                    Close();
                }
            }
            else
                MessageBox.Show("Выберите тип иглы и добавьте процедуры!\nТакже проверьте формат времени!");
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            процедуры_клиентаTableAdapter.DeleteQuery(int.Parse(id_посещенияTextBox.Text));
            посещениеBindingSource.RemoveCurrent();
            посещениеTableAdapter.Update(this.beautyStudioDataSet.Посещение);
            Close();
        }

        #region удаление процедур

        private void процедуры_клиентаDataGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = contextMenuStrip1;
        }

        private void удалитьПроцедуруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(процедуры_клиентаDataGridView.CurrentRow.Cells[0].Value.ToString());
            var result = MessageBox.Show($"Удаление процедуры \"{процедураTableAdapter1.ScalarQuery(int.Parse(процедуры_клиентаDataGridView.CurrentRow.Cells[1].Value.ToString()))}\"", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                DeleteRow(id);
                foreach (DataGridViewRow s in процедуры_клиентаDataGridView.Rows)
                    if (s.Cells[0].Value.ToString() == id.ToString())
                        процедуры_клиентаDataGridView.Rows.Remove(s);
                процедуры_клиентаDataGridView.Refresh();
            }
            updateMoney();
        }

        void DeleteRow(int id)
        {
            SqlConnection conn = new SqlConnection($@"Data Source={clients.connectionSourse};Initial Catalog= {clients.bdName};Integrated Security=True;");
            conn.Open();
            var sqlq = $"DELETE FROM [dbo].[Процедуры клиента] WHERE [Id процедуры клиента] = @id";
            var cmd = new SqlCommand(sqlq, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        #endregion

        void updateMoney()
        {
            try
            {
                int sale = int.Parse(comboBox2.Text);
                if (посещениеTableAdapter.sumPrice(int.Parse(id_посещенияTextBox.Text)) == null)
                {
                    итоговая_ценаTextBox.Text = $"{0 - sale}";
                }
                else
                {
                    итоговая_ценаTextBox.Text = $"{(int)посещениеTableAdapter.sumPrice(int.Parse(id_посещенияTextBox.Text)) - sale}";
                }
            }
            catch
            {

            }
        } //подсчёт итоговой суммы

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            updateMoney();
        } //изменение скидки


        string DeleteSeconds()
        {
            string date = "";
            date += DateTime.Now.ToString().Split(' ')[0];
            date += " ";
            if (DateTime.Now.ToString().Split(' ')[1].Split(':')[0].Length == 1)
            {
                maskedTextBox1.ResetOnPrompt = false;
                maskedTextBox1.ResetOnSpace = false;
                maskedTextBox1.SkipLiterals = false;
            }
            else
            {
                maskedTextBox1.ResetOnPrompt = true;
                maskedTextBox1.ResetOnSpace = true;
                maskedTextBox1.SkipLiterals = true;
            }
            date += DateTime.Now.ToString().Split(' ')[1].Split(':')[0];
            date += ":";
            date += DateTime.Now.ToString().Split(' ')[1].Split(':')[1];
            return date;
        } //удаляет секунды из текущего времени

        string ChangeVisablity()
        {
            if (maskedTextBox1.Text.ToString().Split(' ')[1].Split(':')[0].Length == 2 && maskedTextBox1.Text.ToString().Split(' ')[1].Split(':')[1].Length == 1)
            {
                maskedTextBox1.ResetOnPrompt = false;
                maskedTextBox1.ResetOnSpace = false;
                maskedTextBox1.SkipLiterals = false;
            }
            else
            {                
                maskedTextBox1.ResetOnPrompt = true;
                maskedTextBox1.ResetOnSpace = true;
                maskedTextBox1.SkipLiterals = true;
            }
            return maskedTextBox1.Text;
        }


        private void процедуры_клиентаDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox1.Text.ToString().Split(' ')[1].Split(':')[0].Length == 1 || maskedTextBox1.Text.ToString().Split(' ')[1].Split(':')[0][0] == '0')
                {
                    maskedTextBox1.ResetOnPrompt = false;
                    maskedTextBox1.ResetOnSpace = false;
                    maskedTextBox1.SkipLiterals = false;
                }
                else
                {
                    maskedTextBox1.ResetOnPrompt = true;
                    maskedTextBox1.ResetOnSpace = true;
                    maskedTextBox1.SkipLiterals = true;
                }
            }
            catch
            {

            }
        }
    }
}
