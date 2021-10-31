using System.Drawing;

namespace Exercise4
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(Point location, int radius, Color colorBorder, Color colorFill) : base(location, colorBorder,
            colorFill)
        {
            this.Radius = radius;
        }

        public override void Paint(Graphics graphics)
        {
            Color color = Selected ? Color.Black : this.ColorFill;

            using (Brush brush = new SolidBrush(color))
            {
                graphics.FillEllipse(brush, Location.X, Location.Y, 2 * Radius, 2 * Radius);
            }

            using (Pen pen = new Pen(this.ColorBorder))
            {
                graphics.DrawEllipse(pen, Location.X, Location.Y, 2 * Radius, 2 * Radius);
            }
        }

        public override bool PointInShape(Point point)
        {
            return
                Location.X <= point.X && point.X <= Location.X + Radius
                                      &&
                                      Location.Y <= point.Y && point.Y <= Location.Y + Radius
                ;
        }
    }
}