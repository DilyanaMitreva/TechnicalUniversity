using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Circle : Shape
    {
        public Int32 Radius { get; set; }

        public override Double Area => Math.PI * Radius * Radius;

        public Circle(Int32 xCoordinate, Int32 yCoordinate, Int32 radius, Color colorBorder, Color fillColor) : base(
            xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            Radius = radius;
        }

        public override Boolean PointInShape(PointImpl point)
        {
            PointImpl circleCenter =
                new PointImpl(this.Location.X + this.Radius, this.Location.Y + this.Radius);

            Boolean result = (point.X - circleCenter.X) * (point.X - circleCenter.X) +
                          (point.Y - circleCenter.Y) * (point.Y - circleCenter.Y)
                          <= this.Radius * this.Radius;

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