namespace Kyu8.BeginnerSeriesOneSchoolPaperwork;

public static class Paper
{
    public static int Paperwork(int n, int m)
    {
        return n < 0 || m < 0 ? 0 : n * m;
    }
}


[TestFixture]
public class PaperWork
{
    [Test]
    public void Test()
    {
        Assert.That(Paper.Paperwork(5, 5), Is.EqualTo(25));
        Assert.That(Paper.Paperwork(5, -5), Is.EqualTo(0));
        Assert.That(Paper.Paperwork(-5, -5), Is.EqualTo(0));
        Assert.That(Paper.Paperwork(-5, 5), Is.EqualTo(0));
        Assert.That(Paper.Paperwork(5, 0), Is.EqualTo(0));
    }
}