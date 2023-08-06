using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
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
    }
}