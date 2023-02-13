using System;

namespace Giraffe_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAY OF INTEGER 
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine("Lucky Number in Arrays : " + luckyNumbers[2]);

            // ARRAY OF STRING THAT HAS 10 VALUE
            String[] friends = new string[10];
            friends[0] = "Jim";
            friends[1] = "Kelly";

            Console.WriteLine("\nName of Friend : " + friends[0]);

            Console.ReadLine(); 
        }
    }
}
