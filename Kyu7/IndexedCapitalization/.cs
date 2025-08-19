using System;
using System.Text;
using System.Collections.Generic;

namespace Kyu7.IndexedCapitalization;

public static class Kata
{
    public static string Capitalize(string s, List<int> idxs)
    {
        string str = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (idxs.Contains(i))
            {
                str += char.ToUpper(s[i]);
            }
            else
            {
                str += s[i];
            }
        }

        return str;
    }
}


[TestFixture]
public class BasicTest
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData("abcdef", new List<int> { 1, 2, 5 }).Returns("aBCdeF");
            yield return new TestCaseData("abcdef", new List<int> { 1, 2, 5, 100 }).Returns("aBCdeF");
            yield return new TestCaseData("abcdef", new List<int> { 1, 100, 2, 5 }).Returns("aBCdeF");
            yield return new TestCaseData("codewars", new List<int> { 1, 3, 5, 50 }).Returns("cOdEwArs");
            yield return new TestCaseData("abracadabra", new List<int> { 2, 6, 9, 10 }).Returns("abRacaDabRA");
            yield return new TestCaseData("codewarriors", new List<int> { 5 }).Returns("codewArriors");
            yield return new TestCaseData("indexinglessons", new List<int> { 0 }).Returns("Indexinglessons");
        }
    }

    [Test, TestCaseSource("testCases")]
    public string Test(string s, List<int> idxs) =>
      Kata.Capitalize(s, idxs);
}