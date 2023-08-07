using System;
using System.Diagnostics.Metrics;

namespace lesson08
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Ex. 1
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i == 5)
            //        break;
            //    else
            //        Console.WriteLine(i);
            //}

            //Ex. 2
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i < 9)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //Ex. 3
            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j <= 5; j++)
            //    {
            //        for (int k = 0; k <= 5; k++)
            //        {
            //            Console.WriteLine(k);
            //            if (k == 5)
            //                goto con;
            //        }
            //        Console.WriteLine(j);
            //    }
            //    Console.WriteLine(i);
            //}
            //con: Console.WriteLine("Goto");

            //Ex. 4
            //string StatusCode = "Admin";
            //switch (StatusCode) 
            //{
            //    case "Admin":
            //        Console.WriteLine("1");
            //        goto case "User";
            //    case "NoAdmin":
            //        Console.WriteLine("2");
            //        goto case "NoUser";
            //    case "User":
            //        Console.WriteLine("3");
            //        break;
            //    case "NoUser":
            //        Console.WriteLine("4");
            //        break;
            //}

            //Ex. 5
            //int harajat = 5000, quyilganSumma = 500, number = 1100;
            //int result = FoyidaniHisoblash(harajat, quyilganSumma, number);
            //Console.WriteLine("Foyida" + result + "Summa");

            //Ex. 6
            //try
            //{
            //    Counter();
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Catch is running and errors are being detected." + Environment.NewLine + ex.Message); ;
            //}

            //Ex. 7
            //int a = 5;
            //string result = string.Empty;
            //result = (a == 5) ? "Great" : "Bad";
            //Console.WriteLine(result);
        }

        static int FoyidaniHisoblash(int harajatlar, int quyilganSum, int number)
        {
            return (quyilganSum * number) - harajatlar;
        }

        static void Counter() 
        {
            int x = 7;
            throw new Exception("10-number error!");
        }
    }
}