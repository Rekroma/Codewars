namespace Kyu7.BuildingBlocks;

class Block
{
    int _width;
    int _length;
    int _height;

    public Block(int[] stuff)
    {
        _width = stuff[0];
        _length = stuff[1];
        _height = stuff[2];
    }
    public int GetWidth()
    {
        return _width;
    }
    public int GetLength()
    {
        return _length;
    }
    public int GetHeight()
    {
        return _height;
    }
    public int GetVolume()
    {
        return _height * _width * _length;
    }
    public int GetSurfaceArea()
    {
        return 2 * _length * _width + 2 * _height * _width + 2 * _height * _length;
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public static void ExampleTest()
    {
        Block b = new Block(new int[] { 2, 2, 2 });
        Assert.That(b.GetWidth(), Is.EqualTo(2));
        Assert.That(b.GetLength(), Is.EqualTo(2));
        Assert.That(b.GetHeight(), Is.EqualTo(2));
        Assert.That(b.GetVolume(), Is.EqualTo(8));
        Assert.That(b.GetSurfaceArea(), Is.EqualTo(24));
    }
}