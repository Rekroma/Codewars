namespace Kyu7.Fibonacci;

public class Fibonacci
{
    public static int Fib(int n)
    {
        if (n == 1 || n == 2) return 1;
        int[] arr = new int[n];
        arr[0] = 1;
        arr[1] = 1;

        for (int i = 2; i < n; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }

        return arr[n - 1];
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        Assert.That(Fibonacci.Fib(5), Is.EqualTo(5));
        Assert.That(Fibonacci.Fib(10), Is.EqualTo(55));
    }
}