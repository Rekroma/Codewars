using System.Collections.Generic;

namespace Kyu8.FilteringEvenNumbersBugFixes;

public class Kata
{
    public static List<int> FilterOddNumber(List<int> listOfNumbers)
    {
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            if (listOfNumbers[i] % 2 == 0)
            {
                listOfNumbers.RemoveAt(i--);
            }
        }

        return listOfNumbers;
    }
}


[TestFixture]
public class MyTest
{
    [Test, Order(1)]
    public void FirstTest()
    {
        List<int> listOfNumbers = new List<int>() { 1, 2, 2, 2, 4, 3, 4, 5, 6, 7 };
        List<int> expectedResult = new List<int>() { 1, 3, 5, 7 };
        Assert.That(Kata.FilterOddNumber(listOfNumbers), Is.EqualTo(expectedResult));
    }

    [Test, Order(2)]
    public void SecondTest()
    {
        List<int> listOfNumbers = new List<int>() { 1, 2, 2, 2, 4, 3, 4 };
        List<int> expectedResult = new List<int>() { 1, 3 };
        Assert.That(Kata.FilterOddNumber(listOfNumbers), Is.EqualTo(expectedResult));
    }
}