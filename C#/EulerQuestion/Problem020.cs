using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EulerQuestion
{
    public class Problem020 : IProblem
    {
        public string Name { get { return "Factorial digit sum"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;

            return new Result
            {
                Name = this.Name,
                Answer = Calc(100),
                GivenAnswer = 648,
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
                GivenAnswer = 27,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        private int Calc(int factorialNumber)
        {
            var result = new BigInteger(1);

            for (int i = 1; i <= factorialNumber; i++)
            {
                result *= i;
            }

            var indivDigits = new List<int>();
            result.ToString().ToList().ForEach(c => indivDigits.Add((Char.IsDigit(c) ? Int32.Parse(c.ToString()) : 0)));

            return indivDigits.Sum();
        }
    }
}
