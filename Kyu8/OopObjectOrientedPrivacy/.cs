namespace Kyu8.OopObjectOrientedPiracy;

public class Ship
{
    public int Draft;
    public int Crew;

    public Ship(int draft, int crew)
    {
        Draft = draft;
        Crew = crew;
    }

    public bool IsWorthIt()
    {
        double crewWeight = Crew * 1.5;
        double effectiveDraft = Draft - crewWeight;
        return effectiveDraft > 20;
    }
}


[TestFixture]
public class Sample_Test
{
    [Test, Order(1)]
    public void SampleTests()
    {
        Assert.That(new Ship(15, 10).IsWorthIt(), Is.EqualTo(false));
        Assert.That(new Ship(15, 20).IsWorthIt(), Is.EqualTo(false));
        Assert.That(new Ship(100, 20).IsWorthIt(), Is.EqualTo(true));
        Assert.That(new Ship(35, 20).IsWorthIt(), Is.EqualTo(false));
    }

    [Test, Order(2)]
    public void MutationTest()
    {
        Ship titanic = new Ship(15, 10);
        titanic.IsWorthIt();
        // Mutation tests
        Assert.That(titanic.Draft, Is.EqualTo(15), "Do you need two eyepatches, mate? That ship is clearly 15 draft deep.");
        Assert.That(titanic.Crew, Is.EqualTo(10), "Do you need two eyepatches, mate? That ship clearly has a crew of 10 people.");
    }
}