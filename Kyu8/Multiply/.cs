namespace Kyu8.Multiply;

public class CustomMath
{
    public static int multiply(int a, int b)
    {
        return a * b;
    }
}


[TestFixture]
public class CustomMathTest
{
    [Test]
    public void ShouldMultiple()
    {
        Assert.That(CustomMath.multiply(2, 1), Is.EqualTo(2));
        Assert.That(CustomMath.multiply(2, 4), Is.EqualTo(8));
    }
}