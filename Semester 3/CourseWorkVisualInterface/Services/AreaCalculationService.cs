using System;
using System.Collections.Generic;
using System.Linq;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities.Interfaces;

namespace CourseWorkVisualInterface.Services
{
    public class AreaCalculationService : IAreaCalculationService
    {
        public double AreaOfAllShapes(List<Shape> shapes) => shapes.Sum(s => s.Area);

        public double SmallestAreaOfAllShapes(List<Shape> shapes) =>
            shapes.Select(s => s.Area)
                .Min();

        public double BiggestAreaOfAllShapes(List<Shape> shapes) =>
            shapes.Select(s => s.Area)
                .Max();

        public double AreaOfAllShapesFromType(List<Shape> shapes, Type type) =>
            shapes
                .Where(s => s.GetType() == type)
                .Select(s => s.Area)
                .Sum();


        public double SmallestAreaOfAllShapesFromType(List<Shape> shapes, Type type) =>
            shapes.Where(s => s.GetType() == type)
                .Select(s => s.Area)
                .OrderBy(area => area)
                .First();

        public double BiggestAreaOfAllShapesFromType(List<Shape> shapes, Type type) =>
            shapes.Where(s => s.GetType() == type)
                .OrderBy(s => s.Area)
                .Last()
                .Area;

        public string AllShapesAreaByType(List<Shape> shapes) =>
            shapes.GroupBy(s => s.GetType().Name, shape => shape.Area)
                .Select(s => $"{s.Key}: {s.Sum():N2}")
                .Aggregate((f, s) => f + Environment.NewLine + s);


        public string AllShapesSmallestAreaByType(List<Shape> shapes) =>
            shapes.GroupBy(s => s.GetType().Name, shape => shape.Area)
                .Select(s => $"{s.Key}: {s.Min():N2}")
                .Aggregate((f, s) => f + Environment.NewLine + s);


        public string AllShapesBiggestAreaByType(List<Shape> shapes) =>
            shapes.GroupBy(s => s.GetType().Name, shape => shape.Area)
                .Select(s => $"{s.Key}: {s.Max():N2}")
                .Aggregate((f, s) => f + Environment.NewLine + s);
    }
}