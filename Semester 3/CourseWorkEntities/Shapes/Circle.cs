using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Circle:Shape
    {
        public double Radius { get; set; }
        
        public Circle(int xCoordinate, int yCoordinate, double radius) : base(xCoordinate, yCoordinate)
        {
            this.ShapeType = ShapeType.Circle;
            this.Radius = radius;
        }

        public Circle(int xCoordinate, int yCoordinate, Color outlineColor, Color fillColor, double radius) : base(xCoordinate, yCoordinate, outlineColor, fillColor)
        {
            this.ShapeType = ShapeType.Circle;
            Radius = radius;
        }

        public override double GetArea()
        {
            double result = Math.PI * Radius * Radius;

            return result;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}