namespace Kyu7.ComplementaryDna;

public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        string str = "";

        for (int i = 0; i < dna.Length; i++)
        {
            switch (dna[i])
            {
                case 'A': str += "T"; break;
                case 'T': str += "A"; break;
                case 'C': str += "G"; break;
                case 'G': str += "C"; break;
            }
        }

        return str;
    }
}


[TestFixture]
public class DnaStrandTest
{
    [TestCase("AAAA", "TTTT")]
    [TestCase("ATTGC", "TAACG")]
    [TestCase("GTAT", "CATA")]
    [TestCase("AAGG", "TTCC")]
    [TestCase("CGCG", "GCGC")]
    [TestCase("ATTGC", "TAACG")]
    [TestCase("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA", "CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCTTATGTCTATCTGTCTAAT")]
    public void SampleTests(string dna, string expected)
    {
        Assert.That(DnaStrand.MakeComplement(dna), Is.EqualTo(expected));
    }
}