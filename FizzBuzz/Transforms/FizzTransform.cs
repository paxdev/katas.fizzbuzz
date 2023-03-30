namespace FizzBuzz.Transforms;

public class FizzTransform : Transform
{
    public override bool Match (int i) => i % 3 == 0;
    public override string Transformation (int  i) => "Fizz";
}