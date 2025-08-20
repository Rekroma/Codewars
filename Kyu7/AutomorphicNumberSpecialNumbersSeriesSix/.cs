namespace Kyu7.AutomorphicNumberSpecialNumbersSeriesSix;

using System;

class Kata
{
    public static string Automorphic(int n)
    {
        return Math.Pow(n, 2).ToString().EndsWith(n.ToString()) ? "Automorphic" : "Not!!";
    }
}


[TestFixture]
class Tests
{
    [TestCase(1, "Automorphic")]
    [TestCase(3, "Not!!")]
    [TestCase(6, "Automorphic")]
    [TestCase(9, "Not!!")]
    [TestCase(25, "Automorphic")]
    [TestCase(53, "Not!!")]
    [TestCase(76, "Automorphic")]
    [TestCase(95, "Not!!")]
    [TestCase(625, "Automorphic")]
    [TestCase(225, "Not!!")]
    [TestCase(100, "Not!!")]
    public void BasicTests(int n, string expected)
    {
        Assert.That(Kata.Automorphic(n), Is.EqualTo(expected));
    }
}