namespace Kyu7.SimpleBeadsCount;

public static class Kata
{
    public static int CountRedBeads(int n)
    {
        return n < 3 ? 0 : (n - 1) * 2;
    }
}


[TestFixture]
public class SampleTests
{
    [Test, Description("Basic Tests")]
    public void SampleTest()
    {
        Assert.That(Kata.CountRedBeads(0), Is.EqualTo(0));
        Assert.That(Kata.CountRedBeads(1), Is.EqualTo(0));
        Assert.That(Kata.CountRedBeads(3), Is.EqualTo(4));
        Assert.That(Kata.CountRedBeads(5), Is.EqualTo(8));
    }
}