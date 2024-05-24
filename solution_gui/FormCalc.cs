using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicalFinal
{
    public partial class Form2 : Form
    {
        private List<Person> personList;
        private Person person; private Person oldPerson;
        public Form2(List<Person> personList, Person person)
        {
            InitializeComponent();
            this.personList = personList;
            this.person = person;
            this.oldPerson = person;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += "1";
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += "2";
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += "3";
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += "4";
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += "5";
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += "6";
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += "7";
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += "8";
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += "9";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text = "";
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += "0";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += " + ";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            calcScreen.Text += " - ";
        }

        private void timesBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += " * ";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            calcScreen.Text += " / ";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), calcScreen.Text);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                calcScreen.Text = "= " + row["expression"].ToString();
                person.addCalc();
            }
            catch
            {
                calcScreen.Text = "!!! ERROR !!!";
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            writeCSV();

            FormMain.formMainInstance.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            writeCSV();

            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void writeCSV()
        {
            personList.Remove(oldPerson);
            personList.Add(person);

            using (StreamWriter writer = new StreamWriter(FormMain.CredentialsPath))
            {
                foreach (Person person in personList)
                {
                    writer.WriteLine(person.getData());
                }
            }
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile(personList, person);
            formProfile.Show();
            this.Close();
        }
    }
}
