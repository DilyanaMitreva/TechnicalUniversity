using System;
using System.Drawing;
using System.Text;
using CourseWorkEntities.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CourseWorkEntities.Shapes
{
    public delegate void Draw(Shape shape);
    
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


        // public string AsJson();
        //
        // public abstract string AsXml();

        public void DrawShape(Draw draw)
        {
            draw(this);
        }
    }
}