using System.Linq;

namespace Kyu7.SplitInParts;

public class Kata
{
    public static string SplitInParts(string s, int partLength)
    {
        return string.Join(" ", s.Chunk(partLength).Select(a => string.Join("", a)));
    }
}


[TestFixture]
public class SplitIt
{
    [TestCase, Order(1)]
    //Fixed values
    public void splitString1()
    {
        string str = "supercalifragilisticexpialidocious";
        Assert.That(Kata.SplitInParts(str, 3), Is.EqualTo("sup erc ali fra gil ist ice xpi ali doc iou s"));
    }

    [TestCase, Order(2)]
    //Fixed values
    public void splitString2()
    {
        string str = "HelloKata";
        Assert.That(Kata.SplitInParts(str, 3), Is.EqualTo("Hel loK ata"));
    }

    [TestCase, Order(3)]
    //Fixed values
    public void splitString3()
    {
        string str = "HelloKata";
        Assert.That(Kata.SplitInParts(str, 1), Is.EqualTo("H e l l o K a t a"));
    }

    [TestCase, Order(4)]
    //Fixed values
    public void splitString4()
    {
        string str = "HelloKata";
        Assert.That(Kata.SplitInParts(str, 9), Is.EqualTo("HelloKata"));
    }
}