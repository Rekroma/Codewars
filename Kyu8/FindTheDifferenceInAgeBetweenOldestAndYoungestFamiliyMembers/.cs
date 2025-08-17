using System.Linq;

namespace Kyu8.FindTheDifferenceInAgeBetweenOldestAndYoungestFamiliyMembers;

public class Kata
{
    public static int[] DifferenceInAges(int[] ages)
    {
        return new[] { ages.Min(), ages.Max(), ages.Max() - ages.Min() };
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("Should return expected results for sample tests")]
    public void SampleTest()
    {
        Assert.That(Kata.DifferenceInAges(new int[] { 82, 15, 6, 38, 35 }), Is.EqualTo(new int[] { 6, 82, 76 }));
        Assert.That(Kata.DifferenceInAges(new int[] { 57, 99, 14, 32 }), Is.EqualTo(new int[] { 14, 99, 85 }));
    }
}