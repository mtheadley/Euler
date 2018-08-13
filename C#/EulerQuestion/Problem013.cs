using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EulerQuestion
{
	public class Problem013 : IProblem
	{
		public string Name { get { return "Large sum"; } }

		public IResult Question()
		{
			var begin = DateTime.Now.Ticks;

			return new Result
			{
				Name = this.Name,
				Answer = Calc(),
				GivenAnswer = 5537376230,
				TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
			};
		}

		public IResult Sample()
		{
			var begin = DateTime.Now.Ticks;
			return new Result
			{
				Name = this.Name,
				Answer = 0,
				GivenAnswer = 0,
				TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
			};
		}

		private Int64 Calc()
		{
			var allContents = string.Empty;

			using (var sr = new StreamReader(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\files\\problem013.txt"))
			{
				allContents = sr.ReadToEnd();
			}

			var allDigits = allContents.Replace("\r", "").Replace("\n", "");
			
			var numbers = Enumerable.Range(0, allDigits.Length / 50).Select(i => allDigits.Substring(i * 50, 50));

			var numberList = new List<BigInteger>();
			numbers.ToList().ForEach(i => numberList.Add(BigInteger.Parse(i)));

			var sum = new BigInteger();
			foreach(var n in numberList)
			{
				sum += n;
			}

            return Int64.Parse(sum.ToString().Substring(0, 10));
		}
	}
}
