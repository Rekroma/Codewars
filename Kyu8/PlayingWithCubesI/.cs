namespace Kyu8.PlayingWithCubesI;

public class Cube
{
    private int Side = 0;

    public int GetSide()
    {
        return Side;
    }

    public void SetSide(int num)
    {
        Side = num;
    }
}


[TestFixture]
public class Test
{
    [Test]
    public static void FixedTest()
    {
        Cube c = new Cube();
        Assert.That(c.GetSide(), Is.EqualTo(0), "when not set before, Side should be 0");
        c.SetSide(5);
        Assert.That(c.GetSide(), Is.EqualTo(5), "Should return 5");
    }
}