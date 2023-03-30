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
        transform.Setup(r => r.Match)
            .Returns(i => i == ExpectedMatch);
        transform.Setup(r => r.Transformation)
            .Returns(i => ExpectedTransformed);


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
        firstTransform.Setup(r => r.Match)
            .Returns(i => i == ExpectedMatch);
        firstTransform.Setup(r => r.Transformation)
            .Returns(i => ExpectedTransformed);

        var secondTransform = new Mock<Transform>();
        secondTransform.Setup(r => r.Match)
            .Returns(i => i == ExpectedMatch);
        secondTransform.Setup(r => r.Transformation)
            .Returns(i => OtherTransformed);

        var fizzBuzzerOne = new FizzBuzzer(firstTransform.Object, secondTransform.Object);
        var fizzBuzzerTwo = new FizzBuzzer(secondTransform.Object, firstTransform.Object);

        fizzBuzzerOne.Do(ExpectedMatch).ShouldBe(ExpectedTransformed + OtherTransformed);
        fizzBuzzerTwo.Do(ExpectedMatch).ShouldBe(OtherTransformed + ExpectedTransformed);
    }
}