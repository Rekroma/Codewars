namespace Kyu8.VolumeOfACuboid;

public class Kata
{
    public static double GetVolumeOfCuboid(double length, double width, double height)
    {
        return length * width * height;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTests()
    {
        Assert.That(Kata.GetVolumeOfCuboid(2, 5, 6), Is.EqualTo(60).Within(0.00001), "Length: 2, Width: 5, Height: 6");
        Assert.That(Kata.GetVolumeOfCuboid(6.3, 3, 5), Is.EqualTo(94.5).Within(0.00001), "Length: 6.3, Width: 3, Height: 5");
    }
}