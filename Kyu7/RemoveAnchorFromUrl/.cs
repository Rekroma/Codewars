using System.Linq;

namespace Kyu7.RemoveAnchorFromUrl;

public static class Kata
{
    public static string RemoveUrlAnchor(string url)
    {
        return url.Substring(0, (url.Contains("#") ? url.IndexOf("#") : url.Length));
    }
}


[TestFixture]
public class Tests
{
    [Test, Description("Sample Tests")]
    public void SampleTests()
    {
        Assert.That(Kata.RemoveUrlAnchor("www.codewars.com#about"), Is.EqualTo("www.codewars.com"));
        Assert.That(Kata.RemoveUrlAnchor("www.codewars.com/katas/?page=1#about"), Is.EqualTo("www.codewars.com/katas/?page=1"));
        Assert.That(Kata.RemoveUrlAnchor("www.codewars.com/katas/"), Is.EqualTo("www.codewars.com/katas/"));
    }
}