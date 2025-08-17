using System;
using System.Linq;

namespace Kyu8.EvilOrOdious;

public class Kata
{
    public static string Evil(int n)
    {
        return (Convert.ToString(n, 2).Count(c => c == '1') % 2 == 0) ? "It's Evil!" : "It's Odious!";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Evil(1), Is.EqualTo("It's Odious!"));
        Assert.That(Kata.Evil(2), Is.EqualTo("It's Odious!"));
        Assert.That(Kata.Evil(3), Is.EqualTo("It's Evil!"));
    }
}