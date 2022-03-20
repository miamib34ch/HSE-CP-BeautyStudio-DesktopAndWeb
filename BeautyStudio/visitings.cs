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
    public partial class visitings : Form
    {
        public visitings()
        {
            InitializeComponent();
        }

        private void visitings_Load(object sender, EventArgs e)
        {
            this.скидкаTableAdapter.Fill(this.beautyStudioDataSet.Скидка);
            this.тип_иглыTableAdapter.Fill(this.beautyStudioDataSet.Тип_иглы);
            this.клиентTableAdapter.Fill(this.beautyStudioDataSet.Клиент);
            this.тип_иглыTableAdapter.Fill(this.beautyStudioDataSet.Тип_иглы);
            this.клиентTableAdapter.Fill(this.beautyStudioDataSet.Клиент);
            this.посещениеTableAdapter.FillByDate(this.beautyStudioDataSet.Посещение, dateTimePicker1.Value);
        }

        private void посещениеDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.посещениеTableAdapter.FillByDate(this.beautyStudioDataSet.Посещение, dateTimePicker1.Value);
        }

        private void visitings_Activated(object sender, EventArgs e)
        {
            this.посещениеTableAdapter.FillByDate(this.beautyStudioDataSet.Посещение, dateTimePicker1.Value);
        }
    }
}
