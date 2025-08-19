using System.Linq;

namespace Kyu7.SimpleFunOneFiveSixRotatePaperByOneEightZeroDegrees;

public class Kata
{
    public bool RotatePaper(string number)
    {
        return number.Any(x => !"1347".Contains(x)) && number.Select(x => x == '6' ? '9' : x == '9' ? '6' : x).SequenceEqual(number.Reverse().ToArray());
    }
}


[TestFixture]
public class myjinxin
{

    [Test]
    public void BasicTests()
    {
        var kata = new Kata();

        Assert.That(kata.RotatePaper("000"), Is.EqualTo(true));

        Assert.That(kata.RotatePaper("1"), Is.EqualTo(false));

        Assert.That(kata.RotatePaper("96"), Is.EqualTo(true));

        Assert.That(kata.RotatePaper("689"), Is.EqualTo(true));

        Assert.That(kata.RotatePaper("56789"), Is.EqualTo(false));
    }

}