using System;

namespace Kyu8.GrasshopperTerminalGameCombatFunction;

public static class Game
{
    public static float Combat(float health, float damage)
    {
        return health - damage >= 0 ? health - damage : 0;
    }
}


[TestFixture]
public class BasicTest
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(100, 5).Returns(95);
            yield return new TestCaseData(92, 8).Returns(84);
            yield return new TestCaseData(20, 30).Returns(0);
        }
    }

    [Test, TestCaseSource("testCases")]
    public float Test(float health, float damage) =>
      Game.Combat(health, damage);
}