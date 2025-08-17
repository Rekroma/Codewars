namespace Kyu8.KeepUpTheHoop;

public class Kata
{
    public static string HoopCount(int n)
    {
        return n >= 10 ? "Great, now move on to tricks" : "Keep at it until you get it";
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public static void FixedTest()
    {
        Assert.That(Kata.HoopCount(6), Is.EqualTo("Keep at it until you get it"), "Should work for 6");
        Assert.That(Kata.HoopCount(22), Is.EqualTo("Great, now move on to tricks"), "Should work for 22");
    }
}