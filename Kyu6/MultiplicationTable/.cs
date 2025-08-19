namespace Kyu6.MultiplicationTable;


class Solution
{
    public static int[,] MultiplicationTable(int size)
    {
        int[,] arr = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                arr[i, j] = (i + 1) * (j + 1);
            }
        }

        return arr;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        int[,] expected = new int[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };
        Assert.That(Solution.MultiplicationTable(3), Is.EqualTo(expected));
    }
}