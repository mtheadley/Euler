using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EulerQuestion
{
    public class Problem022 : IProblem
    {
        public string Name { get { return "Names scores"; } }

        public IResult Question()
        {
            var begin = DateTime.Now.Ticks;

            var names = this.ReadAndAlphaFile();
            var loc = 1;

            var totalScore = new BigInteger();

            foreach (var n in names)
            {
                totalScore += NameScore(n.Trim(), loc);
                loc++;
            }

            return new Result
            {
                Name = this.Name,
                Answer = totalScore,
                GivenAnswer = 871198282,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        public IResult Sample()
        {
            var begin = DateTime.Now.Ticks;

            return new Result
            {
                Name = this.Name,
                Answer = this.NameScore("COLIN", 938),
                GivenAnswer = 49714,
                TimeTaken = new TimeSpan(DateTime.Now.Ticks - begin)
            };
        }

        private IList<string> ReadAndAlphaFile()
        {
            var names = new List<string>();
            using (var sr = new StreamReader(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\files\\problem022.txt"))
            {
                names = sr.ReadToEnd().Replace('"', ' ').Split(',').ToList();
            }

            return names.OrderBy(n => n).ToList();
        }

        private Int64 NameScore(string name, int pos)
        {
            var score = 0L;
            foreach (var c in name)
            {
                score += ((int)c) - 64;
            }

            return score * pos;
        }
    }
}
