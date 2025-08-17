using System;

namespace Kyu8.LocalizeTheBarycenterOfATriangle;

public class Barycenter
{
    public static double[] BarTriang(double[] x, double[] y, double[] z)
    {
        return new double[] { Math.Round((x[0] + y[0] + z[0]) / 3, 4), Math.Round((x[1] + y[1] + z[1]) / 3, 4) };
    }
}