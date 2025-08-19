

namespace Kyu7.SimpleFunOneNineFiveGuessHatColor;

    public class Kata
{
    public int GuessHatColor(string a, string b, string c, string d)
    {
        return b != c ? 2 : 1;
    }
}


[TestFixture]
public class myjinxin
{

    [Test]
    public void BasicTests()
    {
        var kata = new Kata();

        Assert.That(kata.GuessHatColor("black", "white", "black", "white"), Is.EqualTo(2));

        Assert.That(kata.GuessHatColor("white", "black", "white", "black"), Is.EqualTo(2));

        Assert.That(kata.GuessHatColor("white", "black", "black", "white"), Is.EqualTo(1));

    }

}