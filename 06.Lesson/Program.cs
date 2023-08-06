using System;

namespace lesson06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex. 1
            //string users = string.Empty;
            //Console.Write("Enter your name: ");
            //users = Console.ReadLine();
            //if (users == "Admin")
            //    Console.WriteLine("Welcome!");
            //else if (users == "Админ")
            //    Console.WriteLine("Welcome! {0}", users);
            //else
            //    Console.WriteLine("Welcome {0}", users);

            //Ex. 2
            int number = 0;
            Console.WriteLine("enter your number 1 to 5");
            char enterNumber = Console.ReadKey().KeyChar;
            int.TryParse(enterNumber.ToString(), out number);
            switch (number)
            {
                case 1: Console.WriteLine("one");
                    break;
                case 2: Console.WriteLine("two");
                    break;
                case 3: Console.WriteLine("three");
                    break;
                case 4: Console.WriteLine("four");
                    break;
                case 5: Console.WriteLine("five");
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }
    }
}