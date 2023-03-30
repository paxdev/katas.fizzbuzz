namespace FizzBuzz.Transforms;

public class FizzyTransform : ITransform
{
    public string Apply(int i) => i.ToString().Contains('3') 
        ? "Fizzy" 
        : string.Empty;
}