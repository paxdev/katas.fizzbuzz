namespace FizzBuzz.Transforms;

public class BuzzTransform : Transform
{
    public override Func<int, bool> Match => i => i % 5 == 0;
    public override Func<int, string> Transformation => i => "Buzz";
}