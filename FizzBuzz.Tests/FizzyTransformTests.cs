namespace FizzBuzz.Tests;

public class FizzyTransformTests
{
    private readonly FizzyTransform transform;

    public FizzyTransformTests() => transform = new FizzyTransform();

    [Theory]
    [InlineData(3)]
    [InlineData(31)]
    [InlineData(301)]
    public void ShouldBeFizzyWhenContainsThree(int input) 
        => transform.Apply(input).ShouldBe("Fizzy");

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(5)]
    [InlineData(20)]
    public void ShouldNotBeEmptyWhenNotContainsThree(int input)
        => transform.Apply(input).ShouldBe(string.Empty);
}