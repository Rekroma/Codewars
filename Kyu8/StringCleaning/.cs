using System.Text.RegularExpressions;

namespace Kyu8.StringCleaning;

public class Kata
{
    public static string StringClean(string s)
    {
        return Regex.Replace(s, @"\d", "");
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.StringClean(""), Is.EqualTo(""));
        Assert.That(Kata.StringClean("! !"), Is.EqualTo("! !"));
        Assert.That(Kata.StringClean("1234567890"), Is.EqualTo(""));
        Assert.That(Kata.StringClean("Dsa32 cdsc34232 csa!!! 1I 4Am cool!"), Is.EqualTo("Dsa cdsc csa!!! I Am cool!"));
        Assert.That(Kata.StringClean("A1 A1! AAA   3J4K5L@!!!"), Is.EqualTo("A A! AAA   JKL@!!!"));
        Assert.That(Kata.StringClean("Adgre2321 A1sad! A2A3A4 fv3fdv3J544K5L@"), Is.EqualTo("Adgre Asad! AAA fvfdvJKL@"));
        Assert.That(Kata.StringClean("Ad2dsad3ds21 A  1$$s122ad! A2A3Ae24 f44K5L@222222 "), Is.EqualTo("Addsadds A  $$sad! AAAe fKL@ "));
        Assert.That(Kata.StringClean("33333Ad2dsad3ds21 A3333  1$$s122a!d! A2!A!3Ae$24 f2##222 "), Is.EqualTo("Addsadds A  $$sa!d! A!A!Ae$ f## "));
        Assert.That(Kata.StringClean("My \"me3ssy\" d8ata issues2! Will1 th4ey ever, e3ver be3 so0lved?"), Is.EqualTo("My \"messy\" data issues! Will they ever, ever be solved?"));
        Assert.That(Kata.StringClean("Wh7y can't we3 bu1y the goo0d software3? #cheapskates3"), Is.EqualTo("Why can't we buy the good software? #cheapskates"));
    }
}