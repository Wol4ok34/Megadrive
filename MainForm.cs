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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEX_BalandinDataSet.NoAuthorization". При необходимости она может быть перемещена или удалена.
            this.noAuthorizationTableAdapter.Fill(this.demoEX_BalandinDataSet.NoAuthorization);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenedgerForm form = new MenedgerForm();
            form.Show();
        }
    }
}
