using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int xCoordinate, int yCoordinate, int radius, Color colorBorder, Color fillColor) : base(
            xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            this.ShapeType = ShapeType.Circle;
            Radius = radius;
        }

        public override decimal GetArea()
        {
            decimal result = (decimal)Math.PI * Radius * Radius;

            return result;
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(this.ColorBorder))
            {
                graphics.DrawEllipse(pen, this.XCoordinate, this.YCoordinate, 2*Radius, 2*Radius);
            }

            using (Brush brush = new SolidBrush(this.FillColor))
            {
                graphics.FillEllipse(brush, this.XCoordinate, this.YCoordinate, 2 * Radius, 2 * Radius);
            }
        }
    }
}