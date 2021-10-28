using System;
using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Triangle : Shape // равнобедрен триъгълник
    {
        public decimal Side { get; set; }

        public Triangle(int xCoordinate, int yCoordinate, decimal side, Color outlineColor, Color fillColor) :
            base(xCoordinate, yCoordinate, outlineColor, fillColor)
        {
            this.ShapeType = ShapeType.Triangle;
            this.Side = side;
        }

        public override decimal GetArea()
        {
            decimal result = ((decimal)Math.Sqrt(3) * Side * Side) / 4;
            return result;
        }

        // public override void Draw()
        // {
        //     throw new System.NotImplementedException();
        // }
    }
}