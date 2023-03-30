namespace FizzBuzz.Tests;

public class FizzTransformTests
{
    private readonly FizzTransform transform;

    public FizzTransformTests() => transform = new FizzTransform();

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(12)]
    [InlineData(27)]
    public void ShouldBeFizzWhenMultipleOfThree(int input) 
        => transform.Apply(input).ShouldBe("Fizz");

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(10)]
    [InlineData(20)]
    public void ShouldBeEmptyWhenNotMultipleOfThree(int input)
        => transform.Apply(input).ShouldBe(string.Empty);
}