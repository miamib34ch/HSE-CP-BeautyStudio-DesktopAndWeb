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
        int idSkin = 0;

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

        public AddClient(int idClient, Clients clients, int idSkin)
        {
            InitializeComponent();
            this.клиентTableAdapter.FillById(this.beautyStudioDataSet.Клиент, idClient);
            this.idSkin = idSkin;
            this.Text = "Изменение информации о клиенте";
            this.clients = clients;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Text == "Добавление клиента")
            {
                var res = MessageBox.Show("Вы уверены, что хотите добавить нового клиента?", "Добавление клиента", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    клиентBindingSource.EndEdit();
                    клиентTableAdapter.Update(this.beautyStudioDataSet.Клиент);
                    Close();
                }
            }
            else
            {
                клиентBindingSource.EndEdit();
                клиентTableAdapter.Update(this.beautyStudioDataSet.Клиент);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            this.тип_кожиTableAdapter.Fill(this.beautyStudioDataSet.Тип_кожи);
            Invalidate();
            comboBoxType.SelectedIndex = idSkin;
        }

        private void AddClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clients != null)
                clients.Enabled = true;
        }

        #region изменение на заглавную букву

        private void фамилияTextBox_Leave(object sender, EventArgs e)
        {
            фамилияTextBox.Text = ((MainForm)MdiParent).firstUp(фамилияTextBox.Text);
        }

        private void имяTextBox_Leave(object sender, EventArgs e)
        {
            имяTextBox.Text = ((MainForm)MdiParent).firstUp(имяTextBox.Text);
        }

        private void отчествоTextBox_Leave(object sender, EventArgs e)
        {
            отчествоTextBox.Text = ((MainForm)MdiParent).firstUp(отчествоTextBox.Text);
        }

        private void противопоказанияTextBox_Leave(object sender, EventArgs e)
        {
            противопоказанияTextBox.Text = ((MainForm)MdiParent).firstUp(противопоказанияTextBox.Text);
        }

        private void примечание_о_клиентеTextBox_Leave(object sender, EventArgs e)
        {
            примечание_о_клиентеTextBox.Text = ((MainForm)MdiParent).firstUp(примечание_о_клиентеTextBox.Text);
        }

        private void соглашениеTextBox_Leave(object sender, EventArgs e)
        {
            соглашениеTextBox.Text = ((MainForm)MdiParent).firstUp(соглашениеTextBox.Text);
        }

        private void как_узнал_о_салонеTextBox_Leave(object sender, EventArgs e)
        {
            как_узнал_о_салонеTextBox.Text = ((MainForm)MdiParent).firstUp(как_узнал_о_салонеTextBox.Text);
        }

        #endregion
    }
}
