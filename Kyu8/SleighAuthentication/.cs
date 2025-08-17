namespace Kyu8.SleighAuthentication;

public class Sleigh
{
    public static bool Authenticate(string name, string password)
    {
        return name == "Santa Claus" && password == "Ho Ho Ho!";
    }
}


[TestFixture]
public class SolutionTest
{
    [Test, Description("The Sleigh must authenticate with correct credentials")]
    public void CorrectTest()
    {
        Assert.That(Sleigh.Authenticate("Santa Claus", "Ho Ho Ho!"));
    }

    [Test, Description("The Sleigh must not authenticate with incorrect credentials")]
    public void IncorrectTest()
    {
        Assert.That(!Sleigh.Authenticate("Santa", "Ho Ho Ho!"));
        Assert.That(!Sleigh.Authenticate("Santa Claus", "Ho Ho!"));
        Assert.That(!Sleigh.Authenticate("jhoffner", "CodeWars"));
    }
}