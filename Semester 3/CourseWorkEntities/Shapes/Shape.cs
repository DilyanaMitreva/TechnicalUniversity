using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public abstract class Shape
    {
        public ShapeType ShapeType { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Color ColorBorder { get; set; }

        public Color FillColor { get; set; }
        
        protected Shape(int xCoordinate, int yCoordinate, Color colorBorder, Color fillColor)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            ColorBorder = colorBorder;
            FillColor = fillColor;
        }
        
        public abstract decimal GetArea();

        public abstract void Draw(Graphics graphics);
    }

   
}