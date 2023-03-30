namespace FizzBuzz.Transforms;

public class FizzTransform : Transform
{
    public override Func<int, bool> Match => i => i % 3 == 0;
    public override Func<int, string> Transformation => i => "Fizz";
}