using System;
using System.Linq;

namespace Kyu6.ArrayHelpers;

public static class Extensions
{
    public static int[] Square(this int[] x)
    {
        return x.Select(n => n * n).ToArray();
    }

    public static int[] Cube(this int[] x)
    {
        return x.Select(n => n * n * n).ToArray();
    }

    public static int Sum(this int[] x)
    {
        int sum = 0;
        foreach (int i in x) sum += i;
        return sum;
    }

    public static double Average(this int[] x)
    {
        return x.Length == 0 ? Double.NaN : x.Sum() / (double)x.Length;
    }

    public static int[] Even(this int[] x)
    {
        return x.Where(n => n % 2 == 0).ToArray();
    }

    public static int[] Odd(this int[] x)
    {
        return x.Where(n => n % 2 != 0).ToArray();
    }
}


[TestFixture]
public class Tests
{
    int[] array = new[] { 1, 2, 3, 4, 5 };

    [Test, Order(1)]
    public void ShouldSquareCorrectly()
    {
        Assert.That(array.Square(), Is.EqualTo(new[] { 1, 4, 9, 16, 25 }), "Square should work correctly");
        Assert.That(array, Is.EqualTo(new[] { 1, 2, 3, 4, 5 }), "Original array should not be modified");
        Assert.That(array.Square(), Is.InstanceOf<int[]>(), "Square should return an array");
    }

    [Test, Order(2)]
    public void ShouldCubeCorrectly()
    {
        Assert.That(array.Cube(), Is.EqualTo(new[] { 1, 8, 27, 64, 125 }), "Cube should work correctly");
        Assert.That(array, Is.EqualTo(new[] { 1, 2, 3, 4, 5 }), "Original array should not be modified");
        Assert.That(array.Cube(), Is.InstanceOf<int[]>(), "Cube should return an array");
    }

    [Test, Order(3)]
    public void ShouldSumCorrectly()
    {
        Assert.That(array.Sum(), Is.EqualTo(15), "Sum should work correctly");
        Assert.That(array, Is.EqualTo(new[] { 1, 2, 3, 4, 5 }), "Original array should not be modified");
    }

    [Test, Order(4)]
    public void ShouldAverageCorrectly()
    {
        Assert.That(array.Average(), Is.EqualTo(3), "Average should work correctly");
        Assert.That(array, Is.EqualTo(new[] { 1, 2, 3, 4, 5 }), "Original array should not be modified");
    }

    [Test, Order(5)]
    public void ShouldEvenAndOddCorrectly()
    {
        Assert.That(array.Even(), Is.EqualTo(new[] { 2, 4 }), "Even should work correctly");
        Assert.That(array, Is.EqualTo(new[] { 1, 2, 3, 4, 5 }), "Original array should not be modified");
        Assert.That(array.Even(), Is.InstanceOf<int[]>(), "Even should return an array");

        Assert.That(array.Odd(), Is.EqualTo(new[] { 1, 3, 5 }), "Odd should work correctly");
        Assert.That(array, Is.EqualTo(new[] { 1, 2, 3, 4, 5 }), "Original array should not be modified");
        Assert.That(array.Odd(), Is.InstanceOf<int[]>(), "Odd should return an array");
    }
}