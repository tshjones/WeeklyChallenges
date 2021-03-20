using System;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        //adds even numbers in array, subtracts odd numbers
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int even = numbers.Where(x=>x%2==0).Sum();
            int odd = numbers.Where(x=>x%2==1).Sum();
            return even - odd;
        }
        //return length of shortest string from four string arguments
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return Math.Min(Math.Min(str1.Length, str2.Length), Math.Min(str3.Length, str4.Length));
        }
        //return smallest number from four integer arguments
        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
        }
        //changes name in business class to TrueCoders
        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }
        //checks to see if all three sides can produce triangle
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1
                && sideLength1 + sideLength3 > sideLength2;
        }
        //can string be parsed into a number?
        public bool IsStringANumber(string input)
        {
            try
            {
                double.Parse(input);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //if over 50% of elements in array are null, returns true
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int count = objs.Count(x => x == null);
            return count > objs.Length / 2;
        }
        //average of all even numbers in int array
        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Count(x => x % 2 == 0) == 0)
                return 0;
            return numbers.Where(x => x % 2 == 0).Average();
        }
        //returns factorial of number, or error if number less than 0
        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException();
            int fact = 1;
            for (int i = number; i > 1; i--)
                fact *= i;
            return fact;
        }
    }
}
