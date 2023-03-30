namespace FizzBuzz.Transforms;

public class BuzzyTransform : Transform
{
    public override bool Match(int i) => i.ToString().Contains('5');

    public override string Transformation(int i) => "Buzzy";
}