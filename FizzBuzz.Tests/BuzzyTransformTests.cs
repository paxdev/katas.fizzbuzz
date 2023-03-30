namespace FizzBuzz.Tests;

public class BuzzyTransformTests
{
    private readonly BuzzyTransform transform;

    public BuzzyTransformTests() => transform = new BuzzyTransform();

    [Theory]
    [InlineData(5)]
    [InlineData(51)]
    [InlineData(503)]

    public void ShouldBeBuzzyWhenContainsFive(int input) 
        => transform.Apply(input).ShouldBe("Buzzy");

    [Theory]
    [InlineData(1)]
    [InlineData(11)]
    [InlineData(3)]
    public void ShouldBeEmptyWhenNotContainsFive(int input) 
        => transform.Apply(input).ShouldBe(string.Empty);
}