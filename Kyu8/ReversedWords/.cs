using System.Linq;

namespace Kyu8.ReversedWords;

public class Kata
{
    public static string ReverseWords(string str)
    {
        return string.Join(" ", str.Split(' ').Reverse());
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void BasicTests()
    {
        Assert.That(Kata.ReverseWords("hello world!"), Is.EqualTo("world! hello"));
        Assert.That(Kata.ReverseWords("yoda doesn't speak like this"), Is.EqualTo("this like speak doesn't yoda"));
        Assert.That(Kata.ReverseWords("foobar"), Is.EqualTo("foobar"));
        Assert.That(Kata.ReverseWords("editor kata"), Is.EqualTo("kata editor"));
        Assert.That(Kata.ReverseWords("row row row your boat"), Is.EqualTo("boat your row row row"));
        Assert.That(Kata.ReverseWords(""), Is.EqualTo(""));
    }
}