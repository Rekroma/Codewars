using System.Linq;

namespace Kyu7.ResponsibleDrinking;

public class Drinkin
{
    public string hydrate(string drinkString)
    {
        int water = (int)drinkString.Where(char.IsDigit).Select(c => char.GetNumericValue(c)).Sum();

        return $"{water} glass{(water > 1 ? "es" : "")} of water";
    }
}


[TestFixture]
public class DrinkinTest
{

    [Test, Order(1)]
    public void drinkinTest1()
    {
        Drinkin drinkin = new Drinkin();
        string expected = "1 glass of water";
        string actual = drinkin.hydrate("1 beer");
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test, Order(2)]
    public void drinkinTest3()
    {
        Drinkin drinkin = new Drinkin();
        string expected = "10 glasses of water";
        string actual = drinkin.hydrate("1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer");
        Assert.That(actual, Is.EqualTo(expected));
    }

}