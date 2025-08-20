using System.Linq;

namespace Kyu7.ConvertAnArrayOfStringsToArrayOfNumbers;

public class stringArrayMethods
{
    public static double[] ToDoubleArray(string[] stringArray)
    {
        return stringArray.Select(double.Parse).ToArray();
    }
}


[TestFixture]
public class stringArrayMethodsTest
{
    [Test]
    public void ExampleTest()
    {
        Console.WriteLine("Running ToDoubleArray(\"1.1\",\"2.2\",\"3.3\")...");
        Assert.That(stringArrayMethods.ToDoubleArray(new string[] { "1.1", "2.2", "3.3" }), Is.EqualTo(new double[] { 1.1, 2.2, 3.3 }));

    }
}