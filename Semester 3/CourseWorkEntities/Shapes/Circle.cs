using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Circle:Shape
    {
        public decimal Radius { get; set; }

        public Circle(int xCoordinate, int yCoordinate, decimal radius, Color outlineColor, Color fillColor) : base(xCoordinate, yCoordinate, outlineColor, fillColor)
        {
            this.ShapeType = ShapeType.Circle;
            Radius = radius;
        }

        public override decimal GetArea()
        {
            decimal result = (decimal)Math.PI * Radius * Radius;

            return result;
        }

        // public override void Draw()
        // {
        //     throw new NotImplementedException();
        // }
    }
}