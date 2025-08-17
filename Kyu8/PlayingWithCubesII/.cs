using System;

namespace Kyu8.PlayingWithCubesII;

public class Cube
{
    private int Side;

    public Cube(int side)
    {
        Side = Math.Abs(side);
    }

    public Cube()
    {
        Side = 0;
    }

    public int GetSide()
    {
        return this.Side;
    }

    public void SetSide(int s)
    {
        this.Side = Math.Abs(s);
    }
}


[TestFixture]
public class Test
{
    [Test]
    public static void TestConstructor()
    {
        Cube c = new Cube(10);
        Assert.That(c.GetSide(), Is.EqualTo(10), "Should be 10");
    }
}