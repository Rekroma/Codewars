using System.Collections.Generic;

namespace Kyu8.OneZeroOneDalmatiansSquashTheBugsNotTheDogs;

public static class Kata
{
    public static string HowManyDalmatians(int number)
    {
        List<string> dogs = new List<string>()
        {
            "Hardly any",
            "More than a handful!",
            "Woah that's a lot of dogs!",
            "101 DALMATIONS!!!"
        };

        if (number <= 10)
            return dogs[0];
        else if (number <= 50)
            return dogs[1];
        else if (number == 101)
            return dogs[3];
        else
            return dogs[2];
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.HowManyDalmatians(26), Is.EqualTo("More than a handful!").IgnoreCase);
        Assert.That(Kata.HowManyDalmatians(8), Is.EqualTo("Hardly any").IgnoreCase);
        Assert.That(Kata.HowManyDalmatians(14), Is.EqualTo("More than a handful!").IgnoreCase);
        Assert.That(Kata.HowManyDalmatians(80), Is.EqualTo("Woah that's a lot of dogs!").IgnoreCase);
        Assert.That(Kata.HowManyDalmatians(100), Is.EqualTo("Woah that's a lot of dogs!").IgnoreCase);
        Assert.That(Kata.HowManyDalmatians(50), Is.EqualTo("More than a handful!").IgnoreCase);
        Assert.That(Kata.HowManyDalmatians(10), Is.EqualTo("Hardly any").IgnoreCase);
        Assert.That(Kata.HowManyDalmatians(101), Is.EqualTo("101 DALMATIONS!!!").IgnoreCase);
    }
}