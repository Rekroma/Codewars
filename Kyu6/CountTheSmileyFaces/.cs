using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kyu6.CountTheSmileyFaces;

public class Kata
{
    public static int CountSmileys(string[] arr)
    {
        return arr.Count(face => Regex.IsMatch(face, @"^[:;][-~]?[)D]$"));
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    [Order(1)]
    public void BasicTest()
    {
        Assert.That(Kata.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }), Is.EqualTo(4));
        Assert.That(Kata.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }), Is.EqualTo(2));
        Assert.That(Kata.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }), Is.EqualTo(1));
        Assert.That(Kata.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }), Is.EqualTo(0));
    }
}