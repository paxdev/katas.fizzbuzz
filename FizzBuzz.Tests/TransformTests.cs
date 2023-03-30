namespace FizzBuzz.Tests;

public class TransformTests
{
    private Transform transform;

    private const int ExpectedMatch = 3;
    private const string ExpectedTransformed = "Transformed";

    public TransformTests()
    {
        var transformMock = new Mock<Transform>();
        transformMock.Setup(t => t.Match)
            .Returns(i => i == ExpectedMatch);
        transformMock.Setup(t => t.Transformation)
            .Returns(i => ExpectedTransformed);

        transform = transformMock.Object;
    }

    [Fact]
    public void ShouldApplyTransformWhenMatched() 
        => transform
            .Apply(ExpectedMatch)
            .ShouldBe(ExpectedTransformed);

    [Fact]
    public void ShouldBeEmptyWhenNotMatched()
        => transform
            .Apply(ExpectedMatch + 1)
            .ShouldBe(string.Empty);
}