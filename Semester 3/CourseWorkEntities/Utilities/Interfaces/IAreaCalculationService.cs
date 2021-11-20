using System;
using System.Collections.Generic;
using CourseWorkEntities.Shapes;

namespace CourseWorkEntities.Utilities.Interfaces
{
    public interface IAreaCalculationService
    {
        double AreaOfAllShapes(List<Shape> shapes);

        double SmallestAreaOfAllShapes(List<Shape> shapes);

        double BiggestAreaOfAllShapes(List<Shape> shapes);

        double AreaOfAllShapesFromType(List<Shape> shapes, Type type);
        
        double SmallestAreaOfAllShapesFromType(List<Shape> shapes,  Type type);

        double BiggestAreaOfAllShapesFromType(List<Shape> shapes,  Type type);

        string AllShapesAreaByType(List<Shape> shapes);
        
        string AllShapesSmallestAreaByType(List<Shape> shapes);
        
        string AllShapesBiggestAreaByType(List<Shape> shapes);

    }
}