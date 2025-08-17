using System.Linq;
using System.Numerics;

namespace PowersOfTwo;

public class Kata
{
    public static BigInteger[] PowersOfTwo(int n)
    {
        return Enumerable.Range(0, n + 1).Select(x => BigInteger.Pow(2, x)).ToArray();
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.PowersOfTwo(0), Is.EqualTo(new BigInteger[] { 1 }));
        Assert.That(Kata.PowersOfTwo(1), Is.EqualTo(new BigInteger[] { 1, 2 }));
        Assert.That(Kata.PowersOfTwo(4), Is.EqualTo(new BigInteger[] { 1, 2, 4, 8, 16 }));
    }
}