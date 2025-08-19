namespace Kyu7.TwoFightersOneWinner;

public class Kata
{
    public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
    {
        Fighter attacker = (firstAttacker == fighter1.Name) ? fighter1 : fighter2;
        Fighter defender = (attacker == fighter1) ? fighter2 : fighter1;

        while (true)
        {
            defender.Health -= attacker.DamagePerAttack;
            if (defender.Health <= 0) return attacker.Name;
            (attacker, defender) = (defender, attacker);
        }
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.declareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Lew"), Is.EqualTo("Lew"));
        Assert.That(Kata.declareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Harry"), Is.EqualTo("Harry"));
        Assert.That(Kata.declareWinner(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harry"), Is.EqualTo("Harald"));
        Assert.That(Kata.declareWinner(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harald"), Is.EqualTo("Harald"));
        Assert.That(Kata.declareWinner(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Jerry"), Is.EqualTo("Harald"));
        Assert.That(Kata.declareWinner(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Harald"), Is.EqualTo("Harald"));
    }
}