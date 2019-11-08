using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //throw new NotImplementedException();

           /string[] nouns = { "apple", "dog", "zebra", "tree", "umbrella", "church" ,"kicker"};

            string noun = "umbrella";

            bool hasUmbrella = nouns.Contains(noun);

            Console.WriteLine
             (
             "The array {0} contain '{1}'.",
             hasUmbrella ? "true" : "false",
             noun
             );
        }
        public bool IsPrimeNumber(int num)
        {

              for (int i = 3; i < num; i++)
            {
                if (num  % i == 0)
                {
                    return true;
                }

                if (i == num)
                {
                    return true;
                }
            }
            return false;
        }
                  
        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {

            int rnum = numbers[0];
            int rcount = 1;

            int currentCount = 0;
            int previousInt = int.MinValue;
            foreach (int number in numbers)
            {
                if (number != previousInt)
                {
                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                }

                if (currentCount >= rcount)
                {
                    rnum = number;
                    rcount = currentCount;
                }

                previousInt = number;
            }

                    return rnum;

        }   
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
