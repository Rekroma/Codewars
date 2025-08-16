using System.Linq;

namespace Kyu8.GravityFlip;

public class Kata
{
    public static int[] Flip(char dir, int[] arr)
    {
        return dir == 'R' ? arr.OrderBy(x => x).ToArray() : arr.OrderByDescending(x => x).ToArray();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void Sample()
    {
        Assert.That(Kata.Flip('R', new int[] { 3, 2, 1, 2 }), Is.EqualTo(new int[] { 1, 2, 2, 3 }));
        Assert.That(Kata.Flip('L', new int[] { 1, 4, 5, 3, 5 }), Is.EqualTo(new int[] { 5, 5, 4, 3, 1 }));
    }
}