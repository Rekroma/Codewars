namespace Kyu8.NeverVisitA;

public class Kata
{
    public static string SubtractSum(int number)
    {
        return "apple";
    }
}


[TestFixture]
public class TestTemplate
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(Kata.SubtractSum(11), Is.EqualTo("apple").IgnoreCase);
    }
}