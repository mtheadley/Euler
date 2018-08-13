using System;

namespace EulerQuestion
{
    public class Problem006 : IProblem
    {
		public string Name { get { return "Sum square difference"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = MathHelper.SquareOfSums(100) - MathHelper.SumOfSquares(100),
                GivenAnswer = 25164150,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = MathHelper.SquareOfSums(10) - MathHelper.SumOfSquares(10),
                GivenAnswer = 2640,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }
    }
}
