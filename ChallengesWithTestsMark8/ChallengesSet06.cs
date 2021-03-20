using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        //checks enumerable to see if it contains word, ignoring case is an option
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
                return false;
            if(!ignoreCase)
                return words.Contains(word);
            words = words.Where(x=>x!=null).Select(x => x.ToLower());
            word = word.ToLower();
            return words.Contains(word);
        }
        //checks whether number is prime
        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
                return false;
            for (int i = 2; i <= num / 2; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        //returns index of last unique character in string, or -1
        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            var charCount = new Dictionary<char, int>();
            for(int i = 0; i < str.Length; i++)
            {
                if (!charCount.ContainsKey(str[i]))
                    charCount.Add(str[i], 1);
                else
                    charCount[str[i]]++;
            }
            for (int i = 0; i < str.Length; i++)
                if (charCount[str[i]] == 1)
                    index = i;
            return index;
        }
        //returns count of max number of repeated consecutive numbers
        public int MaxConsecutiveCount(int[] numbers)
        {
            int local = 1;
            int max = 1;
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                    local++;
                else
                    local = 1;
                if (local > max)
                    max = local;
            }
            return max;
        }
        //returns array of every nth number in array
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var fourth = new List<double>();
            if (elements == null || n < 1)
                return fourth.ToArray();
            for (int i = n-1; i < elements.Count; i += n)
                fourth.Add(elements[i]);
            return fourth.ToArray();
        }
    }
}
