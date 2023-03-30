namespace FizzBuzz.Transforms;

public class BuzzTransform : Transform
{
    public override bool Match(int i) => i % 5 == 0;
    public override string Transformation(int i) => "Buzz";
}