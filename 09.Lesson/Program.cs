using System;

namespace lesson09
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteString("Assalom aleykum");

            //string a = WriteString("Assalom", "aleykum");
            //Console.WriteLine(a);

            // Starter();

            int intVar = 5;
            Console.WriteLine(intVar);
            TwoMultiply(ref intVar);
            Console.WriteLine(intVar);
        }

        //Ex. 1
        //Prosedure
        static void WriteString(string a)
        {
            Console.WriteLine(a + "!");
        }

        //Function
        static string WriteString(string a, string b) 
        {
            return a + b;
        }

        //Ex. 2
        //static void Starter()
        //{
        //    string word = Console.ReadLine();
        //    Console.WriteLine("you wrote it {0}",word);
        //}

        //Ex. 3
        static void TwoMultiply(ref int intVar)
        {
            intVar = intVar * 2;
        }
    }
}