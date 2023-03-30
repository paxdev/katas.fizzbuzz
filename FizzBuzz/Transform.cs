namespace FizzBuzz;

public abstract class Transform
{
    public abstract bool Match(int i);
    public abstract string Transformation(int i);

    public string Apply(int i) => 
        Match(i) 
            ? Transformation(i) 
            : string.Empty;
}