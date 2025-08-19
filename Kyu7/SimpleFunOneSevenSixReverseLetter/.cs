using System;
using System.Linq;

namespace Kyu7.SimpleFunOneSevenSixReverseLetter;

public class Kata
{
    public string ReverseLetter(string str)
    {
        return String.Join("", str.Where(x => Char.IsLetter(x)).Reverse());
    }
}


[TestFixture]
public class myjinxin
{

    [Test]
    public void BasicTests()
    {
        var kata = new Kata();

        Assert.That(kata.ReverseLetter("krishan"), Is.EqualTo("nahsirk"));

        Assert.That(kata.ReverseLetter("ultr53o?n"), Is.EqualTo("nortlu"));

        Assert.That(kata.ReverseLetter("ab23c"), Is.EqualTo("cba"));

        Assert.That(kata.ReverseLetter("krish21an"), Is.EqualTo("nahsirk"));

    }

}