using FigureLib.Figures;
using FigureLib.Figures.Abstractions;

namespace FigureLib;

public static class ShapeFactory
{
    public static Shape Create(string shapeType, params double[] parameters)
    {
        switch (shapeType)
        {
            case "Circle":
                if (parameters.Length != 1)
                {
                    throw new ArgumentException("Circle requires one parameter");
                }

                return new Circle(parameters[0]);

            case "Triangle":
                if (parameters.Length != 3)
                {
                    throw new ArgumentException("Triangle requires three parameters");
                }

                return new Triangle(parameters[0], parameters[1], parameters[2]);
            
            default:
                throw new ArgumentException($"Unknown shape type: {shapeType}");
        }
    }
}