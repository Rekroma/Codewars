using System.Linq;

namespace Kyu8.TotalAmountOfPoints;

public static class Kata
{
    public static int TotalPoints(string[] games)
    {
        return games.Sum(s => s[0] < s[2] ? 0 : s[0] == s[2] ? 1 : 3);
    }
}


[TestFixture]
public class SolutionTest
{

    [Test, Order(1)]
    public void Test1() =>
        Test(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }, 30);

    [Test, Order(2)]
    public void Test2() =>
        Test(new[] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" }, 10);

    [Test, Order(3)]
    public void Test3() =>
        Test(new[] { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4" }, 0);

    [Test, Order(4)]
    public void Test4() =>
        Test(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4" }, 15);

    [Test, Order(5)]
    public void Test5() =>
        Test(new[] { "1:0", "2:0", "3:0", "4:4", "2:2", "3:3", "1:4", "2:3", "2:4", "3:4" }, 12);

    private void Test(string[] input, int expectedOutput) =>
        Assert.That(Kata.TotalPoints(input), Is.EqualTo(expectedOutput));

}