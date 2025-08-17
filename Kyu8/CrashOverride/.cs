namespace Kyu8.CrashOverride;

public partial class Kata
{
    public static string AliasGen(string fName, string lName)
    {
        return char.IsLetter(fName[0]) && char.IsLetter(lName[0]) ? $"{FirstName[fName[0].ToString()]} {Surname[lName[0].ToString()]}" : "Your name must start with a letter from A - Z.";
    }
}


[TestFixture]
public class Test
{
    [Test]
    public void BasicTest()
    {
        Dictionary<string[], string> bisics = new Dictionary<string[], string>()
        {
            {new []{"Mike", "Millington"},  "Malware Mike"},
            {new []{"Fahima", "Tash"},"Function T-Rex"},
            {new []{"Daisy", "Petrovic"},"Data Payload"},
            {new []{"Barny", "White"},"Beta Worm"},
            {new []{"Hank", "Kutz"},"Half-life Killer"},
            {new []{"123abc", "Pinkman"},"Your name must start with a letter from A - Z."}
        };
        foreach (KeyValuePair<string[], string> keyValuePair in bisics)
        {
            Assert.That(Kata.AliasGen(keyValuePair.Key[0], keyValuePair.Key[1]), Is.EqualTo(keyValuePair.Value).IgnoreCase);
        }
    }
}