namespace Kyu6.SimpleFunFourSixCipherTwentySix;

using System.Linq;

public class Kata
{
    public string Cipher26(string message)
    {
        string abc = "abcdefghijklmnopqrstuvwxyz";
        int[] oldCharsIndexes = new int[message.Length];
        oldCharsIndexes[0] = abc.IndexOf(message[0]);
        string str = "" + message[0];

        for (int i = 1; i < message.Length; i++)
        {
            oldCharsIndexes[i] = ((abc.IndexOf(message[i]) - oldCharsIndexes.Sum()) % 26 + 26) % 26;
            str += abc[oldCharsIndexes[i]];
        }

        return str;
    }
}


[TestFixture]
public class myjinxin
{

    [Test]
    public void BasicTests()
    {
        var kata = new Kata();

        Assert.That(kata.Cipher26("taiaiaertkixquxjnfxxdh"), Is.EqualTo("thisisencryptedmessage"));

        Assert.That(kata.Cipher26("ibttlprimfymqlpgeftwu"), Is.EqualTo("itsasecrettoeverybody"));

        Assert.That(kata.Cipher26("ftnexvoky"), Is.EqualTo("fourtytwo"));

        Assert.That(kata.Cipher26("taevzhzmashvjw"), Is.EqualTo("thereisnospoon"));

        Assert.That(kata.Cipher26("abdgkpvcktdoanbqgxpicxtqon"), Is.EqualTo("abcdefghijklmnopqrstuvwxyz"));

        Assert.That(kata.Cipher26("z"), Is.EqualTo("z"));


    }

}