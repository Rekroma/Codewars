using System.Collections.Generic;

namespace Kyu6.SplitStrings;

public class SplitString
{
    public static string[] Solution(string str)
    {
        if (str == "") return new string[0];

        List<string> pairs = new List<string>();

        for (int i = 0; i < str.Length; i += 2)
        {
            if (i + 1 < str.Length) pairs.Add(str.Substring(i, 2));
            else pairs.Add(str[i] + "_");
        }

        return pairs.ToArray();
    }
}


[TestFixture]
public class SplitStringTests
{
    [Test]
    public void BasicTests()
    {
        var actual = SplitString.Solution("abc");
        Assert.That(actual, Is.EqualTo(new string[] { "ab", "c_" }));

        actual = SplitString.Solution("abcdef");
        Assert.That(actual, Is.EqualTo(new string[] { "ab", "cd", "ef" }));
    }
}