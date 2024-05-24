using System;

namespace practical2Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int option;

            do
            {
                Console.Clear();

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(" 1. Square Root Operation");
                Console.WriteLine(" 2. Modulo Operation");
                Console.WriteLine(" 3. Sequential Combined Operation");
                Console.WriteLine(" 4. Exit");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine();
                Console.Write("-> ");

                try
                {
                    option = Int32.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            calc.squareOperation();
                            break;
                        case 2:
                            calc.moduloOperation();
                            break;
                        case 3:
                            calc.sequentialOperation();
                            break;
                        case 4:
                            return;
                    }
                }
                catch
                {
                    Console.WriteLine("\n!!! INVALID !!!");
                    Console.ReadKey();
                }

            } while (true);

        }
    }

}