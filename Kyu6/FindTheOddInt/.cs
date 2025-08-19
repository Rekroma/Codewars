using System.Linq;

namespace Kyu6.FindTheOddInt;

class Kata
{
    public static int find_it(int[] seq)
    {
        return seq.Aggregate((res, num) => res ^ num);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Order(1)]
    public void Tests()
    {
        Assert.That(Kata.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }), Is.EqualTo(5));
    }
}