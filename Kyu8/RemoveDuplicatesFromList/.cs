using System.Linq;

namespace Kyu8.RemoveDuplicatesFromList;

public static class Program
{
    public static int[] distinct(int[] a)
    {
        return a.Distinct().ToArray();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(Program.distinct(new int[] { 1 }), Is.EqualTo(new int[] { 1 }));
        Assert.That(Program.distinct(new int[] { 1, 2 }), Is.EqualTo(new int[] { 1, 2 }));
        Assert.That(Program.distinct(new int[] { 1, 1, 2 }), Is.EqualTo(new int[] { 1, 2 }));
    }
}