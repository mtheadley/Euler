using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerQuestion
{
	public class Problem017 : IProblem
	{
		public string Name { get { return "Number letter counts"; } }

		public IResult Question()
		{
			var begin = DateTime.Now.Ticks;

			return new Result
			{
				Name = this.Name,
				Answer = 10, //Calc(1000),
				GivenAnswer = 1366,
				TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
			};
		}

		public IResult Sample()
		{
			var begin = DateTime.Now.Ticks;
			return new Result
			{
				Name = this.Name,
				Answer = Calc(5),
				GivenAnswer = 19,
				TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
			};
		}

		private int Calc(int stoppingNumber)
		{
			var letterCount = 0;
			for (int i = 1; i <= stoppingNumber; i++)
			{
				letterCount += LessThanNine[i - 1].Count();

			}
			return letterCount;
		}

		private static readonly List<string> LessThanNine = new List<string>
		{
			"one",
			"two",
			"three",
			"four",
			"five",
			"six",
			"seven",
			"eight",
			"nine"
		};

		private static readonly List<string> Teens = new List<string>
		{
			"eleven",
			"twelve",
			"thirteen",
			"fourteen",
			"fifteen",
			"sixteen",
			"seventeen",
			"eighteen",
			"nineteen"
		};

		private static readonly List<string> Tens = new List<string>
		{
			"ten",
			"twenty",
			"thirty",
			"fourty",
			"fifty",
			"sixty",
			"seventy",
			"eighty",
			"ninety"
		};

		private static readonly List<string> Misc = new List<string>
		{
			"and",
			"hundred",
			"thousand"
		};
	}
}
