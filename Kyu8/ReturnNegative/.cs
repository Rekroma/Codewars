namespace Kyu8.ReturnNegative;

public static class Kata
{
    public static int MakeNegative(int number)
    {
        return number < 0 ? number : -number;
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.That(Kata.MakeNegative(42), Is.EqualTo(-42), "Incorrect answer for number=42");
    }
}