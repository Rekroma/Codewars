using System.Linq;
using System.Collections.Generic;

namespace Kyu8.PiratesAreTheCannonsReady;

public static class Kata
{
    public static string CannonsReady(Dictionary<string, string> gunners)
    {
        return gunners.Values.All(s => s == "aye") ? "Fire!" : "Shiver me timbers!";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("should fire the cannons when ready")]
    [Order(1)]
    public void SampleAyeTest()
    {
        Dictionary<string, string> gunners = new Dictionary<string, string>
      {
        {"Mike", "aye"},
        {"Joe", "aye"},
        {"Johnson", "aye"},
        {"Peter", "aye"}
      };

        Assert.That(Kata.CannonsReady(gunners), Is.EqualTo("Fire!"));
    }

    [Test, Description("should shiver me timbers if not ready")]
    [Order(2)]
    public void SampleNayTest()
    {
        Dictionary<string, string> gunners = new Dictionary<string, string>
      {
        {"Mike", "aye"},
        {"Joe", "nay"},
        {"Johnson", "aye"},
        {"Peter", "aye"}
      };

        Assert.That(Kata.CannonsReady(gunners), Is.EqualTo("Shiver me timbers!"));
    }
}