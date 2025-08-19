using System;
using System.Linq;
using System.Collections.Generic;

namespace Kyu7.TestingOneTwoThree;

public class LineNumbering
{
    public static List<string> Number(List<string> lines)
    {
        var result = new List<string>();

        for (int i = 0; i < lines.Count; i++)
        {
            result.Add($"{i + 1}: {lines[i]}");
        }

        return result;
    }
}


[TestFixture]
public class LineNumberingTest
{
    [Test]
    public void basicTests()
    {
        Assert.That(LineNumbering.Number(new List<string>()), Is.EqualTo(new List<string>()));
        Assert.That(LineNumbering.Number(new List<string> { "a", "b", "c" }), Is.EqualTo(new List<string> { "1: a", "2: b", "3: c" }));
        Assert.That(LineNumbering.Number(new List<string> { "", "", "", "", "" }), Is.EqualTo(new List<string> { "1: ", "2: ", "3: ", "4: ", "5: " }));
    }
}