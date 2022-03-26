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
    public partial class Password : Form
    {
        public string password { get; set; }

        public Password()
        {
            InitializeComponent();
            string fileName = Application.StartupPath + "\\pass.txt";

            System.IO.StreamReader sr = new System.IO.StreamReader(System.IO.File.OpenRead(fileName));
            password = sr.ReadLine();
            sr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == password)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                label.Text = "Неверный пароль! Повторите попытку!";
            }
        }

        private void Password_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
