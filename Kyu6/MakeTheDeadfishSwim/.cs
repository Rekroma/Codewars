using System;
using System.Collections.Generic;

namespace Kyu6.MakeTheDeadfishSwim;

public class Deadfish
{
    public static int[] Parse(string data)
    {
        List<int> result = new List<int>();
        int value = 0;

        for (int i = 0; i < data.Length; i++)
        {
            switch (data[i])
            {
                case 'i':
                    value++;
                    break;
                case 'd':
                    value--;
                    break;
                case 's':
                    value = (int)Math.Pow(value, 2);
                    break;
                case 'o':
                    result.Add(value);
                    break;
                default:
                    break;
            }
        }

        return result.ToArray();
    }
}


[TestFixture]
public class SolutionTest
{
    private static object[] sampleTestCases = new object[]
    {
      new object[] {"iiisdoso", new int[] {8, 64}},
      new object[] {"iiisdosodddddiso", new int[] {8, 64, 3600}},
    };

    [Test, TestCaseSource("sampleTestCases")]
    public void SampleTest(string data, int[] expected)
    {
        Assert.That(Deadfish.Parse(data), Is.EqualTo(expected));
    }
}