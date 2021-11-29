using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args){
            //The execution section does not always have to use ++
            for (int i = 1; i < 256; i = i + 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
