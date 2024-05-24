using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicalFinal
{
    public partial class FormMain : Form
    {
        public static FormMain formMainInstance;
        public static string CredentialsPath = "pwd.csv";
        public FormMain()
        {
            formMainInstance = this;

            WindowState = FormWindowState.Minimized;
            //ShowInTaskbar = false;
            //Visible = false;

            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void killBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
