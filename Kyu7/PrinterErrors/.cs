using System;
using System.Linq;

namespace Kyu7.PrinterErrors;

public class Printer
{
    public static string PrinterError(String s)
    {
        return $"{s.Length - s.Where(x => "abcdefghijklm".Contains(x)).Count()}/{s.Length}";
    }
}


[TestFixture]
public static class PrinterTests
{
    [Test]
    public static void test1()
    {
        string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
        Assert.That(Printer.PrinterError(s), Is.EqualTo("3/56"));
    }
}