using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerQuestion
{
    public class Problem004 : IProblem
    {
		public string Name { get { return "Largest palindrome product"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = DeterminePalindrome(3).Max(),
                GivenAnswer = 906609,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = DeterminePalindrome(2).Max(),
                GivenAnswer = 9009,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        private IList<Int64> DeterminePalindrome(int digitCount)
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
                    if (MathHelper.IsPalindrome(singleResult))
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
