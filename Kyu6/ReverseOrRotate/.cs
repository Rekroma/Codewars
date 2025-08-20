using System;
using System.Linq;

namespace Kyu6.ReverseOrRotate;

public class Revrot
{
    public static string RevRot(string strng, int sz)
    {
        if (strng == "" || sz <= 0 || sz > strng.Length) return "";

        var result = strng.Chunk(sz).Select(x => new string(x)).ToList();
        string res = "";

        foreach (var item in result)
        {
            if (item.Length == sz)
            {
                int sum = item.Select(c => (c - '0')).Sum();
                res += (sum % 2 == 0 ? new string(item.Reverse().ToArray()) : Revrot.Rotate(item));
            }
        }

        return res;
    }

    public static string Rotate(string str)
    {
        return str.Substring(1) + str[0];
    }
}


[TestFixture]
public static class RevrotTests
{

    private static void testing(string actual, string expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public static void test1()
    {
        testing(Revrot.RevRot("1234", 0), "");
        testing(Revrot.RevRot("", 0), "");
        testing(Revrot.RevRot("1234", 5), "");
        String s = "733049910872815764";
        testing(Revrot.RevRot(s, 5), "330479108928157");
    }
}