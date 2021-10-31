using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public abstract class Shape
    {
        protected readonly Color SelectedColor = Color.Red;

        public delegate void Draw(Shape shape);
        
        public PointImpl Location { get; set; }

        public Color ColorBorder { get; set; }

        public Color FillColor { get; set; }

        public Boolean IsSelected { get; set; }

        public abstract Double Area { get; }

        protected Shape(int xCoordinate, int yCoordinate, Color colorBorder, Color fillColor)
        {
            Location = new PointImpl(xCoordinate, yCoordinate);
            ColorBorder = colorBorder;
            FillColor = fillColor;
        }


        public abstract Boolean PointInShape(PointImpl point);

        public void DrawShape(Draw draw)
        {
            draw(this);
        }
    }
}