using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.Write("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 12)
                {
                    Console.WriteLine("Yo do not access!");
                }
                else
                {
                    Console.WriteLine("Welcome!");
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