namespace FizzBuzz.Transforms;

public class FizzyTransform : Transform
{
    public override Func<int, bool> Match => i => i.ToString().Contains('3');

    public override Func<int, string> Transformation => i => "Fizzy";
}