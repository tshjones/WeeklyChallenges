using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        //returns true if character argument is a letter
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }
        //returns true if length of array is even
        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }
        //returns true if number is even
        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }
        //returns true if number is odd
        public bool IsNumberOdd(int num)
        {
            return Math.Abs(num) % 2 == 1;
        }
        //returns sum of smallest and largest number from ienumerables 
        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
                return 0;
            var iList = numbers.ToList();
            if (iList.Count < 1)
                return 0;
            return numbers.Max() + numbers.Min();
        }
        //returns length of shortest string
        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }
        //returns sum of int array
        public int Sum(int[] numbers)
        {
            if (numbers == null)
                return 0;
            return numbers.Sum();
        }
        //Sum of every even number in int array
        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
            return numbers.Where(x=>x % 2 == 0).Sum();
        }
        //returns true if sum of all numbers in list is odd
        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            return Math.Abs(numbers.Sum()) % 2 == 1;
        }
        //Counts every positive odd number under number
        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for(int i = 1; i < number; i+=2)
                count++;
            return count;
        }
    }
}
