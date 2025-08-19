namespace Kyu7.SumOfASequence;

public static class Kata
{
    public static int SequenceSum(int start, int end, int step)
    {
        if (start > end) return 0;
        int sum = 0;

        for (int i = start; i <= end; i += step)
        {
            sum += i;
        }

        return sum;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.SequenceSum(2, 6, 2), Is.EqualTo(12));
        Assert.That(Kata.SequenceSum(1, 5, 1), Is.EqualTo(15));
        Assert.That(Kata.SequenceSum(1, 5, 3), Is.EqualTo(5));
        Assert.That(Kata.SequenceSum(0, 15, 3), Is.EqualTo(45));
        Assert.That(Kata.SequenceSum(16, 15, 3), Is.EqualTo(0));
        Assert.That(Kata.SequenceSum(2, 24, 22), Is.EqualTo(26));
        Assert.That(Kata.SequenceSum(2, 2, 2), Is.EqualTo(2));
        Assert.That(Kata.SequenceSum(2, 2, 1), Is.EqualTo(2));
        Assert.That(Kata.SequenceSum(1, 15, 3), Is.EqualTo(35));
        Assert.That(Kata.SequenceSum(15, 1, 3), Is.EqualTo(0));
    }
}