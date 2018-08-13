using System;

namespace EulerQuestion
{
    public class Problem001 : IProblem
    {
		public string Name { get { return "Multiples of 3 and 5"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;

            return new Result
            {
				Name = this.Name,
                Answer = Calc(1000),
                GivenAnswer = 233168,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = Calc(10),
                GivenAnswer = 23,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        private int Calc(int naturalNumber)
        {
            var result = 0;
            for (var i = 1; i < naturalNumber; i++)
            {
                result += (MathHelper.IsDivisible(3, i) || MathHelper.IsDivisible(5, i)) ? i : 0;
            }

            return result;
        }
    }
}
