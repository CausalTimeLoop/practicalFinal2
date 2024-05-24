using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practical2Extension
{
    class Calc
    {
        public void sequentialOperation()
        {
            Console.Clear();

            Console.Write("Enter a simple ( + - * / ) expression: ");
            string input = Console.ReadLine();

            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), input);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                input = "= " + row["expression"].ToString();
                Console.WriteLine("\n"+input);
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("\n!!! INVALID !!!");
                Console.ReadKey();
            }
        }

        public void moduloOperation()
        {
            Console.Clear();

            try
            {
                Console.Write("Dividend of the operation: ");
                double dividend = double.Parse(Console.ReadLine());
                Console.Write("Divisor of the operation: ");
                double divisor = double.Parse(Console.ReadLine());

                double remainder = dividend;

                while (remainder >= divisor)
                {
                    remainder -= divisor;
                }
                Console.WriteLine("\n= " + remainder);
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("\n!!! INVALID !!!");
                Console.ReadKey();
            }
        }
        public void squareOperation()
        {
            Console.Clear();
            try
            {
                Console.Write("Value of the operation: ");
                double value = double.Parse(Console.ReadLine());
                

                if (value < 0)
                {
                    throw new ArgumentException("\n!!! CANNOT COMPUTE NEGATIVE NUMBER !!!");
                }

                double guess = value / 2;
                double previousGuess;
                do
                {
                    previousGuess = guess;
                    guess = (guess + value / guess) / 2;
                } while (Math.Abs(guess - previousGuess) > double.Epsilon);

                Console.WriteLine("\n= " + guess);
                Console.ReadKey();


            }
            catch
            {
                Console.WriteLine("\n!!! INVALID !!!");
                Console.ReadKey();
            }

        }
    }
}
