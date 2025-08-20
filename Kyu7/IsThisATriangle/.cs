using System.Linq;

namespace Kyu7.IsThisATriangle;

public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        return new int[] { a, b, c }.Max() < new int[] { a, b, c }.OrderBy(x => x).Take(2).Sum();
    }
}


[TestFixture]
public class TriangleTests
{
    [Test]
    [Order(1)]
    public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
    {
        Assert.That(Triangle.IsTriangle(5, 7, 10), Is.True);
    }
}