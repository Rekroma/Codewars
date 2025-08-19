using System;

namespace Kyu7.PredictYourAge;

public class Predicter
{
    public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8)
    {
        return (int)Math.Sqrt(age1 * age1 + age2 * age2 + age3 * age3 + age4 * age4 + age5 * age5 + age6 * age6 + age7 * age7 + age8 * age8) / 2;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void FixedTest()
    {
        Assert.That(Predicter.PredictAge(65, 60, 75, 55, 60, 63, 64, 45), Is.EqualTo(86));
        Assert.That(Predicter.PredictAge(32, 54, 76, 65, 34, 63, 64, 45), Is.EqualTo(79));
    }
}