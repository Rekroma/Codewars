namespace Kyu8.LOneBartenderDrinks;

public class Kata
{
    public static string GetDrinkByProfession(string p)
    {
        switch (p.ToLower())
        {
            case "jabroni": return "Patron Tequila";
            case "school counselor": return "Anything with Alcohol";
            case "programmer": return "Hipster Craft Beer";
            case "bike gang member": return "Moonshine";
            case "politician": return "Your tax dollars";
            case "rapper": return "Cristal";
            default: return "Beer";
        }
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.GetDrinkByProfession("jabrOni"), Is.EqualTo("Patron Tequila"), "'Jabroni' should map to 'Patron Tequila'");
        Assert.That(Kata.GetDrinkByProfession("scHOOl counselor"), Is.EqualTo("Anything with Alcohol"), "'School Counselor' should map to 'Anything with alcohol'");
        Assert.That(Kata.GetDrinkByProfession("prOgramMer"), Is.EqualTo("Hipster Craft Beer"), "'Programmer' should map to 'Hipster Craft Beer'");
        Assert.That(Kata.GetDrinkByProfession("bike ganG member"), Is.EqualTo("Moonshine"), "'Bike Gang Member' should map to 'Moonshine'");
        Assert.That(Kata.GetDrinkByProfession("poLiTiCian"), Is.EqualTo("Your tax dollars"), "'Politician' should map to 'Your tax dollars'");
        Assert.That(Kata.GetDrinkByProfession("rapper"), Is.EqualTo("Cristal"), "'Rapper' should map to 'Cristal'");
        Assert.That(Kata.GetDrinkByProfession("pundit"), Is.EqualTo("Beer"), "'Pundit' should map to 'Beer'");
        Assert.That(Kata.GetDrinkByProfession("Pug"), Is.EqualTo("Beer"), "'Pug' should map to 'Beer'");
    }
}