using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Rectangle : Shape
    {
        public int Width { get; set; } // дължина

        public int Height { get; set; } // широчина

        public override double Area => Height * Width;

        public Rectangle()
        {
        }

        public Rectangle(int xCoordinate, int yCoordinate, int width, int height, Color colorBorder, Color fillColor)
            : base(xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            this.Width = width;
            this.Height = height;
        }

        public override bool PointInShape(PointImpl point)
        {
            return
                this.Location.X <= point.X && point.X <= this.Location.X + Width
                                           &&
                                           this.Location.Y <= point.Y && point.Y <= this.Location.Y + Height;
        }

        public override bool Intersect(Rectangle rectangle) =>
            this.Location.X < rectangle.Location.X + rectangle.Width &&
            rectangle.Location.X < this.Location.X + Width &&
            this.Location.Y < rectangle.Location.Y + rectangle.Height &&
            rectangle.Location.Y < this.Location.Y + Height;
    }
}