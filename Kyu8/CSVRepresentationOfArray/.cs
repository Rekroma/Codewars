using System.Text;

namespace Kyu8.CsvRepresentationOfArray;

public static class Kata
{
    public static string ToCsvText(int[][] array)
    {
        StringBuilder csv = new StringBuilder();

        for (int i = 0; i < array.Length; i++)
        {
            csv.Append(string.Join(",", array[i]));

            if (i < array.Length - 1)
            {
                csv.Append("\n");
            }
        }

        return csv.ToString();
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.ToCsvText(new[]
        {
            new[] {0, 1, 2, 3, 45},
            new[] {10, 11, 12, 13, 14},
            new[] {20, 21, 22, 23, 24},
            new[] {30, 31, 32, 33, 34}
        }), Is.EqualTo("0,1,2,3,45\n10,11,12,13,14\n20,21,22,23,24\n30,31,32,33,34"));

        Assert.That(Kata.ToCsvText(new[]
        {
            new[] {-25, 21, 2, -33, 48},
            new[] {30, 31, -32, 33, -34}
        }), Is.EqualTo("-25,21,2,-33,48\n30,31,-32,33,-34"));

        Assert.That(Kata.ToCsvText(new[]
        {
            new[] {5, 55, 5, 5, 55},
            new[] {6, 6, 66, 23, 24},
            new[] {666, 31, 66, 33, 7}
        }), Is.EqualTo("5,55,5,5,55\n6,6,66,23,24\n666,31,66,33,7"));
    }
}