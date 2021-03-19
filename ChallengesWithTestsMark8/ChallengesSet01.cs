using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {

        //tests if two integers equal to each other, true or false
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            return num1 == num2;
        }
        //subtracts second argument from first, returns result
        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }
        //adds two numbers together, returns result
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        //returns smalles of two arguments
        public int GetSmallestNumber(int number1, int number2)
        {
            return Math.Min(number1, number2);
        }
        //multiplies two numbers, returns results
        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }
        //returns hello + argument as string
        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
                return "Hello!";
            return "Hello, " + nameOfPerson + "!";
        }
        //returns "Hey!"
        public string GetHey()
        {
            return "HEY!";
        }
    }
}
