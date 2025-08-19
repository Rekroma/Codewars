namespace Kyu7.SumOfMinimums;

class Kata
{
    public static int SumOfMinimums(int[,] numbers)
    {
        int rowCount = numbers.GetLength(0);
        int colCount = numbers.GetLength(1);
        int sum = 0;

        for (int i = 0; i < rowCount; i++)
        {
            int minValue = int.MaxValue;

            for (int j = 0; j < colCount; j++)
            {
                if (numbers[i, j] < minValue)
                {
                    minValue = numbers[i, j];
                }
            }
            sum += minValue;
        }

        return sum;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(Kata.SumOfMinimums(new int[3, 5] { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 20, 21, 34, 56, 100 } }), Is.EqualTo(26));
        Assert.That(Kata.SumOfMinimums(new int[3, 5] { { 7, 9, 8, 6, 2 }, { 6, 3, 5, 4, 3 }, { 5, 8, 7, 4, 5 } }), Is.EqualTo(9));
        Assert.That(Kata.SumOfMinimums(new int[4, 4] { { 11, 12, 14, 54 }, { 67, 89, 90, 56 }, { 7, 9, 4, 3 }, { 9, 8, 6, 7 } }), Is.EqualTo(76));
    }
}