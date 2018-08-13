using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerQuestion
{
    public class Equation
    {
        public static int One(int naturalNumber)
        {
            int result = 0;
            for (int i = 1; i < naturalNumber; i++)
            {
                result += (Math.IsDivisible(3, i) || Math.IsDivisible(5, i)) ? i : 0;
            }

            return result;
        }

        public static long Two(int count)
        {
            return EvenFibonacciSum(count);
        }

        public static long Three(long value)
        {
            return LargestPrimeNumber(value);
        }

        public static long Four(int digits)
        {
            return DeterminePalindrome(digits).Max();
        }

        public static Int64 Five(IList<Int64> numbers)
        {
            Int64 n1 = numbers[0];
            Int64 n2;

            for (var i = 1; i < numbers.Count; i++)
            {
                n2 = numbers[i];
                n1 = Math.LeastCommonMultiple(n1, n2);
            }

            return n1;
        }

        public static Int64 Six(int numberOfTerms)
        {
            return SquareOfSums(numberOfTerms) - SumOfSquares(numberOfTerms);
        }

        public static Int64 Seven(int primeIndex)
        {
            var primes = new List<Int64>();
            var i = 0;
            do
            {
                if (Math.IsPrime(i))
                    primes.Add(i);

                i++;

                if (primes.Count == primeIndex)
                    break;
            } while (true);

            return primes[primeIndex - 1];
        }

        public static Int64 Eight(string fullString, int numberWithinSubstring)
        {
            var topNumber = 0;

            for (int i = 0; i < fullString.Length; i++)
            {
                if ((i + numberWithinSubstring) > fullString.Length)
                    break;

                var subString = fullString.Substring(i, numberWithinSubstring);
                var segmentProd = 1;

                foreach (var c in subString)
                {
                    segmentProd *= Int32.Parse(c.ToString());
                }

                topNumber = (segmentProd > topNumber) ? segmentProd : topNumber;
            }

            return topNumber;
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
                if (Math.IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            var sum = 0L;
            primes.ForEach(i => sum += i);

            return sum;
        }


        public static long EvenFibonacciSum(int whenToStop)
        {
            var sum = 0L;
            var prevNum = 0L;
            var currentNum = 1L;
            var result = 0L;

            do
            {
                sum += Math.IsDivisible(2, result) ? result : 0;

                result = prevNum + currentNum;

                prevNum = currentNum;
                currentNum = result;
            } while (currentNum <= whenToStop);

            return sum;
        }

        public static long LargestPrimeNumber(long number)
        {
            var num = Math.GetFactors(number);
            var factors = new List<long>();
            foreach (var n in num)
            {
                if (Math.IsPrime(n))
                {
                    factors.Add(n);
                }
            }

            return factors.Max();
        }

        public static IList<long> DeterminePalindrome(int digitCount)
        {
            var maxNum1 = Int32.Parse(new string('1', digitCount)) * 9;
            var maxNum2 = Int32.Parse(new string('1', digitCount)) * 9;
            var results = new List<long>();

            var singleResult = 0L;
            for (int i = maxNum1; i >= 0; i--)
            {
                for (int j = maxNum2; j >= 0; j--)
                {
                    singleResult = i * j;
                    if (Math.IsPalindrome(singleResult))
                    {
                        results.Add(singleResult);
                        break;
                    }
                }
            }
            
            return results;
        }
    }
}
