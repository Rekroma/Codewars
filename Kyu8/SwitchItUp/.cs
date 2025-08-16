namespace Kyu8.SwitchItUp;

public class Kata
{
    public static string SwitchItUp(int number)
    {
        switch (number)
        {
            default: return "Zero";
            case 1: return "One";
            case 2: return "Two";
            case 3: return "Three";
            case 4: return "Four";
            case 5: return "Five";
            case 6: return "Six";
            case 7: return "Seven";
            case 8: return "Eight";
            case 9: return "Nine";
        }
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Kata.SwitchItUp(1), Is.EqualTo("One"));
        Assert.That(Kata.SwitchItUp(3), Is.EqualTo("Three"));
        Assert.That(Kata.SwitchItUp(5), Is.EqualTo("Five"));
    }
}