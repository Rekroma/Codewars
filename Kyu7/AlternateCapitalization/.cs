using System;
using System.Linq;

namespace Kyu7.AlternateCapitalization;

public static class Kata
{
    public static string[] Capitalize(string s)
    {
        return new[] { new string(s.Select((c, i) => i % 2 == 0 ? char.ToUpper(c) : char.ToLower(c)).ToArray()), new string(s.Select((c, i) => i % 2 != 0 ? char.ToUpper(c) : char.ToLower(c)).ToArray()) };
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(Kata.Capitalize("abcdef"), Is.EqualTo(new string[2] { "AbCdEf", "aBcDeF" }));
        Assert.That(Kata.Capitalize("codewars"), Is.EqualTo(new string[2] { "CoDeWaRs", "cOdEwArS" }));
        Assert.That(Kata.Capitalize("abracadabra"), Is.EqualTo(new string[2] { "AbRaCaDaBrA", "aBrAcAdAbRa" }));
        Assert.That(Kata.Capitalize("codewarriors"), Is.EqualTo(new string[2] { "CoDeWaRrIoRs", "cOdEwArRiOrS" }));
    }
}