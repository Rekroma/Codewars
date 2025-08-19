using System.Linq;

namespace Kyu7.SortArrayByStringLength;

public class Kata
{
    public static string[] SortByLength(string[] array)
    {
        return array.OrderBy(s => s.Length).ToArray();
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(Kata.SortByLength(new string[] { "Beg", "Life", "I", "To" }), Is.EqualTo(new string[] { "I", "To", "Beg", "Life" }));
        Assert.That(Kata.SortByLength(new string[] { "", "Moderately", "Brains", "Pizza" }), Is.EqualTo(new string[] { "", "Pizza", "Brains", "Moderately" }));
        Assert.That(Kata.SortByLength(new string[] { "Longer", "Longest", "Short" }), Is.EqualTo(new string[] { "Short", "Longer", "Longest" }));
    }
}