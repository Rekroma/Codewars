using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Kyu6.FireAndFury;

public class Dinglemouse
{
    public static string FireAndFury(string tweet)
    {
        var allowedChars = new HashSet<char> { 'E', 'F', 'I', 'R', 'U', 'Y' };

        if (tweet.Any(c => !allowedChars.Contains(c)))
        {
            return "Fake tweet.";
        }

        var matches = Regex.Matches(tweet, "(FIRE|FURY)");

        if (matches.Count == 0)
        {
            return "Fake tweet.";
        }

        var result = new List<string>();
        int i = 0;

        while (i < matches.Count)
        {
            string currentWord = matches[i].Value;
            int count = 0;

            while (i + count < matches.Count && matches[i + count].Value == currentWord)
            {
                count++;
            }
            if (currentWord == "FIRE")
            {
                result.Add("You" + (count > 1 ? string.Join("", Enumerable.Repeat(" and you", count - 1)) : "") + " are fired!");
            }
            else
            {
                result.Add("I am" + (count > 1 ? string.Join("", Enumerable.Repeat(" really", count - 1)) : "") + " furious.");
            }
            i += count;
        }

        return string.Join(" ", result);
    }
}


public class ExampleTests
{
    [Test, Order(1)]
    public void Ex1()
    {
        Assert.That(Dinglemouse.FireAndFury("FURYYYFIREYYFIRE"), Is.EqualTo("I am furious. You and you are fired!"));
    }

    [Test, Order(2)]
    public void Ex2()
    {
        Assert.That(Dinglemouse.FireAndFury("FIREYYFURYYFURYYFURRYFIRE"), Is.EqualTo("You are fired! I am really furious. You are fired!"));
    }

    [Test, Order(3)]
    public void Ex3()
    {
        Assert.That(Dinglemouse.FireAndFury("FYRYFIRUFIRUFURE"), Is.EqualTo("Fake tweet."));
    }
}