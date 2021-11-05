using System.Drawing;

namespace Exercise6
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }

        public int Width { get; set; }


        public override int Area => this.Height * this.Width;

        public Rectangle()
        {
        }

        public Rectangle(Point location, int height, int width, Color colorBorder, Color colorFill) : base(location,
            colorBorder, colorFill)
        {
            Height = height;
            Width = width;
        }


        public override void Paint(Graphics graphics)
        {
            Color color = Selected ? Color.Red : this.ColorBorder;

            using (Brush brush = new SolidBrush(this.ColorFill))
            {
                graphics.FillRectangle(brush, Location.X, Location.Y, Width, Height);
            }

            using (Pen pen = new Pen(color))
            {
                graphics.DrawRectangle(pen, Location.X, Location.Y, Width, Height);
            }
        }

        public override bool PointInShape(Point point) =>
            (this.Location.X <= point.X && point.X <= this.Location.X + Width)
            &&
            (this.Location.Y <= point.Y && point.Y <= this.Location.Y + Height);

        public override bool Intersect(Rectangle rectangle) =>
            (this.Location.X < rectangle.Location.X + rectangle.Width &&
             rectangle.Location.X < this.Location.X + Width &&
             this.Location.Y < rectangle.Location.Y + rectangle.Height &&
             rectangle.Location.Y < this.Location.Y + Height);
    }
}