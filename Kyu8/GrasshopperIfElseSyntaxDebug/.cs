namespace Kyu8.GrasshopperIfElseSyntaxDebug;

public class Player
{
    private int health = 100;
    public int Health
    {
        get
        {
            return this.health;
        }
        set
        {
            health = value;
        }
    }

    public Player()
    {

    }

    public bool CheckAlive()
    {
        return this.Health > 0;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Should return the proper result with fixed tests")]
    public void FixedTest()
    {
        Player greg = new Player();
        greg.Health = 5;
        Assert.That(greg.CheckAlive(), Is.True);

        Player joe = new Player();
        joe.Health = 0;
        Assert.That(joe.CheckAlive(), Is.False);
    }
}