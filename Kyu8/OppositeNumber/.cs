namespace Kyu8.OppositeNumber;

public class Kata
{
    public static int Opposite(int number)
    {
        return -number;
    }
}


[TestFixture]
public class MyTest
{
    [Test]
    public void Test_1()
    {
        Assert.That(Kata.Opposite(1), Is.EqualTo(-1), "Incorrect answer for number=1");
    }
}