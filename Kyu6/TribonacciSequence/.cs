using System;
using System.Linq;

namespace Kyu6.TribonacciSequence;

public class Xbonacci
{
    public double[] Tribonacci(double[] signature, int n)
    {
        if (signature == null || signature.Length < 3) return null;
        if (n == 0) return new double[0];
        if (n < 3) return signature.Take(n).ToArray();

        double[] arr = new double[n];
        Array.Copy(signature, arr, 3);

        for (int i = 3; i < n; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
        }

        return arr;
    }
}


[TestFixture]
public class XbonacciTest
{
    private Xbonacci variabonacci;

    [SetUp]
    public void SetUp()
    {
        variabonacci = new Xbonacci();
    }

    [TearDown]
    public void TearDown()
    {
        variabonacci = null;
    }

    [Test]
    public void Tests()
    {
        Assert.That(variabonacci.Tribonacci(new double[] { 1, 1, 1 }, 10), Is.EqualTo(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }));
        Assert.That(variabonacci.Tribonacci(new double[] { 0, 0, 1 }, 10), Is.EqualTo(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }));
        Assert.That(variabonacci.Tribonacci(new double[] { 0, 1, 1 }, 10), Is.EqualTo(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }));
    }
}