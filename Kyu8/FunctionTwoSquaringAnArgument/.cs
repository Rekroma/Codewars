namespace Kyu8.FunctionTwoSquaringAnArgument;

public class Kata
{
    public static double Square(double n)
    {
        return n * n;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Sample Tests")]
    public void Test()
    {
        Assert.That(Kata.Square(2), Is.EqualTo(4));
        Assert.That(Kata.Square(10), Is.EqualTo(100));
    }
}