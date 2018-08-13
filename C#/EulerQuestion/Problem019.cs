using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerQuestion
{
    public class Problem019 : IProblem
    {
        public string Name { get { return "Counting Sundays"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;

            DateTime startDate = new DateTime(1901, 1, 1);
            DateTime endDate = new DateTime(2000, 12, 31);

            DateTime currentDate = startDate;
            var sundayCount = 0;
            do{
                if (DayOfWeek.Sunday == currentDate.DayOfWeek)
                    sundayCount++;

                currentDate = currentDate.AddMonths(1);

            }while(currentDate <= endDate);


            return new Result
            {
                Name = this.Name,
                Answer = sundayCount,
                GivenAnswer = 171,
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
