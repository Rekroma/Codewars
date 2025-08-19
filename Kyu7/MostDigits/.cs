using System.Linq;

namespace Kyu7.MostDigits;

public class Kata
{
    public static int FindLongest(int[] numbers)
    {
        return numbers
            .Select((num, index) => new { num, index })
            .OrderByDescending(x => x.num.ToString().Length)
            .ThenBy(x => x.index)
            .First().num;
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.FindLongest(new int[] { 1, 10, 100 }), Is.EqualTo(100));
        Assert.That(Kata.FindLongest(new int[] { 9000, 8, 800 }), Is.EqualTo(9000));
        Assert.That(Kata.FindLongest(new int[] { 8, 900, 500 }), Is.EqualTo(900));
    }
}