using System;

namespace BigSightedness{
    class AnagramBigSightedness{
        public static void Main(string[] args){
            string input;
            
            input = Console.ReadLine();

            for(int i = 0; i < 5; i++){
                for(int j = 0; j < input.Length; j++){
                    if(input[j] == 'A'){
                        if(i == 0)
                            Console.Write("*** ");
                        else if(i == 1)
                            Console.Write("* * ");
                        else if(i == 2)
                            Console.Write("*** ");
                        else if(i == 3)
                            Console.Write("* * ");
                        else if(i == 4)
                            Console.Write("* * ");
                    }
                    else if(input[j] == 'B'){
                        if(i == 0)
                            Console.Write("**  ");
                        else if(i == 1)
                            Console.Write("* * ");
                        else if(i == 2)
                            Console.Write("**  ");
                        else if(i == 3)
                            Console.Write("* * ");
                        else if(i == 4)
                            Console.Write("**  ");
                    }
                    else if(input[j] == 'C'){
                        if(i == 0 || i == 4)
                            Console.Write("*** ");
                        else if(i < 4)
                            Console.Write("*   ");
                    }
                }
                Console.Write("\n");
            }

            
        }
    }
}