namespace FizzBuzz.Transforms;

public class FizzyTransform : Transform
{
    public override bool Match(int i) => i.ToString().Contains('3');

    public override string Transformation(int i) => "Fizzy";
}