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

public static class Kata
{
    public static int Factorial(int n)
    {
        if (0 > n || n > 12) throw new ArgumentOutOfRangeException();
        int sum = 1;

        for (int i = n; 0 < i; i--)
        {
            sum *= i;
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


[TestFixture]
public class FactorialTests
{
    [Test, Order(1)]
    public void FactorialOf0ShouldBe1()
    {
        Assert.That(Kata.Factorial(0), Is.EqualTo(1));
    }

    [Test, Order(2)]
    public void FactorialOf1ShouldBe1()
    {
        Assert.That(Kata.Factorial(1), Is.EqualTo(1));
    }

    [Test, Order(3)]
    public void FactorialOf2ShouldBe2()
    {
        Assert.That(Kata.Factorial(2), Is.EqualTo(2));
    }

    [Test, Order(4)]
    public void FactorialOf3ShouldBe6()
    {
        Assert.That(Kata.Factorial(3), Is.EqualTo(6));
    }
}
