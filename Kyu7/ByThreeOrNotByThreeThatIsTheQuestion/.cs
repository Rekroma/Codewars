using System.Linq;

namespace Kyu7.ByThreeOrNotByThreeThatIsTheQuestion;

public static class Kata
{
    public static bool DivisibleByThree(string n)
    {
        return n.Select(c => c - 48).Sum() % 3 == 0;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.DivisibleByThree("1891009"), Is.EqualTo(false));
        Assert.That(Kata.DivisibleByThree("00009"), Is.EqualTo(true));
        Assert.That(Kata.DivisibleByThree("57"), Is.EqualTo(true));
    }
}