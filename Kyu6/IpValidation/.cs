namespace Kyu6.IpValidation;

class Kata
{
    public static bool IsValidIp(string ipAddres)
    {
        string[] ip = ipAddres.Split('.');

        if (ip.Length != 4)
        {
            return false;
        }
        foreach (string item in ip)
        {
            if (item.Length > 1 && item[0] == '0' || item.Contains(' '))
            {
                return false;
            }
            if (!int.TryParse(item, out int num))
            {
                return false;
            }
            if (num < 0 || num > 255)
            {
                return false;
            }
        }

        return true;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void TestCases()
    {
        Assert.That(Kata.IsValidIp("0.0.0.0"), Is.EqualTo(true));
        Assert.That(Kata.IsValidIp("12.255.56.1"), Is.EqualTo(true));
        Assert.That(Kata.IsValidIp("137.255.156.100"), Is.EqualTo(true));

        Assert.That(Kata.IsValidIp(""), Is.EqualTo(false));
        Assert.That(Kata.IsValidIp("abc.def.ghi.jkl"), Is.EqualTo(false));
        Assert.That(Kata.IsValidIp("123.456.789.0"), Is.EqualTo(false));
        Assert.That(Kata.IsValidIp("12.34.56"), Is.EqualTo(false));
        Assert.That(Kata.IsValidIp("12.34.56.00"), Is.EqualTo(false));
        Assert.That(Kata.IsValidIp("12.34.56.7.8"), Is.EqualTo(false));
        Assert.That(Kata.IsValidIp("12.34.256.78"), Is.EqualTo(false));
        Assert.That(Kata.IsValidIp("1234.34.56"), Is.EqualTo(false));
        Assert.That(Kata.IsValidIp("pr12.34.56.78"), Is.EqualTo(false));
        Assert.That(Kata.IsValidIp("12.34.56.78sf"), Is.EqualTo(false));
        Assert.That(Kata.IsValidIp("12.34.56 .1"), Is.EqualTo(false));
        Assert.That(Kata.IsValidIp("12.34.56.-1"), Is.EqualTo(false));
        Assert.That(Kata.IsValidIp("123.045.067.089"), Is.EqualTo(false));
    }
}