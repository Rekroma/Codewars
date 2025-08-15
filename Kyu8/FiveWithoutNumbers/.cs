namespace Kyu8.FiveWithoutNumbers;

class Kata
{
    public static int UnusualFive()
    {
        return "Hello".Length;
    }
}


[TestFixture]
class Tests
{
    [Test]
    public void Test()
    {
        Assert.That(Kata.UnusualFive(), Is.EqualTo(5));
    }
}