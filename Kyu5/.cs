namespace Kyu5.MoveZeroes;

public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        int[] res = new int[arr.Length];
        int zeroIndex = res.Length - 1;
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                res[zeroIndex] = 0;
                zeroIndex--;
            }
            else
            {
                res[index] = arr[i];
                index++;
            }
        }

        return res;
    }
}


[TestFixture]
public class Sample_Test
{
    [Test]
    [Order(1)]
    public void Test()
    {
        int[] expected = new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 };
        Assert.That(Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }), Is.EqualTo(expected));
    }
}