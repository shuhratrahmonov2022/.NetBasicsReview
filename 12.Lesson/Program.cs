using System;
using System.Collections;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList, Hashtable, List, Queue, Stack, Dictionary

            //Ex. 1
            ArrayList arrayList = new ArrayList();
            arrayList.Add("one");
            arrayList.Add("two");
            arrayList.Add("three");
            Console.WriteLine("ArrayList data: " + arrayList.Count);

            arrayList.Insert(3, "Four");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Ex. 2 
            arrayList.RemoveAt(1);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Clear();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}