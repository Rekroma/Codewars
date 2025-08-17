namespace Kyu8.HowManyLightsabersDoYouOwn;

public class Kata
{
    public static int HowManyLightsabersDoYouOwn(string name)
    {
        return name == "Zach" ? 18 : 0;
    }
}


[TestFixture]
public class Tests
{
    [Test, Order(1)]
    public static void Adam()
    {
        Assert.That(Kata.HowManyLightsabersDoYouOwn("Adam"), Is.EqualTo(0));
    }

    [Test, Order(2)]
    public static void Zach()
    {
        Assert.That(Kata.HowManyLightsabersDoYouOwn("Zach"), Is.EqualTo(18));
    }
}