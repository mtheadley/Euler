using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EulerQuestion
{
    public class Problem026 : IProblem
    {
        public string Name { get { return "Reciprocal cycles"; } }

        public IResult Question()
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

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
                Name = this.Name,
                Answer = Calc(10),
                GivenAnswer = 0,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }


        public int Calc(int d)
        {
            var n = new Dictionary<int, int>();
            var repeat = string.Empty;
            var maxDigits = 0;
            var denom = 0;

            for (int i = 2; i <= d; i++)
            {
                var dec = (1 / (decimal)i).ToString().Substring((1/(decimal)i).ToString().IndexOf('.') + 1);

                foreach (var c in dec)
                {
                    repeat += c;

                    if (repeat.Count() < 20)
                    {
                        int j = Regex.Matches(dec, repeat).Cast<Match>().Count();

                        if ((j != 0 ) && ((dec.Length % j) == 0))
                        {
                            if(dec.Length > maxDigits)
                            {
                                maxDigits = repeat.Length;
                                denom = i;
                                repeat = string.Empty;
                            }
                            break;
                        }
                    }
                }
            }

            return denom;
        }
    }
}
