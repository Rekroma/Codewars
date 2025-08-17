namespace Kyu8.GrasshopperTerminalGameOne;

public class Hero
{
    public string Name { get; set; }
    public string Position { get; set; }
    public float Health { get; set; }
    public float Damage { get; set; }
    public int Experience { get; set; }

    public Hero(string name = "Hero")
    {
        Name = name;
        Position = "00";
        Health = 100f;
        Damage = 5f;
        Experience = 0;
    }
}


[TestFixture]
public class Hero_Class
{
    [Test, Description("Hero should create a Hero")]
    [Order(1)]
    public void InitTest()
    {
        Hero myHero = new Hero();
        Assert.That(myHero.Name, Is.EqualTo("Hero"));
    }

    [Test, Description("Hero should have appropriate types for its properties")]
    [Order(2)]
    public void TypeTest()
    {
        Hero myHero = new Hero();
        Assert.That(myHero.Health, Is.TypeOf<float>());
    }
#pragma warning restore CS0183
}