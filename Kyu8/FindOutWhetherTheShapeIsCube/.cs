using System;

namespace Kyu8.FindOutWhetherTheShapeIsCube;

public class CubeChecker
{
    public bool IsCube(double volume, double side)
    {
        return volume > 0 && side > 0 && Math.Pow(side, 3) == volume;
    }
}


[TestFixture]
public class CubeTests
{
    [Test, Order(1)]
    public void ShouldReturnFalse()
    {
        CubeChecker cube = new CubeChecker();
        Assert.That(cube.IsCube(1, 1), Is.EqualTo(true));
        Assert.That(cube.IsCube(8, 2), Is.EqualTo(true));
    }

    [Test, Order(2)]
    public void ShouldReturnTrue()
    {
        CubeChecker cube = new CubeChecker();
        Assert.That(cube.IsCube(2, 1), Is.EqualTo(false));
        Assert.That(cube.IsCube(6, 3), Is.EqualTo(false));
        Assert.That(cube.IsCube(-8, -2), Is.EqualTo(false));
        Assert.That(cube.IsCube(0, 0), Is.EqualTo(false));
        Assert.That(cube.IsCube(200, 4), Is.EqualTo(false));
    }
}
