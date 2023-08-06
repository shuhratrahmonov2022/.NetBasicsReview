using System;
using System.Text;

namespace lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex. 1
            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine(i.ToString());
            //}

            //Ex. 2
            //string[] massiv = { "Khush kelibsiz", "Dobro pojalovat", "Welcome" };
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    Console.WriteLine(massiv[i]);
            //}

            //Ex. 3
            //int[] massiv = { 0, 1, 2, 3, 4, 5, 6, 7 };
            //int x = 0;
            //while (x < massiv.Length)
            //{
            //    Console.WriteLine(massiv[x]);
            //    x++;
            //}

            //Ex. 4
            //string key = string.Empty;
            //while (key != "parol")
            //{
            //    Console.WriteLine("Enter your key!");
            //    key = Console.ReadLine();
            //    if (key != "parol")
            //    {
            //        Console.WriteLine("Your key incorrect");
            //    }
            //    else
            //        Console.WriteLine("welcome!");
            //}

            //Ex. 5
            //int[] massiv = { 0, 1, 2, 3 };
            //int k = 0;
            //do
            //{
            //    Console.WriteLine(massiv[k].ToString());
            //    k++;
            //}
            //while (k <= 2);

            //Ex. 6
            //Console.Write("Enter your password:");
            //ConsoleKeyInfo ki;
            //StringBuilder sb = new StringBuilder();

            //do
            //{
            //    ki = Console.ReadKey(true);
            //    if (ki.Key != ConsoleKey.Backspace)
            //    {
            //        sb.Append(ki.KeyChar);
            //        Console.Write("*");

            //    }
            //    else
            //    {
            //        sb.Remove(sb.Length - 1, 1);
            //        Console.Write("\b \b");
            //    }

            //}
            //while (ki.Key != ConsoleKey.Enter);
            //Console.WriteLine();
            //Console.Write("Your Password: " + sb);

            //Ex. 7
            string[] massiv = { "acer", "asus", "dell", "fujitsu", "hp", "lenova", "lg", "msi", "toshiba" };
            foreach (var s in massiv)
            {
                Console.WriteLine(s);
            }

        }
    }
}