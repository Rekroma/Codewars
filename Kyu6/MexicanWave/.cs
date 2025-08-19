using System.Linq;
using System.Collections.Generic;

namespace Kyu6.MexicanWave;

public class Kata
{
    public List<string> wave(string str)
    {
        List<string> wave = new List<string>();
        char[] chars = str.ToCharArray();

        for (int i = 0; i < str.Length; i++)
        {
            chars = chars.Select(x => char.ToLower(x)).ToArray();

            if (str[i] != ' ')
            {
                chars[i] = char.ToUpper(chars[i]);
                wave.Add(new string(chars));
            }
        }

        return wave;
    }
}


[TestFixture]
class KataTestClass
{
    [TestCase]
    [Order(1)]
    public void BasicTest1()
    {
        Kata kata = new Kata();
        List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
        Assert.That(kata.wave("hello"), Is.EqualTo(result), "it should return '" + result + "'");
    }

    [TestCase]
    [Order(2)]
    public void BasicTest2()
    {
        Kata kata = new Kata();
        List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
        Assert.That(kata.wave("codewars"), Is.EqualTo(result), "it should return '" + result + "'");
    }

    [TestCase]
    [Order(3)]
    public void BasicTest3()
    {
        Kata kata = new Kata();
        List<string> result = new List<string> { };
        Assert.That(kata.wave(""), Is.EqualTo(result), "it should return '" + result + "'");
    }

    [TestCase]
    [Order(4)]
    public void BasicTest4()
    {
        Kata kata = new Kata();
        List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
        Assert.That(kata.wave("two words"), Is.EqualTo(result), "it should return '" + result + "'");
    }

    [TestCase]
    [Order(5)]
    public void BasicTest5()
    {
        Kata kata = new Kata();
        List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
        Assert.That(kata.wave(" gap "), Is.EqualTo(result), "it should return '" + result + "'");
    }
}