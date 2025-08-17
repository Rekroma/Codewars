using System.Linq;
using System.Collections.Generic;

namespace Kyu8.LarioAndMuigiPipeProblem;

public class Fixer
{
    public static List<int> PipeFix(List<int> numbers)
    {
        return Enumerable.Range(numbers.Min(), numbers.Max() - numbers.Min() + 1).ToList();
    }
}


[TestFixture]
public class LarioWorld
{
    [Test, Order(1)]
    public void FixThosePipes_t1()
    {
        Assert.That(Fixer.PipeFix(new List<int> { 1, 2, 3, 5, 6, 8, 9 }), Is.EqualTo(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
    }

    [Test, Order(2)]
    public void FixThosePipes_t2()
    {
        Assert.That(Fixer.PipeFix(new List<int> { 1, 2, 3, 12 }), Is.EqualTo(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }));
    }

    [Test, Order(3)]
    public void FixThosePipes_t3()
    {
        Assert.That(Fixer.PipeFix(new List<int> { 6, 9 }), Is.EqualTo(new List<int> { 6, 7, 8, 9 }));
    }


}