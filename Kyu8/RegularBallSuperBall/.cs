namespace Kyu8.RegularBallSuperBall;

public class Ball
{
    public string ballType { get; set; }

    public Ball(string ballType = "regular")
    {
        this.ballType = ballType;
    }
}


[TestFixture]
public class FactorialTests
{
    [Test, Order(1)]
    public void DefaultConstructorShouldSetBallTypeToRegular()
    {
        Assert.That(new Ball().ballType, Is.EqualTo("regular"));
    }

    [Test, Order(2)]
    public void ConstructorWithArgumentShouldSetBallTypeAsExpected()
    {
        Assert.That(new Ball("super").ballType, Is.EqualTo("super"));
    }
}