using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Rectangle : Shape
    {
        public int Width { get; set; } // дължина

        public int Height { get; set; } // широчина

        public override decimal Area => Height * Width;

        public Rectangle(int xCoordinate, int yCoordinate, int width, int height, Color colorBorder,
            Color fillColor)
            : base(xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            this.ShapeType = ShapeType.Rectangle;
            Width = width;
            Height = height;
        }


        public override bool PointInShape(PointImpl point)
        {
            return
                 Location.X <= point.X && point.X <= Location.X + Width
                 && 
                 Location.Y <= point.Y && point.Y <= Location.Y + Height;
        }

        public override bool Intersect(Shape shape)
        {
            throw new NotImplementedException();
        }
    }
}