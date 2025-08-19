using System.Linq;

namespace Kyu7.SumOfOddCubedNumbers;

public class Kata
{
    public static int CubeOdd(int[] arr)
    {
        return arr.Where(x => x % 2 != 0).Select(x => x * x * x).Sum();
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.CubeOdd(new int[] { 1, 2, 3, 4 }), Is.EqualTo(28));
        Assert.That(Kata.CubeOdd(new int[] { -3, -2, 2, 3 }), Is.EqualTo(0));
    }
}