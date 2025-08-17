using System.Linq;

namespace Kyu8.CountingSheep;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        return sheeps.Count(sheeps => sheeps);
    }
}


[TestFixture]
public class CountSheepsTests
{

    [Test]
    [Order(1)]
    public void SampleTest()
    {
        var sheeps = new bool[] { true, false, true };

        Assert.That(Kata.CountSheeps(sheeps), Is.EqualTo(2));
    }
}