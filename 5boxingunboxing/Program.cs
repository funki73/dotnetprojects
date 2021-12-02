using System;
using System.Collections.Generic;

namespace boxingunboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<object>();

            myList.Add (7);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("Chair");

            int sum = 0;
            foreach(var item in myList)
            {
                Console.WriteLine(item);
                if(item is int)
                {
                    Console.WriteLine("Looks like we have an int!");
                    sum += (int)item;
                    Console.WriteLine($"Current sum: {sum}");
                }
            }
        }
    }
}
