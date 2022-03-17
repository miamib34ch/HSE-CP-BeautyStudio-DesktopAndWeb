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
                addClient = new AddClient(клиентBindingSource.Position, this, res);
            else
                addClient = new AddClient(клиентBindingSource.Position, this, 0);
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
                удалитьКлиентаToolStripMenuItem.Enabled = true;
                добавитьПосещениеКлиентуToolStripMenuItem.Enabled = true;
            }
            else
            {
                посмотретьИнформациюToolStripMenuItem.Enabled = false;
                изменитьИнформациюToolStripMenuItem.Enabled = false;
                удалитьКлиентаToolStripMenuItem.Enabled = false;
                добавитьПосещениеКлиентуToolStripMenuItem.Enabled = false;
            }
        }

        private void клиентDataGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = contextMenuStripClient;
        }

        private void удалитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string surname = клиентDataGridView.CurrentRow.Cells[1].Value.ToString();
            string name = клиентDataGridView.CurrentRow.Cells[2].Value.ToString();
            string fatherName = клиентDataGridView.CurrentRow.Cells[3].Value.ToString();
            var result = MessageBox.Show($"Удаление клиента: {surname} {name} {fatherName}", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int index = клиентDataGridView.CurrentRow.Index;
                DeleteRow(int.Parse(клиентDataGridView.CurrentRow.Cells[0].Value.ToString()));
                клиентDataGridView.Rows.Remove(клиентDataGridView.CurrentRow);
                клиентDataGridView.Refresh();
            }
        }

        void DeleteRow(int id)
        {
            SqlConnection conn = new SqlConnection($@"Data Source={connectionSourse};Initial Catalog= {bdName};Integrated Security=True;");
            conn.Open();
            var sqlq = $"DELETE FROM [dbo].[Клиент] WHERE [Id клиента] = @id";
            var cmd = new SqlCommand(sqlq, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void добавитьПосещениеКлиентуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visiting visit;
            visit = new Visiting(клиентDataGridView.CurrentRow.Cells[0].Value.ToString(),this);
            visit.MdiParent = this.MdiParent;
            visit.Show();
            this.Enabled = false;
            //((MainForm)MdiParent).addVisit = visit;
        }
    }
}
