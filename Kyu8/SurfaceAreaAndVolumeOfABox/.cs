namespace Kyu8.SurfaceAreaAdVolumeOfABox;

public class Kata
{
    public static int[] Get_size(int w, int h, int d)
    {
        return new int[] { 2 * (w * h + h * d + d * w), w * h * d };
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void Test1()
    {
        Assert.That(Kata.Get_size(4, 2, 6), Is.EqualTo(new[] { 88, 48 }));
        Assert.That(Kata.Get_size(1, 1, 1), Is.EqualTo(new[] { 6, 1 }));
        Assert.That(Kata.Get_size(1, 2, 1), Is.EqualTo(new[] { 10, 2 }));
        Assert.That(Kata.Get_size(1, 2, 2), Is.EqualTo(new[] { 16, 4 }));
        Assert.That(Kata.Get_size(10, 10, 10), Is.EqualTo(new[] { 600, 1000 }));
    }
}