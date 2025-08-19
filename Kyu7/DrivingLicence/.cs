using System;

namespace Kyu7.DrivingLicence;

class Kata
{
    public string driver(params string[] data)
    {
        string licenceNumber = "";

        for (int i = 0; i < 5; i++)
        {
            if (i < data[2].Length)
            {
                licenceNumber += char.ToUpper(data[2][i]);
            }
            else
            {
                licenceNumber += "9";
            }
        }

        licenceNumber += data[3].Split("-")[2][2];
        licenceNumber += (DateTime.Parse(data[3]).Month + (data[4] == "F" ? 50 : 0)).ToString("D2");
        licenceNumber += data[3].Split("-")[0][0]; licenceNumber += data[3].Split("-")[0][1];
        licenceNumber += data[3].Split("-")[2][3];
        licenceNumber += data[0][0];
        licenceNumber += (data[1] == "" ? "9" : data[1][0]);
        licenceNumber += "9AA";

        return licenceNumber;
    }
}


[TestFixture]
class KataTestClass
{
    [Order(1)]
    [TestCase]
    public void KataTest1()
    {
        Kata test = new Kata();
        string[] data = new string[] { "John", "James", "Smith", "01-Jan-2000", "M" };
        Assert.That(test.driver(data), Is.EqualTo("SMITH001010JJ9AA"));
    }

    [Order(2)]
    [TestCase]
    public void KataTest2()
    {
        Kata test = new Kata();
        string[] data = new string[] { "Johanna", "", "Gibbs", "13-Dec-1981", "F" };
        Assert.That(test.driver(data), Is.EqualTo("GIBBS862131J99AA"));
    }

    [Order(3)]
    [TestCase]
    public void KataTest3()
    {
        Kata test = new Kata();
        string[] data = new string[] { "Andrew", "Robert", "Lee", "02-September-1981", "M" };
        Assert.That(test.driver(data), Is.EqualTo("LEE99809021AR9AA"));
    }
}