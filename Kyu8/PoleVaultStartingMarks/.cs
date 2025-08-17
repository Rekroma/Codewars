using System;

namespace Kyu8.PoleVaultStartingMarks;

class PoleVault
{
    public static double StartingMark(double bodyHeight)
    {
        double height1 = 1.52;
        double mark1 = 9.45;
        double height2 = 1.83;
        double mark2 = 10.67;

        double slope = (mark2 - mark1) / (height2 - height1);
        double intercept = mark1 - slope * height1;
        double startingMark = slope * bodyHeight + intercept;

        return Math.Round(startingMark, 2);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(PoleVault.StartingMark(1.52), Is.EqualTo(9.45));
        Assert.That(PoleVault.StartingMark(1.83), Is.EqualTo(10.67));
        Assert.That(PoleVault.StartingMark(1.22), Is.EqualTo(8.27));
        Assert.That(PoleVault.StartingMark(2.13), Is.EqualTo(11.85));
    }
}