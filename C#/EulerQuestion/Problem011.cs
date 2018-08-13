using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace EulerQuestion
{
    public class Problem011 : IProblem 
    {
		public string Name { get { return "Largest product in a grid"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;

            var allContents = new List<List<Int64>>();

            using (var sr = new StreamReader(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\files\\problem011.txt"))
            {
                while (sr.Peek() > 0)
                {
                    var s = sr.ReadLine().Split(' ').ToList();
                    var innerList = new List<Int64>();
                    s.ForEach(i => innerList.Add(Int32.Parse(i)));

                    allContents.Add(innerList);
                }
            }

            var maxAdj = 0L;

            foreach (var l in allContents)
            {
                var x = MathHelper.MaxProductInList(l, 4);
                maxAdj = (x > maxAdj) ? x : maxAdj;
                
            }

            return new Result
            {
                Name = this.Name,
                Answer = maxAdj,
                GivenAnswer = -1,
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
    }
}
