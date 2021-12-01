using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // RandomArray();
            TossCoin();
        }

        public static void RandomArray()
        {
        // Create a function called RandomArray() that returns an integer array//
            // Place 10 random integer values between 5-25 into the array
            // Print the min and max values of the array
            // Print the sum of all the values
        int[] randArray;
        randArray = new int[] {5,7,9,19,18,6,21,10,12,15};
        {
        int currMin = int.MaxValue;
        int currMax = int.MinValue;
        int sum = 0;

        foreach (int num in randArray)
        {
            sum += num;
            if(currMax < num)
                currMax = num;
            if(currMin > num)
                currMin = num;
        }
        Console.WriteLine($"Min: {currMin}");
        Console.WriteLine($"Max: {currMax}");
        Console.WriteLine($"sum: {sum}");
        }
        }
        //Create a function called TossCoin() that returns a string//
            //Have the function print "Tossing a Coin!"
            //Randomize a coin toss with a result signaling either side of the coin 
            //Have the function print either "Heads" or "Tails"
            //Finally, return the result
        public static void TossCoin()
        {
        Console.WriteLine("Tossing a Coin!");
        Random ran = new Random();
        int randNum = ran.Next();
        if(randNum == 1)
        {
            Console.WriteLine("Heads");
        }
        else if(randNum == 2)
        {
            Console.WriteLine("Tails");
        }
        }

        //Create another function called TossMultipleCoins(int num) that returns a Double
            //Have the function call the tossCoin function multiple times based on num value
            //Have the function return a Double that reflects the ratio of head toss to total toss



        //Build a function Names that returns a list of strings.//
            //Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            //Shuffle the list and print the values in the new order
            //Return a list that only includes names longer than 5 characters

        List<string> thenames = new List<string>();
        thenames.Add("Todd");
        thenames.Add("Tiffany")
        thenames.Add("Charlie")
        thenames.Add("Genove")
        thenames.Add("Sydney")
    }
}
