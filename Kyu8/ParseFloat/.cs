using System;

namespace Kyu8.ParseFloat;

public class Kata
{
    public static double? ParseF(object s = null)
    {
        if (s == null)
        {
            return null;
        }
        if (s is string || s is float || s is decimal || s is int || s is long)
        {
            try
            {
                return Convert.ToDouble(s);
            }
            catch (FormatException)
            {
                return null;
            }
            catch (InvalidCastException)
            {
                return null;
            }
            catch (OverflowException)
            {
                return null;
            }
        }
        return null;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.ParseF("1"), Is.EqualTo(1.0d));
    }
}