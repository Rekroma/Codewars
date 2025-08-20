using System;
using System.Collections.Generic;
using System.Linq;

namespace Kyu7.BuildingStringsFromAHash;

public static class Kata
{
    public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
    {
        string res = "";

        foreach (KeyValuePair<TKey, TValue> kv in hash)
        {
            res += $"{kv.Key} = {kv.Value},";
        }

        return res.TrimEnd(',', ' ');
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Basic Tests")]
    public void Test()
    {
        Assert.That(Kata.StringifyDict(new Dictionary<char, int> { { 'a', 1 }, { 'b', 2 } }), Is.EqualTo("a = 1,b = 2"));
        Assert.That(Kata.StringifyDict(new Dictionary<char, int> { { 'b', 1 }, { 'c', 2 }, { 'e', 3 } }), Is.EqualTo("b = 1,c = 2,e = 3"));
        Assert.That(Kata.StringifyDict(new Dictionary<char, int>()), Is.EqualTo(""));
    }
}