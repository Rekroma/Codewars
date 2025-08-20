using System;

namespace Kyu7.LongestVowelChain;

public static class Kata
{
    public static int Solve(string str)
    {
        int vowelMaxLength = 0;
        int vowelLength = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if ("aeiou".Contains(str[i]))
            {
                vowelLength++;
                vowelMaxLength = Math.Max(vowelMaxLength, vowelLength);
            }
            else
            {
                vowelLength = 0;
            }
        }

        return vowelMaxLength;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Basic Tests")]
    public void SampleTest()
    {
        Assert.That(Kata.Solve("codewarriors"), Is.EqualTo(2));
        Assert.That(Kata.Solve("suoidea"), Is.EqualTo(3));
        Assert.That(Kata.Solve("ultrarevolutionariees"), Is.EqualTo(3));
        Assert.That(Kata.Solve("strengthlessnesses"), Is.EqualTo(1));
        Assert.That(Kata.Solve("cuboideonavicuare"), Is.EqualTo(2));
        Assert.That(Kata.Solve("chrononhotonthuooaos"), Is.EqualTo(5));
        Assert.That(Kata.Solve("iiihoovaeaaaoougjyaw"), Is.EqualTo(8));
    }
}