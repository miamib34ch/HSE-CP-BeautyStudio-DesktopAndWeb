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
    public partial class Clients : Form
    {

        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beautyStudioDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.beautyStudioDataSet.Клиент);
        }

        int lastSelectedRowId = 0;
        bool flag = true; //нужен для проверки была ли строка выбрана автоматически (при перезаливке таблицы) или вручную 
        public string connectionSourse = "(LocalDB)\\MSSQLLocalDB";
        public string bdName = "BeautyStudio";

        private void Clients_Activated(object sender, EventArgs e)
        {
            if (клиентDataGridView.Rows.Count != 0)
            {
                this.клиентTableAdapter.Fill(this.beautyStudioDataSet.Клиент);
                клиентDataGridView.ClearSelection();
                клиентDataGridView.Rows[lastSelectedRowId].Selected = true;
                flag = true;
            }
            else
            {
                this.клиентTableAdapter.Fill(this.beautyStudioDataSet.Клиент);
            }
        }

        private void Clients_Deactivate(object sender, EventArgs e)
        {
            if (клиентDataGridView.CurrentRow != null)
            {
                lastSelectedRowId = клиентDataGridView.CurrentRow.Index;
                flag = false;
            }
        }

        private void клиентDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (flag)
            {
                lastSelectedRowId = e.RowIndex;
            }
        }

        private void изменитьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient addClient;
            if (int.TryParse(клиентDataGridView.CurrentRow.Cells[6].Value.ToString(),out int res))
                addClient = new AddClient(int.Parse(клиентDataGridView.CurrentRow.Cells[0].Value.ToString()), this, res);
            else
                addClient = new AddClient(int.Parse(клиентDataGridView.CurrentRow.Cells[0].Value.ToString()), this, 0);
            addClient.MdiParent = this.MdiParent;
            addClient.Show();
            this.Enabled = false;
            ((MainForm)MdiParent).changeClient = addClient;
        }

        private void contextMenuStripClient_Opening(object sender, CancelEventArgs e)
        {
            if (lastSelectedRowId == клиентDataGridView.CurrentRow.Index) //соотвествует ли выбранная строка и подсвечиваемая 
            {
                посмотретьИнформациюToolStripMenuItem.Enabled = true;
                изменитьИнформациюToolStripMenuItem.Enabled = true;
                добавитьПосещениеКлиентуToolStripMenuItem.Enabled = true;
            }
            else
            {
                посмотретьИнформациюToolStripMenuItem.Enabled = false;
                изменитьИнформациюToolStripMenuItem.Enabled = false;
                добавитьПосещениеКлиентуToolStripMenuItem.Enabled = false;
            }
        }

        private void клиентDataGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = contextMenuStripClient;
        }

        private void добавитьПосещениеКлиентуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visiting visit;
            visit = new Visiting(клиентDataGridView.CurrentRow.Cells[0].Value.ToString(),this);
            visit.MdiParent = this.MdiParent;
            visit.Show();
            this.Enabled = false;
            ((MainForm)MdiParent).addVisit = visit;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (surnameSearch.Text != "")
            {
                this.клиентTableAdapter.FillBySurname(this.beautyStudioDataSet.Клиент, firstUp(surnameSearch.Text));
                
                surnameSearch.Text = "";
            }
            if (numberSearch.Text != "(   )    -" && numberSearch.Text.Length == 14)
            {
                this.клиентTableAdapter.FillByNumber(this.beautyStudioDataSet.Клиент, numberSearch.Text);
                numberSearch.Text = "(   )    -";
            }
        }

        public string firstUp(string s)
        {
            if (s != "")
            {
                var s0Up = char.ToUpper(s[0]);
                if (s0Up != s[0])
                {
                    string new_s = ""; 
                    new_s += s0Up;
                    for (int i = 1; i < s.Length; i++)
                    {
                        new_s += s[i].ToString();
                    }
                    return new_s;
                }
                else 
                    return s;
            }
            else
                return s;
        }

        private void посмотретьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientInfo info;
            if (int.TryParse(клиентDataGridView.CurrentRow.Cells[6].Value.ToString(), out int res))
                info = new ClientInfo(int.Parse(клиентDataGridView.CurrentRow.Cells[0].Value.ToString()), res);
            else
                info = new ClientInfo(int.Parse(клиентDataGridView.CurrentRow.Cells[0].Value.ToString()), 0);
            info.MdiParent = this.MdiParent;
            info.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
