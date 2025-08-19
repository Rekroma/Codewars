using System;
using System.Linq;

namespace Kyu6.ConsonantValue;

public class Kata
{
    public static int Solve(string s)
    {
        return s.Split("aeiou".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(sub => sub.Sum(c => c - 'a' + 1)).Max();
    }
}


[TestFixture]
public class Tests
{
    [TestCase("zodiac", 26)]
    [TestCase("chruschtschov", 80)]
    [TestCase("khrushchev", 38)]
    [TestCase("strength", 57)]
    [TestCase("catchphrase", 73)]
    [TestCase("twelfthstreet", 103)]
    [TestCase("mischtschenkoana", 80)]
    public void BasicTests(string input, int expected)
    {
        Assert.That(Kata.Solve(input), Is.EqualTo(expected));
    }
}