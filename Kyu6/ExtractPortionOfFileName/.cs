using System.Linq;

namespace Kyu6.ExtractPortionOfFileName;

class FileNameExtractor
{
    public static string ExtractFileName(string dirtFileName)
    {
        return string.Join(".", dirtFileName.Substring(dirtFileName.IndexOf('_') + 1).Split('.').Take(2));
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(FileNameExtractor.ExtractFileName("1_FILE_NAME.EXTENSION.OTHEREXTENSIONadasdassdassds34"), Is.EqualTo("FILE_NAME.EXTENSION"));
        Assert.That(FileNameExtractor.ExtractFileName("1231231223123131_FILE_NAME.EXTENSION.OTHEREXTENSION"), Is.EqualTo("FILE_NAME.EXTENSION"));
    }
}