using System.Linq;

namespace Kyu7.SortArraysOne;

public class Kata
{
    public static string[] SortMe(string[] names)
    {
        return names.OrderBy(x => x).ToArray();
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(string.Join(",", Kata.SortMe(new[] { "one", "two", "three" })), Is.EqualTo("one,three,two"));
    }
}