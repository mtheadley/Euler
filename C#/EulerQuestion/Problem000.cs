using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerQuestion
{
    public class Problem000 : IProblem
    {
        public string Name { get { return "Shell Class"; } }

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
                Answer = 0,
                GivenAnswer = 0,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }
    }
}
