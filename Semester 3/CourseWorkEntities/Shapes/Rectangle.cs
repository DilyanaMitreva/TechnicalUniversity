using System.Drawing;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Rectangle : Shape
    {
        public decimal Lenght { get; set; } // дължина

        public decimal Height { get; set; } // широчина

        public Rectangle(int xCoordinate, int yCoordinate, decimal lenght, decimal height, Color outlineColor,
            Color fillColor)
            : base(xCoordinate, yCoordinate, outlineColor, fillColor)
        {
            this.ShapeType = ShapeType.Rectangle;
            Lenght = lenght;
            Height = height;
        }

        public override decimal GetArea()
        {
            decimal result = Height * Lenght;

            return result;
        }

        // public override void Draw()
        // {
        //     throw new System.NotImplementedException();
        // }
    }
}