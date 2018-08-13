namespace EulerQuestion
{
    public interface IProblem
    {
	    string Name { get; }
        IResult Question();
        IResult Sample();
    }
}
