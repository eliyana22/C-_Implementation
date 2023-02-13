using System;
namespace Calculator{
    class AnswerCalculator{         
        static void Main(string[] args){

                string input;
                int num1, num2, ans;
                string op;
                input = Console.ReadLine();

                string[] strlist = input.Split(new char[0]);

                num1 = Convert.ToInt32(strlist[0]);  
                op = strlist[1];                           
                num2 = Convert.ToInt32(strlist[2]);

                switch(op){
                    case "*":ans = num1 * num2; Console.WriteLine(ans);break;
                    case "/":ans = num1 / num2; Console.WriteLine(ans);break;
                    case "+":ans = num1 + num2; Console.WriteLine(ans);break;
                    case "-":ans = num1 - num2; Console.WriteLine(ans);break;
                    default: Console.WriteLine("Invalid Input");break;
                }
        }
    }
}

