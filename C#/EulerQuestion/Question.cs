using System;
using System.Collections.Generic;
using System.IO;

namespace EulerQuestion
{
    public class Question : IQuestion
    {
		public IResult One()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[1],
                Answer = Equation.One(1000),
                GivenAnswer = 233168,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Two()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[2],
                Answer = Equation.Two(4000000),
                GivenAnswer = 4613732,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Three()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[3],
                Answer = Equation.Three(600851475143),
                GivenAnswer = 6857,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Four()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[4],
                Answer = Equation.Four(3),
                GivenAnswer = 906609,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Five()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[5],
                Answer = Equation.Five(new List<Int64>{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20}),
                GivenAnswer = 232792560,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Six()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[6],
                Answer = Equation.Six(100),
                GivenAnswer = 25164150,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Seven()
        {
            var begin = DateTime.Now.Ticks;
            return new Result
            {
				Name = QuestionName.Names[7],
                Answer = Equation.Seven(10001),
                GivenAnswer = 104743,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

		public IResult Eight()
		{
			var begin = DateTime.Now.Ticks;

            var allContents = string.Empty;

            using (var sr = new StreamReader(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\files\\problem8.txt"))
            {
                allContents = sr.ReadToEnd();
            }

            var numberList = new List<Int64>();

            foreach (var c in allContents)
                numberList.Add(Int32.Parse(c.ToString()));

			return new Result
			{
				Name = QuestionName.Names[8],
				Answer = Equation.MaxProductInList(numberList, 5),
				GivenAnswer = 40824,
				TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
			};
		}

		public IResult Nine()
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
				Name = QuestionName.Names[9],
				Answer = answer,
                GivenAnswer = 31875000,
				TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
			};
		}

		public IResult Ten()
		{
            var begin = DateTime.Now.Ticks;

			return new Result
			{
				Name = QuestionName.Names[10],
				Answer = Equation.SumOfPrimes(2000000),
                GivenAnswer = 142913828922,
				TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
			};
		}
    }
}
