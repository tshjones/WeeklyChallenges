using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        //returns the next number after startnumber divisible by n
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int i = startNumber+1; ; i++)
                if (i % n == 0)
                    return i;
        }
        //changes name string in business class to closed if no revenue
        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
                if (businesses[i].TotalRevenue <= 0)
                    businesses[i].Name = "CLOSED";
        }
        //checks whether each number in array is bigger than the last element
        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length < 1)
                return false;
            for (int i = 1; i < numbers.Length; i++)
                if (numbers[i] < numbers[i - 1])
                    return false;
            return true;
        }
        //sum of every element that follows an even number
        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
                return sum;
            for (int i = 1; i < numbers.Length; i++)
                if (numbers[i - 1] % 2 == 0)
                    sum += numbers[i];
                    
            return sum;
        }
        //takes string array and turns it into sentence, adds spaces and period.
        public string TurnWordsIntoSentence(string[] words)
        {
            if (words==null || !words.Any(i=>i.Any(c=>char.IsLetter(c))))
                return "";
            words = words.Where(x=>x.Any(c=>char.IsLetter(c))).Select(x => x.Trim()).ToArray();
            return string.Join(" ", words) + ".";
        }
        //filters array to return every fourth index value
        public double[] GetEveryFourthElement(List<double> elements)
        {
            var fourth = new List<double>();
            if (elements == null)
                return fourth.ToArray();
            for (int i = 3; i < elements.Count; i+=4)
                fourth.Add(elements[i]);
            return fourth.ToArray();
        }
        //O(n^2) test to see if two numbers in array can sum to target number
        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == targetNumber)
                        return true;
            return false;
        }
    }
}
