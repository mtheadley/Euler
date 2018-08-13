using System;

namespace EulerQuestion
{
	public class Problem012 : IProblem
	{
		public string Name { get { return "Highly divisible triangular number"; } }

		public IResult Question()
		{
			var begin = DateTime.Now.Ticks;

			return new Result
			{
				Name = this.Name,
				Answer = Calc(500),
				GivenAnswer = 76576500,
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
				GivenAnswer = 28,
				TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
			};
		}

		private Int64 GetNextTriangleNumbers(Int64 currentIndex)
		{
			var result = 0;
			for(var i = 1; i <= (currentIndex + 1); i++)
			{
				result += i;
			}

			return result;
		}

		private Int64 Calc(int numberOfDivisors)
		{
			var result = 0L;

			var currentIndex = 1;
			do
			{
				var tri = GetNextTriangleNumbers(currentIndex);
				var factors = MathHelper.GetFactors(tri);

				if (factors.Count > numberOfDivisors)
				{
					result = tri;
					break;
				}

				currentIndex++;

			} while (true);
			

			return result;
		}
	}
}
