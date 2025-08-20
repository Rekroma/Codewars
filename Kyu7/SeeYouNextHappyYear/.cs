namespace Kyu7.SeeYouNextHappyYear;

public class Kata
{
    public short NextHappyYear(short year)
    {
        string yearstr = (year += 1).ToString();

        while (yearstr[0] == yearstr[1] || yearstr[1] == yearstr[2] || yearstr[2] == yearstr[3] ||
               yearstr[0] == yearstr[2] || yearstr[1] == yearstr[3] || yearstr[0] == yearstr[3])
        {
            year++;
            yearstr = year.ToString();
        }

        return year;
    }
}


[TestFixture]
public class SolutionTest
{
    Kata kata = new Kata();

    [Test, Order(1)]
    public void BasicValues()
    {
        Assert.That(kata.NextHappyYear(1001), Is.EqualTo(1023));
        Assert.That(kata.NextHappyYear(1123), Is.EqualTo(1203));
        Assert.That(kata.NextHappyYear(2001), Is.EqualTo(2013));
        Assert.That(kata.NextHappyYear(2334), Is.EqualTo(2340));
        Assert.That(kata.NextHappyYear(3331), Is.EqualTo(3401));
        Assert.That(kata.NextHappyYear(2342), Is.EqualTo(2345));
        Assert.That(kata.NextHappyYear(1987), Is.EqualTo(2013));
        Assert.That(kata.NextHappyYear(2013), Is.EqualTo(2014));
        Assert.That(kata.NextHappyYear(3000), Is.EqualTo(3012));
    }

    [Test, Order(2)]
    public void LargeValues()
    {
        Assert.That(kata.NextHappyYear(5555), Is.EqualTo(5601));
        Assert.That(kata.NextHappyYear(7712), Is.EqualTo(7801));
        Assert.That(kata.NextHappyYear(8088), Is.EqualTo(8091));
        Assert.That(kata.NextHappyYear(8800), Is.EqualTo(8901));
        Assert.That(kata.NextHappyYear(8989), Is.EqualTo(9012));
        Assert.That(kata.NextHappyYear(8977), Is.EqualTo(9012));
        Assert.That(kata.NextHappyYear(6869), Is.EqualTo(6870));
        Assert.That(kata.NextHappyYear(8999), Is.EqualTo(9012));
    }
}