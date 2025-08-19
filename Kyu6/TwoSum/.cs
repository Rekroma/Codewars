namespace Kyu6.TwoSum;

public class Kata
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        int[] res = new int[2];

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    res[0] = i;
                    res[1] = j;
                }
            }
        }

        return res;
    }
}


[TestFixture]
public class KataTests
{
    [Test]
    [Order(1)]
    public void BasicTests()
    {
        Assert.That(Kata.TwoSum(new[] { 1, 2, 3 }, 4), Is.EqualTo(new[] { 0, 2 }.OrderBy(a => a).ToArray()));
        Assert.That(Kata.TwoSum(new[] { 1234, 5678, 9012 }, 14690), Is.EqualTo(new[] { 1, 2 }.OrderBy(a => a).ToArray()));
        Assert.That(Kata.TwoSum(new[] { 2, 2, 3 }, 4), Is.EqualTo(new[] { 0, 1 }.OrderBy(a => a).ToArray()));
    }
}