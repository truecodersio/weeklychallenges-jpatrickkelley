using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            // Declaration of data type 
            bool result;
            // checking if c is a 
            // Unicode letter or not 
            if (true)
            {
                return result = Char.IsLetter(c);
            }
            else
            {

            }
        }
        public bool CountOfElementsIsEven(string[] vals)
        {
            int count = 0;  // data tyype declare
            foreach (var value in vals)   //Loop to iterate through values
            {
                count++;   // to increase count
            }
            return count % 2 == 0;  // returns even values by using modulus (no remainder)
        }
        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }
        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }
        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double max = 0;
            double min = 0;
            double sum = 0;
            double counter = 0;

            if(numbers != null)
            {
                foreach (var num in numbers)
                {
                    if (max == 0 && min == 0 && counter == 0)
                    {
                        max = num;
                        min = num;
                        counter++;
                    }
                    else
                    {
                        if (num > max)
                        {
                            max = num;
                        }
                        if (num < min)
                        {
                            min = num;
                        }
                    }
                    sum = max + min;
                }
            }
            else
            {
                sum = 0;
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)    // compares string length
            {
                return str2.Length;  // if 2 is shorter  returns value of 2
            }
            else
            {

            }
            return str1.Length;
        }
        public int Sum(int[] numbers)
        {
            if (numbers == null)    // have to check for null first in its own statement
            {
                return 0;
            }
            int[] number = new int[] { 5, 5, 6, 7 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int[] number = new int[] { };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)

                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            return sum;
        }
        public bool IsSumOdd(List<int> numbers)
        {
            List<int> digits = new List<int>();  //create list
            int sum = 0;                         // create var to hold info
            if (numbers == null)                  // have to check for null first in its own statement
                return false;
            foreach (int num in numbers)        // iterate through value
            {
                sum += num;                     // changes value to sum
            }
            if (sum % 2 == 0)                   // checks to see if sum is even
            {
                return false;                   // if even returns false 
            }
            else
            {
                return true;
            }

        }
        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var counter = 0;
            var myLong = new long();
            

            for(myLong = 0; myLong < number; myLong++)
            {
                if(myLong % 2 != 0)
                    counter++;
            }
            return counter;
             
        }
    }
}





