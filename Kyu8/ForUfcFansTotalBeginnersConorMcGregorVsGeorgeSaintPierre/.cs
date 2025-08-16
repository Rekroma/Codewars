
namespace ForUfcFansTotalBeginnersConorMcGregorVsGeorgeSaintPierre;

public static class Kata
{
    public static string Quote(string fighter)
    {
        return fighter.ToLower() == "george saint pierre" ? "I am not impressed by your performance." : "I'd like to take this chance to apologize.. To absolutely NOBODY!";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Quote("george saint pierre"), Is.EqualTo("I am not impressed by your performance."));
        Assert.That(Kata.Quote("conor mcgregor"), Is.EqualTo("I'd like to take this chance to apologize.. To absolutely NOBODY!"));
        Assert.That(Kata.Quote("George Saint Pierre"), Is.EqualTo("I am not impressed by your performance."));
        Assert.That(Kata.Quote("Conor McGregor"), Is.EqualTo("I'd like to take this chance to apologize.. To absolutely NOBODY!"));
    }
}