using System;
using System.Linq;

namespace Kyu6.DuplicateEncoder;

public static class Kata
{
    public static string DuplicateEncode(string word)
    {
        word = word.ToLower();
        string res = "";

        foreach (char c in word)
        {
            if (word.Count(x => x == c) > 1)
            {
                res += ")";
            }
            else
            {
                res += "(";
            }
        }

        return res;
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.DuplicateEncode("din"), Is.EqualTo("((("));
        Assert.That(Kata.DuplicateEncode("recede"), Is.EqualTo("()()()"));
        Assert.That(Kata.DuplicateEncode("Success"), Is.EqualTo(")())())"), "should ignore case");
        Assert.That(Kata.DuplicateEncode("(( @"), Is.EqualTo("))(("));
    }
}