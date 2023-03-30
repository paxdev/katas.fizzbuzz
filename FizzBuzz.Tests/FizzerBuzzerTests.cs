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
        var transform = new Mock<Transform>();
        transform.Setup(r => r.Match(ExpectedMatch))
            .Returns(true);
        transform.Setup(r => r.Transformation(ExpectedMatch))
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
        var firstTransform = new Mock<Transform>();
        firstTransform.Setup(r => r.Match(ExpectedMatch))
            .Returns(true);
        firstTransform.Setup(r => r.Transformation(ExpectedMatch))
            .Returns(ExpectedTransformed);

        var secondTransform = new Mock<Transform>();
        secondTransform.Setup(r => r.Match(ExpectedMatch))
            .Returns(true);
        secondTransform.Setup(r => r.Transformation(ExpectedMatch))
            .Returns(OtherTransformed);

        var fizzBuzzerOne = new FizzBuzzer(firstTransform.Object, secondTransform.Object);
        var fizzBuzzerTwo = new FizzBuzzer(secondTransform.Object, firstTransform.Object);

        fizzBuzzerOne.Do(ExpectedMatch).ShouldBe(ExpectedTransformed + OtherTransformed);
        fizzBuzzerTwo.Do(ExpectedMatch).ShouldBe(OtherTransformed + ExpectedTransformed);
    }
}