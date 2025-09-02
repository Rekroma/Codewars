using System;

namespace Kyu8.ColorGhost;

public class Ghost
{
    private readonly string[] Colors = { "white", "yellow", "purple", "red" };
    public string GetColor() { return Colors[new Random().Next(0, 4)]; }
}


[TestFixture]
public class GhostTests
{

    [Test]
    public void ShouldSometimesMakeWhiteGhosts()
    {
        Assert.Pass("Create your own tests here");
    }

}
