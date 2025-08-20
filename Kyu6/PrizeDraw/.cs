using System;
using System.Collections.Generic;
using System.Linq;

namespace Kyu6.PrizeDraw;

public class Rank
{
    public static string NthRank(string st, int[] we, int n)
    {
        if (string.IsNullOrEmpty(st)) return "No participants";
        if (n > we.Length) return "Not enough participants";

        string abc = "0abcdefghijklmnopqrstuvwxyz";
        var winNum = new Dictionary<string, int>();

        foreach (string s in st.Split(','))
        {
            int index = Array.IndexOf(st.Split(','), s);
            int sum = 0;
            foreach (char c in s.ToLower())
            {
                sum += abc.IndexOf(c);
            }
            winNum.Add(s, (sum + s.Length) * we[index]);
        }
        winNum = winNum.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary();

        return winNum.Keys.ToList()[n - 1].ToString();
    }
}


[TestFixture]
public static class RankTests
{


    [Test]
    public static void test1()
    {
        string st = "";
        int[] we = new int[] { 4, 2, 1, 4, 3, 1, 2 };
        Assert.That(Rank.NthRank(st, we, 4), Is.EqualTo("No participants"));
        st = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
        we = new int[] { 4, 2, 1, 4, 3, 1, 2 };
        Assert.That(Rank.NthRank(st, we, 8), Is.EqualTo("Not enough participants"));
        st = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
        we = new int[] { 4, 2, 1, 4, 3, 1, 2 };
        Assert.That(Rank.NthRank(st, we, 4), Is.EqualTo("Benjamin"));
        st = "Elijah,Chloe,Elizabeth,Matthew,Natalie,Jayden";
        we = new int[] { 1, 3, 5, 5, 3, 6 };
        Assert.That(Rank.NthRank(st, we, 2), Is.EqualTo("Matthew"));
    }
}