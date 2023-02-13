using System;

namespace _1_2_3_what
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            String num = Console.ReadLine();

            for (int i = 0; i < num.Length; i++) {
                if ((num[i] - 48) > 3) {
                    Console.WriteLine(num[i]);
                    flag++;
                }
            }

            if (flag == 0) {
                Console.WriteLine("none");
            }
        }
    }
}
