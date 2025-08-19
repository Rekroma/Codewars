using System;

namespace Kyu6.YourOrderPlease;

public static class Kata
{
    public static string Order(string words)
    {
        if (string.IsNullOrEmpty(words)) return string.Empty;
        string[] sentence = new string[words.Split().Length];

        foreach (var word in words.Split(' '))
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    Console.WriteLine(word[i]);
                    sentence[Convert.ToInt32(word[i]) - '0' - 1] = word;
                }
            }
        }

        return string.Join(" ", sentence);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Sample Tests"), Order(1)]
    public void SampleTest()
    {
        Assert.That(Kata.Order("is2 Thi1s T4est 3a"), Is.EqualTo("Thi1s is2 3a T4est"));
        Assert.That(Kata.Order("4of Fo1r pe6ople g3ood th5e the2"), Is.EqualTo("Fo1r the2 g3ood 4of th5e pe6ople"));
        Assert.That(Kata.Order(""), Is.EqualTo(""));
    }
}