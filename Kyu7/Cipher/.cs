using System;
using System.Linq;

namespace Kyu7.Cipher;

public static class Kata
{
    public static string Encode(string str)
    {
        return string.Join("", str.Select(c => (char)(Convert.ToInt32(c) * 6)));
    }

    public static string Decode(string str)
    {
        return string.Join("", str.Select(c => (char)(Convert.ToInt32(c) / 6)));
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Encode("Hello World!"), Is.EqualTo("ưɞʈʈʚÀȊʚʬʈɘÆ"));
        Assert.That(Kata.Decode("ưɞʈʈʚÀȊʚʬʈɘÆ"), Is.EqualTo("Hello World!"));
    }
}