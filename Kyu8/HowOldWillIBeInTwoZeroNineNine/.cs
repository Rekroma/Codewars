using System;

namespace Kyu8.HowOldWillIBeInTwoZeroNineNine;

public static class AgeDiff
{
    public static string CalculateAge(int birth, int yearTo)
    {
        return birth == yearTo ? "You were born this very year!" : (birth > yearTo ? $"You will be born in {birth - yearTo} {(birth - yearTo == 1 ? "year" : "years")}." : $"You are {yearTo - birth} {(yearTo - birth == 1 ? "year" : "years")} old.");
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(AgeDiff.CalculateAge(2003, 2020), Is.EqualTo("You are 17 years old."));
        Assert.That(AgeDiff.CalculateAge(2019, 2020), Is.EqualTo("You are 1 year old."));
        Assert.That(AgeDiff.CalculateAge(2003, 2003), Is.EqualTo("You were born this very year!"));
        Assert.That(AgeDiff.CalculateAge(2020, 2003), Is.EqualTo("You will be born in 17 years."));
        Assert.That(AgeDiff.CalculateAge(2020, 2019), Is.EqualTo("You will be born in 1 year."));
    }
}