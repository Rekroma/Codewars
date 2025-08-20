namespace Kyu6.SimpleFunOneSixNinePressButton;

public class Kata
{
    public long PressButton(long n)
    {
        return n * (n * n + 5) / 6;
    }
}


[TestFixture]
public class myjinxin
{
    [Test]
    public void BasicTests()
    {
        var kata = new Kata();

        Assert.That(kata.PressButton(1), Is.EqualTo(1));
        Assert.That(kata.PressButton(3), Is.EqualTo(7));
        Assert.That(kata.PressButton(4), Is.EqualTo(14));
        Assert.That(kata.PressButton(10), Is.EqualTo(175));
        Assert.That(kata.PressButton(2000), Is.EqualTo(1333335000));
    }
}