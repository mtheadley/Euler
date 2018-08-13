using System;

namespace EulerQuestion
{
    public class Problem009 : IProblem
    {
		public string Name { get { return "Special Pythagorean triplet"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;

            var answer = 0;
            for (int a = 1; a <= 1000; a++)
            {
                for (int b = 1; b <= 1000; b++)
                {
                    var c2 = (a * a) + (b * b);

                    var c = System.Math.Sqrt(c2);

                    if ((System.Math.Ceiling(c) == System.Math.Floor(c)) && ((a < b) && (b < c2)))
                    {
                        if ((a + b + c) == 1000)
                        {
                            answer = a * b * (int)c;
                            break;
                        }
                    }
                }

                if (answer != 0) break;
            }

            return new Result
            {
				Name = this.Name,
                Answer = answer,
                GivenAnswer = 31875000,
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
