namespace FizzBuzz.Transforms;

public class BuzzTransform : ITransform
{
    public string Apply(int i)
    {
        return (i % 5 == 0) 
            ? "Buzz" 
            : string.Empty;
    }
}