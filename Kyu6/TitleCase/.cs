using System;
using System.Linq;

namespace Kyu6.TitleCase;

public class Kata
{
    public static string TitleCase(string title, string minorWords = "")
    {
        if (string.IsNullOrEmpty(title)) return "";
        var minorSet = (minorWords ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLower()).ToHashSet();

        return string.Join(" ", title.Split().Select((word, i) =>
        {
            string lower = word.ToLower();
            return (i == 0 || !minorSet.Contains(lower)) ? char.ToUpper(lower[0]) + lower.Substring(1) : lower;
        }));
    }
}


[TestFixture]
public class SolutionTest
{
    [TestCase("a clash of KINGS", "a an the of", "A Clash of Kings")]
    [TestCase("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
    [Order(1)]
    public void MyTest(string sampleTitle, string sampleMinorWords, string expected)
    {
        Assert.That(Kata.TitleCase(sampleTitle, sampleMinorWords), Is.EqualTo(expected));
    }
    [Test, Order(2)]
    public void MyTest2()
    {
        Assert.That(Kata.TitleCase(""), Is.EqualTo(""));
    }
    [Test, Order(3)]
    public void MyTest3()
    {
        Assert.That(Kata.TitleCase("the quick brown fox"), Is.EqualTo("The Quick Brown Fox"));
    }
}