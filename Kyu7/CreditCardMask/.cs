namespace Kyu7.CreditCardMask;

public static class Kata
{
    public static string Maskify(string cc)
    {
        if (cc.Length < 5) return cc;
        return new string('#', cc.Length - 4) + cc.Substring(cc.Length - 4);
    }
}


[TestFixture]
public class Tests
{
    [Test]
    [Order(1)]
    public void ExamplesTests()
    {
        Assert.That(Kata.Maskify("4556364607935616"), Is.EqualTo("############5616"));
        Assert.That(Kata.Maskify("1"), Is.EqualTo("1"));
        Assert.That(Kata.Maskify("11111"), Is.EqualTo("#1111"));
    }
}