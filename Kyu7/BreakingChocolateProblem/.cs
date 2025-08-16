namespace Kyu7.BreakingChocolateProblem;

public class Kata
{
    public static int BreakChocolate(int n, int m)
    {
        return n == 0 || m == 0 ? 0 : n * m - 1;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SimpleTests()
    {
        Assert.That(Kata.BreakChocolate(5, 5), Is.EqualTo(24));
        Assert.That(Kata.BreakChocolate(1, 1), Is.EqualTo(0));
    }
}