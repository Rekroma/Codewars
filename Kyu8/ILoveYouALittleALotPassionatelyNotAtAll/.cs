namespace Kyu8.ILoveYouALittleALotPassionatelyNotAtAll;

public class Kata
{
    public static string HowMuchILoveYou(int nb_petals)
    {
        return new string[] { "I love you", "a little", "a lot", "passionately", "madly", "not at all" }[(nb_petals - 1) % 6];
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void SampleTests()
    {
        Assert.That(Kata.HowMuchILoveYou(7), Is.EqualTo("I love you"));
        Assert.That(Kata.HowMuchILoveYou(3), Is.EqualTo("a lot"));
        Assert.That(Kata.HowMuchILoveYou(6), Is.EqualTo("not at all"));
    }
}