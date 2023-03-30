namespace FizzBuzz.Tests;

public class FizzBuzzerTests
{
    private const string ExpectedTransformed = "Applied";
    private const string OtherTransformed = "Other";
    private const int ExpectedMatch = 2;
    private const int ExpectedNonMatch = 1;

    private FizzBuzzer fizzBuzzer;

    private void SetupToApplyExpectedTransform()
    {
        var transform = new Mock<ITransform>();
        transform.Setup(r => r.Apply(ExpectedMatch))
            .Returns(ExpectedTransformed);

        fizzBuzzer = new FizzBuzzer(transform.Object);
    }

    [Fact]
    public void ShouldOutputNumberWhenNotMatching()
    {
        SetupToApplyExpectedTransform();

        fizzBuzzer.Do(ExpectedNonMatch).ShouldBe(ExpectedNonMatch.ToString());
    }

    [Fact]
    public void ShouldTransformWhenMatchesRule()
    {
        SetupToApplyExpectedTransform();

        fizzBuzzer.Do(ExpectedMatch).ShouldBe(ExpectedTransformed);
    }

    [Fact]
    public void ShouldApplyTransformsInOrder()
    {
        var firstTransform = new Mock<ITransform>();
        firstTransform.Setup(t => t.Apply(ExpectedMatch))
            .Returns(ExpectedTransformed);

        var secondTransform = new Mock<ITransform>();
        secondTransform.Setup(t => t.Apply(ExpectedMatch))
            .Returns(OtherTransformed);

        var fizzBuzzerOne = new FizzBuzzer(firstTransform.Object, secondTransform.Object);
        var fizzBuzzerTwo = new FizzBuzzer(secondTransform.Object, firstTransform.Object);

        fizzBuzzerOne.Do(ExpectedMatch).ShouldBe(ExpectedTransformed + OtherTransformed);
        fizzBuzzerTwo.Do(ExpectedMatch).ShouldBe(OtherTransformed + ExpectedTransformed);
    }
}