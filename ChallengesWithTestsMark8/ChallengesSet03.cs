using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        //checks whether array has false value
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }
        //determines whether sum of collection is odd
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;
            return Math.Abs(numbers.Sum()) % 2 == 1; 
        }
        //checks whether string has uppercase, lowercase letter and digit
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(c => char.IsDigit(c)) && password.Any(c => char.IsLower(c)) && 
                password.Any(c=>char.IsUpper(c));
        }
        //return char at index 0 of string
        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }
        //returns char at end of string
        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }
        //returns division, if divisor zero returns zero
        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            return dividend / divisor;
        }
        //returns last element minus first element of int array
        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }
        //returns array of odd numbers below 100
        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1, 100).Where(x=>x%2==1).ToArray();
        }
        //turns strings in array to uppercase
        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
