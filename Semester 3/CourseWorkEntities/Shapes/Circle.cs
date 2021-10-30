using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override double Area => Math.PI * Radius * Radius;

        public Circle(int xCoordinate, int yCoordinate, int radius, Color colorBorder, Color fillColor) : base(
            xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            this.ShapeType = ShapeType.Circle;
            Radius = radius;
        }

        public override bool PointInShape(PointImpl point)
        {
            bool result = (Location.X <= point.X && point.X <= Location.X + Radius)
                          &&
                          (Location.Y <= point.Y && point.Y <= Location.Y + Radius);

            return result;
        }

        // public override bool Intersect(Shape shape)
        // {
        //     bool result = false;
        //     if (shape is Rectangle rectangle)
        //     {
        //     }
        //     else if (shape is EquilateralTriangle)
        //     {
        //     }
        //     else if (shape is Circle)
        //     {
        //     }
        //
        //     return result;
        // }
    }
}