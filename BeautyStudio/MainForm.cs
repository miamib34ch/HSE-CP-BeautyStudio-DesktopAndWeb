using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            fileName = Application.StartupPath + "\\pass.txt";
        }

        string fileName;

        birthdays birthdays;
        visitings visitings;
        Dictionaries dictionaries;
        AddClient addClient;

        public Clients clients { get; set; }
        public Visiting addVisit { get; set; }
        public AddClient changeClient { get; set; }

        #region открытие дочерних форм 

        private void показатьВсехКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.MdiParent = this;
            this.clients = clients;
            clients.Show();
            if (MdiChildren.Contains(addClient) || MdiChildren.Contains(changeClient))
            {
                clients.Enabled = false;
                if (MdiChildren.Contains(addClient))
                    addClient.clients = clients;
                else
                    changeClient.clients = clients;
            }
        }

        private void добавитьНовогоКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Contains(clients))
            {
                addClient = new AddClient(clients);
                clients.Enabled = false;
            }
            else
                addClient = new AddClient();
            addClient.MdiParent = this;
            addClient.Show();
        }

        private void показатьУКогоСегодняДеньРожденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            birthdays birth = new birthdays();
            birth.MdiParent = this;
            birthdays = birth;
            birth.Show();
        }

        private void поискПосещенийПоДатеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitings visitings = new visitings();
            visitings.MdiParent = this;
            this.visitings = visitings;
            visitings.Show();
        }

        private void обновитьСловариToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() == 0)
            {
                Password psw = new Password();
                if (psw.ShowDialog() == DialogResult.OK)
                {
                    Dictionaries dictionaries = new Dictionaries();
                    dictionaries.MdiParent = this;
                    this.dictionaries = dictionaries;
                    dictionaries.Show();
                }
            }
            else
                MessageBox.Show("Закройте все окна, прежде чем перейти к редактированию словарей!");
        }

        #endregion

        #region учитывание открытых окон 

        private void клиентыToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (this.MdiChildren.Contains(clients) || this.MdiChildren.Contains(dictionaries))
            {
                показатьВсехКлиентовToolStripMenuItem.Enabled = false;
                if (!this.MdiChildren.Contains(dictionaries))
                    показатьВсехКлиентовToolStripMenuItem.Image = BeautyStudio.Properties.Resources.selected;
                else
                    показатьВсехКлиентовToolStripMenuItem.Image = null;
            }
            else
            {
                показатьВсехКлиентовToolStripMenuItem.Enabled = true;
                показатьВсехКлиентовToolStripMenuItem.Image = null;
            }


            if (this.MdiChildren.Contains(addClient) || this.MdiChildren.Contains(dictionaries) || this.MdiChildren.Contains(addVisit))
            {
                добавитьНовогоКлиентаToolStripMenuItem.Enabled = false;
                if (!(this.MdiChildren.Contains(dictionaries) || this.MdiChildren.Contains(addVisit)))
                    добавитьНовогоКлиентаToolStripMenuItem.Image = BeautyStudio.Properties.Resources.selected;
                else
                    добавитьНовогоКлиентаToolStripMenuItem.Image = null;
            }
            else
            {
                if (MdiChildren.Contains(changeClient))
                {
                    добавитьНовогоКлиентаToolStripMenuItem.Enabled = false;
                    добавитьНовогоКлиентаToolStripMenuItem.Image = null;
                }
                else
                {
                    добавитьНовогоКлиентаToolStripMenuItem.Enabled = true;
                    добавитьНовогоКлиентаToolStripMenuItem.Image = null;
                }
            }
        }

        private void функцииToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (this.MdiChildren.Contains(birthdays) || this.MdiChildren.Contains(dictionaries))
            {
                показатьУКогоСегодняДеньРожденияToolStripMenuItem.Enabled = false;
                if (!this.MdiChildren.Contains(dictionaries))
                    показатьУКогоСегодняДеньРожденияToolStripMenuItem.Image = Properties.Resources.selected;
                else
                    показатьУКогоСегодняДеньРожденияToolStripMenuItem.Image = null;
            }
            else
            {
                показатьУКогоСегодняДеньРожденияToolStripMenuItem.Enabled = true;
                показатьУКогоСегодняДеньРожденияToolStripMenuItem.Image = null;
            }

            if (this.MdiChildren.Contains(visitings) || this.MdiChildren.Contains(dictionaries))
            {
                поискПосещенийПоДатеToolStripMenuItem.Enabled = false;
                if (!this.MdiChildren.Contains(dictionaries))
                    поискПосещенийПоДатеToolStripMenuItem.Image = Properties.Resources.selected;
                else
                    поискПосещенийПоДатеToolStripMenuItem.Image = null;
            }
            else
            {
                поискПосещенийПоДатеToolStripMenuItem.Enabled = true;
                поискПосещенийПоДатеToolStripMenuItem.Image = null;
            }
        }

        private void свойстваToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (this.MdiChildren.Contains(dictionaries))
            {
                обновитьСловариToolStripMenuItem.Enabled = false;
                обновитьСловариToolStripMenuItem.Image = Properties.Resources.selected;
                сменитьПарольАдминаToolStripMenuItem.Visible = true;
            }
            else
            {
                обновитьСловариToolStripMenuItem.Enabled = true;
                обновитьСловариToolStripMenuItem.Image = null;
                сменитьПарольАдминаToolStripMenuItem.Visible = false;
            }

            if(MdiChildren.Count() == 0)
                упорядочитьОкнаToolStripMenuItem.Enabled=false;
            else
                упорядочитьОкнаToolStripMenuItem.Enabled = true;
        }

        #endregion

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
        }//делает первую букву заглавной

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Contains(addVisit))
                addVisit.btnCancel_Click(sender, e); //если не выполнить, то в базу данных добавится несохранненное посещение 
            if (this.MdiChildren.Contains(dictionaries))
                if(dictionaries.тип_иглыDataGridView.Visible == true)
                    dictionaries.btnBack_Click(sender, e); //если не выполнить, то в базу данных добавится несохранненный импорт
            Application.Exit();
        }

        private void упорядочитьОкнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                File.WriteAllText(fileName, toolStripTextBox1.Text);
                MessageBox.Show("Пароль изменён!");
            }
        } //смена пароля админа
    }
}
