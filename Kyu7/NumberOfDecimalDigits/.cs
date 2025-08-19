
namespace Kyu7.NumberOfDecimalDigits;

public class DecTools
{
    public static int Digits(ulong n)
    {
        return n.ToString().Length;
    }
}

[TestFixture]
public class SampleTests
{
    [Test]
    public void Digits()
    {
        Assert.That(DecTools.Digits(5ul), Is.EqualTo(1));
        Assert.That(DecTools.Digits(12345ul), Is.EqualTo(5));
        Assert.That(DecTools.Digits(9876543210ul), Is.EqualTo(10));
    }
}