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
    public partial class birthdays : Form
    {
        public birthdays()
        {
            InitializeComponent();
        }

        private void birthdays_Load(object sender, EventArgs e)
        {
            this.клиентTableAdapter.FillByBirthday(this.beautyStudioDataSet.Клиент, DateTime.Now);
        }

        private void birthdays_Activated(object sender, EventArgs e)
        {
            this.клиентTableAdapter.FillByBirthday(this.beautyStudioDataSet.Клиент, DateTime.Now);
        }
    }
}
