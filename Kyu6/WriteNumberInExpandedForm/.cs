using System;

namespace Kyu6.WriteNumbersInExpandedForm;

public static class Kata
{
    public static string ExpandedForm(long num)
    {
        return string.Join(" + ", num.ToString().Reverse().Select((x, i) => (x - '0') * (long)Math.Pow(10, i)).Where(x => x > 0).Reverse());
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void BasicTests()
    {
        Assert.That(Kata.ExpandedForm(12), Is.EqualTo("10 + 2"));
        Assert.That(Kata.ExpandedForm(42), Is.EqualTo("40 + 2"));
        Assert.That(Kata.ExpandedForm(70304), Is.EqualTo("70000 + 300 + 4"));
    }
}