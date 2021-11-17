using System;
using System.Collections.Generic;
using System.Linq;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkEntities.Utilities.Interfaces;

namespace CourseWorkEntities.Services
{
    public class AreaCalculationService : IAreaCalculationService
    {
        public double AreaOfAllShapes(List<Shape> shapes) => shapes.Sum(s => s.Area);

        public double SmallestAreaOfAllShapes(List<Shape> shapes) =>
            shapes.Select(s => s.Area)
                .ToList()
                .Min();

        public double BiggestAreaOfAllShapes(List<Shape> shapes) =>
            shapes.Select(s => s.Area)
                .ToList()
                .Max();

        public double AreaOfAllShapesFromType(List<Shape> shapes, Type type) =>
            shapes
                .Where(s => s.GetType() == type)
                .Select(s => s.Area)
                .ToList()
                .Sum();


        public double SmallestAreaOfAllShapesFromType(List<Shape> shapes, Type type) =>
            shapes.Where(s => s.GetType() == type)
                .Select(s => s.Area)
                .OrderBy(area => area)
                .ToList()
                .First();

        public double BiggestAreaOfAllShapesFromType(List<Shape> shapes, Type type) =>
            shapes.Where(s => s.GetType() == type)
                .OrderBy(s => s.Area)
                .ToList()
                .Last()
                .Area;
    }
}