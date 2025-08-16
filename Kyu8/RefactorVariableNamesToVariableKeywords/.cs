namespace Kyu8.RefactorVariableNamesToVariableKeywords;

public class VariableName
{
    public bool @bool = false;
    public char @char = '\0';
    public sbyte @sbyte = 0;
    public byte @byte = 0;
    public short @short = 0;
    public ushort @ushort = 0;
    public int @int = 0;
    public uint @uint = 0;
    public long @long = 0;
    public ulong @ulong = 0;
    public float @float = 0;
    public double @double = 0;
    public decimal @decimal = 0;
}


[TestFixture]
public class VariableNameExampleTests
{
    [Test, Order(1)]
    public void TestBoolVariable()
    {
        VariableName variables = new VariableName();
        Assert.That(CheckType(variables, "bool", typeof(bool)), Is.True);
    }

    [Test, Order(2)]
    public void TestCharVariable()
    {
        VariableName variables = new VariableName();
        Assert.That(CheckType(variables, "char", typeof(char)), Is.True);
    }

    [Test, Order(3)]
    public void TestSbyteVariable()
    {
        VariableName variables = new VariableName();
        Assert.That(CheckType(variables, "sbyte", typeof(sbyte)), Is.True);
    }

    private bool CheckType(object obj, string fieldName, Type expectedType)
    {
        var field = obj.GetType().GetField(fieldName);
        if (field == null) return false;

        return field.FieldType == expectedType;
    }
}