using System;

namespace Giraffe_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  
            // GET INTEGER
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);
          */

            // GET DOUBLE
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("THE SUM OF TWO NUMBER IS " + num1 + num2);
        }
    }
}
