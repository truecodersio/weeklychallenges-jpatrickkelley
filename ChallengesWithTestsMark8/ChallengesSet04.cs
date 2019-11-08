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
            int[] myString = { str1.Length, str2.Length, str3.Length, str4.Length };
            Array.Sort(myString);
            return myString[0];
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] myArray = { number1, number2, number3, number4 };
            Array.Sort(myArray);
            return myArray[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)

        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
           return

                (

                sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1

                );
        }
        public bool IsStringANumber(string input)
        {

            return double.TryParse(input, out double number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var majority = (objs.Length / 2) + 1;
            var count = 0;
            foreach (var item in objs)
            {
                if (item == null)
                {
                    count++;
                }
            }

            if (count >= majority)

            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double count = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (int num in numbers)
            {

                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }
            if (count > 0)
            {
                return sum / count;
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            var fact = 1;

            for (int i = number; i > 0; i--)
            {
                fact *= i;

                if (number < 0)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            return fact;
        }
    }
}
