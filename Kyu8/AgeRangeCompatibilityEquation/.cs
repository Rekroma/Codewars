using System;

namespace AgeRangeCompatibilityEquation;

public class Kata
{
    public static string DatingRange(int age)
    {
        return age <= 14 ? $"{Math.Floor(age - 0.10 * age)}-{Math.Floor(age + 0.10 * age)}" : $"{(age / 2) + 7}-{(age - 7) * 2}";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Example Test Cases")]
    public void Test()
    {
        Assert.That(Kata.DatingRange(17), Is.EqualTo("15-20"));
        Assert.That(Kata.DatingRange(40), Is.EqualTo("27-66"));
        Assert.That(Kata.DatingRange(15), Is.EqualTo("14-16"));
        Assert.That(Kata.DatingRange(35), Is.EqualTo("24-56"));
        Assert.That(Kata.DatingRange(10), Is.EqualTo("9-11"));
    }
}