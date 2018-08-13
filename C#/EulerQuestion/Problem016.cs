using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EulerQuestion
{
	public class Problem016 : IProblem
	{
		public string Name { get { return "Power digit sum"; } }

		public IResult Question()
		{
			var begin = DateTime.Now.Ticks;

			return new Result
			{
				Name = this.Name,
				Answer = Calc(1000),
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
				Answer = Calc(15),
				GivenAnswer = 26,
				TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
			};
		}

		private int Calc(int exponential)
		{
			var result = BigInteger.Pow(2, exponential);

			var indivDigits = new List<int>();
			result.ToString().ToList().ForEach(c => indivDigits.Add((Char.IsDigit(c) ? Int32.Parse(c.ToString()) : 0)));

			return indivDigits.Sum();
		}
	}
}
