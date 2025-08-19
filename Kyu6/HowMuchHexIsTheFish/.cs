namespace Kyu6.HowMuchHexIsTheFish;

using System;
using System.Linq;

public class Kata
{
    public static int FisHex(string name)
    {
        return name.ToLower()
                   .Where(c => "abcdef".Contains(c))
                   .Select(c => Convert.ToInt32(c.ToString(), 16))
                   .Aggregate(0, (acc, val) => acc ^ val);
    }
}


[TestFixture]
public class KataTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.FisHex("pufferfish"), Is.EqualTo(1));
        Assert.That(Kata.FisHex("puffers"), Is.EqualTo(14));
        Assert.That(Kata.FisHex("balloonfish"), Is.EqualTo(14));
        Assert.That(Kata.FisHex("blowfish"), Is.EqualTo(4));
        Assert.That(Kata.FisHex("bubblefish"), Is.EqualTo(10));
        Assert.That(Kata.FisHex("globefish"), Is.EqualTo(10));
        Assert.That(Kata.FisHex("swellfish"), Is.EqualTo(1));
        Assert.That(Kata.FisHex("toadfish"), Is.EqualTo(8));
        Assert.That(Kata.FisHex("toadies"), Is.EqualTo(9));
        Assert.That(Kata.FisHex("honey toads"), Is.EqualTo(9));
        Assert.That(Kata.FisHex("sugar toads"), Is.EqualTo(13));
        Assert.That(Kata.FisHex("sea squab"), Is.EqualTo(5));
    }
}