using System.Linq;

namespace Kyu8.AlternatingCaseAlternatingCase;

public static class StringExt
{
    public static string ToAlternatingCase(this string s)
    {
        return string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void Examples()
    {
        Assert.That("hello world".ToAlternatingCase(), Is.EqualTo("HELLO WORLD"));
        Assert.That("HELLO WORLD".ToAlternatingCase(), Is.EqualTo("hello world"));
        Assert.That("hello WORLD".ToAlternatingCase(), Is.EqualTo("HELLO world"));
        Assert.That("HeLLo WoRLD".ToAlternatingCase(), Is.EqualTo("hEllO wOrld"));
        Assert.That("12345".ToAlternatingCase(), Is.EqualTo("12345"));
        Assert.That("1a2b3c4d5e".ToAlternatingCase(), Is.EqualTo("1A2B3C4D5E"));
        Assert.That("String.ToAlternatingCase".ToAlternatingCase(), Is.EqualTo("sTRING.tOaLTERNATINGcASE"));
        var alternating = "Hello World".ToAlternatingCase();
        Assert.That(alternating.ToAlternatingCase(), Is.EqualTo("Hello World"), "Hello World => hELLO wORLD => Hello World");
    }
}