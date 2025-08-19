namespace Kyu6.EqualSidesOfAnArray;

public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            rightSum += arr[i];
        }
        for (int i = 0; i < arr.Length; i++)
        {
            rightSum -= arr[i];

            if (leftSum == rightSum)
            {
                return i;
            }
            leftSum += arr[i];
        }

        return -1;
    }
}


[TestFixture]
public class ValidateWordTest
{
    [Test]
    public void GenericTests()
    {
        Assert.That(Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }), Is.EqualTo(3));
        Assert.That(Kata.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }), Is.EqualTo(1));
        Assert.That(Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }), Is.EqualTo(-1));
        Assert.That(Kata.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }), Is.EqualTo(3));
    }
}