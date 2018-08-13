using System;

namespace EulerQuestion
{
    public class Problem010 : IProblem
    {
		public string Name { get { return "Summation of primes"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;

            return new Result
            {
				Name = this.Name,
                Answer = MathHelper.SumOfPrimes(2000000),
                GivenAnswer = 142913828922,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;

            return new Result
            {
				Name = this.Name,
                Answer = MathHelper.SumOfPrimes(10),
                GivenAnswer = 17,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }
    }
}
