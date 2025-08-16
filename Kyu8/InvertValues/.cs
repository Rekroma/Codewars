using System.Linq;

namespace Kyu8.InvertValues;

public static class ArraysInversion
{
    public static int[] InvertValues(int[] input)
    {
        return input.Select(i => -i).ToArray();
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void BasicTests()
    {
        Assert.That(ArraysInversion.InvertValues(new int[] { 1, 2, 3, 4, 5 }), Is.EqualTo(new int[] { -1, -2, -3, -4, -5 }));
        Assert.That(ArraysInversion.InvertValues(new int[] { 1, -2, 3, -4, 5 }), Is.EqualTo(new int[] { -1, 2, -3, 4, -5 }));
        Assert.That(ArraysInversion.InvertValues(new int[] { }), Is.EqualTo(new int[] { }));
        Assert.That(ArraysInversion.InvertValues(new int[] { 0 }), Is.EqualTo(new int[] { 0 }));
    }
}