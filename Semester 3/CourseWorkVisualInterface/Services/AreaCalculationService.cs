using System;
using System.Collections.Generic;
using System.Linq;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;

namespace CourseWorkVisualInterface.Services
{
    public class AreaCalculationService : IAreaCalculationService
    {
        public double AreaOfAllShapes(List<Shape> shapes) => shapes.Sum(s => s.Area);

        public double SmallestAreaOfAllShapes(List<Shape> shapes) =>
            shapes.OrderBy(s => s.Area)
                .First()
                .Area;

        public double BiggestAreaOfAllShapes(List<Shape> shapes) =>
            shapes.OrderByDescending(s => s.Area)
                .First()
                .Area;

        public double AreaOfAllShapesFromType(List<Shape> shapes, Type type) =>
            shapes.Where(s => s.GetType() == type)
                .ToList()
                .Sum(s => s.Area);


        public double SmallestAreaOfAllShapesFromType(List<Shape> shapes, Type type) =>
            shapes.Where(s => s.GetType() == type)
                .OrderBy(s => s.Area)
                .ToList()
                .First()
                .Area;

        public double BiggestAreaOfAllShapesFromType(List<Shape> shapes, Type type)=>
            shapes.Where(s => s.GetType() == type)
                .OrderBy(s => s.Area)
                .ToList()
                .Last()
                .Area;
    }
}