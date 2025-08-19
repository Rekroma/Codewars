namespace Kyu7.HiddenWorld;

public class Kata
{
    public string hidden(int num)
    {
        string key = "oblietadnm";
        string str = "";

        foreach (char c in num.ToString())
        {
            str += key[c - '0'];
        }

        return str;
    }
}


[TestFixture]
class KataTestClass
{
    [TestCase, Order(1)]
    public void BasicTest1()
    {
        Kata kata = new Kata();
        Assert.That(kata.hidden(637), Is.EqualTo("aid"));
    }

    [TestCase, Order(2)]
    public void BasicTest2()
    {
        Kata kata = new Kata();
        Assert.That(kata.hidden(7415), Is.EqualTo("debt"));
    }

    [TestCase, Order(3)]
    public void BasicTest3()
    {
        Kata kata = new Kata();
        Assert.That(kata.hidden(49632), Is.EqualTo("email"));
    }

    [TestCase, Order(4)]
    public void BasicTest4()
    {
        Kata kata = new Kata();
        Assert.That(kata.hidden(942547), Is.EqualTo("melted"));
    }
}