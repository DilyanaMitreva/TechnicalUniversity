using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        
        public override decimal Area => (decimal)Math.PI * Radius * Radius;

        public Circle(int xCoordinate, int yCoordinate, int radius, Color colorBorder, Color fillColor) : base(
            xCoordinate, yCoordinate, colorBorder, fillColor)
        {
            this.ShapeType = ShapeType.Circle;
            Radius = radius;
        }

        public override bool PointInShape(PointImpl point)
        { return
                Location.X <= point.X && point.X <= Location.X + Radius
                                   &&
                                   Location.Y <= point.Y && point.Y <= Location.Y + Radius
                ;
            
            
        }

        public override bool Intersect(Shape shape)
        {
            throw new NotImplementedException();
        }
        
       
        
    }
}