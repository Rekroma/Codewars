using System;

namespace Kyu6.SimpleFunOneFourZeroCircleSlash;

public class Kata
{
    public int CircleSlash(int n)
    {
        return 2 * (n - (int)Math.Pow(2, Math.Floor(Math.Log(n, 2)))) + 1;
    }
}


[TestFixture]
[Order(1)]
public class myjinxin
{

    [Test]
    [Order(1)]
    public void BasicTests()
    {
        var kata = new Kata();

        Assert.That(kata.CircleSlash(5), Is.EqualTo(3));

        Assert.That(kata.CircleSlash(11), Is.EqualTo(7));

        Assert.That(kata.CircleSlash(1), Is.EqualTo(1));

        Assert.That(kata.CircleSlash(2), Is.EqualTo(1));

        Assert.That(kata.CircleSlash(3), Is.EqualTo(3));

        Assert.That(kata.CircleSlash(4), Is.EqualTo(1));

        Assert.That(kata.CircleSlash(8), Is.EqualTo(1));

        Assert.That(kata.CircleSlash(16), Is.EqualTo(1));

        Assert.That(kata.CircleSlash(15), Is.EqualTo(15));

        Assert.That(kata.CircleSlash(31), Is.EqualTo(31));

    }

}