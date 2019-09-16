using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            bool Boolean1 = (num1 == num2);
            bool Boolean2 = (num1 != num2);
            return Boolean1;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double a = (minuend - subtrahend);
            return a;


        }

        public int Add(int number1, int number2)
        {
            int a = (number1 + number2);
            return a;



        }

        public int GetSmallestNumber(int number1, int number2)
               
        {
            if (number2 > number1)
                return number1;
            if (number1 > number2)
                return number2;
            if (number1 == number2)
               
           {
                return number1;
           }
           else return 0;
        }
                
        
        




        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            return ("Hello!");
           
            else 
        
              return ("Hello, " + nameOfPerson + "!");

        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
