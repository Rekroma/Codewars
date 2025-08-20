using System;

namespace Kyu7.FormattingDecimalPlacesOne;

public class Numbers
{
    public static double TwoDecimalPlaces(double number)
    {
        return Math.Truncate(number * 100) / 100;
    }
}