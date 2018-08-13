using System;
using System.Collections.Generic;

namespace EulerQuestion
{
    public class Sample : IQuestion
    {
        public IResult One()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
                Name = QuestionName.Names[1],
                Answer = Equation.One(10),
                GivenAnswer = 23,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Two()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[2],
                Answer = Equation.Two(10),
                GivenAnswer = 10,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Three()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[3],
                Answer = Equation.Three(13195),
                GivenAnswer = 29,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Four()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[4],
                Answer = Equation.Four(2),
                GivenAnswer = 9009,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Five()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[5],
                Answer = Equation.Five(new List<Int64> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                GivenAnswer = 2520,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Six()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[6],
                Answer = Equation.Six(10),
                GivenAnswer = 2640,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Seven()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[7],
                Answer = Equation.Seven(6),
                GivenAnswer = 13,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Eight()
		{
			var begin = DateTime.Now.Ticks;
			return new Result
			{
				Name = QuestionName.Names[8],
				Answer = Equation.MaxProductInList(new List<Int64>{1,2,3,4,5,6,7,8,9}, 5),
				GivenAnswer = 15120,
				TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
			};
		}

		public IResult Nine()
		{
			var begin = DateTime.Now.Ticks;
			return new Result
			{
				Name = QuestionName.Names[9],
				Answer = 0,
				GivenAnswer = 0,
				TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
			};
		}

		public IResult Ten()
		{
			var begin = DateTime.Now.Ticks;

			return new Result
			{
				Name = QuestionName.Names[10],
				Answer = Equation.SumOfPrimes(10),
				GivenAnswer = 17,
				TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
			};
		}
    }
}
