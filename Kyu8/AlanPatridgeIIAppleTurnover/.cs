using System;

namespace Kyu8.AlanPatridgeIIAppleTurnover;

public class Kata
{
    public static string Apple(object n)
    {
        return Convert.ToInt32(n) * Convert.ToInt32(n) > 1000 ? "It\'s hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Apple("50"), Is.EqualTo("It's hotter than the sun!!"));
        Assert.That(Kata.Apple(4), Is.EqualTo("Help yourself to a honeycomb Yorkie for the glovebox."));
    }
}