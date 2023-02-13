using System;

namespace BulkUp{
    class AnswerBulkUp{
        public static void Main(string[] args){
            int sum = 0, largest = 0;
            int max = Convert.ToInt32(Console.ReadLine());
            int[] x = new int [3];
            int[] y = new int [2];

            x[0] = Convert.ToInt32(Console.ReadLine());
            x[1] = Convert.ToInt32(Console.ReadLine());
            x[2] = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 3; i++){
                for(int j = i+1 ; j < 3; j++){
                    sum = x[i] + x[j];
                    if (sum > largest && sum <= max){
                        largest = sum;
                        y[0] = x[i];
                        y[1] = x[j];
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("{0}\n{1}", y[0], y[1]);
        }
    }
}

