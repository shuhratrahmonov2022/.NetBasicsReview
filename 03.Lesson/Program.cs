using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");
        }

        static void VariableLive()
        {
            int countSum = 10;
            countSum = countSum + 10;
        }

        static int countSum;

        static void SimpleVariable()
        {
            countSum = 100;

        }
    }
}