using System.Numerics;

namespace Kyu4.AddingBigNumbers;

public class Kata
{
    public static string Add(string a, string b)
    {
        return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}


[TestFixture]
public class KataTest
{
    [Test]
    public void ASimpleKataTest()
    {
        Assert.That(Kata.Add("91", "19"), Is.EqualTo("110"));
        Assert.That(Kata.Add("123456789", "987654322"), Is.EqualTo("1111111111"));
        Assert.That(Kata.Add("999999999", "1"), Is.EqualTo("1000000000"));
    }
}
