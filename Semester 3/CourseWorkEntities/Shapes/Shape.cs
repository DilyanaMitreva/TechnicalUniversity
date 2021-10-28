using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public abstract class Shape
    {
        public ShapeType ShapeType { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Color OutlineColor { get; set; }

        public Color FillColor { get; set; }

        protected Shape(int xCoordinate, int yCoordinate, Color outlineColor, Color fillColor)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            OutlineColor = outlineColor;
            FillColor = fillColor;
        }
        
        public abstract decimal GetArea();

       // public abstract void Draw();
    }

   
}