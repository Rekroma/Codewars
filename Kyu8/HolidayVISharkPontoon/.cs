namespace Kyu8.HolidayVISharkPontoon;

public class Kata
{
    public static string Shark(
      int pontoonDistance,
      int sharkDistance,
      int youSpeed,
      int sharkSpeed,
      bool dolphin)
    {
        return (pontoonDistance / (dolphin ? youSpeed * 2 : youSpeed)) < (sharkDistance / (dolphin ? sharkSpeed / 2.0 : sharkSpeed)) ? "Alive!" : "Shark Bait!";
    }
}


[TestFixture]
public class BasicTests
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.Shark(12, 50, 4, 8, true), Is.EqualTo("Alive!"));
        Assert.That(Kata.Shark(12, 50, 4, 8, false), Is.EqualTo("Alive!"));
        Assert.That(Kata.Shark(7, 55, 4, 16, true), Is.EqualTo("Alive!"));
        Assert.That(Kata.Shark(24, 0, 4, 8, true), Is.EqualTo("Shark Bait!"));
        Assert.That(Kata.Shark(40, 35, 3, 20, true), Is.EqualTo("Shark Bait!"));
        Assert.That(Kata.Shark(7, 8, 3, 4, true), Is.EqualTo("Alive!"));
        Assert.That(Kata.Shark(7, 8, 3, 4, false), Is.EqualTo("Shark Bait!"));
    }
}