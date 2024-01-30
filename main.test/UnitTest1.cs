using main.Models;

namespace main.test;

public class TestesUnitarios
{
    private Iphone _iphone = new Iphone();

    [Fact]
    public void Test1()
    {
        Assert.True(5 + 6 == 11);
    }
}