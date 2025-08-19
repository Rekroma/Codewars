using System;

namespace Kyu7.TheCouponCode;

public static class Kata
{
    public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
    {
        return enteredCode == correctCode && DateTime.Parse(currentDate) <= DateTime.Parse(expirationDate);
    }
}


[TestFixture]
public class CouponCodeTest
{
    [Test, Order(1)]
    public static void ValidCoupon()
    {
        Assert.That(Kata.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"), Is.True);
    }

    [Test, Order(2)]
    public static void InvalidCoupon()
    {
        Assert.That(Kata.CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"), Is.False);
    }
}
