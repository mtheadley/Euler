using System;
using System.Collections.Generic;

namespace EulerQuestion
{
    public class Problem007 : IProblem
    {
		public string Name { get { return "10001st prime"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = Calc(10001),
                GivenAnswer = 104743,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = Calc(6),
                GivenAnswer = 13,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        private Int64 Calc(int primeIndex)
        {
            var primes = new List<Int64>();
            var i = 0;
            do
            {
                if (MathHelper.IsPrime(i))
                    primes.Add(i);

                i++;

                if (primes.Count == primeIndex)
                    break;
            } while (true);

            return primes[primeIndex - 1];
        }
    }
}
