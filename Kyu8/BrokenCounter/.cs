namespace Kyu8.BrokenCounter;

public class Counter
{
    private int _value;
    public int Value
    {
        get
        {
            return _value;
        }
        private set
        {
            _value = value;
        }
    }

    public Counter()
    {
        Value = 0;
    }

    public void Increase()
    {
        Value++;
    }

    public void Reset()
    {
        Value = 0;
    }
}


[TestFixture]
public class Counter_Test
{

    [Test]
    public void Test()
    {
        Counter counter = new Counter();
        Assert.That(counter.Value, Is.EqualTo(0), "Initial counter value must be 0");
        counter.Increase();
        Assert.That(counter.Value, Is.EqualTo(1), "Counter value must be incremented.");
        counter.Reset();
        Assert.That(counter.Value, Is.EqualTo(0), "Counter value must be reset.");
    }
}