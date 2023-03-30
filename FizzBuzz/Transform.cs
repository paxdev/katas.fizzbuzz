namespace FizzBuzz;

public abstract class Transform
{
    public abstract Func<int, bool> Match { get; }
    public abstract Func<int, string> Transformation { get; }

    public string Apply(int i) => 
        Match(i) 
            ? Transformation(i) 
            : string.Empty;
}