using System;
using System.Linq;

namespace Kyu8MultiplyTheNumber;

public class Kata
{
    public static int Multiply(int number)
    {
        return number * (int)Math.Pow(5, number.ToString().Count(char.IsDigit));
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Basic Tests")]
    public void SampleTest()
    {
        Assert.That(Kata.Multiply(10), Is.EqualTo(250));
        Assert.That(Kata.Multiply(5), Is.EqualTo(25));
        Assert.That(Kata.Multiply(200), Is.EqualTo(25000));
        Assert.That(Kata.Multiply(0), Is.EqualTo(0));
        Assert.That(Kata.Multiply(-2), Is.EqualTo(-10));
    }
}