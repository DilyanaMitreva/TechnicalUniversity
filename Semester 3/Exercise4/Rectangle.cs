using System.Drawing;

namespace Exercise4
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }

        public int Widht { get; set; }

        public Rectangle(Point location, int height, int widht, Color colorBorder, Color colorFill) : base(location,
            colorBorder, colorFill)
        {
            Height = height;
            Widht = widht;
        }

        public override void Paint(Graphics graphics)
        {
            Color color = Selected ? Color.Black : this.ColorFill;
            
            using (Brush brush = new SolidBrush(color))
            {
                graphics.FillRectangle(brush, Location.X, Location.Y, Widht, Height);
            }

            using (Pen pen = new Pen(this.ColorBorder))
            {
                graphics.DrawRectangle(pen, Location.X, Location.Y, Widht, Height);
            }
        }

        public override bool PointInShape(Point point)
        {
            return
                Location.X <= point.X && point.X <= Location.X + Widht
                                      &&
                                      Location.Y <= point.Y && point.Y <= Location.Y + Height
                ;
        }
    }
}