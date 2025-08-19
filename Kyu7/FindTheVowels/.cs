using System;
using System.Linq;
using System.Collections.Generic;

namespace Kyu7.FindTheVowels;

public class Kata
{
    public static int[] VowelIndices(string word)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
        List<int> indices = new List<int>();

        for (int i = 0; i < word.Length; i++)
        {
            if (vowels.Contains(char.ToLower(word[i]))) { indices.Add(i + 1); }
        }

        return indices.ToArray();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void FixedTest()
    {
        Assert.That(Kata.VowelIndices("mmm"), Is.EqualTo(new int[] { }));
        Assert.That(Kata.VowelIndices("apple"), Is.EqualTo(new int[] { 1, 5 }));
        Assert.That(Kata.VowelIndices("super"), Is.EqualTo(new int[] { 2, 4 }));
        Assert.That(Kata.VowelIndices("orange"), Is.EqualTo(new int[] { 1, 3, 6 }));
        Assert.That(Kata.VowelIndices("supercalifragilisticexpialidocious"), Is.EqualTo(new int[] { 2, 4, 7, 9, 12, 14, 16, 19, 21, 24, 25, 27, 29, 31, 32, 33 }));
    }
}