namespace Kyu8.DnaToRnaConversion;

public class Converter
{
    public string dnaToRna(string dna)
    {
        return dna.Replace('T', 'U');
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void test()
    {
        Converter converter = new Converter();
        Assert.That(converter.dnaToRna("TTTT"), Is.EqualTo("UUUU"));
    }
}