namespace Kyu8.AreYouPlayingBanjo;

public class Kata
{
    public static string AreYouPlayingBanjo(string name)
    {
        return name.ToLower()[0] == 'r' ? $"{name} plays banjo" : $"{name} does not play banjo";
    }
}


[TestFixture]
public class AreYouPlayingBanjo
{
    [Test, Order(1)]
    public static void Martin()
    {
        var expected = "Martin does not play banjo";
        Assert.That(Kata.AreYouPlayingBanjo("Martin"), Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public static void Rikke()
    {
        var expected = "Rikke plays banjo";
        Assert.That(Kata.AreYouPlayingBanjo("Rikke"), Is.EqualTo(expected));
    }

    [Test, Order(3)]
    public static void bravo()
    {
        var expected = "bravo does not play banjo";
        Assert.That(Kata.AreYouPlayingBanjo("bravo"), Is.EqualTo(expected));
    }

    [Test, Order(4)]
    public static void rolf()
    {
        var expected = "rolf plays banjo";
        Assert.That(Kata.AreYouPlayingBanjo("rolf"), Is.EqualTo(expected));
    }
}