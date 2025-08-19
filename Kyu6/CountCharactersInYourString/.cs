using System.Collections.Generic;

namespace Kyu6.CountCharactersInYourString;

public class Kata
{
    public static Dictionary<char, int> Count(string str)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in str)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict.Add(c, 1);
            }
        }

        return dict;
    }
}


[TestFixture]
public class Tests
{
    private static void Tester(Dictionary<char, int> expected, Dictionary<char, int> submitted, string input)
    {
        foreach (KeyValuePair<char, int> entry in expected)
        {
            char key = entry.Key;
            if (submitted.ContainsKey(key))
            {
                int val = entry.Value;
                int num = submitted[key];
                Assert.That(num, Is.EqualTo(val), $"For input string: \"{input}\"\n \n< Incorrect Value for Key '{key}' >");
            }
            else
            {
                Assert.Fail($"For input string: \"{input}\"\n \n< The submitted Dictionary should contain an entry for key '{entry.Key}' >");
            }
        }
        foreach (KeyValuePair<char, int> entry in submitted)
        {
            if (expected.ContainsKey(entry.Key) == false)
            {
                Assert.Fail($"For input string: \"{input}\"\n \n< The submitted Dictionary should NOT contain an entry for key '{entry.Key}' >");
            }
        }
        Assert.That(true, Is.EqualTo(true));
    }
    [Test, Order(1)]
    public static void SampleTest_a()
    {
        Dictionary<char, int> d = new Dictionary<char, int>();
        d.Add('a', 1);
        string s = "a";
        Tester(d, Kata.Count(s), s);
    }
    [Test, Order(2)]
    public static void SampleTest_aba()
    {
        Dictionary<char, int> d = new Dictionary<char, int>();
        d.Add('a', 2);
        d.Add('b', 1);
        string s = "aba";
        Tester(d, Kata.Count(s), s);
    }
}