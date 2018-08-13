using System;

namespace EulerQuestion
{
    public class Problem002 : IProblem
    {
		public string Name { get { return "Even Fibonacci numbers"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = MathHelper.EvenFibonacciSum(4000000),
                GivenAnswer = 4613732,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = MathHelper.EvenFibonacciSum(10),
                GivenAnswer = 10,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }
    }
}
