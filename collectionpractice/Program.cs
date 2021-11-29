using System;
using System.Collections.Generic;

namespace collectionpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays//
            //Create an array to hold integer values 0 through 9
            int[] numArray;
            numArray = new int[] {0,1,2,3,4,5,6,7,8,9};
            {
                Console.WriteLine(numArray);
            }

            //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};

            //Create an array of length 10 that alternates between true and false values, starting with true
            //<not started>

            //List of Flavors//
            //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            //Output the length of this list after building it
            //Output the third flavor in the list, then remove this value
            //Output the new length of the list (It should just be one fewer!)
            List<string> icecream = new List<string>();
            icecream.Add("Chocolate");
            icecream.Add("Vanilla");
            icecream.Add("Mint");
            icecream.Add("Strawberry");
            icecream.Add("Cookie dough");

            Console.WriteLine("There are {icecream.Count} flavors of ice cream.");
            Console.WriteLine(icecream[2]);

            for (var idx = 0; idx < icecream.Count; idx++)
            {
                Console.WriteLine(icecream[idx]);
            }
            icecream.Remove("Mint");

        }
    }
}
