namespace FizzBuzz.Transforms;

public class BuzzyTransform : ITransform
{
    public string Apply(int i)
    {
        return i.ToString().Contains('5') 
            ? "Buzzy" 
            : string.Empty;
    }
}