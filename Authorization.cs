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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authenficazia_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Вход для не авторизированных пользователей
        {
           
            NoAuthorizationForm form = new NoAuthorizationForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e) //Вход для авторизированных пользователей
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }
    }
}
