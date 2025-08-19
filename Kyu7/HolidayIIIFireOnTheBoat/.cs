namespace Kyu7.HolidayIIIFireOnTheBoat;

public class Kata
{
    public static string FireFight(string s)
    {
        return s.Replace("Fire", "~~");
    }
}


[TestFixture]
public class KataTests
{
    [Test, Order(1)]
    public void BasicTests()
    {
        Assert.That(Kata.FireFight("Boat Rudder Mast Boat Hull Water Fire Boat Deck Hull Fire Propeller Deck Fire Deck Boat Mast"), Is.EqualTo("Boat Rudder Mast Boat Hull Water ~~ Boat Deck Hull ~~ Propeller Deck ~~ Deck Boat Mast"));
        Assert.That(Kata.FireFight("Mast Deck Engine Water Fire"), Is.EqualTo("Mast Deck Engine Water ~~"));
        Assert.That(Kata.FireFight("Fire Deck Engine Sail Deck Fire Fire Fire Rudder Fire Boat Fire Fire Captain"), Is.EqualTo("~~ Deck Engine Sail Deck ~~ ~~ ~~ Rudder ~~ Boat ~~ ~~ Captain"));
    }
}