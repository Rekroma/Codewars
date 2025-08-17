namespace Kyu8.DollarsAndCents;

public class Kata
{
    public static string FormatMoney(double amount)
    {
        return amount.ToString("$0.00");
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.FormatMoney(39.99), Is.EqualTo("$39.99"), "That's not formatted the way we expected.");
    }
}