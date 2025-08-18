using System.Linq;

namespace Kyu7.FindTheStrayNumber;

class Solution
{
    public static int Stray(int[] numbers)
    {
        return numbers.GroupBy(x => x).OrderBy(x => x.Count()).First().Key;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SimpleArray1()
    {
        Assert.That(Solution.Stray(new int[] { 1, 1, 2 }), Is.EqualTo(2));
    }
}