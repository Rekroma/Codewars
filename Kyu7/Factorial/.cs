namespace Kyu7.Factorial;

public static class Program
{
    public static ulong Factorial(int n)
    {
        ulong sum = 1;

        while (n > 0)
        {
            sum *= (ulong)n;
            n--;
        }

        return sum;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void Tests()
    {
        Assert.That(Program.Factorial(0), Is.EqualTo(1));
        Assert.That(Program.Factorial(1), Is.EqualTo(1));
        Assert.That(Program.Factorial(2), Is.EqualTo(2));
        Assert.That(Program.Factorial(3), Is.EqualTo(6));
        Assert.That(Program.Factorial(4), Is.EqualTo(24));
        Assert.That(Program.Factorial(5), Is.EqualTo(120));
    }
}