namespace Kyu8.WillThereBeEnoughSpace;

public static class Kata
{
    public static int Enough(int cap, int on, int wait)
    {
        return cap >= (on + wait) ? 0 : -cap + on + wait;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Enough(10, 5, 5), Is.EqualTo(0));
        Assert.That(Kata.Enough(100, 60, 50), Is.EqualTo(10));
        Assert.That(Kata.Enough(20, 5, 5), Is.EqualTo(0));
    }
}