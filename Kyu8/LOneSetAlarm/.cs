namespace Kyu8.LOneSetAlarm;

public class Kata
{
    public static bool SetAlarm(bool employed, bool vacation)
    {
        return vacation != true && employed == true;
    }
}


[TestFixture]
public class SetAlarmTest
{
    [Test]
    public void Tests()
    {
        Assert.That(Kata.SetAlarm(true, true), Is.False);
        Assert.That(Kata.SetAlarm(false, true), Is.False);
        Assert.That(Kata.SetAlarm(true, false), Is.True);
        Assert.That(Kata.SetAlarm(false, false), Is.False);
    }
}