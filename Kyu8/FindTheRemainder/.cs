using System;

namespace Kyu8.FindTheRemainder;

public class Kata
{
    public static int Remainder(int a, int b)
    {
        return Math.Max(a, b) % Math.Min(a, b) == 0 ? 0 : Math.Max(a, b) % Math.Min(a, b);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Your solution should handle arguments and math as defined in specifications")]
    public void FixedTest()
    {
        Assert.That(Kata.Remainder(17, 5), Is.EqualTo(2), "Returned value should be the value left over after dividing as much as possible.");
        Assert.That(Kata.Remainder(72, 13), Is.EqualTo(Kata.Remainder(13, 72)), "The order the arguments are passed should not matter.");
        Assert.Throws<DivideByZeroException>(() => Kata.Remainder(0, 1));
        Assert.Throws<DivideByZeroException>(() => Kata.Remainder(0, 0));
    }
}