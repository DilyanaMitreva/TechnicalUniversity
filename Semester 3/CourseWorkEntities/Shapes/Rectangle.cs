using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Rectangle : Shape
    {
        public int Width { get; set; } // дължина

        public int Height { get; set; } // широчина

        public Rectangle(int xCoordinate, int yCoordinate, int width, int height, Color colorBorder,
            Color fillColor)
            : base(xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            this.ShapeType = ShapeType.Rectangle;
            Width = width;
            Height = height;
        }

        public override decimal GetArea()
        {
            decimal result = Height * Width;

            return result;
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(this.ColorBorder))
            {
                graphics.DrawRectangle(pen, this.XCoordinate, this.YCoordinate, this.Width, this.Height);
            }

            using (Brush brush = new SolidBrush(this.FillColor))
            {
                graphics.FillRectangle(brush, this.XCoordinate, this.YCoordinate, this.Width, this.Height);
            }
        }
    }
}