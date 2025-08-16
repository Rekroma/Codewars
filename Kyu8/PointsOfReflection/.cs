namespace Kyu8.PointsOfReflection;

public class Kata
{
    public static int[] SymmetricPoint(int[] p, int[] q)
    {
        return new int[] { 2 * q[0] - p[0], 2 * q[1] - p[1] };
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Your solution should work for some fixed tests")]
    public void FixedTest()
    {
        Assert.That(Kata.SymmetricPoint(new int[] { 0, 0 }, new int[] { 1, 1 }), Is.EqualTo(new int[] { 2, 2 }));
        Assert.That(Kata.SymmetricPoint(new int[] { 2, 6 }, new int[] { -2, -6 }), Is.EqualTo(new int[] { -6, -18 }));
        Assert.That(Kata.SymmetricPoint(new int[] { 10, -10 }, new int[] { -10, 10 }), Is.EqualTo(new int[] { -30, 30 }));
        Assert.That(Kata.SymmetricPoint(new int[] { 1, -35 }, new int[] { -12, 1 }), Is.EqualTo(new int[] { -25, 37 }));
        Assert.That(Kata.SymmetricPoint(new int[] { 1000, 15 }, new int[] { -7, -214 }), Is.EqualTo(new int[] { -1014, -443 }));
        Assert.That(Kata.SymmetricPoint(new int[] { 0, 0 }, new int[] { 0, 0 }), Is.EqualTo(new int[] { 0, 0 }));
    }
}