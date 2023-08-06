using System;

namespace lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void VariableLive()
        {
            int countSum = 10;
            countSum = countSum + 10;
        }

        static int countSum;

        static void VaribaleSimple()
        {
            countSum = 100;
        }
    }
}