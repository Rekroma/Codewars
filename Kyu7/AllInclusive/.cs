using System;
using System.Collections.Generic;

namespace Kyu7.AllInclusive;

public class Rotations
{
    public static Boolean ContainAllRots(string strng, List<string> arr)
    {
        for (int i = 0; i < strng.Length; i++)
        {
            string rotated = strng.Substring(i) + strng.Substring(0, i);
            if (!arr.Contains(rotated)) return false;
        }

        return true;
    }
}


[TestFixture]
public static class RotationsTests
{

    private static void testing(Boolean actual, Boolean expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Description("Basic Tests ContainAllRots")]
    public static void test1()
    {
        List<string> a = new List<string>() { "bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs" };
        testing(Rotations.ContainAllRots("bsjq", a), true);
        a = new List<string>() { };
        testing(Rotations.ContainAllRots("", a), true);
        a = new List<string>() { "bsjq", "qbsj" };
        testing(Rotations.ContainAllRots("", a), true);
        a = new List<string>() { "TzYxlgfnhf", "yqVAuoLjMLy", "BhRXjYA", "YABhRXj", "hRXjYAB", "jYABhRX", "XjYABhR", "ABhRXjY" };
        testing(Rotations.ContainAllRots("XjYABhR", a), false);
    }
}