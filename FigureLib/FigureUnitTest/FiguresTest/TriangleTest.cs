using FigureLib;
using FigureLib.Figures;

namespace FigureUnitTest.FiguresTest;

public class TriangleTest
{
    [Fact]
    public void Triangle_WithNegativeSideLength_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-1, 2, 3));
    }

    [Fact]
    public void Triangle_WithInvalidSideLengths_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 5));
    }

    [Fact]
    public void Triangle_GetArea_ReturnsCorrectResult()
    {
        var shape = ShapeFactory.Create("Triangle", 3,4,5);
        
        Assert.Equal(6,shape.GetArea());
    }

    [Fact]
    public void Triangle_IsRightAngle_ReturnsTrueForRightAngleTriangle()
    {
        var shape = ShapeFactory.Create("Triangle", 3, 4, 5);

        if (shape is Triangle triangle)
        {
            Assert.True(triangle.IsRightAngle());
        }
    }

    [Fact]
    public void Triangle_IsRightAngle_ReturnsFalseForNonRightAngleTriangle()
    {
        var shape = ShapeFactory.Create("Triangle", 2, 3, 4);

        if (shape is Triangle triangle)
        {
            Assert.False(triangle.IsRightAngle());
        }
    }
}