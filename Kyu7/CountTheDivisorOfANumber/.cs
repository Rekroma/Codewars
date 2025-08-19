namespace Kyu7.CountTheDivisorOfANumber;

public class Kata
{
    public static int Divisors(int n)
    {
        int divisor = 0;

        for (int div = 1; div <= (n / 2); div++)
        {
            if (n % div == 0) divisor++;
        }

        return divisor + 1;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Divisors(1), Is.EqualTo(1));
        Assert.That(Kata.Divisors(10), Is.EqualTo(4));
        Assert.That(Kata.Divisors(11), Is.EqualTo(2));
        Assert.That(Kata.Divisors(54), Is.EqualTo(8));
    }
}