using System.Drawing;

namespace Exercise4
{
    public abstract class Shape
    {
        public Point Location { get; set; }

        public Color ColorBorder { get; set; }

        public Color ColorFill { get; set; }

        public bool Selected { get; set; }

        protected Shape(Point location, Color colorBorder, Color colorFill)
        {
            Location = location;
            ColorBorder = colorBorder;
            ColorFill = colorFill;
        }

        public abstract void Paint(Graphics graphics);

        public abstract bool PointInShape(Point point);
    }
}