using System.Linq;

namespace Kyu6.Meeting;

public class JohnMeeting
{
    public static string Meeting(string s)
    {
        return string.Join("",
            s.ToUpper()
             .Split(';')
             .Select(name => name.Split(':'))
             .Select(parts => (LastName: parts[1], FirstName: parts[0]))
             .OrderBy(person => person.LastName)
             .ThenBy(person => person.FirstName)
             .Select(person => $"({person.LastName}, {person.FirstName})"));
    }
}


[TestFixture]
public static class JohnMeetingTests
{

    private static void testing(string s, string expect)
    {
        string actual = JohnMeeting.Meeting(s);
        Assert.That(actual, Is.EqualTo(expect), $"s=\"{s}\"");
    }

    [Test]
    public static void test1()
    {
        testing("Alexis:Wahl;John:Bell;Victoria:Schwarz;Abba:Dorny;Grace:Meta;Ann:Arno;Madison:STAN;Alex:Cornwell;Lewis:Kern;Megan:Stan;Alex:Korn",
                "(ARNO, ANN)(BELL, JOHN)(CORNWELL, ALEX)(DORNY, ABBA)(KERN, LEWIS)(KORN, ALEX)(META, GRACE)(SCHWARZ, VICTORIA)(STAN, MADISON)(STAN, MEGAN)(WAHL, ALEXIS)");
        testing("John:Gates;Michael:Wahl;Megan:Bell;Paul:Dorries;James:Dorny;Lewis:Steve;Alex:Meta;Elizabeth:Russel;Anna:Korn;Ann:Kern;Amber:Cornwell",
            "(BELL, MEGAN)(CORNWELL, AMBER)(DORNY, JAMES)(DORRIES, PAUL)(GATES, JOHN)(KERN, ANN)(KORN, ANNA)(META, ALEX)(RUSSEL, ELIZABETH)(STEVE, LEWIS)(WAHL, MICHAEL)");
        testing("Alex:Arno;Alissa:Cornwell;Sarah:Bell;Andrew:Dorries;Ann:Kern;Haley:Arno;Paul:Dorny;Madison:Kern",
            "(ARNO, ALEX)(ARNO, HALEY)(BELL, SARAH)(CORNWELL, ALISSA)(DORNY, PAUL)(DORRIES, ANDREW)(KERN, ANN)(KERN, MADISON)");
    }
}