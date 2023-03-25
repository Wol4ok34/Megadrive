using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мегадрайф
{
    public partial class MenedgerForm : Form
    {
        public MenedgerForm()
        {
            InitializeComponent();
        }

        private void MenedgerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEX_BalandinDataSet1.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.demoEX_BalandinDataSet1.Zakaz);

        }
    }
}
