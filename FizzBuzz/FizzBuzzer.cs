namespace FizzBuzz;

public class FizzBuzzer
{
    private readonly IEnumerable<Transform> transforms;

    public FizzBuzzer(params Transform[] transforms)
    {
        this.transforms = transforms;
    }

    public string Do(int i)
    {
        var transformed = 
            transforms
                .Aggregate(string.Empty, (current, transform) => current + transform.Apply(i));

        return transformed == string.Empty 
            ? i.ToString() 
            : transformed;
    }
}