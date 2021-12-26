using System;
using System.Collections.Generic;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities.Interfaces;

namespace CourseWorkVisualInterface.Services
{
    public class SelectShapeService : ISelectShapeService
    {
        public void SelectAllShapes(List<Shape> shapes) => shapes.ForEach(s => s.IsSelected = true);
        
        public void SelectAllShapesByType(List<Shape> shapes, Type type)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.GetType() == type)
                {
                    shape.IsSelected = true;
                }
                else shape.IsSelected = false;
            }
        }
    }
}