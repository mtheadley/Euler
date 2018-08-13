using System;
using System.Numerics;

namespace EulerQuestion
{
    public class Result : IResult
    {
        public string Name { get; set; }
		public BigInteger Answer { get; set; }
		public BigInteger GivenAnswer { get; set; }
        public TimeSpan TimeTaken { get; set; }
    }

	public interface IResult
	{
		string Name { get; set; }
		BigInteger Answer { get; set; }
		BigInteger GivenAnswer { get; set; }
		TimeSpan TimeTaken { get; set; }
	}
}
