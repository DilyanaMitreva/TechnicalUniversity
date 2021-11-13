using System;
using System.Drawing;
using System.Text;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public PointImpl Center { get; set; }

        public override double Area => Math.PI * Radius * Radius;

        public Circle(int xCoordinate, int yCoordinate, int radius, Color colorBorder, Color fillColor) : base(
            xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            this.Radius = radius;
            this.Center = new PointImpl(this.Location.X + this.Radius, this.Location.Y + this.Radius);
        }


        public override Boolean PointInShape(PointImpl point)
        {
            Boolean result = (point.X - Center.X) * (point.X - Center.X) +
                             (point.Y - Center.Y) * (point.Y - Center.Y)
                             <= this.Radius * this.Radius;

            return result;
        }

        public override bool Intersect(Rectangle rectangle)
        {
            int xNear = Math.Max(rectangle.Location.X,
                Math.Min(Center.X, rectangle.Location.X + rectangle.Width));
            int yNear = Math.Max(rectangle.Location.Y,
                Math.Min(Center.Y, rectangle.Location.Y + rectangle.Height));

            int distanceX = xNear - Center.X;
            int distanceY = yNear - Center.Y;

            return (distanceX * distanceX + distanceY * distanceY) <= this.Radius * this.Radius;
        }

        public override string AsString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Circle")
                .Append($"Location: {this.Location.AsString()}")
                .AppendLine($"Radius: {this.Radius}")
                .AppendLine($"Area: {this.Area}")
                .AppendLine($"BorderColor: {this.ColorBorder.ToString()}")
                .AppendLine($"FillColor: {this.FillColor.ToString()}")
                .AppendLine($"Is Selected: {this.IsSelected.ToString()}");

            return sb.ToString();
        }
    }
}