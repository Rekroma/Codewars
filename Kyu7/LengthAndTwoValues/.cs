namespace Kyu7.LengthAndTwoValues;

public class Kata
{
    public static object[] Alternate(int n, object firstValue, object secondValue)
    {
        object[] obj = new object[n];

        for (int i = 0; i < n; i++)
        {
            obj[i] = i % 2 == 0 ? firstValue : secondValue;
        }

        return obj;
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTests()
    {
        Assertion(new object[] { true, false, true, false, true }, (5, true, false));
        Assertion(new object[] { "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red" }, (20, "blue", "red"));
        Assertion(new object[0], (0, "lemons", "apples"));
    }

    private void Assertion(object[] expected, (int, object, object) inputs)
    {
        object[] actual = Kata.Alternate(inputs.Item1, inputs.Item2, inputs.Item3);
        Assert.That(actual, Is.EqualTo(expected),
          $"\n  n = {inputs.Item1}" +
          $"\n  firstValue = {inputs.Item2}" +
          $"\n  secondValue = {inputs.Item3}\n" +
          $"\n  Expected = [{string.Join(", ", expected)}]" +
          $"\n  Actual = [{string.Join(", ", actual)}]\n"
        );
    }
}