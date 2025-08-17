namespace Kyu8.SuperDuperEasy;

public class Kata
{
    public static string Problem(string a)
    {
        return double.TryParse(a, out double number) ? (number * 50 + 6).ToString() : "Error";
    }
}


[TestFixture]
public class EasyTests
{

    [Test]
    public void Test1()
    {
        Assert.That(Kata.Problem("hello"), Is.EqualTo("Error"));
        Assert.That(Kata.Problem("1"), Is.EqualTo("56"));
        Assert.That(Kata.Problem("5"), Is.EqualTo("256"));
        Assert.That(Kata.Problem("0"), Is.EqualTo("6"));
        Assert.That(Kata.Problem("1.2"), Is.EqualTo("66"));
    }
}