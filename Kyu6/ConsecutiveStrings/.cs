using System.Linq;

namespace Kyu6.ConsecutiveStrings;

public class LongestConsecutives
{
    public static string LongestConsec(string[] strarr, int k)
    {
        if (strarr.Length == 0 || k <= 0 || strarr.Length < k) return "";

        string str = "";

        for (int i = 0; i <= strarr.Length - k; i++)
        {
            string temp = string.Concat(strarr.Skip(i).Take(k));
            if (temp.Length > str.Length)
                str = temp;
        }

        return str;
    }
}


[TestFixture]
public static class LongestConsecutivesTests
{
    private static void testing(string actual, string expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public static void test1()
    {
        testing(LongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2), "abigailtheta");
        testing(LongestConsecutives.LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1), "oocccffuucccjjjkkkjyyyeehh");
        testing(LongestConsecutives.LongestConsec(new String[] { }, 3), "");
        testing(LongestConsecutives.LongestConsec(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2), "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");
        testing(LongestConsecutives.LongestConsec(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2), "wlwsasphmxxowiaxujylentrklctozmymu");
        testing(LongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2), "");
        testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3), "ixoyx3452zzzzzzzzzzzz");
        testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15), "");
        testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0), "");
    }
}