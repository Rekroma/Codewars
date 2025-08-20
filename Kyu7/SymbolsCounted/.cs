using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Kyu7.SymbolsCounted;

public static class Kata
{
    public static string Transform(string s)
    {
        var counts = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        var processedRepeatedChars = new HashSet<char>();
        var resultBuilder = new StringBuilder();

        foreach (char c in s)
        {
            if (counts[c] == 1) { resultBuilder.Append(c); }
            else
            {
                if (!processedRepeatedChars.Contains(c))
                {
                    resultBuilder.Append(c);
                    resultBuilder.Append(counts[c]);
                    processedRepeatedChars.Add(c);
                }
            }
        }

        return resultBuilder.ToString();
    }
}


[TestFixture]
public class BasicTests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData("elevation").Returns("e2lvation");
            yield return new TestCaseData("transplantology").Returns("t2ra2n2spl2o2gy");
            yield return new TestCaseData("economics").Returns("ec2o2nmis");
            yield return new TestCaseData("embarrassed").Returns("e2mba2r2s2d");
            yield return new TestCaseData("impressive").Returns("i2mpre2s2v");
        }
    }

    [Test, TestCaseSource("testCases")]
    public string Test(string s) =>
      Kata.Transform(s);
}