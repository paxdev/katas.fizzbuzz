namespace FizzBuzz.Tests;

public class BuzzTransformTests
{
    private readonly BuzzTransform transform;

    public BuzzTransformTests() => transform = new BuzzTransform();

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(15)]
    [InlineData(65)]

    public void ShouldBeBuzzWhenMultipleOfFive(int input) 
        => transform.Apply(input).ShouldBe("Buzz");

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(11)]
    [InlineData(3)]
    public void ShouldBeEmptyWhenNotMultipleOfFive(int input) 
        => transform.Apply(input).ShouldBe(string.Empty);
}