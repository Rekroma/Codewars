using System;

namespace Kyu8.CountTheNumbersOfCubesWithPaintOn;

public static class Kata
{
    public static int CountSquares(int cuts)
    {
        return cuts == 0 ? 1 : (int)Math.Pow(cuts + 1, 3) - (int)Math.Pow(cuts - 1, 3);
    }
}


[TestFixture]
public class KataTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.CountSquares(0), Is.EqualTo(1));
        Assert.That(Kata.CountSquares(5), Is.EqualTo(152));
        Assert.That(Kata.CountSquares(16), Is.EqualTo(1538));
        Assert.That(Kata.CountSquares(23), Is.EqualTo(3176));
    }
}
