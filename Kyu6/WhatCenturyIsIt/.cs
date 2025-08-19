using System.Collections.Generic;

namespace Kyu6.WhatCenturyIsIt;

public class Kata
{
    public static string WhatCentury(string year)
    {
        int century = (int.Parse(year) + 99) / 100;
        Dictionary<int, string> suffixes = new Dictionary<int, string>
        {
            {1, "st"},
            {2, "nd"},
            {3, "rd"}
        };

        if (century % 100 / 10 == 1)
        {
            return century + "th";
        }
        if (suffixes.ContainsKey(century % 10))
        {
            return century + suffixes[century % 10];
        }

        return century + "th";
    }
}


[TestFixture]
public class KataTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.WhatCentury("1999"), Is.EqualTo("20th"), "With input '1999' solution produced wrong output.");
        Assert.That(Kata.WhatCentury("2011"), Is.EqualTo("21st"), "With input '2011' solution produced wrong output.");
        Assert.That(Kata.WhatCentury("2154"), Is.EqualTo("22nd"), "With input '2154' solution produced wrong output.");
        Assert.That(Kata.WhatCentury("2259"), Is.EqualTo("23rd"), "With input '2259' solution produced wrong output.");
    }
}