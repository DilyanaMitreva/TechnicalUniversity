using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public delegate void Draw(Shape shape, Graphics graphics);

    [Serializable]
    public abstract class Shape
    {
        public PointImpl Location { get; set; }

        public Color ColorBorder { get; set; }

        public Color FillColor { get; set; }

        public bool IsSelected { get; set; }

        public abstract double Area { get; }

        protected Shape()
        {
        }

        protected Shape(int xCoordinate, int yCoordinate, Color colorBorder, Color fillColor)
        {
            Location = new PointImpl(xCoordinate, yCoordinate);
            ColorBorder = colorBorder;
            FillColor = fillColor;
        }


        public abstract bool PointInShape(PointImpl point);

        public abstract bool Intersect(Rectangle rectangle);

        public abstract string AsString();

        public void DrawShape(Draw draw, Graphics graphics) => draw(this, graphics);
    }
}