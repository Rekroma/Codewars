using System;
using System.Linq;

namespace Kyu6.IpvFourToIntThreeTwo;

public class IPConvert
{
    public static uint ToInt32(string ip)
    {
        byte[] bytes = ip.Split('.').Select(byte.Parse).ToArray();

        return ((uint)bytes[0] << 24) | ((uint)bytes[1] << 16) | ((uint)bytes[2] << 8) | bytes[3];
    }
}


[TestFixture]
public class IPConverterTest
{
    [Test]
    public void TestIPtoInt()
    {
        Assert.That(IPConvert.ToInt32("128.32.10.1"), Is.EqualTo(2149583361), "Incorrect answer for ip = \"128.32.10.1\"");
    }
}
