using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicalFinal
{
    public partial class FormLogin : Form
    {
        private List<Person> personList = new List<Person>();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            string user = userText.Text;
            string pass = passText.Text;

            if (CredentialsCheck(user, pass) != null)
            {
                Form2 form2 = new Form2(personList, CredentialsCheck(user, pass));
                form2.Show();
                this.Close();
            }
            else
            {
                loginBtn.Text = "!ERROR!";
                loginBtn.ForeColor = Color.Red;
                userText.Text = ""; passText.Text = "";
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            CredentialsLoad();
        }

        private void CredentialsLoad()
        {
            if (File.Exists(FormMain.CredentialsPath))
            {
                try
                {
                    string user; string pass; string name; string mail; int calcs;
                    string[] lines = File.ReadAllLines(FormMain.CredentialsPath);
                    foreach (string line in lines)
                    {
                        string[] data = line.Split(';');
                        user = data[0];
                        pass = data[1];
                        name = data[2];
                        mail = data[3];
                        calcs = int.Parse(data[4]);

                        personList.Add(new Person(user, pass, name, mail, calcs));
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("!!! Error Loading Credentials !!!");
                }
            }
        }

        private Person CredentialsCheck(string username, string password)
        {
            foreach (Person person in personList)
            {
                if ( (username == person.getUser()) && (password == person.getPass()) )
                {
                    return person;
                }
            }
            return null;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            FormMain.formMainInstance.Close();
        }
    }
}
