using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            try
            {
                Console.Write("Enter your age: ");
                Age = Convert.ToInt32(Console.ReadLine());
                if (Age <= 12)
                {
                    Console.WriteLine("You do not have access!");
                }
                else
                {
                    Console.WriteLine("Welcome");
                }
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine(dex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
