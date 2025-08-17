using System.Linq;

namespace Kyu8.CalculateAverage;

class AverageSolution
{
    public static double FindAverage(double[] array)
    {
        return array.Length == 0 ? 0 : array.Average();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTests()
    {
        DoTest(new double[] { 1, 2, 3 }, 2.0);
        DoTest(new double[] { 5, 5, 5, 5 }, 5.0);
        DoTest(new double[] { 2, 3, 6, 7, 1 }, 3.8);
    }

    private static void DoTest(double[] input, double expected)
    {
        String message = String.Format("for array = [{0}]\n", String.Join(", ", input));
        double actual = AverageSolution.FindAverage(input);
        Assert.That(actual, Is.EqualTo(expected).Within(1e-3), message);
    }
}