using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerQuestion
{
    public class Problem021 : IProblem
    {
        public string Name { get { return "Amicable numbers"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;

            return new Result
            {
                Name = this.Name,
                Answer = Calc(),
                GivenAnswer = 31626,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
                Name = this.Name,
                Answer = DetermineAmicable(220),
                GivenAnswer = 284,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        private Int64 Calc()
        {
            var amicableNumber = new List<Int64>();

            for (int i = 0; i < 10000; i++)
			{
                if (!amicableNumber.Contains(i))
                {
                    var result = DetermineAmicable(i);

                    if ((result != 0) && (result != i))
                    {
                        amicableNumber.Add(i);

                        if(!amicableNumber.Contains(result)) amicableNumber.Add(result);
                    }
                }
			}

            return amicableNumber.Sum();
        }

        private Int64 DetermineAmicable(Int64 number)
        {
            var firstFactors = MathHelper.GetFactors(number);
            firstFactors.Remove(number);

            var secondNumber = firstFactors.Sum();

            var secondFactors = MathHelper.GetFactors(secondNumber);
            secondFactors.Remove(secondNumber);

            return (secondFactors.Sum() == number) ? secondNumber : 0;
        }
    }
}
