using System;
using System.Collections.Generic;

namespace EulerQuestion
{
    public class Problem005 : IProblem
    {
		public string Name { get { return "Smallest multiple"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = Calc(new List<Int64> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }),
                GivenAnswer = 232792560,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = Calc(new List<Int64> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                GivenAnswer = 2520,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        private Int64 Calc(IList<Int64> numbers)
        {
            Int64 n1 = numbers[0];
            Int64 n2;

            for (var i = 1; i < numbers.Count; i++)
            {
                n2 = numbers[i];
                n1 = MathHelper.LeastCommonMultiple(n1, n2);
            }

            return n1;
        }
    }
}
