namespace Kyu8.FindTheFirstNonConsecutiveNumber;

public class Kata
{
    public static object FirstNonConsecutive(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; ++i)
        {
            if (arr[i] + 1 != arr[i + 1])
            {
                return arr[i + 1];
            }
        }

        return null;
    }
}


[TestFixture]
public class Test
{
    [Test]
    [Order(1)]
    public void SampleTest()
    {
        Assert.That(Kata.FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8 }), Is.EqualTo(6));
    }

    [Test]
    [Order(2)]
    public void SequentialTest()
    {
        Assert.That(Kata.FirstNonConsecutive(new int[] { 1, 2, 3, 4 }), Is.EqualTo(null));
    }
}