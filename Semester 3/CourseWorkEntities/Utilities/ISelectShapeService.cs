using System;
using System.Collections.Generic;
using CourseWorkEntities.Shapes;

namespace CourseWorkEntities.Utilities
{
    public interface ISelectShapeService
    {
        void SelectAllShapes(List<Shape> shapes);

        void SelectAllShapesByType(List<Shape> shapes, Type type);
    }
}