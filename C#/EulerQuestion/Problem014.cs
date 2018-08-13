using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerQuestion
{
    public class Problem014 : IProblem
    {
        public string Name { get { return "Longest Collatz sequence"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;

            var max = 0L;
            var index = 0;

            for (int i = 1; i < 1000000; i++)
            {
                var c = Collatz(i);

                if (c > max)
                {
                    max = c;
                    index = i;
                }
            }

            return new Result
            {
                Name = this.Name,
                Answer = index,
                GivenAnswer = 837799,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
                Name = this.Name,
                Answer = Collatz(13),
                GivenAnswer = 10,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        //private List<int> Collatz(int number)
        private Int64 Collatz(Int64 number)
        {
            var n = number;
            var result = 1L; //need to consider the first number

            do
            {
                n = (MathHelper.IsDivisible(2, n)) ? EvenNumber(n) : OddNumber(n);

                result++;

            } while (n != 1);

            return result;
        }

        private Int64 OddNumber(Int64 number)
        {
            return (3 * number) + 1;
        }

        private Int64 EvenNumber(Int64 number)
        {
            return (number / 2);
        }
    }
}
