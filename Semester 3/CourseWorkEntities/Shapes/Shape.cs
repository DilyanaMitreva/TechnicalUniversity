using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public abstract class Shape
    {
        protected readonly Color SelectedColor = Color.Red;

        public delegate void Draw(Shape shape);

        public ShapeType ShapeType { get; set; }

        public PointImpl Location { get; set; }

        public Color ColorBorder { get; set; }

        public Color FillColor { get; set; }

        public bool Selected { get; set; }

        public abstract decimal Area { get; }

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

        public abstract bool Intersect(Shape shape);

        public void DrawShape(Draw draw)
        {
            draw(this);
        }
    }
}