using System;
using System.Collections.Generic;
using System.IO;

namespace EulerQuestion
{
    public class Problem008 : IProblem
    {
		public string Name { get { return "Largest product in a series"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;

            var allContents = string.Empty;

            using (var sr = new StreamReader(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\files\\problem008.txt"))
            {
                allContents = sr.ReadToEnd();
            }

            var numberList = new List<Int64>();

            foreach (var c in allContents)
                numberList.Add(Int32.Parse(c.ToString()));

            return new Result
            {
				Name = this.Name,
                Answer = MathHelper.MaxProductInList(numberList, 5),
                GivenAnswer = 40824,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = this.Name,
                Answer = MathHelper.MaxProductInList(new List<Int64> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5),
                GivenAnswer = 15120,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }
    }
}
