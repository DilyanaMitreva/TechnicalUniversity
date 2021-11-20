using System;
using System.Drawing;
using System.Text;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    [Serializable]
    public class Rectangle : Shape
    {
        public int Width { get; set; } // дължина

        public int Height { get; set; } // широчина

        public override double Area => Height * Width;

        public Rectangle() : base()
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

        public override bool Intersect(Rectangle rectangle)
        {
            return this.Location.X < rectangle.Location.X + rectangle.Width &&
                   rectangle.Location.X < this.Location.X + Width &&
                   this.Location.Y < rectangle.Location.Y + rectangle.Height &&
                   rectangle.Location.Y < this.Location.Y + Height;
        }

        public override string AsString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Rectangle")
                .Append($"Location: {this.Location.AsString()}")
                .AppendLine($"Width: {this.Width}")
                .AppendLine($"Height: {this.Height}")
                .AppendLine($"Area: {this.Area}")
                .AppendLine($"BorderColor: {this.ColorBorder.ToString()}")
                .AppendLine($"FillColor: {this.FillColor.ToString()}")
                .AppendLine($"Is Selected: {this.IsSelected.ToString()}");

            return sb.ToString();
        }
    }
}