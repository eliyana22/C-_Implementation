using System;

namespace Anagram{
    class AnagramAnswer{
        public static void Main(string[] args){
            string input1, input2;
            int counter = 0;

            input1 = Console.ReadLine();
            input2 = Console.ReadLine();

            if (input1.Length != input2.Length){
                Console.WriteLine("false");
            }
            else{
                for(int i = 0; i < input1.Length; i++){
                    if(input1[i] == '?')
                        counter++;
                    for(int j = 0; j < input2.Length; j++){
                        if(input1[i] == input2[j])
                            counter++;
                    }
                }
                if(counter >= input1.Length)
                    Console.WriteLine("anagram");
                else
                    Console.WriteLine("false");
            }
        }
    }
}