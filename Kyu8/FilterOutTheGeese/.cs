using System.Linq;
using System.Collections.Generic;

namespace Kyu8.FilterOutTheGeese;

public static class Filter
{
    public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
    {
        string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

        return birds.Except(geese);
    }
}


[TestFixture]
public class SolutionTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Filter.GooseFilter(new string[] { "Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish" }),
            Is.EqualTo(new string[] { "Mallard", "Hook Bill", "Crested", "Blue Swedish" }));

        Assert.That(Filter.GooseFilter(new string[] { "Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested" }),
            Is.EqualTo(new string[] { "Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested" }));

        Assert.That(Filter.GooseFilter(new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" }),
            Is.EqualTo(new string[] { }));
    }
}