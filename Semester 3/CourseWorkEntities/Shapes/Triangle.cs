using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Triangle : Shape // равнобедрен триъгълник
    {
        public double Side { get; set; }

        public Triangle(int xCoordinate, int yCoordinate, double side) : base(xCoordinate, yCoordinate)
        {
            this.ShapeType = ShapeType.Triangle;
            this.Side = side;
            
            this.OutlineColor = Color.Black;
            this.FillColor = Color.White;
        }

        public Triangle(int xCoordinate, int yCoordinate, double side,Color outlineColor, Color fillColor) : 
            base(xCoordinate, yCoordinate, outlineColor, fillColor)
        {
            this.ShapeType = ShapeType.Triangle;
            this.Side = side;
        }

        public override double GetArea()
        {
            double result = (Math.Sqrt(3) * Side * Side) / 4;
            return result;
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}