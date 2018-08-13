using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EulerQuestion
{
    public class Problem025 : IProblem
    {
        public string Name { get { return "1000-digit Fibonacci number"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;

            return new Result
            {
                Name = this.Name,
                Answer = Calc(1000),
                GivenAnswer = 4782,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
                Name = this.Name,
                Answer = Calc(3),
                GivenAnswer = 12,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        private BigInteger Calc(int numberOfDigits)
        {
            BigInteger prevNum = 0L;
            BigInteger currentNum = 1L;
            BigInteger result = 0L;
            Int64 termIndex = 1;

            do
            {
                result = prevNum + currentNum;
                prevNum = currentNum;

                currentNum = result;
                termIndex++;
            } while (currentNum.ToString().Length < numberOfDigits);

            return termIndex;
        }
    }
}
