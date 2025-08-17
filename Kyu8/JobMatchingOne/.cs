using System;
using StriveObjects;

namespace Kyu8.JobMatchingOne;

public class Strive
{
    public static bool Match(Candidate c, Job j)
    {
        return c.MinSalary == null || j.MaxSalary == null ? throw new Exception() : c.MinSalary * 0.9 <= j.MaxSalary;
    }
}


[TestFixture]
public class ExampleTests
{
    Candidate candidate = new Candidate(MinSalary: 120000);
    Job job1 = new Job(MaxSalary: 130000);
    Job job2 = new Job(MaxSalary: 80000);

    [Test]
    [Order(1)]
    public void ShouldMatch()
    {
        Assert.That(Strive.Match(candidate, job1), Is.True);
    }
    [Test]
    [Order(2)]
    public void ShouldNotMatch()
    {
        Assert.That(Strive.Match(candidate, job2), Is.False);
    }
}