using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int even = 0;
            int odd = 0;
            int sum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    even += num;
                }
                else
                {
                    odd += num;
                }
                 sum = even - odd;
                
            }
            return sum;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
             int [] myString = { str1.Length, str2.Length, str3.Length, str4.Length };
             Array.Sort(myString);
             return myString[0];
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
