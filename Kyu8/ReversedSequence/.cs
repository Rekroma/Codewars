using System.Linq;

namespace Kyu8.ReversedSequence;

public static class Kata
{
    public static int[] ReverseSeq(int n)
    {
        return Enumerable.Range(1, n).Reverse().ToArray();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.ReverseSeq(5), Is.EqualTo(new int[] { 5, 4, 3, 2, 1 }));
    }
}