using FigureLib;
using FigureLib.Figures;

namespace FigureUnitTest.FiguresTest;

public class CircleTest
{
    [Fact]
    public void Circle_WithZeroRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }

    [Fact]
    public void Circle_GetArea_ReturnsCorrectResult()
    {
        var shape = ShapeFactory.Create("Circle",4);
        
        Assert.Equal(Math.PI * 4 * 4, shape.GetArea());
    }
}