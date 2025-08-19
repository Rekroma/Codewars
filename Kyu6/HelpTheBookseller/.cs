using System;
using System.Linq;
using System.Collections.Generic;

namespace Kyu6.HelpTheBookseller;

public class StockList
{
    public static string stockSummary(string[] lstOfArt, string[] lstOf1stLetter)
    {
        if (lstOfArt.Length == 0 || lstOf1stLetter.Length == 0) return "";
        Dictionary<string, int> dict = new();

        foreach (string letter in lstOf1stLetter)
        {
            dict[letter] = 0;
        }

        foreach (string s in lstOfArt)
        {
            int num = int.Parse(new string(s.Where(char.IsDigit).ToArray()));
            string key = s[0].ToString();

            if (dict.ContainsKey(key)) dict[key] += num;
        }

        return string.Join(" - ", dict.Select(kvp => $"({kvp.Key} : {kvp.Value})"));
    }
}


[TestFixture]
public class StockListTests
{

    [Test]
    public void Test1()
    {
        string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
        String[] cd = new String[] { "A", "B" };
        Assert.That(StockList.stockSummary(art, cd), Is.EqualTo("(A : 200) - (B : 1140)"));
    }
}
