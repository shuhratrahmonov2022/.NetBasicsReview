using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex. 1
            //Int32 int32Var = 65000;
            //Int64 int64Var;
            //int64Var = int32Var;
            //Console.WriteLine(int64Var);

            // Ex. 2
            //short shortVar = 10;
            //int intVar = 50;
            //shortVar = (short)(shortVar + intVar);
            //Console.WriteLine(shortVar);

            // Ex. 3
            //int intVar = 5;
            //string strVar = string.Empty;
            //strVar = Convert.ToString(intVar);
            //Console.WriteLine(strVar);

            //Ex. 4
            //string strVar = "70";
            //int intVar = 0;
            //intVar = int.Parse(strVar);
            //Console.WriteLine(intVar);

            //Ex. 5
            //bool enterNumber = false;
            //float number = 0;
            //Console.WriteLine("Hisobingizdan qancha pul echib olishni hohlaysiz?");
            //string text = Console.ReadLine();
            //enterNumber = float.TryParse(text, out number);
            //if (enterNumber)
            //{
            //    Console.WriteLine(string.Format("{0} - pul miqdori hisobingizdan echib olindi.", number));
            //}
            //else
            //{
            //    Console.WriteLine("Pul miqdori noto`g`ri kiritildi!");
            //    enterNumber = false;
            //}

            //Ex. 6
            const string about = "Aboit Program";
            const int month = 12, weeks = 52, days = 365;

            Console.WriteLine(about + Environment.NewLine + month + weeks + days);s
        }
    }
}