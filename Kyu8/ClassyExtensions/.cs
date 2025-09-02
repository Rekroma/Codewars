namespace Kyu8.ClassyExtensions;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override string Speak()
    {
        return $"{this.Name} meows.";
    }
}


[TestFixture]
public class Fixed_Tests
{
    [Test]
    public void Test()
    {
        Cat cat = new Cat("Mr Whiskers");
        Assert.That(cat.Speak(), Is.EqualTo("Mr Whiskers meows."));
        Assert.That(cat is Animal, "The Cat class should inherit from Animal");

        cat = new Cat("Lamp");
        Assert.That(cat.Speak(), Is.EqualTo("Lamp meows."));
        Assert.That(cat is Animal, "The Cat class should inherit from Animal");

        cat = new Cat("$$Money Bags$$");
        Assert.That(cat.Speak(), Is.EqualTo("$$Money Bags$$ meows."));
        Assert.That(cat is Animal, "The Cat class should inherit from Animal");
    }
}



public class Animal
{
    public string Name { get; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual string Speak()
    {
        return $"{Name} makes a noise.";
    }
}