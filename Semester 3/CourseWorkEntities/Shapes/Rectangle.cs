using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Rectangle : Shape
    {
        public Int32 Width { get; set; } // дължина

        public Int32 Height { get; set; } // широчина

        public override Double Area => Height * Width;

        public Rectangle(Int32 xCoordinate, Int32 yCoordinate, Int32 width, Int32 height, Color colorBorder,
            Color fillColor)
            : base(xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            Width = width;
            Height = height;
        }


        public override Boolean PointInShape(PointImpl point)
        {
            return
                Location.X <= point.X && point.X <= Location.X + Width
                                      &&
                                      Location.Y <= point.Y && point.Y <= Location.Y + Height;
        }
        
    }
}