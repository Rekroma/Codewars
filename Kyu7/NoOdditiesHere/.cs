using System.Linq;

namespace Kyu7.NoOdditiesHere;

public class NoOddities
{
    public static int[] NoOdds(int[] values)
    {
        return values.Where(x => x % 2 == 0).ToArray();
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public void OneThroughFive()
    {
        Assert.That(NoOddities.NoOdds(new int[] { 1, 2, 3, 4, 5 }), Is.EqualTo(new int[] { 2, 4 }));
    }
}