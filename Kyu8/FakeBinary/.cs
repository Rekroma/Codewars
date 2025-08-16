using System.Linq;

namespace Kyu8.FakeBinary;

public class Kata
{
    public static string FakeBin(string x)
    {
        return string.Concat(x.Select(a => a < '5' ? "0" : "1"));
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.FakeBin("45385593107843568"), Is.EqualTo("01011110001100111"));
        Assert.That(Kata.FakeBin("509321967506747"), Is.EqualTo("101000111101101"));
        Assert.That(Kata.FakeBin("366058562030849490134388085"), Is.EqualTo("011011110000101010000011011"));
    }
}