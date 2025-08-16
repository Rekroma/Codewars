namespace Kyu8.ReturnTheDay;

public class Kata
{
    public static string WhatDay(int n)
    {
        return n switch
        {
            1 => "Sunday",
            2 => "Monday",
            3 => "Tuesday",
            4 => "Wednesday",
            5 => "Thursday",
            6 => "Friday",
            7 => "Saturday",
            _ => "Wrong, please enter a number between 1 and 7"
        };
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    [TestCase(1, "Sunday")]
    [TestCase(2, "Monday")]
    [TestCase(3, "Tuesday")]
    [TestCase(4, "Wednesday")]
    [TestCase(5, "Thursday")]
    [TestCase(6, "Friday")]
    [TestCase(7, "Saturday")]
    [TestCase(-1, "Wrong, please enter a number between 1 and 7")]
    [TestCase(0, "Wrong, please enter a number between 1 and 7")]
    [TestCase(8, "Wrong, please enter a number between 1 and 7")]
    [TestCase(20, "Wrong, please enter a number between 1 and 7")]
    public void FixedTest(int n, string expected)
    {
        Assert.That(Kata.WhatDay(n), Is.EqualTo(expected));
    }
}