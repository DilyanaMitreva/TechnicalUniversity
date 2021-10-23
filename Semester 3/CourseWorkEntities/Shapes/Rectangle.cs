using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Shapes
{
    public class Rectangle:Shape
    {
        public double Lenght { get; set; } // дължина

        public double Height { get; set; } // широчина
        
        public Rectangle(int xCoordinate, int yCoordinate, double lenght, double height) : base(xCoordinate, yCoordinate)
        {
            this.ShapeType = ShapeType.Rectangle;
            this.Lenght = lenght;
            this.Height = height;
        }

        public override double GetArea()
        {
            double result = Height * Lenght;

            return result;
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}