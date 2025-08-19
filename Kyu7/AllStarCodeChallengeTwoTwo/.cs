using System;

namespace Kyu7.AllStarCodeChallenge;

public static class Kata
{
    public static string ToTime(int seconds)
    {
        return $"{TimeSpan.FromSeconds(seconds).Hours + TimeSpan.FromSeconds(seconds).Days * 24} hour(s) and {TimeSpan.FromSeconds(seconds).Minutes} minute(s)";
    }
}


[TestFixture]
public class SolutionTest
{
    private static void Act(int seconds, string expected)
    {
        var actual = Kata.ToTime(seconds);
        Assert.That(actual, Is.EqualTo(expected), $"Input: seconds = {seconds}");
    }

    [Test(Description = "Fixed Tests")]
    public void FixedTests()
    {
        Act(3600, "1 hour(s) and 0 minute(s)");
        Act(3601, "1 hour(s) and 0 minute(s)");
        Act(3500, "0 hour(s) and 58 minute(s)");
        Act(323500, "89 hour(s) and 51 minute(s)");
        Act(0, "0 hour(s) and 0 minute(s)");
    }
}