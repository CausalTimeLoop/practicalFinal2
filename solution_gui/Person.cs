using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practicalFinal
{
    public class Person
    {
        protected string user {  get; set; }
        protected string pass { get; set; }
        protected string name { get; set; }
        protected string mail { get; set; }
        protected int calcs { get; set; }

        public Person(string username, string password, string legalname, string email, int operations) 
        { 
            this.user = username;
            this.pass = password;
            this.name = legalname;
            this.mail = email;
            this.calcs = operations;
        }

        public string getUser()
        {
            return user;
        }

        public string getPass()
        {
            return pass;
        }

        public void addCalc()
        {
            calcs++;
        }
        
        public string getData()
        {
            string line = user+";"+pass+";"+name+";"+mail+";"+calcs;
            return line;
        }
        public string getName()
        {
            return name;
        }
        public string getMail()
        {
            return mail;
        }
        public int getCalcs()
        {
            return calcs;
        }
    }
}
