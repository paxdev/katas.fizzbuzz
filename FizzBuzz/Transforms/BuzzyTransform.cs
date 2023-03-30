namespace FizzBuzz.Transforms;

public class BuzzyTransform : Transform
{
    public override Func<int, bool> Match => i => i.ToString().Contains('5');

    public override Func<int, string> Transformation => i => "Buzzy";
}