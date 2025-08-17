namespace Kyu8.DoIGetABonus;

public static class Kata
{
    public static string bonus_time(int salary, bool bonus)
    {
        return bonus ? "$" + salary + "0" : "$" + salary;
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.bonus_time(10000, true), Is.EqualTo("$100000").IgnoreCase);
        Assert.That(Kata.bonus_time(25000, true), Is.EqualTo("$250000").IgnoreCase);
        Assert.That(Kata.bonus_time(10000, false), Is.EqualTo("$10000").IgnoreCase);
        Assert.That(Kata.bonus_time(60000, false), Is.EqualTo("$60000").IgnoreCase);
        Assert.That(Kata.bonus_time(2, true), Is.EqualTo("$20").IgnoreCase);
        Assert.That(Kata.bonus_time(78, false), Is.EqualTo("$78").IgnoreCase);
        Assert.That(Kata.bonus_time(67890, true), Is.EqualTo("$678900").IgnoreCase);
    }
}