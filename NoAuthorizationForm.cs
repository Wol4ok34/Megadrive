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
    public partial class NoAuthorizationForm : Form
    {
        public NoAuthorizationForm()
        {
            InitializeComponent();
        }

        private void NoAuthorizationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEX_BalandinDataSet.NoAuthorization". При необходимости она может быть перемещена или удалена.
            this.noAuthorizationTableAdapter.Fill(this.demoEX_BalandinDataSet.NoAuthorization);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
