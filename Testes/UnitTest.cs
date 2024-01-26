using Programa.Models;

namespace UnitTest;

public class UnitTest
{
    private Iphone _IPhone;
    private Nokia _nokia;

    public UnitTest()
    {
        _IPhone = new Iphone();
        _nokia = new Nokia();
    }

    [Fact]
    public void Test1()
    {
        // Arrenge
        // Act
        // Assert
    }
}