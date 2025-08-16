namespace Kyu8.PriceOfMangoes;

public class Kata
{
    public static int Mango(int quantity, int price)
    {
        return quantity * price - (quantity / 3) * price;
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.Mango(3, 3), Is.EqualTo(6));
        Assert.That(Kata.Mango(9, 5), Is.EqualTo(30));
    }
}