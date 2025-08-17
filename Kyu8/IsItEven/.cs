namespace Kyu8.IsItEven;

public class Number
{
    public bool IsEven(double n)
    {
        return n % 2 == 0;
    }
}


[TestFixture]
public class NumberTest
{
    private Number num;

    [SetUp]
    public void SetUp()
    {
        num = new Number();
    }

    [TearDown]
    public void TearDown()
    {
        num = null;
    }

    [Test]
    public void Tests()
    {
        Assert.That(num.IsEven(0), Is.EqualTo(true));
        Assert.That(num.IsEven(0.5), Is.EqualTo(false));
        Assert.That(num.IsEven(1), Is.EqualTo(false));
        Assert.That(num.IsEven(2), Is.EqualTo(true));
        Assert.That(num.IsEven(-4), Is.EqualTo(true));
    }
}