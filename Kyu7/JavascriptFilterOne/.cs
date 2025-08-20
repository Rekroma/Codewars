using System.Linq;

namespace Kyu7.JavascriptFilterOne;

public class Kata
{
    public static string[][] search_names(string[][] logins)
    {
        return logins.Where((s, i) => logins[i][0].EndsWith('_')).ToArray();
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void Test1()
    {
        string[][] a = { new[] { "foo", "foo@foo.com" }, new[] { "bar_", "bar@bar.com" } };
        string[][] b = { new[] { "bar_", "bar@bar.com" } };
        Assert.That(b, Is.EquivalentTo(Kata.search_names(a)));
    }

    [Test]
    public void Test2()
    {
        string[][] a = { new[] { "foo_", "foo@foo.com" }, new[] { "bar_", "bar@bar.com" } };
        string[][] b = { new[] { "foo_", "foo@foo.com" }, new[] { "bar_", "bar@bar.com" } };
        Assert.That(b, Is.EquivalentTo(Kata.search_names(a)));
    }

    [Test]
    public void Test3()
    {
        string[][] a = { new[] { "foo", "foo@foo.com" }, new[] { "bar", "bar@bar.com" } };
        string[] b = new string[0];
        Assert.That(b, Is.EquivalentTo(Kata.search_names(a)));
    }
}