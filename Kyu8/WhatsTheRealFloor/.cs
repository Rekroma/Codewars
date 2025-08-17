namespace Kyu8.WhatsTheRealFloor;

public static class Kata
{
    public static int GetRealFloor(int n)
    {
        return n < 1 ? n : n < 13 ? n - 1 : n - 2;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.GetRealFloor(1), Is.EqualTo(0));
        Assert.That(Kata.GetRealFloor(5), Is.EqualTo(4));
        Assert.That(Kata.GetRealFloor(15), Is.EqualTo(13));
    }
}