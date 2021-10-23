using System;
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