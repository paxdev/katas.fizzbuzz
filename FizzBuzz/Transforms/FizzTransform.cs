namespace FizzBuzz.Transforms;

public class FizzTransform : ITransform
{
    public string Apply(int i) => (i % 3 == 0) 
        ? "Fizz" 
        : string.Empty;
}