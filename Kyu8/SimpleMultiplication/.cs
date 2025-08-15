namespace Kyu8.SimpleMultiplication;

public class Multiplier
{
    public static int Multiply(int x)
    {
        return x % 2 == 0 ? x * 8 : x * 9;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Multiplier.Multiply(1), Is.EqualTo(9), "Should return given argument times nine");
        Assert.That(Multiplier.Multiply(2), Is.EqualTo(16), "Should return given argument times eight");
        Assert.That(Multiplier.Multiply(8), Is.EqualTo(64), "Should return given argument times eight");
        Assert.That(Multiplier.Multiply(4), Is.EqualTo(32), "Should return given argument times eight");
        Assert.That(Multiplier.Multiply(5), Is.EqualTo(45), "Should return given argument times nine");
    }
}