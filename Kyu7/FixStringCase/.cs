using System;

namespace Kyu7.FixStringCase;

class Kata
{
    public static string Solve(string s)
    {
        int upper = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (Char.IsUpper(s[i])) upper++;
        }

        return s.Length / 2 < upper ? s.ToUpper() : s.ToLower();
    }
}


[TestFixture]
class Tetst
{
    [TestCase("code", "code")]
    [TestCase("CODe", "CODE")]
    [TestCase("COde", "code")]
    [TestCase("Code", "code")]
    public void BasicTests(string s, string expected)
    {
        Assert.That(Kata.Solve(s), Is.EqualTo(expected));
    }
}