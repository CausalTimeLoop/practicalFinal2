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
    public partial class FormProfile : Form
    {
        private List<Person> personList;
        private Person person; private Person oldPerson;
        public FormProfile(List<Person> personList, Person person)
        {
            InitializeComponent();
            this.personList = personList;
            this.person = person;
            this.oldPerson = person;
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            usernameBox.Text = person.getUser();
            passwordBox.Text = person.getPass();
            legalnameBox.Text = person.getName();
            emailBox.Text = person.getMail();
            operationsBox.Text = (person.getCalcs()).ToString();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(personList, person);
            form2.Show();
            this.Close();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                personList.Remove(oldPerson);
                personList.Add(new Person(usernameBox.Text, passwordBox.Text, legalnameBox.Text, emailBox.Text, int.Parse(operationsBox.Text)));

                using (StreamWriter writer = new StreamWriter(FormMain.CredentialsPath))
                {
                    foreach (Person person in personList)
                    {
                        writer.WriteLine(person.getData());
                    }
                }
            }
            catch
            {
                applyBtn.Text = "!ERROR!";
                applyBtn.ForeColor = Color.Red;
                usernameBox.Text = oldPerson.getUser();
                passwordBox.Text = oldPerson.getPass();
                legalnameBox.Text = oldPerson.getName();
                emailBox.Text = oldPerson.getMail();
                operationsBox.Text = (oldPerson.getCalcs()).ToString();
            }
          
        }
    }
}
