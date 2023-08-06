using System;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *   +   - Addition operator
             *   -   - Subtraction operator
             *   /   - Division operator 
             *   *   - Multiplication operator
             *   %   - Remainder operator 
             *   
             *  ++   - Increment operator
             *  --   - Decrement operator
             *
            */

            //Ex. 1
            //int numberA = 2;
            //int numberB = 3; 
            //int numberC = numberA + numberB;
            //int numberM;
            //numberM = numberC * (numberA - 1);
            //Console.WriteLine(numberM);

            //Ex. 2
            //int numberA = 7;
            //numberA += 1; // numberA = numberA + 1
            //numberA -= 2; // numberA = numberA - 2
            //numberA *= 3; // numberA = numberA * 3
            //numberA /= 2; // numberA = numberA / 2
            //numberA %= 4; // numberA = numberA % 4

            //Ex. 3
            //string strA = "Hello";
            //string strB = " ";
            //string strC = "World";
            //Console.WriteLine(strA + strB + strC);

            //Ex. 4
            //bool a = true;
            //bool b = false;
            //if(a != b)
            //    Console.WriteLine("Not equal!");
            //else
            //    Console.WriteLine("Equal!");

            //Ex. 5
            //bool a = true;
            //bool b = false;
            //if(a)
            //    Console.WriteLine("a - true");
            //else
            //    Console.WriteLine("a - false");

            //if(b)
            //    Console.WriteLine("b - true");
            //else
            //    Console.WriteLine("b - false");

            //Ex. 6
            int a = 10;
            int b = 20;
            if((a == 10) && (b == 20)) 
            {
                Console.WriteLine("a = 10 and b = 20");
            }
            else
                Console.WriteLine("false");
        }
    }
}