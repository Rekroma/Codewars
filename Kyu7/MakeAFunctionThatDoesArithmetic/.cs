namespace Kyu7.MakeAFunctionThatDoesArithmetic;

public class Kata
{
    public static double Arithmetic(double a, double b, string op)
    {
        return op switch
        {
            "add" => a + b,
            "subtract" => a - b,
            "multiply" => a * b,
            "divide" => a / b,
        };
    }


    [TestFixture]
    public class Tests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.That(Kata.Arithmetic(1, 2, "add"), Is.EqualTo(3));
            Assert.That(Kata.Arithmetic(8, 2, "subtract"), Is.EqualTo(6));
            Assert.That(Kata.Arithmetic(5, 2, "multiply"), Is.EqualTo(10));
            Assert.That(Kata.Arithmetic(8, 2, "divide"), Is.EqualTo(4));
        }
    }
}