using System;
using System.Linq;

namespace Kyu7.MakeBackronym;

public partial class Kata
{
    public static string MakeBackronym(string s)
    {
        return String.Join(" ", s.Select(x => dict[Char.ToUpper(x)]));
    }
}


[TestFixture]
public static class BackronymTests
{
    [Test, Order(1)]
    public static void TestExample1()
    {
        Assert.That(Kata.MakeBackronym("interesting"), Is.EqualTo("ingestable newtonian turn eager rant eager stylish turn ingestable newtonian gregarious"));
    }

    [Test, Order(2)]
    public static void TestExample2()
    {
        Assert.That(Kata.MakeBackronym("codewars"), Is.EqualTo("confident oscillating disturbing eager weird awesome rant stylish"));
    }
}



public static partial class Kata
{
    public static readonly Dictionary<char, string> dict = new()
    {
        { 'I', "ingestable" },
        { 'N', "newtonian" },
        { 'T', "turn" },
        { 'E', "eager" },
        { 'R', "rant" },
        { 'S', "stylish" },
        { 'G', "gregarious" },
        { 'C', "confident" },
        { 'O', "oscillating" },
        { 'D', "disturbing" },
        { 'W', "weird" },
        { 'A', "awesome" }
    };
}
