using System.Linq;

namespace Kyu8.SpeechCodeTwoArrayMadness;

public class Kata
{
    public static bool ArrayMadness(int[] a, int[] b)
    {
        return a.Sum(x => x * x) > b.Sum(x => x * x * x);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Should work for sample tests")]
    public void SampleTest()
    {
        Assert.That(Kata.ArrayMadness(new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 }), Is.EqualTo(true));
        Assert.That(Kata.ArrayMadness(new int[] { 5, 6, 7 }, new int[] { 4, 5, 6 }), Is.EqualTo(false));
    }
}