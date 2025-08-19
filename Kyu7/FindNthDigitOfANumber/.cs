using System.Linq;

namespace Kyu7.FindNthDigitOfANumber;

public class Kata
{
    public static int FindDigit(int num, int nth)
    {
        if (nth <= 0) return -1;
        int[] numTrans = num.ToString().Replace("-", "").Select(x => int.Parse(x.ToString())).ToArray();
        if (nth > numTrans.Length) return 0;
        return numTrans[numTrans.Length - nth];
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.FindDigit(5673, 4), Is.EqualTo(5));
        Assert.That(Kata.FindDigit(129, 2), Is.EqualTo(2));
        Assert.That(Kata.FindDigit(-2825, 3), Is.EqualTo(8));
        Assert.That(Kata.FindDigit(-456, 4), Is.EqualTo(0));
        Assert.That(Kata.FindDigit(0, 20), Is.EqualTo(0));
        Assert.That(Kata.FindDigit(65, 0), Is.EqualTo(-1));
        Assert.That(Kata.FindDigit(24, -8), Is.EqualTo(-1));
    }
}