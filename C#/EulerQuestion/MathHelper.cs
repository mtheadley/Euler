using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerQuestion
{
    public class MathHelper
    {
        public static bool IsDivisible(int quotient, long value)
        {
            return ((value % quotient) == 0) ? true : false;
        }

        public static bool IsPrime(Int64 value)
        {
            return (MathHelper.GetFactors(value).Count == 2);
        }

        public static IList<long> GetFactors(Int64 value)
        {
            var result = new List<long>();

            var sqrt = (long)System.Math.Ceiling(System.Math.Sqrt(value));

            // Start from 1 as we want our method to also work when numberToCheck is 0 or 1.
            for (long i = 1; i < sqrt; i++)
            {
                if (value % i == 0)
                {
                    result.Add(i);
                    result.Add(value / i);
                }
            }

            // Check if our number is an exact square.
            if (sqrt * sqrt == value)
            {
                result.Add(sqrt);
            }

            return result;
        }

        public static bool IsPalindrome(long value)
        {
            var forward = new Stack<char>();
            var reverse = new Stack<char>();
            var valueAsString = value.ToString();

            for (var i = 0; i < valueAsString.Length; i++)
            {
                forward.Push(valueAsString[i]);
            }

            for (var i = valueAsString.Length - 1; i >= 0; i--)
            {
                reverse.Push(valueAsString[i]);
            }

            var result = true;
            while (forward.Count > 0 && reverse.Count > 0)
            {
                if (forward.Pop() != reverse.Pop())
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static Int64 LeastCommonMultiple(Int64 num1, Int64 num2)
        {
            return (num1 * num2) / GreatestCommonDivisor(num1, num2);
        }

        public static Int64 GreatestCommonDivisor(Int64 num1, Int64 num2)
        {
            var factors1 = GetFactors(num1);
            var factors2 = GetFactors(num2);

            var commonFactors = factors1.Intersect(factors2);

            return commonFactors.Max();
        }

        public static Int64 EvenFibonacciSum(Int64 whenToStop)
        {
            var sum = 0L;
            var prevNum = 0L;
            var currentNum = 1L;
            var result = 0L;

            do
            {
                sum += MathHelper.IsDivisible(2, result) ? result : 0;

                result = prevNum + currentNum;

                prevNum = currentNum;
                currentNum = result;
            } while (currentNum <= whenToStop);

            return sum;
        }


        public static Int64 LargestPrimeNumber(Int64 number)
        {
            var num = MathHelper.GetFactors(number);
            var factors = new List<Int64>();
            foreach (var n in num)
            {
                if (MathHelper.IsPrime(n))
                {
                    factors.Add(n);
                }
            }

            return factors.Max();
        }

        public static Int64 SumOfSquares(int numberOfTerms)
        {
            var result = 0;
            for (int i = 1; i <= numberOfTerms; i++)
            {
                result += (i * i);
            }

            return result;
        }

        public static Int64 SquareOfSums(int numberOfTerms)
        {
            var result = 0;
            for (int i = 1; i <= numberOfTerms; i++)
            {
                result += i;
            }

            return result * result;
        }

        public static Int64 SumOfPrimes(Int64 stoppingNumber)
        {
            var primes = new List<Int64>();

            for (var i = 1; i <= stoppingNumber; i++)
            {
                if (MathHelper.IsPrime(i))
                {
                    primes.Add(i);
                }
            }

	        var sum = primes.Sum();

            return sum;
        }

        public static Int64 MaxProductInList(IList<Int64> listOfNumbers, int numberOfTerms)
        {
            var topNumber = 0L;

            for (int i = 0; i <= listOfNumbers.Count; i++)
            {
                if ((i + numberOfTerms) > listOfNumbers.Count)
                    break;

                var segmentProd = 1L;

                for (int j = i; j < (i + numberOfTerms); j++)
                {
                    segmentProd *= listOfNumbers[j];
                }

                topNumber = (segmentProd > topNumber) ? segmentProd : topNumber;
            }

            return topNumber;
        }
    }
}
