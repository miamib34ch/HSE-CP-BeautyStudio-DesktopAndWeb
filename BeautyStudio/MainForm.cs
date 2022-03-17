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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Icon = BeautyStudio.Properties.Resources.iconBS;
        }

        Clients clients;
        AddClient addClient;
        public AddClient changeClient { get; set; }
        public Visiting addVisit { get; set; }

        private void показатьВсехКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(this.MdiChildren.Contains(clients)))
            {
                clients = new Clients();
            }
            clients.MdiParent = this;
            clients.Show();
            if (this.MdiChildren.Contains(addClient))
            {
                clients.Enabled = false;
                addClient.clients = clients;
            }
        }

        private void добавитьНовогоКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(this.MdiChildren.Contains(addClient)))
            {
                if (this.MdiChildren.Contains(clients))
                {
                    addClient = new AddClient(clients);
                    clients.Enabled = false;
                }
                else
                    addClient = new AddClient();
            }
            addClient.MdiParent = this;
            addClient.Show();
        }

        private void клиентыToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (this.MdiChildren.Contains(clients))
            {
                показатьВсехКлиентовToolStripMenuItem.Enabled = false;
                показатьВсехКлиентовToolStripMenuItem.Image = BeautyStudio.Properties.Resources.selected;
            }
            else
            {
                показатьВсехКлиентовToolStripMenuItem.Enabled = true;
                показатьВсехКлиентовToolStripMenuItem.Image = null;
            }
            if (this.MdiChildren.Contains(addClient))
            {
                добавитьНовогоКлиентаToolStripMenuItem.Enabled = false;
                добавитьНовогоКлиентаToolStripMenuItem.Image = BeautyStudio.Properties.Resources.selected;
            }
            else
            {
                if (MdiChildren.Contains(changeClient))
                {
                    добавитьНовогоКлиентаToolStripMenuItem.Enabled = false;
                    добавитьНовогоКлиентаToolStripMenuItem.Image = BeautyStudio.Properties.Resources.selected;
                }
                else
                {
                    добавитьНовогоКлиентаToolStripMenuItem.Enabled = true;
                    добавитьНовогоКлиентаToolStripMenuItem.Image = null;
                }
            }
        }

        private void найтиКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void обновитьСловариToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Password psw = new Password();
            if (psw.ShowDialog() == DialogResult.OK)
            {
                Dictionaries dictionaries = new Dictionaries();
                dictionaries.MdiParent = this;
                dictionaries.Show();
            }
        }
    }
}
