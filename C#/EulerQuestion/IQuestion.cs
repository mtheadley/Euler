using System.Collections.Generic;

namespace EulerQuestion
{
	public static class QuestionName
	{
		public static List<string> Names = new List<string> { 
			"0", 
			"Multiples of 3 and 5", 
			"Even Fibonacci numbers", 
			"Largest prime factor", 
			"Largest palindrome product", 
			"Smallest multiple", 
			"Sum square difference", 
			"10001st prime", 
			"Largest product in a series",
			"Special Pythagorean triplet",
			"Summation of primes" };
	}

	public interface IQuestion
	{
		IResult One();
		IResult Two();
		IResult Three();
		IResult Four();
		IResult Five();
		IResult Six();
		IResult Seven();
		IResult Eight();
		IResult Nine();
		IResult Ten(); 
	}
}