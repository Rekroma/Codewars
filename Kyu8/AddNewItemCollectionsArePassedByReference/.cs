using System.Collections.Generic;

namespace Kyu8.AddNewItemCollectionsArePassedByReference;

public class AddMore
{
    public static List<int> AddExtra(List<int> listOfNumbers)
    {
        return new List<int>(listOfNumbers) { 13 };
    }
}


[TestFixture]
public class AddMoreTest
{
    [Test]
    public void FirstTest()
    {
        List<int> listOfNumbers = new List<int>() { 1, 2, 2, 2, 4, 3, 4, 5, 6, 7 };
        int expectedCount = listOfNumbers.Count + 1;
        Assert.That(AddMore.AddExtra(listOfNumbers).Count, Is.EqualTo(expectedCount));
    }
}