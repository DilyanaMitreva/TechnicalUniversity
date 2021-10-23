using System;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;

namespace CourseWorkEntities.Services
{
    public class ShapeCreateService : ICreateService
    {
        public Shape createRectangle(int xPosition, int yPosition, double height, double lenght)
        {
            Shape rectangle = new Rectangle(xPosition, yPosition, lenght, height);

            return rectangle;
        }

        public Shape createCircle(int xPosition, int yPosition, double radius)
        {
            Shape circle = new Circle(xPosition, yPosition, radius);

            return circle;
        }

        public Shape createTriangle(int xPosition, int yPosition, double side)
        {
            Shape triangle = new Triangle(xPosition, yPosition, side);

            return triangle;
        }
    }
}