using System;

namespace Kyu6.BuyingACar;

public class BuyCar
{
    public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth)
    {
        if (startPriceOld >= startPriceNew) return new[] { 0, startPriceOld - startPriceNew };

        int months = 0;
        double oldPrice = startPriceOld, newPrice = startPriceNew, savings = 0, loss = percentLossByMonth;

        while (oldPrice + savings < newPrice)
        {
            months++;
            if (months % 2 == 0) loss += 0.5;
            oldPrice *= 1 - loss / 100;
            newPrice *= 1 - loss / 100;
            savings += savingPerMonth;
        }

        return new[] { months, (int)Math.Round(oldPrice + savings - newPrice) };
    }
}


[TestFixture]
public class BuyCarTests
{

    [Test, Order(1)]
    public void Test1()
    {
        int[] r = new int[] { 6, 766 };
        Assert.That(BuyCar.nbMonths(2000, 8000, 1000, 1.5), Is.EqualTo(r));
    }

    [Test, Order(2)]
    public void Test2()
    {
        int[] r = new int[] { 0, 4000 };
        Assert.That(BuyCar.nbMonths(12000, 8000, 1000, 1.5), Is.EqualTo(r));
    }
}