using System.Collections.Generic;
using System.Text;

namespace Kyu6.AlphabetWarAirstrikeLettersMassacre;

public class Kata
{
    public static string AlphabetWar(string fight)
    {

        if (string.IsNullOrEmpty(fight)) return "Let's fight again!";

        string leftside = "0sbpw";
        string rightside = "0zdqm";
        int score = 0;

        string result = RemoveBombs(fight);

        for (int i = 0; i < result.Length; i++)
        {
            if (leftside.Contains(result[i]))
            {
                score += leftside.IndexOf(result[i]);
            }
            else if (rightside.Contains(result[i]))
            {
                score -= rightside.IndexOf(result[i]);
            }
        }

        return score > 0 ? "Left side wins!" : score == 0 ? "Let's fight again!" : "Right side wins!";
    }

    public static string RemoveBombs(string fight)
    {
        var bombedIndexes = new HashSet<int>();

        for (int i = 0; i < fight.Length; i++)
        {
            if (fight[i] == '*')
            {
                bombedIndexes.Add(i);
                if (i > 0) bombedIndexes.Add(i - 1);
                if (i < fight.Length - 1) bombedIndexes.Add(i + 1);
            }
        }

        var result = new StringBuilder();

        for (int i = 0; i < fight.Length; i++)
        {
            if (!bombedIndexes.Contains(i))
            {
                result.Append(fight[i]);
            }
        }

        return result.ToString();
    }
}


[TestFixture]
public class AlphabetWarTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.AlphabetWar("z"), Is.EqualTo("Right side wins!"));
        Assert.That(Kata.AlphabetWar("****"), Is.EqualTo("Let's fight again!"));
        Assert.That(Kata.AlphabetWar("z*dq*mw*pb*s"), Is.EqualTo("Let's fight again!"));
        Assert.That(Kata.AlphabetWar("zdqmwpbs"), Is.EqualTo("Let's fight again!"));
        Assert.That(Kata.AlphabetWar("zz*zzs"), Is.EqualTo("Right side wins!"));
        Assert.That(Kata.AlphabetWar("*wwwwww*z*"), Is.EqualTo("Left side wins!"));
    }
}