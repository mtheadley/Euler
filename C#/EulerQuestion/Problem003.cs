using System;

namespace EulerQuestion
{
    public class Problem003 : IProblem
    {
		public string Name { get { return "Largest prime factor"; } }
        
		public IResult Question()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = MathHelper.LargestPrimeNumber(600851475143),
                GivenAnswer = 6857,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = MathHelper.LargestPrimeNumber(13195),
                GivenAnswer = 29,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }
    }
}
