using System;

namespace lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex. 1
            //int[] massiv1 = new int[5];
            //Console.WriteLine(massiv1[0].ToString());

            //Ex. 2
            //string[] massiv1 = { "Monday", "Tuesday", "Wedneday", "Thursday", "Friday" };
            //string[] massiv2 = new string[] { "Monday", "Tuesday", "Wedneday", "Thursday", "Friday" };
            //Console.WriteLine(massiv1[2]);
            //Console.WriteLine(massiv2[3]);

            //Ex. 3
            //int[] massiv;
            //Console.Write("Enter Massiv: ");
            //int i = int.Parse(Console.ReadLine());
            //massiv = new int[i];
            //massiv[1] = 7;
            //foreach (int k in massiv)
            //{
            //    Console.WriteLine(k.ToString());
            //}

            //Ex. 4
            //int[] massiv1 = { 1, 7, 13 };
            //int[] massiv2;
            //massiv2 = massiv1;
            //massiv2[1] = 9;
            //for (int j = 0; j < 3; j++)
            //{
            //    Console.WriteLine(massiv1[j].ToString());
            //    Console.WriteLine(massiv2[j].ToString());
            //}

            //Ex. 5
            //int[,] massiv1;
            //float[,,] massiv2;
            //massiv1 = new int[7, 7];
            //massiv2 = new float[5, 4, 7];
            //massiv1[4, 3] = 404;

            //Ex. 6
            //int[,] massiv1 = new int[9, 9];
            //for (int k = 0; k < 9; k++)
            //{
            //    for (int m = 0; m < 9; m++)
            //    {
            //        massiv1[k, m] = k * m;
            //        Console.WriteLine(massiv1[k,m].ToString());
            //    }
            //}

            //Ex. 7
            //int[,] massiv1 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //Ex. 8
            //string[] massiv = { "C#", "java", "delphi", "vb", "php", "perl", "python", "asm", "c++", "asm", "c#", "c++", "delphi", "java", "perl", "php", "python", "vn" };
            //foreach (string el in massiv)
            //{
            //    Console.WriteLine(el);
            //}
            //Console.WriteLine();
            //Array.Sort(massiv);
            //foreach (var item in massiv)
            //{
            //    Console.WriteLine(item);
            //}

            //Ex. 9
            string words = "This is example words!";
            char dividr = Convert.ToChar(" ");
            string[] wordsmassiv = words.Split(dividr);
            foreach (var item in wordsmassiv)
            {
                Console.WriteLine(item);
            }
        }
    }
}
